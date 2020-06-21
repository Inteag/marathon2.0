using marathon.Администрация;
using marathon.Бегун;
using marathon.Координатор;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marathon
{
    public partial class AuthicationLogin : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        string Email;
        public AuthicationLogin()
        {
            InitializeComponent();
        }

        private void AuthicationLogin_Load(object sender, EventArgs e)
        {
            daytime.Start();
            date = new DateTime(2020, 11, 24, 6, 00, 00);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            Hide();
            daytime.Stop();
        }

        private void AuthicationLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Back_Click(this,null);
        }

        private void authication_Click(object sender, EventArgs e)
        {
           string connection = "Database=prakt;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=";
            MySqlConnection connect = new MySqlConnection(connection);
            try
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand(
                    "SELECT COUNT(*) ,RoleId,Password,Email,FirstName,LastName " +
                    "FROM user " + "WHERE Email LIKE'" + loginuse.Text + "'" +
                    " AND " +
                    "Password LIKE '" + password.Text + "';", connect);
                int countuser = 0;
                string role = "";
                string firsname = "";
                string lasname = "";
                string login = "";

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    countuser = reader.GetInt32(0);
                    role = reader.GetString("RoleId");
                    login = reader.GetString("Email");
                    firsname = reader.GetString("FirstName");
                    lasname = reader.GetString("LastName");
                }
                reader.Close();
                if (countuser != 0)
                {
                    if (role == "R" )
                    {
                        Email = loginuse.Text;
                        MenuRunner form = new MenuRunner(firsname, lasname, Email);
                        form.Show();
                        this.Hide();
                    }
                    if (role == "A")
                    {
                        Admin form = new Admin(firsname, lasname);
                        form.ShowDialog();
                        this.Hide();
                    }
                    if (role == "C")
                    {
                        Coordinatormenu form = new Coordinatormenu(firsname, lasname);
                        form.Show();
                        this.Hide();
                    }
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                label1.Text = "Введён неправильный логин или пароль";
            }
        }

        private void datetime_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mtlable.Text = "Осталось " + d.Days + " дней. " + d.Hours + " часов " + d.Minutes + " минут " + d.Seconds + "секунд";
        }
    }
}
