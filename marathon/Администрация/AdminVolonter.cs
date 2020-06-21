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

namespace marathon.Администрация
{
    public partial class AdminVolonter : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public AdminVolonter()
        {
            InitializeComponent();
        }

        private void AdminVolonter_Load(object sender, EventArgs e)
        {
            daytime.Start();
            date = new DateTime(2020, 11, 24, 6, 00, 00);

            string connection = "Database=prakt;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=";
            MySqlConnection connect = new MySqlConnection(connection);
            connect.Open();
            MySqlCommand schet = new MySqlCommand("SELECT COUNT(*) FROM volunteer WHERE 1", connect);
            metroLabel3.Text = "Всего волонтеров:" + schet.ExecuteScalar().ToString();
            String sSQL1 = "SELECT * FROM volunteer";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(sSQL1, connection);
            if (result.HasError == false)
            {
                metroGrid1.Columns.Clear();
                metroGrid1.DataSource = result.ResultData.DefaultView;
            }
            else
            {
                MessageBox.Show(result.ErrorText);
            }
            connect.Close();

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            VolonterAdd frm = new VolonterAdd();
            frm.ShowDialog();
            mtrefresh_Click(this, null);
        }

        private void daytime_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mtlable.Text = "Осталось " + d.Days + " дней. " + d.Hours + " часов " + d.Minutes + " минут " + d.Seconds + "секунд";

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if (metroComboBox1.Text == "Имя")
                metroGrid1.Sort(metroGrid1.Columns[1], ListSortDirection.Ascending);
            else if (metroComboBox1.Text == "Фамилия")
                metroGrid1.Sort(metroGrid1.Columns[2], ListSortDirection.Ascending);
            else if (metroComboBox1.Text == "Страна")
                metroGrid1.Sort(metroGrid1.Columns[3], ListSortDirection.Ascending);
            else if (metroComboBox1.Text == "Пол")
                metroGrid1.Sort(metroGrid1.Columns[4], ListSortDirection.Ascending);
          //  metroLabel3.Text = "Всего волонтеров:" + schet.ExecuteScalar().ToString();
        }

        private void mtrefresh_Click(object sender, EventArgs e)
        {
            string connection = "Database=prakt;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=";
            MySqlConnection connect = new MySqlConnection(connection);
            connect.Open();
            MySqlCommand schet = new MySqlCommand("SELECT COUNT(*) FROM volunteer WHERE 1", connect);
            metroLabel3.Text = "Всего волонтеров:" + schet.ExecuteScalar().ToString();
            String sSQL1 = "SELECT * FROM volunteer";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(sSQL1, connection);
            if (result.HasError == false)
            {
                metroGrid1.Columns.Clear();
                metroGrid1.DataSource = result.ResultData.DefaultView;
            }
            else
            {
                MessageBox.Show(result.ErrorText);
            }
            connect.Close();
        }
    }
}
