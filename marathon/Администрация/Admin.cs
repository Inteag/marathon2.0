using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marathon.Администрация
{
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public Admin(string firsname, string lasname)
        {

            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            daytime.Start();
            date = new DateTime(2020, 11, 24, 6, 00, 00);
        }

        private void daytime_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mtlable.Text = "Осталось " + d.Days + " дней. " + d.Hours + " часов " + d.Minutes + " минут " + d.Seconds + "секунд";
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            Администрация.Inventory frm = new Администрация.Inventory();
            frm.ShowDialog();
        }

        private void Volonter_Click(object sender, EventArgs e)
        {
            AdminVolonter frm2 = new AdminVolonter();
            frm2.ShowDialog();
        }

        private void blagorganiz_Click(object sender, EventArgs e)
        {
            adminblago frm1 = new adminblago();
            frm1.ShowDialog();
        }

        private void Uzer_Click(object sender, EventArgs e)
        {
            AdminUser frm3 = new AdminUser();
            frm3.ShowDialog();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }
    }
}
