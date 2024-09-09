using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMainApp
{
    struct Menu
    {
        public int id;
        public int parent_id;
        public string name;
        public string dll;
        public int order;
        public string func;
        public bool R, W, E, D;
        public int local_id;
    }

    public partial class MenuForm : Form
    {
        private string oledb_attrs = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BCompany.mdb";
        private int userID;
        private List<Menu> user_menu = new List<Menu>();

        private void GetMenuInfo()
        {
            OleDbConnection connection = new OleDbConnection(oledb_attrs);
            connection.Open();

            string cmd = "select " +
                "пр.код_пункта, пр.R, пр.W, пр.E, пр.D, м.код_родителя, м.название, м.dll, м.порядок, м.функция " +
                "from меню as м " +
                "inner join права_пользователя as пр " +
                "on м.[код_пункта] = пр.[код_пункта] " +
                "where пр.код_пользователя = @id";
            OleDbCommand command = new OleDbCommand(cmd, connection);
            command.Parameters.AddWithValue("@id", userID);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Menu item = new DBMainApp.Menu();
                item.id = reader.GetInt32(0);
                item.R = reader.GetBoolean(1);
                item.W = reader.GetBoolean(2);
                item.E = reader.GetBoolean(3);
                item.D = reader.GetBoolean(4);
                item.parent_id = reader.GetInt32(5);
                item.name = reader.GetString(6);
                item.dll = reader.GetString(7);
                item.order = reader.GetInt32(8);
                item.func = reader.GetString(9);
                item.local_id = -1;
                user_menu.Add(item);
            }

            user_menu = user_menu.OrderBy(item => item.order).ToList();
            connection.Close();
        }

        private void MenuClick(int index)
        {
            try
            {
                if (user_menu[index].dll.Equals("null") || user_menu[index].func.Equals("null"))
                    return;

                Assembly assembly = Assembly.LoadFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, user_menu[index].dll));

                Type type = null;
                foreach (Type t in assembly.GetTypes())
                {
                    MethodInfo info = t.GetMethod(user_menu[index].func);
                    if (info != null)
                    {
                        type = t;
                        break;
                    }
                }

                if (type != null)
                {
                    object obj = Activator.CreateInstance(type);
                    MethodInfo info = type.GetMethod(user_menu[index].func);

                    object[] param = { userID, user_menu[index].R, user_menu[index].W, user_menu[index].E, user_menu[index].D };
                    object output = info.Invoke(obj, param);

                    if (output is UserControl userControl)
                    {
                        panel1.Controls.Clear();
                        panel1.Controls.Add(userControl);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка доступа к файлам, не удалось загрузить dll!");
            }
        }

        private void BuildMenu()
        {
            // Добавляем пункты меню в menu strip
            for (int i = 0; i < user_menu.Count; i++)
            {
                if (user_menu[i].parent_id == 0 && user_menu[i].R)
                {
                    menuStrip.Items.Add(user_menu[i].name);

                    Menu correct_item = user_menu[i];
                    correct_item.local_id = menuStrip.Items.Count - 1;
                    user_menu[i] = correct_item;

                    //Cобытие
                    int menu_id = i;
                    menuStrip.Items[menuStrip.Items.Count - 1].Click += (sender, e) => MenuClick(menu_id);
                }
            }
            // Добавляем подпункты в menu strip
            for (int i = 0; i < user_menu.Count; i++)
            {
                if (user_menu[i].parent_id > 0 && user_menu[i].R)
                {
                    int parent_db_id = user_menu[i].parent_id;
                    int id = user_menu.FindIndex(user_menu => user_menu.id == parent_db_id);

                    if (id == -1 || !user_menu[id].R)
                        continue;

                    ToolStripMenuItem item = (ToolStripMenuItem)menuStrip.Items[user_menu[id].local_id];
                    item.DropDownItems.Add(user_menu[i].name);

                    //Cобытие
                    int menu_id = i;
                    item.DropDownItems[item.DropDownItems.Count - 1].Click += (sender, e) => MenuClick(menu_id);
                }
            }
        }

        public MenuForm(int id)
        {
            InitializeComponent();

            userID = id;
            GetMenuInfo();
            BuildMenu();
        }
    }
}
