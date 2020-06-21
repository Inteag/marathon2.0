using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universal;

namespace marathon.Бегун
{
    public partial class UpdateRunner : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        string filename = "";
        string Emaillog;
        string countrys;
        public UpdateRunner(string Email)
        {
            Emaillog = Email;
            InitializeComponent();

        }

        private void UpdateRunner_Load(object sender, EventArgs e)
        {
            /* MySqlConnection connection = new MySqlConnection("Database=marathon-skills-2020;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=root;");
             MySqlCommand command;
             MySqlDataAdapter jora;
             string selectQuery = "SELECT * FROM charity";
             command = new MySqlCommand(selectQuery, connection);
             jora = new MySqlDataAdapter(command);

             DataTable table = new DataTable();

             dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
             dataGridView1.RowTemplate.Height = 50;
             dataGridView1.AllowUserToAddRows = false;

             jora.Fill(table);

             dataGridView1.DataSource = table;

             DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
             imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[3];
             imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
             jora.Dispose();*/

            mtEmail.Text = Emaillog;
            daytime.Start();
            date = new DateTime(2020, 11, 24, 6, 00, 00);
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
                MySqlCommand cmd = new MySqlCommand("SELECT `image` FROM `runner` where `Email`='" + Emaillog + "'", connect);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                byte[] img = (byte[])table.Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
                pbImage.Image = Image.FromStream(ms);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            byte[] byteArray = new byte[0];


            MySqlCommand comm = new MySqlCommand("SELECT `image` FROM `runner` where `Email`='" + Emaillog + "'", connect);

            //  byteArray = (byte[])comm.ExecuteScalar();
            // MemoryStream ms = new MemoryStream(byteArray);
            // MemoryStream ms = new MemoryStream((byte[])comm.ExecuteScalar());
            //pbImage.Image = Image.FromStream(ms);
            // pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            // ms.Close();
            /*  MySqlCommand im = new MySqlCommand("SELECT Photo FROM Darck_diamond.Jewelry WHERE idJewelry=@id", connect);
              im.Parameters.AddWithValue("@id", i);
              MySqlDataAdapter da = new MySqlDataAdapter(im);
              DataTable table = new DataTable();
              byte[] img = (byte[])table.Rows[0][0];
              MemoryStream ms = new MemoryStream(img);
              da.Fill(table);
              imaj = Image.FromStream(ms);
              da.Dispose();*/
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string connection = "Database=prakt;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=";
            MySqlConnection connect = new MySqlConnection(connection);
            connect.Open();
            try
            {
                MySqlCommand countryCode = new MySqlCommand("Select `CountryCode` From`country` where CountryName like '" + mtcountry.Text + "'", connect); ;
                MySqlDataReader counrucode = countryCode.ExecuteReader();
                while (counrucode.Read())
                {
                    countrys = counrucode.GetString(0);
                }
                counrucode.Close();

                if (filename != "")
                {
                    Image img = Image.FromFile(filename);
                    if (mtpass.Text != "")
                    {
                        if (Recording.SecurityPassword(mtpass.Text))
                        {
                            //Меняем пароль
                            if (mtpass.Text == mtpasspov.Text)
                            {
                                MySqlCommand upduser = new MySqlCommand("UPDATE `user` SET  `Password` = ' " + mtpass.Text + " ' , `FirstName` = '" + mtname.Text + "', `LastName` = '" + mtlastname.Text + " ' Where Email= '" + mtEmail.Text + " ';", connect);
                                MySqlDataReader reader1 = upduser.ExecuteReader();
                                while (reader1.Read())
                                {
                                }
                                reader1.Close();
                                string dateString = string.Format("{0:yyyy-MM-dd hh:mm:ss}", mthappy.Value);
                                MySqlCommand uprunner = new MySqlCommand("UPDATE `runner ` SET  `Image` = '@imageHere' , `Gender` = '" + mtmd.Text + "', `DateofBith` = '" + dateString + "', `CountryCode`= ' " + mtcountry.Text + " ' Where Email= '" + mtEmail.Text + " ';", connect);
                                FileStream fImage = new FileStream(filename, FileMode.Open, FileAccess.Read);
                                Byte[] imageBytes = new byte[fImage.Length];
                                fImage.Read(imageBytes, 0, imageBytes.Length);
                                MySqlParameter par = new MySqlParameter("@imageHERE", MySqlDbType.Blob);
                                par.Value = imageBytes;
                                MySqlDataReader runnerread = uprunner.ExecuteReader();
                                while (runnerread.Read())
                                {

                                }
                                runnerread.Close();
                                connect.Close();

                            }

                            else
                                MetroFramework.MetroMessageBox.Show(this, "Не правильный повторный пароль!", "Ошибка смены пароля");
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Пароль должен содержать: \n 1. Минимум 6 символов \n 2. Минимум 1 цифру \n 3. Набор специальных знаков \n 4. 1 прописная буква");
                            return;
                        }
                    }
                    else
                    {
                        MySqlCommand upduser = new MySqlCommand("UPDATE `user ` SET  `FirstName` = '" + mtname.Text + "', `LastName` = '" + mtlastname.Text + " ' Where Email= '" + mtEmail.Text + " ';", connect);
                        MySqlDataReader reader1 = upduser.ExecuteReader();
                        while (reader1.Read())
                        {
                        }
                        reader1.Close();
                        string dateString = string.Format("{0:yyyy-MM-dd hh:mm:ss}", mthappy.Value);
                        MySqlCommand uprunner = new MySqlCommand("UPDATE `runner ` SET  `Image` = '@imageHere' , `Gender` = '" + mtmd.Text + "', `DateofBith` = '" + dateString + "', `CountryCode`= ' " + mtcountry.Text + " ' Where Email= '" + mtEmail.Text + " ';", connect);
                        FileStream fImage = new FileStream(filename, FileMode.Open, FileAccess.Read);
                        Byte[] imageBytes = new byte[fImage.Length];
                        fImage.Read(imageBytes, 0, imageBytes.Length);
                        MySqlParameter par = new MySqlParameter("@imageHERE", MySqlDbType.Blob);
                        par.Value = imageBytes;
                        MySqlDataReader runnerread = uprunner.ExecuteReader();
                        while (runnerread.Read())
                        {

                        }
                        runnerread.Close();
                        connect.Close();
                    }
                    this.Update();
                    MetroFramework.MetroMessageBox.Show(this, "Данные успешно измененые", "Успех");
                }
                else
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Фото профиля не загружено?", "Фото не загружено", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        Image ConvertToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void daytime_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mtlable.Text = "Осталось " + d.Days + " дней. " + d.Hours + " часов " + d.Minutes + " минут " + d.Seconds + "секунд";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    pbImage.Image = Image.FromFile(filename);
                }
            }
        }

        private void mtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(e.KeyChar) && number != 8)
                e.Handled = true;
        }

        private void mtlastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(e.KeyChar) && number != 8)
                e.Handled = true;
        }
    }
}
