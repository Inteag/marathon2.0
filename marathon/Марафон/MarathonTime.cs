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
    public partial class MarathonTime : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();

        public MarathonTime()
        {
            InitializeComponent();
        }

        private void MarathonTime_Load(object sender, EventArgs e)
        {
            daytime.Start();
            date = new DateTime(2020, 11, 24, 6, 00, 00);

        }

        private void daytime_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mtlable.Text = "Осталось " + d.Days + " дней. " + d.Hours + " часов " + d.Minutes + " минут " + d.Seconds + "секунд";

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox6.Image;
            metroLabel1.Text = "Гоночный болид F1 пройдет марафон за 7 минут 20 секунд";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox2.Image;
            metroLabel1.Text = "Червь пройдет марафон за 58 дней 7 часов";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox3.Image;
            metroLabel1.Text = "Ленивец пройдет марафон за 14 дней 12 часов";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox4.Image;
            metroLabel1.Text = "Капибара пройдет марафон за 1 час 12 минут";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox5.Image;
            metroLabel1.Text = "Ягуар пройдет марафон за 31 минуту 30 секунд";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox11.Image;
            metroLabel1.Text = "Длина airbus-a380 73 м. Это займет 575,34 из них, чтобы покрыть расстояние в 42 км марафона"; 
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox10.Image;
            metroLabel1.Text = "Длина pair-of-havaianas 24.5 cм. Это займет 171428 из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox9.Image;
            metroLabel1.Text = "Длина football-field 105 м. Это займет 400 из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox8.Image;
            metroLabel1.Text = "Длина ronaldinho 1.81 м. Это займет 23204 из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox7.Image;
            metroLabel1.Text = "Длина bus 10 м. Это займет 4200 из них, чтобы покрыть расстояние в 42 км марафона";
        }
    }
}
