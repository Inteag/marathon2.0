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
    public partial class listblagoorg : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public listblagoorg()
        {
            InitializeComponent();
        }

        private void listblagoorg_Load(object sender, EventArgs e)
        {
             String sSQL1 = "SELECT CharityId,CharityName,CharityDescription FROM charity";
             String sConnectionString = "Database=prakt;Data Source=127.0.0.1;User Id=root";

             MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
             result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(sSQL1, sConnectionString);
             if (result.HasError == false)
             {
                 metroGrid1.Columns.Clear();
                 metroGrid1.DataSource = result.ResultData.DefaultView;
             }
            else
            { 
                MessageBox.Show(result.ErrorText);
            }
     //       for (int i=1;i<14; i++)
          //  {
        //        metroGrid1.Rows[i].Cells[3].Value = Properties.Resources.arise_logo;
        //    }
        
            daytime.Start();
            date = new DateTime(2020, 11, 24, 6, 00, 00);
        }

        private void listblagoorg_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void daytime_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mtlable.Text = "Осталось " + d.Days + " дней. " + d.Hours + " часов " + d.Minutes + " минут " + d.Seconds + "секунд";
        }
    }
}
