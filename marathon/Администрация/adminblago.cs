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
    public partial class adminblago : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        int index = 0;
        public adminblago()
        {
            InitializeComponent();
        }

        private void adminblago_Load(object sender, EventArgs e)
        {
            daytime.Start();
            date = new DateTime(2020, 11, 24, 6, 00, 00);
            string connection = "Database=prakt;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=";
            MySqlConnection connect = new MySqlConnection(connection);
            connect.Open();
            MySqlCommand command;
            MySqlDataAdapter add;
            string selectQuery = "SELECT * FROM charity";
            command = new MySqlCommand(selectQuery, connect);
            add = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            add.Fill(table);
            metroGrid1.DataSource = table;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)metroGrid1.Columns[3];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            add.Dispose();
            /*   String sSQL1 = "SELECT CharityId,CharityName,CharityDescription FROM charity";
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
               }*/
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            BlagoAdd frm = new BlagoAdd(index);
            frm.ShowDialog();
        }

        private void daytime_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mtlable.Text = "Осталось " + d.Days + " дней. " + d.Hours + " часов " + d.Minutes + " минут " + d.Seconds + "секунд";

        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = metroGrid1.SelectedRows[0].Index + 1;
            BlagoAdd frm = new BlagoAdd(index);
            frm.ShowDialog();
        }
    }
}
