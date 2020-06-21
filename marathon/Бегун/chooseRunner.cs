using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using marathon.Бегун;

namespace marathon.Спонсоры
{
    public partial class chooseRunner : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public chooseRunner()
        {

            InitializeComponent();
        }

        private void chooseRunner_Load(object sender, EventArgs e)
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
            AuthicationLogin autor = new AuthicationLogin();
            autor.Show();
            this.Close();
        }
        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            RunnerReg reg = new RunnerReg();
            reg.Show();
            this.Close();
        }
    }
}
