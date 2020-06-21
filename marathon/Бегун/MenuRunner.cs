using MetroFramework.Controls;
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
using System.Xml.Serialization;

namespace marathon.Бегун
{
    public partial class MenuRunner : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public string Gender, name,Emailid;
        public int RegID;
        public DateTime DateofBirthDay; 
        public MenuRunner(string firsname, string lasname,string Email)
        {
           
            Emailid = Email;
            InitializeComponent();
        }

        private void MenuRunner_Load(object sender, EventArgs e)
        {
            daytime.Start();
            date = new DateTime(2020, 11, 24, 6, 00, 00);
            string connection = "Database=prakt;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=";
            MySqlConnection connect = new MySqlConnection(connection);
            connect.Open();
            try
            {
                MySqlCommand dateof = new MySqlCommand("Select DateOfBirth from `runner` Where Email Like '"+Emailid+ "'", connect);
                MySqlDataReader dateread = dateof.ExecuteReader();
                while (dateread.Read())
                {
                    DateofBirthDay = dateread.GetDateTime(0);
                }
                MySqlCommand genderof = new MySqlCommand("Select Gender from `runner` Where Email Like '" + Emailid + "'", connect);
                MySqlDataReader genderread = genderof.ExecuteReader();
                while (genderread.Read())
                {
                    Gender = genderread.GetString(0);
                }
            }
            catch (Exception ex)
            {

            }
            connect.Close();
        }

        private void daytime_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mtlable.Text = "Осталось " + d.Days + " дней. " + d.Hours + " часов " + d.Minutes + " минут " + d.Seconds + "секунд";
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Телефон: +7 952 323 7092" + Environment.NewLine + "Почта: hd.anufriev@yandex.ru", "Контакты спонсора");
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            UpdateRunner upd = new UpdateRunner(Emailid);
            upd.ShowDialog();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            MySponsor spmy = new MySponsor();
            spmy.ShowDialog();
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            Regmarathon regmar = new Regmarathon();
            regmar.ShowDialog();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            MyResult frm = new MyResult(RegID, Gender, DateofBirthDay);
            frm.ShowDialog();
            frm.MdiParent = null;
        }
    }
}
