using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Inventory.ReportGenerators.ReportForms
{
    public partial class PerSectionStock : Form
    {
        public PerSectionStock()
        {
            InitializeComponent();
        }
        GetDataBase obj = new GetDataBase();
        private void PerSectionStock_Load(object sender, EventArgs e)
        {
            try
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
                    if (totalmonths > 6)
                    {
                        MessageBox.Show("Please, The Application Requires Update To Be Able To Generate The Crystal Report!");
                    }
                    else
                    {

                        DataTable getStock = new DataTable();
                        //DataTable dt = new ReportGenerators.DataSet.dsPerSection.dtPerSectionDataTable();

                        if (txtsection.Text == "A1")
                        {
                            getStock = obj.getdatabase("Select productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,srv,expirydate from product WHERE section = 'A1'");
                            // dt = getStock;
                            ReportGenerators.CrystalReport.crpPerSection crpPerSection = new CrystalReport.crpPerSection();

                            crpPerSection.Database.Tables["dtPerSection"].SetDataSource(getStock);
                            // crvPerSection.DisplayGroupTree = false;
                            crvPerSection.ReportSource = null;
                            crvPerSection.ReportSource = crpPerSection;
                        }
                        else if (txtsection.Text == "A2")
                        {
                            getStock = obj.getdatabase("Select productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,srv,expirydate from product WHERE section = 'A2'");
                            //dt = getStock;
                            ReportGenerators.CrystalReport.crpPerSection crpPerSection = new CrystalReport.crpPerSection();
                            crpPerSection.Database.Tables["dtPerSection"].SetDataSource(getStock);
                            // crvPerSection.DisplayGroupTree = false;
                            crvPerSection.ReportSource = null;
                            crvPerSection.ReportSource = crpPerSection;
                        }
                        else if (txtsection.Text == "A3")
                        {
                            getStock = obj.getdatabase("Select productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,srv,expirydate from product WHERE section = 'A3'");
                            //dt = getStock;
                            ReportGenerators.CrystalReport.crpPerSection crpPerSection = new CrystalReport.crpPerSection();
                            crpPerSection.Database.Tables["dtPerSection"].SetDataSource(getStock);
                            // crvPerSection.DisplayGroupTree = false;
                            crvPerSection.ReportSource = null;

                            crvPerSection.ReportSource = crpPerSection;
                        }
                        else if (txtsection.Text == "D")
                        {
                            getStock = obj.getdatabase("Select productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,srv,expirydate from product WHERE section = 'D'");
                            //dt = getStock;
                            ReportGenerators.CrystalReport.crpPerSection crpPerSection = new CrystalReport.crpPerSection();
                            crpPerSection.Database.Tables["dtPerSection"].SetDataSource(getStock);
                            // crvPerSection.DisplayGroupTree = false;
                            crvPerSection.ReportSource = null;
                            crvPerSection.ReportSource = crpPerSection;
                        }
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
