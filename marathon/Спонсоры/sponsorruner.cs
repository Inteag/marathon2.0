using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using marathon.Спонсоры;
using MySql.Data.MySqlClient;

namespace marathon.бегун
{
    public partial class sponsorruner : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public sponsorruner()
        {
            InitializeComponent();
        }

        private void cardfi_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(e.KeyChar) && number != 8)
                e.Handled = true;
        }

        private void cardnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 32)
            {
                e.Handled = true;
            }
        }

        private void cardnum_TextChanged(object sender, EventArgs e)
        {
            if (cardnum.TextLength >= 17)
            {
                cardnum.Text = cardnum.Text.Substring(0, cardnum.Text.Length - 1);
                namesp.Focus();
            }
        }

        private void cvc_TextChanged(object sender, EventArgs e)
        {
            if (cvc.TextLength >= 4)
            {
                cvc.Text = cvc.Text.Substring(0, cvc.Text.Length - 1);
                namesp.Focus();
            }
        }

        private void monthcard_TextChanged(object sender, EventArgs e)
        {
            if (monthcard.TextLength >= 3)
            {
                monthcard.Text = monthcard.Text.Substring(0, monthcard.Text.Length - 1);
                namesp.Focus();
            }
        }

        private void yearscard_TextChanged(object sender, EventArgs e)
        {
            if (yearscard.TextLength >= 5)
            {
                yearscard.Text = yearscard.Text.Substring(0, yearscard.Text.Length - 1);
                namesp.Focus();
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
         
            if (yearscard.Text != "" && namesp.Text !="" && cvc.Text !="")
            {
                if (monthcard.Text != ""  && cardfi.Text !="" )
                {
                    int monthtext = int.Parse(monthcard.Text);
                    int yearstext = int.Parse(yearscard.Text);
                    if (yearstext > DateTime.Now.Year)
                    {
                            fanksponsor frm = new fanksponsor(namesp.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToString(runnercb.Text), Convert.ToString(blagocb.Text));
                            frm.Show();
                            this.Hide();
                    }
                    else
                    {
                        errortime.Text = "Карта не действительна";
                    }
                    if (yearstext == DateTime.Now.Year)
                    {
                        if (monthtext >= DateTime.Now.Month)
                        {
                            fanksponsor frm = new fanksponsor(namesp.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToString(runnercb.Text), Convert.ToString(blagocb.Text));
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            errortime.Text = "Карта не действительна";
                        }
                    }
                   
                }
            }
            else
            {
                error.Text = "Пожалуйста заполните все данные карты";
            }          
        }
        private void sponsorruner_Load(object sender, EventArgs e)
        {
            daytime.Start();
            date = new DateTime(2020, 11, 24, 6, 00, 00);
            string connection = "Database=prakt;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=";
            MySqlConnection connect = new MySqlConnection(connection);
            connect.Open();
            try
            { 
                MySqlCommand commandcb = new MySqlCommand("SELECT concat(`FirstName`,' ',`LastName`) FROM `user` WHERE RoleId like 'R'",connect);           
                MySqlDataReader readercb = commandcb.ExecuteReader();
                while (readercb.Read())
                {
                    runnercb.Items.Add(readercb.GetString(0));
                }
                runnercb.SelectedIndex = 0;
                readercb.Close();
                MySqlCommand command1 = new MySqlCommand("Select concat(`CharityName`,'-',`charityId`) from `charity` Where 1", connect);
                MySqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    blagocb.Items.Add(reader1.GetString(0)); 
                }
                blagocb.SelectedIndex = 0;
                reader1.Close();
            }
            catch(Exception ex) 
            { 

            }
            connect.Close();
        }

        private void daytime_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mtlable.Text = "Осталось " + d.Days + " дней. " + d.Hours + " часов " + d.Minutes + " минут " + d.Seconds + "секунд";
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
            daytime.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string cb;
            if (blagocb.SelectedIndex >=9)
                cb = blagocb.Text.Substring(0, blagocb.Text.Length - 3);
            else
                cb = blagocb.Text.Substring(0, blagocb.Text.Length - 2);
            infblago inf = new infblago(cb);
            inf.ShowDialog();
        }
    }
}