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
    public partial class PrintVoucher : Form
    {
        public PrintVoucher()
        {
            InitializeComponent();
        }
        GetDataBase obj = new GetDataBase();
        private void PrintVoucher_Load(object sender, EventArgs e)
        {
            try
            {
                if (txtrepeatreceipt.Text == "")
                {

                    DataTable dtidentity = new DataTable();
                    dtidentity = obj.getdatabase("Select * from identity");

                    System.Data.DataTable dtgetVoucher = new System.Data.DataTable();
                    if (txtForm.Text == "update")
                    {
                        dtgetVoucher = obj.getdatabase("Select productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,srv,expirydate,suppliername,staffname,runningtotal from preupdate order by productid");
                        if (dtgetVoucher.Rows.Count > 0)
                        {
                            DataTable dt = new ReportGenerators.DataSet.dsVoucher.dtVoucherDataTable();
                            dt = dtgetVoucher;
                            ReportGenerators.CrystalReport.crpVoucher crp = new ReportGenerators.CrystalReport.crpVoucher();
                            crp.SetDataSource(dt);
                            crvVoucher.ReportSource = crp;
                        }
                       
                    }
                    else
                    {
                        dtgetVoucher = obj.getdatabase("Select productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,srv,expirydate,suppliername,staffname,runningtotal from preentry order by productid");
                        if (dtgetVoucher.Rows.Count > 0)
                        {
                            DataTable dt = new ReportGenerators.DataSet.dsVoucher.dtVoucherDataTable();
                            dt = dtgetVoucher;
                            ReportGenerators.CrystalReport.crpVoucher crp = new ReportGenerators.CrystalReport.crpVoucher();
                            crp.SetDataSource(dt);
                         
                            crvVoucher.ReportSource = crp;
                        }

                    }
                }
                else
                {
                    DataTable dtidentity = new DataTable();
                    dtidentity = obj.getdatabase("Select * from identity");
                    double temp = 0;
                    System.Data.DataTable dtgetsaleslog = new System.Data.DataTable();
                    dtgetsaleslog = obj.getdatabase("select * from product where srv= '" + txtrepeatreceipt.Text + "' order by productname");
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
