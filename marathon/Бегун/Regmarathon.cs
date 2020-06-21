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

namespace marathon.Бегун
{
    public partial class Regmarathon : MetroFramework.Forms.MetroForm
    {

        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        private int RunID, RegSum = 0;
        string costA, costB, costC;
        public Regmarathon()
        {
            InitializeComponent();
        }

        private void Regmarathon_Load(object sender, EventArgs e)
        {
            daytime.Start();
            date = new DateTime(2020, 11, 24, 6, 00, 00);
           string connection = "Database=prakt;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=";
           MySqlConnection connect = new MySqlConnection(connection);
           connect.Open();
           try
            {
                MySqlCommand command1 = new MySqlCommand("Select concat(`CharityName`,'-',`charityId`) from `charity` Where 1", connect);
                MySqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    inpcb.Items.Add(reader1.GetString(0));
                }
                inpcb.SelectedIndex = 0;
                reader1.Close();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string cb;
            if (inpcb.SelectedIndex >= 9)
                cb = inpcb.Text.Substring(0, inpcb.Text.Length - 3);
            else
                cb = inpcb.Text.Substring(0, inpcb.Text.Length - 2);
            Спонсоры.infblago inf = new Спонсоры.infblago(cb);
            inf.ShowDialog();
        }

        private void regb_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(materialSingleLineTextField1.Text) >= 0)
            {
                string temp = "";
                if (mtrba.Checked)
                    temp = "A";
                else if (mtrbb.Checked)
                    temp = "B";
                else if (mtrbc.Checked)
                    temp = "C";
                MetroFramework.MetroMessageBox.Show(this, "Вы успешно зарегистрировались! С вами свяжуться по поводу оплаты", "Успех");
            }
            else
            {
                MessageBox.Show("Сумма взноса не должна быть отрицательной!", "Ошибка");
                return;
            }
        }

        private void materialSingleLineTextField1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 32)
            {
                e.Handled = true;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            RegSum = materialCheckBox3.Checked ? RegSum += 20 : RegSum -= 20;
            metroLabel3.Text = RegSum.ToString();
        }

        private void materialCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            RegSum = materialCheckBox2.Checked ? RegSum += 75 : RegSum -= 75;
            metroLabel3.Text = RegSum.ToString();
        }

        private void mtrba_CheckedChanged(object sender, EventArgs e)
        { 
            RegSum = mtrba.Checked ? RegSum += 0 : RegSum -= 0;
            metroLabel3.Text = RegSum.ToString();
        }

        private void mtrbb_CheckedChanged(object sender, EventArgs e)
        {
            RegSum = mtrbb.Checked ? RegSum += 20 : RegSum -= 20;
            metroLabel3.Text = RegSum.ToString();
        }

        private void mtrbc_CheckedChanged(object sender, EventArgs e)
        {
          RegSum = mtrbc.Checked ? RegSum += 45 : RegSum -= 45;
            metroLabel3.Text = RegSum.ToString();
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            RegSum = materialCheckBox1.Checked ? RegSum += 145 : RegSum -= 145;
            metroLabel3.Text = RegSum.ToString();
        }
    }
}
