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

namespace marathon.Администрация
{
    public partial class BlagoAdd : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        int i;
        bool Img = false;
        string filename;
        public BlagoAdd(int index)
        {
            i = index;
           // string inde = index;
            InitializeComponent();
        }

        private void BlagoAdd_Load(object sender, EventArgs e)
        {
            daytime.Start();
            date = new DateTime(2020, 11, 24, 6, 00, 00);
          
            if (opis.Text != "")
            {
                if (naimenov.Text != "")
                {
                    if (i > 0)
                    {

                        string connection = "Database=prakt;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=";
                        MySqlConnection connect = new MySqlConnection(connection);
                        connect.Open();
                        try
                        {
                            MySqlCommand cmd = new MySqlCommand("Select CharityLogo From charity Where `CharityId` like'" + i + "'", connect);
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            da.Fill(table);
                            byte[] img = (byte[])table.Rows[0][0];
                            MemoryStream ms = new MemoryStream(img);
                            pictureBox1.Image = Image.FromStream(ms);
                            da.Dispose();
                            MySqlCommand command = new MySqlCommand("Select CharityName From charity Where `CharityId` like'" + i + "'", connect);
                            MySqlDataReader name = command.ExecuteReader();
                            while (name.Read())
                            {
                                naimenov.Text = name.GetString(0);
                            }
                            name.Close();
                            MySqlCommand command2 = new MySqlCommand("Select CharityDescription From charity Where `CharityId` like'" + i + "'", connect);
                            MySqlDataReader opisanie = command2.ExecuteReader();
                            while (opisanie.Read())
                            {
                                opis.Text = opisanie.GetString(0);
                            }
                            opisanie.Close();

                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
            }
        }

        private void daytime_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mtlable.Text = "Осталось " + d.Days + " дней. " + d.Hours + " часов " + d.Minutes + " минут " + d.Seconds + "секунд";
        }

        private void mtsave_Click(object sender, EventArgs e)
        {
            string connection = "Database=prakt;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=";
            MySqlConnection connect = new MySqlConnection(connection);
            connect.Open();
            try
            {
             /*   MySqlCommand clear = new MySqlCommand("update `charity` set `CharityLogo`='Null' where `CharityId` like'" + i + "';", connect);
                MySqlCommand add = new MySqlCommand("UPDATE `charity` SET  `CharityName` = ' " + naimenov.Text + " ' , `CharityDescription` = '" + opis.Text + "'  where `CharityId` like'" + i + "';", connect);
                MySqlCommand inp = new MySqlCommand("INSERT INTO `runner`(`image`)values('@imageHERE')", connect);

                //     MySqlCommand inp = new MySqlCommand("INSERT INTO `runner`(`image`, `Email`, `Gender`, `DateOfBirth`, `CountryCode`) VALUES('@imageHERE','" + mtEmail.Text + "','" + mtmd.Text + "','" + dateString + "' ,'" + countrys + "')", connect);
                //  MySqlCommand cmd = new MySqlCommand("INSERT INTO `runner` (`image`)" + " VALUES(@imageHERE);", connect);
               FileStream fImage = new FileStream(filename, FileMode.Open, FileAccess.Read);
                Byte[] imageBytes = new byte[fImage.Length];
                fImage.Read(imageBytes, 0, imageBytes.Length);
                MySqlParameter par = new MySqlParameter("@imageHERE", MySqlDbType.Blob);
                par.Value = imageBytes;
                MySqlDataReader runnerread = inp.ExecuteReader();
                while (runnerread.Read())
                {

                }
                runnerread.Close();*/
            }
            catch (Exception ex)
            {

            }
        }

        private void mtopen_Click(object sender, EventArgs e)
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
