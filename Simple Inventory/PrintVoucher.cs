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


                            DataTable dtidentity = new DataTable();
                            dtidentity = obj.getdatabase("Select * from identity");

                            System.Data.DataTable dtgetVoucher = new System.Data.DataTable();
                            if (txtForm.Text == "update")
                            {
                                dtgetVoucher = obj.getdatabase("Select productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,srv,expirydate,suppliername,staffname,runningtotal from preupdate order by productid");
                                if (dtgetVoucher.Rows.Count > 0)
                                {
                                    //DataTable dt = new ReportGenerators.DataSet.dsVoucher.dtVoucherDataTable();
                                    //dt = dtgetVoucher;
                                    ReportGenerators.CrystalReport.crpVoucher crp = new ReportGenerators.CrystalReport.crpVoucher();
                                    crp.Database.Tables["dtVoucher"].SetDataSource(dtgetVoucher);
                                    crvVoucher.ReportSource = null;
                                    crvVoucher.ReportSource = crp;
                                }

                            }
                            else
                            {
                                dtgetVoucher = obj.getdatabase("Select productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,srv,expirydate,suppliername,staffname,runningtotal from preentry order by productid");
                                if (dtgetVoucher.Rows.Count > 0)
                                {
                                    //DataTable dt = new ReportGenerators.DataSet.dsVoucher.dtVoucherDataTable();
                                    //dt = dtgetVoucher;
                                    ReportGenerators.CrystalReport.crpVoucher crp = new ReportGenerators.CrystalReport.crpVoucher();
                                    crp.Database.Tables["dtVoucher"].SetDataSource(dtgetVoucher);
                                    crvVoucher.ReportSource = null;
                                    crvVoucher.ReportSource = crp;

                                }

                            }
                        }
                    }
                }
                else
                {
                    DataTable dtidentity = new DataTable();
                    dtidentity = obj.getdatabase("Select * from identity");
//                  double temp = 0;
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
