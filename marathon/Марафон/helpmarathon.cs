using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marathon.Марафон
{
    public partial class helpmarathon : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public helpmarathon()
        {
            InitializeComponent();
        }

        private void helpmarathon_Load(object sender, EventArgs e)
        {
            daytime.Start();
            date = new DateTime(2020, 11, 24, 6, 00, 00);
        }

        private void listblago_Click(object sender, EventArgs e)
        {
            listblagoorg helpmar = new listblagoorg ();
            helpmar.ShowDialog();
        }

        private void helpmarathon_FormClosed(object sender, FormClosedEventArgs e)
        {
            daytime.Stop();
            Form1 frm = new Form1();
            frm.Show();
           
        }

        private void daytime_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mtlable.Text = "Осталось " + d.Days + " дней. " + d.Hours + " часов " + d.Minutes + " минут " + d.Seconds + "секунд";
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            MarathonTime mrtime = new MarathonTime();
            mrtime.ShowDialog();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Result fr = new Result();
            fr.ShowDialog();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            InfMarathon Infform = new InfMarathon();
            Infform.ShowDialog();
        }
    }
}
