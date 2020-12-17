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
                DataTable getStock = new DataTable();
                DataTable dt = new ReportGenerators.DataSet.dsPerSection.dtPerSectionDataTable();

                if (txtsection.Text == "A1")
                {
                    getStock = obj.getdatabase("Select productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,srv,expirydate from product WHERE section = 'A1'");
                    dt = getStock;
                    ReportGenerators.CrystalReport.crpPerSection crpPerSection = new CrystalReport.crpPerSection();
                    
                    crpPerSection.SetDataSource(dt);
                    crvPerSection.DisplayGroupTree = false;
                    crvPerSection.ReportSource = crpPerSection;
                }
               else if(txtsection.Text == "A2")
                {
                    getStock = obj.getdatabase("Select productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,srv,expirydate from product WHERE section = 'A2'");
                    dt = getStock;
                    ReportGenerators.CrystalReport.crpPerSection crpPerSection = new CrystalReport.crpPerSection();
                    crpPerSection.SetDataSource(dt);
                    crvPerSection.DisplayGroupTree = false;
                    crvPerSection.ReportSource = crpPerSection;
                }
                else if (txtsection.Text == "A3")
                {
                    getStock = obj.getdatabase("Select productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,srv,expirydate from product WHERE section = 'A3'");
                    dt = getStock;
                    ReportGenerators.CrystalReport.crpPerSection crpPerSection = new CrystalReport.crpPerSection();
                    crpPerSection.SetDataSource(dt);
                    crvPerSection.DisplayGroupTree = false;
                    crvPerSection.ReportSource = crpPerSection;
                }
                else if (txtsection.Text == "D")
                {
                    getStock = obj.getdatabase("Select productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,srv,expirydate from product WHERE section = 'D'");
                    dt = getStock;
                    ReportGenerators.CrystalReport.crpPerSection crpPerSection = new CrystalReport.crpPerSection();
                    crpPerSection.SetDataSource(dt);
                    crvPerSection.DisplayGroupTree = false;
                    crvPerSection.ReportSource = crpPerSection;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
