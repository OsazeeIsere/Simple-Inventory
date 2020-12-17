using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
//using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using MySql.Data.MySqlClient;
using CrystalDecisions.Data;

namespace Simple_Inventory
{
    public partial class SectionA1Report : Form
    {
        public SectionA1Report()
        {
            InitializeComponent();
        }
        GetDataBase obj = new GetDataBase();
        ReportGenerators.CrystalReport.SectionA1Stock crp = new ReportGenerators.CrystalReport.SectionA1Stock();
        private void SectionA1Report_Load(object sender, EventArgs e)
        {
            try
            {
                string connString = "Server=localhost;Port=3306;Database=edp;Uid=root;Pwd=prayer;";
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                MySqlConnection cn = new MySqlConnection(connString);
                da.SelectCommand = new MySqlCommand(@"SELECT * FROM supplylog", cn);
                //da.Fill(ds, "a1report");
                //dt = ds.Tables["a1report"];
                //dt.WriteXml("SectionA1.xml");
                //MessageBox.Show("An XLM file is created");
                DataSet dsReport = new ReportGenerators.DataSet.dsA1Section();
                // create temp dataset to read xml information 
                DataSet dsTempReport = new DataSet();

                dsTempReport.ReadXml(@"C:\Users\Osazee\source\repos\Simple Inventory\Simple Inventory\bin\Debug\SectionA1.xml");
                // copy XML data from temp dataset to our typed data set 
                dsReport.Tables[0].Merge(dsTempReport.Tables[0]);
                //prepare report for preview 
                ReportGenerators.CrystalReport.SectionA1Stock rptXMLReport = new ReportGenerators.CrystalReport.SectionA1Stock();
               
                rptXMLReport.SetDataSource(dsReport.Tables[0]);
                A1rptview.DisplayGroupTree = false;
                A1rptview.ReportSource = rptXMLReport;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
            }

        private void SectionA1Stock1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
