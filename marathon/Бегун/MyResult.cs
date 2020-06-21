using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marathon.Бегун
{
    public partial class MyResult : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        private int RegistrationId;
        private string Gen;
        private DateTime Date;
        public MyResult(int reg, string gen, DateTime date)
        {
            RegistrationId = reg;
            Gen = gen;
            Date = date;
            InitializeComponent();
        }

        private void MyResult_Load(object sender, EventArgs e)
        {
            daytime.Start();
            date = new DateTime(2020, 11, 24, 6, 00, 00);
            metroLabel1.Text = "Пол: " + Gen;
            DateTime dt; TimeSpan dt2;
            dt = DateTime.Now;
            dt2 = dt - Date;
            if (dt2.Days / 365 < 18)
                metroLabel2.Text = "Возрастная категория: до 18";
            else if ((dt2.Days / 365) >= 18 && (dt2.Days / 365) <= 29)
                metroLabel2.Text = "Возрастная категория: от 18 до 29";
            else if ((dt2.Days / 365) >= 30 && (dt2.Days / 365) <= 39)
                metroLabel2.Text = "Возрастная категория: от 30 до 39";
            else if ((dt2.Days / 365) >= 40 && (dt2.Days / 365) <= 55)
                metroLabel2.Text = "Возрастная категория: от 40 до 55";
            else if ((dt2.Days / 365) >= 56 && (dt2.Days / 365) <= 70)
                metroLabel2.Text = "Возрастная категория: от 56 до 70";
            else if ((dt2.Days / 365) > 70)
                metroLabel2.Text = "Возрастная категория: более 70";
        }

        private void daytime_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mtlable.Text = "Осталось " + d.Days + " дней. " + d.Hours + " часов " + d.Minutes + " минут " + d.Seconds + "секунд";
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
