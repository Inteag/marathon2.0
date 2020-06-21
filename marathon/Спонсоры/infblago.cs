using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marathon.Спонсоры
{
    public partial class infblago : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        string fond;
        public infblago(string blagofond)
        {
            InitializeComponent();
         fond = blagofond;
        }

        private void infblago_Load(object sender, EventArgs e)
        {
            namespon.Text = fond;
            string connection = "Database=prakt;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=";
            MySqlConnection connect = new MySqlConnection(connection);
            connect.Open();
            MySqlCommand commandcb = new MySqlCommand("SELECT CharityDescription from charity where CharityName like '" + namespon.Text + "'", connect);
            MySqlDataReader readercb = commandcb.ExecuteReader();
            while (readercb.Read())
            {
                metroLabel1.Text = readercb.GetString(0);
            }
            readercb.Close();
            MySqlCommand commandcb2 = new MySqlCommand("SELECT CharityLogo from charity where CharityName like '" + namespon.Text + "'", connect);
            MySqlDataReader readercb2 = commandcb2.ExecuteReader();
            while (readercb2.Read())
            {
                metroLabel2.Text = readercb2.GetString(0);
            }
            readercb2.Close();
            if(metroLabel2.Text == "arise-logo.png")
                pictureBox1.Image = Properties.Resources.arise_logo;
            if (metroLabel2.Text == "aves-do-brazil_logo.png")
                pictureBox1.Image = Properties.Resources.aves_do_brazil_logo;
            if (metroLabel2.Text == "clara-santos_oliveira-institute-logo.png")
                pictureBox1.Image = Properties.Resources.clara_santos_oliveira_institute_logo;
            if (metroLabel2.Text == "conquer-cancer-brazil.png")
                pictureBox1.Image = Properties.Resources.conquer_cancer_brazil;
            if (metroLabel2.Text == "diabetes-brazil-logo.png")
                pictureBox1.Image = Properties.Resources.diabetes_brazil_logo;
            if (metroLabel2.Text == "heart-health-sao-paulo-logo.png")
                pictureBox1.Image = Properties.Resources.heart_health_sao_paulo_logo;
            if (metroLabel2.Text == "human-rights-centre-logo.png")
                pictureBox1.Image = Properties.Resources.human_rights_centre_logo;
            if (metroLabel2.Text == "oxfam-international-logo.png")
                pictureBox1.Image = Properties.Resources.oxfam_international_logo;
            if (metroLabel2.Text == "querstadtein-logo.png")
                pictureBox1.Image = Properties.Resources.querstadtein_logo;
            if (metroLabel2.Text == "save_the-children-fund-logo.png")
                pictureBox1.Image = Properties.Resources.save_the_children_fund_logo;
            if (metroLabel2.Text == "stay-pumped-logo.png")
                pictureBox1.Image = Properties.Resources.stay_pumped_logo;
            if (metroLabel2.Text == "the-red-cross-logo.png")
                pictureBox1.Image = Properties.Resources.the_red_cross_logo;
            if (metroLabel2.Text == "upbeat-logo.png")
                pictureBox1.Image = Properties.Resources.upbeat_logo;
            if (metroLabel2.Text == "wwsm-rescue-logo.png")
                pictureBox1.Image = Properties.Resources.wwsm_rescue_logo;
                connect.Close();
            daytime.Start();
            date = new DateTime(2020, 11, 24, 6, 00, 00);
        }

        private void daytime_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mtlable.Text = "Осталось " + d.Days + " дней. " + d.Hours + " часов " + d.Minutes + " минут " + d.Seconds + "секунд";
        }

        private void namespon_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
