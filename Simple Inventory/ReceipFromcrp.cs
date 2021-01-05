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
                    DateTime dateOne;
                    int months = 0;
                    int months1 = 0;
                    int year = 0;
                    int year1 = 0;
                    int monthdiff1 = 0;
                    int yeardiff = 0;
                    int totalmonths = 0;

                    System.Data.DataTable getregistry = new DataTable();
                    getregistry = obj.getdatabase("Select * from registry");
                    if (getregistry.Rows.Count > 0)
                    {
                        dateOne = Convert.ToDateTime(getregistry.Rows[0]["startdate"]);
                        months = dateOne.Month;
                        months1 = dateTimePicker1.Value.Month;
                        monthdiff1 = 12 - months1;
                        year = dateOne.Year;
                        year1 = dateTimePicker1.Value.Year;
                        //this helps to capture the full years  
                        yeardiff = ((year - 1) - (year1 + 1)) + 1;
                        totalmonths = (months + monthdiff1) + (12 * yeardiff);
                        if (totalmonths >6)
                        {
                            MessageBox.Show("Please, The Application Requires Update To Be Able To Generate The Crystal Report!");
                        }
                        else
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
