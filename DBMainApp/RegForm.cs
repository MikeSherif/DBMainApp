using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DBMainApp
{
    public partial class RegForm : Form
    {
        private string oledb_attrs = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BCompany.mdb";

        public RegForm()
        {
            InitializeComponent();

            caps_label.Visible = false;
            rus_label.Visible = false;
            eng_label.Visible = false;
            status_timer.Start();
        }

        private void status_timer_Tick(object sender, EventArgs e)
        {
            if (IsKeyLocked(Keys.CapsLock))
            {
                caps_label.Visible = true;
            }
            else
            {
                caps_label.Visible = false;
            }

            if (InputLanguage.CurrentInputLanguage.LayoutName == "США")
            {
                rus_label.Visible = false;
                eng_label.Visible = true;
            }
            else
            {
                eng_label.Visible = false;
                rus_label.Visible = true;
            }
        }

        private bool IsSameLogin()
        {
            OleDbConnection connection = new OleDbConnection(oledb_attrs);
            connection.Open();

            string cmd = "select count(*) from пользователь where логин = @login"; 
            OleDbCommand command = new OleDbCommand(cmd, connection);
            command.Parameters.AddWithValue("@login", login_t.Text);
            int count = (int)command.ExecuteScalar();

            connection.Close();
            return count > 0;
        }

        private bool IsCorrectInfo()
        {
            if (login_t.Text.Contains(" ") || password_t.Text.Contains(" "))
            {
                MessageBox.Show("Логин и пароль не должны содержать пробелов!");
                return false;
            }
            else if (login_t.Text.Length == 0 || password_t.Text.Length == 0 || password_t2.Text.Length == 0)
            {
                MessageBox.Show("Заполните все необходимые данные!");
                return false;
            }
            else if (!password_t.Text.Equals(password_t2.Text))
            {
                MessageBox.Show("Пароли должны совпадать!");
                return false;
            }
            else if (IsSameLogin())
            {
                MessageBox.Show("Такой логин уже используется, выберите другой!");
                return false;
            }

            return true;
        }

        public static string CreateSHA256(string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashVal = SHA256.Create().ComputeHash(passwordBytes);

            return BitConverter.ToString(hashVal);
        } 

        private void registration_b_Click(object sender, EventArgs e)
        {
            if (!IsCorrectInfo())
            {
                return;
            }

            OleDbConnection connection = new OleDbConnection(oledb_attrs);
            connection.Open();

            string cmd = "insert into пользователь (логин, пароль) values (@login, @password)";
            OleDbCommand command = new OleDbCommand(cmd, connection);
            command.Parameters.AddWithValue("@login", login_t.Text);
            command.Parameters.AddWithValue("@password", CreateSHA256(password_t.Text));
            command.ExecuteNonQuery();

            cmd = "select max(код_пользователя) from пользователь";
            command = new OleDbCommand(cmd, connection);
            int userID = (int)command.ExecuteScalar();

            //Добавление прав для сборки меню
            cmd = "insert into права_пользователя (код_пользователя, код_пункта, R, W, E, D) values (@1, @2, @3, @4, @5, @6)";
            for (int i = 0; i < 20; i++)
            {
                bool reg = (i + 1) == 1 || (i + 1) == 2;

                command = new OleDbCommand(cmd, connection);
                command.Parameters.AddWithValue("@1", userID);
                command.Parameters.AddWithValue("@2", i + 1);
                command.Parameters.AddWithValue("@3", reg);
                command.Parameters.AddWithValue("@4", reg);
                command.Parameters.AddWithValue("@5", reg);
                command.Parameters.AddWithValue("@6", reg);
                command.ExecuteNonQuery();
            }

            connection.Close();

            MessageBox.Show("Вы успешно зарегистрировались!");
            this.Close();
        }
    }
}
