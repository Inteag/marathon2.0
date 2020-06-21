using marathon.бегун;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace marathon.Спонсоры
{
    public partial class fanksponsor : MetroFramework.Forms.MetroForm
    {
        private string Name, Fond,Charity;
        private int Coin ;
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public fanksponsor(string name, int coin, string charity, string fond)
        {
            InitializeComponent();
            Name = name;
            Coin = coin;
            Charity = charity;
            Fond = fond;
        }

        private void fanksponsor_Load(object sender, EventArgs e)
        {
            Currency.Text = Coin + "$";
            Fondname.Text = Fond;
           Runname.Text = Charity;
            daytime.Start();
            date = new DateTime(2020, 11, 24, 6, 00, 00);
        }

        private void daytime_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mtlable.Text = "Осталось " + d.Days + " дней. " + d.Hours + " часов " + d.Minutes + " минут " + d.Seconds + "секунд";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sponsorruner frm = new sponsorruner();
             frm.Show();
              this.Close();
            daytime.Stop();
        }
    }
}
