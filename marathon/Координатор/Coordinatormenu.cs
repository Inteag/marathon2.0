using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marathon.Координатор
{
    public partial class Coordinatormenu : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public Coordinatormenu(string firsname, string lasname)
        {
            InitializeComponent();
        }

        private void Coordinatormenu_Load(object sender, EventArgs e)
        {
            daytime.Start();
            date = new DateTime(2020, 11, 24, 6, 00, 00);
        }

        private void daytime_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mtlable.Text = "Осталось " + d.Days + " дней. " + d.Hours + " часов " + d.Minutes + " минут " + d.Seconds + "секунд";

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            RunnerCordinator rc = new RunnerCordinator();
            rc.ShowDialog();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            SponsorCordinator sc = new SponsorCordinator();
            sc.ShowDialog();
        }
    }
}
