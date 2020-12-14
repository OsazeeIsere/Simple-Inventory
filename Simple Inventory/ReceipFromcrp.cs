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

namespace Simple_Inventory
{
    public partial class ReceipFromcrp : Form
    {
        public ReceipFromcrp()
        {
            InitializeComponent();
        }
        GetDataBase obj = new GetDataBase();
        private void ReceipFromcrp_Load(object sender, EventArgs e)
        {
            try
            {
                if (txtrepeatreceipt.Text == "")
                {

                    System.Data.DataTable dtgetsales = new System.Data.DataTable();
                   dtgetsales = obj.getdatabase("Select * from supply order by itemsupplied");
                    //dtgetsales.WriteXmlSchema("osazee.xml")
                    if (dtgetsales.Rows.Count > 0)
                    {
                        string connString = "Server=localhost;Port=3306;Database=edp;Uid=root;Pwd=prayer;";
                        MySqlDataAdapter da = new MySqlDataAdapter();
                        DataSet ds = new ReportGenerators.DataSet.dsReceipt();
                        DataTable dt = new ReportGenerators.DataSet.dsReceipt.dtReceiptDataTable();
                        MySqlConnection cn = new MySqlConnection(connString);
                        cn.Open();
                        dt = obj.getdatabase("SELECT destination, siv, itemsupplied, unitpack, section, staffname, quantitysupplied, unitrate,unitsalesprice,amount,runningtotal FROM supply");
                        cn.Close();
                        ReportGenerators.CrystalReport.crpReceipt rptXMLReport = new ReportGenerators.CrystalReport.crpReceipt();

                        rptXMLReport.SetDataSource(dt);
                        crvReceipt1.DisplayGroupTree = false;
                        crvReceipt1.ReportSource = rptXMLReport;
                    }
                }
                else
                {
                    System.Data.DataTable dtgetsaleslog = new System.Data.DataTable();
                    dtgetsaleslog = obj.getdatabase("select * from supplylog where siv= '" + txtrepeatreceipt.Text + "' order by itemsupplied");
                    if (dtgetsaleslog.Rows.Count > 0)
                    {

                    }
                      
                    }
                               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
