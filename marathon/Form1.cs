using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using marathon.бегун;
using marathon.Спонсоры;
using marathon.Марафон;

namespace marathon
{
    public partial class Form1 : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            AuthicationLogin fl = new AuthicationLogin();
            fl.Show();
            fl.MdiParent = null;
            Hide();
        }

        private void begun_Click(object sender, EventArgs e)
        {
           chooseRunner frm = new chooseRunner();
            frm.Show();
            this.Hide();

        }

        private void sponsor_Click(object sender, EventArgs e)
        {
            sponsorruner sponsorr = new sponsorruner();
            sponsorr.Show();
            this.Hide();
        }

        private void marathon_Click(object sender, EventArgs e)
        {
            helpmarathon helpmar = new helpmarathon();
            helpmar.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            daytime.Stop();
            Application.Exit();
        }

        private void mtlable_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            daytime.Start();
             date = new DateTime(2020, 11, 24, 6,00,00);
        }

        private void daytime_Tick(object sender, EventArgs e)
        {
           d = date - DateTime.Now ;
            mtlable.Text = "Осталось " + d.Days + " дней. " + d.Hours + " часов " + d.Minutes + " минут " + d.Seconds + "секунд";
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            AuthicationLogin fl = new AuthicationLogin();
            fl.Show();
            fl.MdiParent = null;
            Hide();
        }
    }
}
