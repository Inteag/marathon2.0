using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universal;

namespace marathon.Бегун
{
    public partial class RunnerReg : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        string filename;
        bool Img = false;
        string countrys;
        public RunnerReg()
        {
            InitializeComponent();
        }

        private void RunnerReg_Load(object sender, EventArgs e)
        {
            string connection = "Database=prakt;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=";
            MySqlConnection connect = new MySqlConnection(connection);
            connect.Open();
            try
            {
                MySqlCommand command = new MySqlCommand("Select CountryName From country", connect);
                MySqlDataReader country = command.ExecuteReader();
                while (country.Read())
                {
                    mtcountry.Items.Add(country.GetString(0));
                }
                mtcountry.SelectedIndex = 0;
                country.Close();
                MySqlCommand command2 = new MySqlCommand(" SELECT* FROM `gender`", connect);
                MySqlDataReader gender = command2.ExecuteReader();
                while (gender.Read())
                {
                    mtmd.Items.Add(gender.GetString(0));
                }
                mtmd.SelectedIndex = 0;
                gender.Close();

            }
            catch (Exception ex)
            {

            }
            connect.Dispose();
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
            string checkem = "";
            string connection = "Database=prakt;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=";
            MySqlConnection connect = new MySqlConnection(connection);
            connect.Open();
            try
            {
                MySqlCommand check = new MySqlCommand("Select Email From user where Email Like'" + mtEmail.Text + "'", connect);
                MySqlDataReader em = check.ExecuteReader();
                while (em.Read())
                {
                    checkem = em.GetString(0);
                }
                em.Close();
            }
            catch (Exception ex)
            {

            }
            if (checkem == "")
            {
                if (mtEmail.Text != "" && mtlastname.Text != "" && mtname.Text != "" && mtpass.Text != "" && mtpasspov.Text != "" && mtcountry.Text != "" && mtmd.Text != "")
                {

                    if (!(Recording.SecurityPassword(mtpass.Text)))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Пароль должен содержать: \n 1. Минимум 6 символов \n 2. Минимум 1 цифру \n 3. Набор специальных знаков \n 4. 1 прописная буква");
                        return;
                    }
                    if (!(Recording.IsValidDate(Convert.ToDateTime(mthappy.Value), 10)))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Возраст участника должен быть не меньше 10 лет!");
                        return;
                    }
                    if (!(Recording.IsValidEmail(mtEmail.Text)))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Не корректный Email адрес!");
                        return;
                    }
                    if (mtpass.Text == mtpasspov.Text)
                    {
                        try
                        {
                            MySqlCommand countryCode = new MySqlCommand("Select `CountryCode` From`country` where CountryName like '" + mtcountry.Text + "'", connect); ;
                            MySqlDataReader counrucode = countryCode.ExecuteReader();
                            while (counrucode.Read())
                            {
                                countrys = counrucode.GetString(0);
                            }
                            counrucode.Close();

                            MySqlCommand user = new MySqlCommand("INSERT INTO `user`(`Email`,`Password`, `FirstName`,`LastName`,`RoleId`) VALUES('" + mtEmail.Text + "','" + mtpass.Text + "','" + mtname.Text + "' ,'" + mtlastname.Text + "' , 'R')", connect);
                            MySqlDataReader userread = user.ExecuteReader();
                            while (userread.Read())
                            {

                            }
                            userread.Close();
                            string dateString = string.Format("{0:yyyy-MM-dd hh:mm:ss}", mthappy.Value);
                            MySqlCommand inp = new MySqlCommand("INSERT INTO `runner`(`image`, `Email`, `Gender`, `DateOfBirth`, `CountryCode`) VALUES('@imageHERE','" + mtEmail.Text + "','" + mtmd.Text + "','" + dateString + "' ,'" + countrys + "')", connect);
                            //  MySqlCommand cmd = new MySqlCommand("INSERT INTO `runner` (`image`)" + " VALUES(@imageHERE);", connect);
                            FileStream fImage = new FileStream(filename, FileMode.Open, FileAccess.Read);
                            Byte[] imageBytes = new byte[fImage.Length];
                            fImage.Read(imageBytes, 0, imageBytes.Length);
                            MySqlParameter par = new MySqlParameter("@imageHERE", MySqlDbType.Blob);
                            par.Value = imageBytes;
                            inp.Parameters.Add(par);
                            connect.Close();
                            connect.Open();
                            inp.ExecuteNonQuery();
                            connect.Dispose();
                            /*  MySqlDataReader runnerread = inp.ExecuteReader();
                          while (runnerread.Read()) 
                          { 

                          }
                          runnerread.Close();*/
                            connect.Close();
                        }
                        catch (Exception ex)
                        {

                        }
                        MetroFramework.MetroMessageBox.Show(this, "Вы успешно зарегистрировались!", "Успех", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Пароли не совпадают", "Ошибка регистрации", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Не все поля были заполнены!", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                error.Text = "пользователь с таким Email уже зарегистрирован";
        }
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void mtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && e.KeyChar == (char)Keys.Back)
                e.Handled = true;
        }

        private void RunnerReg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(filename);
                    Img = true;
                }
            }
        }
    }
}
