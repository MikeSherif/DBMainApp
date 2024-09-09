using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using OfficeOpenXml;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace DBMainApp
{
    public partial class Form1 : Form
    {
        private string oledb_attrs = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BCompany.mdb";

        public Form1()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            

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

        private void registration_b_Click(object sender, EventArgs e)
        {
            RegForm form = new RegForm();

            this.Hide();
            status_timer.Stop();
            form.ShowDialog();
            status_timer.Start();
            this.Show();
        }

        private int GetUserId(string password)
        {
            OleDbConnection connection = new OleDbConnection(oledb_attrs);
            connection.Open();

            string cmd = "select код_пользователя from пользователь where логин = @login and пароль = @password";
            int id = 0;
            OleDbCommand command = new OleDbCommand(cmd, connection);
            command.Parameters.AddWithValue("@login", login_t.Text);
            command.Parameters.AddWithValue("@password", password);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                id = (int)reader.GetInt32(0);
            }

            connection.Close();

            return id;
        }

        private void enter_b_Click(object sender, EventArgs e)
        {
            string password = RegForm.CreateSHA256(password_t.Text);
            int userID = GetUserId(password);

            if (userID == 0)
            {
                MessageBox.Show("Не удалось войти в систему, проверьте введенные данные.");
                return;
            }

            MenuForm form = new MenuForm(userID);
            this.Hide();
            status_timer.Stop();
            form.ShowDialog();            
            this.Show();
        }
    }
}
