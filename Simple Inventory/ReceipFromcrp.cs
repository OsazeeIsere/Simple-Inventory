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
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Data;
using CrystalDecisions.ReportAppServer;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
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
                        DataTable dt = new DataTable();
                        dt = obj.getdatabase("SELECT destination, siv, itemsupplied, unitpack, section, staffname, quantitysupplied, unitrate,unitsalesprice,amount,runningtotal FROM supply");
                        
                        ReportGenerators.CrystalReport.crpReceipt rptXMLReport = new ReportGenerators.CrystalReport.crpReceipt();

                        rptXMLReport.Database.Tables["dtReceipt"].SetDataSource(dt);
                        crvReceipt1.ReportSource = null;
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
