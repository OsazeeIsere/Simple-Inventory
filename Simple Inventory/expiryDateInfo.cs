using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xlapp = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;

namespace Simple_Inventory
{
    public partial class expiryDateInfo : Form
    {
        public expiryDateInfo()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {
            try
            {
                int months=0;
                int months1 = 0;
                int year = 0;
                int year1 = 0;
                int monthdiff1 = 0;
                int yeardiff = 0;
                int totalmonths = 0;
                DateTime dateOne = default(DateTime);
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                System.Data.DataTable dtgetproduct1 = new System.Data.DataTable();
                System.Data.DataSet ds = new DataSet();
                if (string.IsNullOrEmpty(ComboBox1.Text))
                {
                    MessageBox.Show("Please Select the period under which to examine the EXPIRY DATE INFO");
                    ComboBox1.Focus();
                }
                else if ((ComboBox1.Text) == "Three Months(3) Time")
                {
                    ds = new DataSet();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dtgetproduct = obj.getdatabase("Select productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,srv,expirydate from expirydate");
                    if (dtgetproduct.Rows.Count > 0)
                    {
                        dt = dtgetproduct.Clone();

                        foreach (DataRow drtableOld in dtgetproduct.Rows)
                        {
                            //lstitem = new ListViewItem();
                            dateOne = Convert.ToDateTime(drtableOld["expirydate"]);
                            months = dateOne.Month;
                            months1 = DateTimePicker1.Value.Month;
                            monthdiff1 = 12 - months1;
                            year = dateOne.Year;
                            year1 = DateTimePicker1.Value.Year;
                            //this helps to capture the full years  
                            yeardiff = ((year - 1) - (year1 + 1)) + 1;
                            totalmonths = (months + monthdiff1) + (12 * yeardiff);
                            if (totalmonths > -1 && totalmonths < 4)
                            {
                                                                                             
                                  dt.ImportRow(drtableOld);
                                //lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                                //lsvitems.Items.Add(lstitem);
                                //dt.Rows.[j]=dtgetproduct.Rows[j]["productid"].ToString();
                                //dt.Rows.Add(dtgetproduct.Rows[j]["productname"].ToString());
                                //dt.Rows.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                                //dt.Rows.Add(dtgetproduct.Rows[j]["section"].ToString());
                                //dt.Rows.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                                //dt.Rows.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                                //dt.Rows.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                                //dt.Rows.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                                ////ds.Tables.Add(dtgetproduct.Rows[j]["batch"].ToString());
                                //dt.Rows.Add(dtgetproduct.Rows[j]["srv"].ToString());
                                //// lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());
                                //dt.Rows.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                                //lsvitems.Items.Add(lstitem);

                            }
                           
                        }
                        
                        //lsvitems.ForeColor = Color.IndianRed;
                        //txttotal.Text = lsvitems.Items.Count.ToString();
                        ReportGenerators.CrystalReport.crpExpirydateInfo crpExpiryDate = new ReportGenerators.CrystalReport.crpExpirydateInfo();
                        ReportGenerators.ReportForms.ExpiryDateReport expirydate = new ReportGenerators.ReportForms.ExpiryDateReport();
                       // crpExpiryDate.SetDataSource(ds);
                        crpExpiryDate.Database.Tables["dtPerSection"].SetDataSource(dt);

                        // crvPerSection.DisplayGroupTree = false;
                        expirydate.crvExpiryDateinfo.ReportSource = null;
                        expirydate.crvExpiryDateinfo.ReportSource = crpExpiryDate;
                        expirydate.Show();
                    }
                }
                else if ((ComboBox1.Text) == "Six Months(6) Time")
                {
                    ds = new DataSet();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dtgetproduct = obj.getdatabase("Select productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,srv,expirydate from expirydate");
                    if (dtgetproduct.Rows.Count > 0)
                    {
                        dt = dtgetproduct.Clone();

                        foreach (DataRow drtableOld in dtgetproduct.Rows)
                        {
                            //lstitem = new ListViewItem();
                            dateOne = Convert.ToDateTime(drtableOld["expirydate"]);

                            months = dateOne.Month;
                            months1 = DateTimePicker1.Value.Month;
                            monthdiff1 = 12 - months1;
                            year = dateOne.Year;
                            year1 = DateTimePicker1.Value.Year;
                            //this helps to capture the full years  
                            yeardiff = ((year - 1) - (year1 + 1)) + 1;
                            totalmonths = (months + monthdiff1) + (12 * yeardiff);
                            if (totalmonths > -1 && totalmonths < 7)
                            {
                                dt.ImportRow(drtableOld);

                                //lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                                //lsvitems.Items.Add(lstitem);

                            }
                        }
                        //lsvitems.ForeColor = Color.Red;
                        //txttotal.Text = lsvitems.Items.Count.ToString();
                        //lsvitems.ForeColor = Color.IndianRed;
                        //txttotal.Text = lsvitems.Items.Count.ToString();
                        ReportGenerators.CrystalReport.crpExpirydateInfo crpExpiryDate = new ReportGenerators.CrystalReport.crpExpirydateInfo();
                        ReportGenerators.ReportForms.ExpiryDateReport expirydate = new ReportGenerators.ReportForms.ExpiryDateReport();
                        // crpExpiryDate.SetDataSource(ds);
                        crpExpiryDate.Database.Tables["dtPerSection"].SetDataSource(dt);

                        // crvPerSection.DisplayGroupTree = false;
                        expirydate.crvExpiryDateinfo.ReportSource = null;
                        expirydate.crvExpiryDateinfo.ReportSource = crpExpiryDate;
                        expirydate.Show();

                    }
                }
                else if ((ComboBox1.Text) == "Above Six Months(6) Time")
                {
                    ds = new DataSet();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dtgetproduct = obj.getdatabase("Select productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,srv,expirydate from expirydate");
                    if (dtgetproduct.Rows.Count > 0)
                    {
                        dt = dtgetproduct.Clone();

                        foreach (DataRow drtableOld in dtgetproduct.Rows)
                        {
                            //lstitem = new ListViewItem();
                            dateOne = Convert.ToDateTime(drtableOld["expirydate"]);

                            months = dateOne.Month;
                            months1 = DateTimePicker1.Value.Month;
                            monthdiff1 = 12 - months1;
                            year = dateOne.Year;
                            year1 = DateTimePicker1.Value.Year;
                            //this helps to capture the full years  
                            yeardiff = ((year - 1) - (year1 + 1)) + 1;
                            totalmonths = (months + monthdiff1) + (12 * yeardiff);
                            if (totalmonths > 6)
                            {
                                dt.ImportRow(drtableOld);

                                //lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                                //lsvitems.Items.Add(lstitem);
                            }
                        }
                       
                        //lsvitems.ForeColor = Color.IndianRed;
                        //txttotal.Text = lsvitems.Items.Count.ToString();
                        ReportGenerators.CrystalReport.crpExpirydateInfo crpExpiryDate = new ReportGenerators.CrystalReport.crpExpirydateInfo();
                        ReportGenerators.ReportForms.ExpiryDateReport expirydate = new ReportGenerators.ReportForms.ExpiryDateReport();
                        // crpExpiryDate.SetDataSource(ds);
                        crpExpiryDate.Database.Tables["dtPerSection"].SetDataSource(dt);

                        // crvPerSection.DisplayGroupTree = false;
                        expirydate.crvExpiryDateinfo.ReportSource = null;
                        expirydate.crvExpiryDateinfo.ReportSource = crpExpiryDate;
                        expirydate.Show();

                    }
                }
                else if ((ComboBox1.Text) == "Drugs Already Expired")
                {
                    ds = new DataSet();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dtgetproduct = obj.getdatabase("Select productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,srv,expirydate from expirydate");
                    if (dtgetproduct.Rows.Count > 0)
                    {
                        dt = dtgetproduct.Clone();

                        foreach (DataRow drtableOld in dtgetproduct.Rows)
                        {
                            //lstitem = new ListViewItem();
                            dateOne = Convert.ToDateTime(drtableOld["expirydate"]);
                            months = dateOne.Month;
                            months1 = DateTimePicker1.Value.Month;
                            monthdiff1 = 12 - months1;
                            year = dateOne.Year;
                            year1 = DateTimePicker1.Value.Year;
                            //this helps to capture the full years  
                            yeardiff = ((year - 1) - (year1 + 1)) + 1;
                            totalmonths = (months + monthdiff1) + (12 * yeardiff);
                            if (totalmonths < 0)
                            {
                                dt.ImportRow(drtableOld);

                                //lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                                //lsvitems.Items.Add(lstitem);
                            }
                        }
                        //lsvitems.ForeColor = Color.IndianRed;
                        //txttotal.Text = lsvitems.Items.Count.ToString();
                        ReportGenerators.CrystalReport.crpExpirydateInfo crpExpiryDate = new ReportGenerators.CrystalReport.crpExpirydateInfo();
                        ReportGenerators.ReportForms.ExpiryDateReport expirydate = new ReportGenerators.ReportForms.ExpiryDateReport();
                        // crpExpiryDate.SetDataSource(ds);
                        crpExpiryDate.Database.Tables["dtPerSection"].SetDataSource(dt);

                        // crvPerSection.DisplayGroupTree = false;
                        expirydate.crvExpiryDateinfo.ReportSource = null;
                        expirydate.crvExpiryDateinfo.ReportSource = crpExpiryDate;
                        expirydate.Show();

                    }
                }
                else if ((ComboBox1.Text) == "Drugs That Will Expire This Month")
                {
                    ds = new DataSet();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dtgetproduct = obj.getdatabase("Select productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,srv,expirydate from expirydate");
                    if (dtgetproduct.Rows.Count > 0)
                    {
                        dt = dtgetproduct.Clone();

                        foreach (DataRow drtableOld in dtgetproduct.Rows)
                        {
                            //lstitem = new ListViewItem();
                            dateOne = Convert.ToDateTime(drtableOld["expirydate"]);
                            months = dateOne.Month;
                            months1 = DateTimePicker1.Value.Month;
                            monthdiff1 = 12 - months1;
                            year = dateOne.Year;
                            year1 = DateTimePicker1.Value.Year;
                            //this helps to capture the full years  
                            yeardiff = ((year - 1) - (year1 + 1)) + 1;
                            totalmonths = (months + monthdiff1) + (12 * yeardiff);
                            if (totalmonths == 0)
                            {
                                dt.ImportRow(drtableOld);

                                //lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());
                                //lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                                //lsvitems.Items.Add(lstitem);
                            }
                        }
                        //lsvitems.ForeColor = Color.IndianRed;
                        //txttotal.Text = lsvitems.Items.Count.ToString();
                        ReportGenerators.CrystalReport.crpExpirydateInfo crpExpiryDate = new ReportGenerators.CrystalReport.crpExpirydateInfo();
                        ReportGenerators.ReportForms.ExpiryDateReport expirydate = new ReportGenerators.ReportForms.ExpiryDateReport();
                        // crpExpiryDate.SetDataSource(ds);
                        crpExpiryDate.Database.Tables["dtPerSection"].SetDataSource(dt);

                        // crvPerSection.DisplayGroupTree = false;
                        expirydate.crvExpiryDateinfo.ReportSource = null;
                        expirydate.crvExpiryDateinfo.ReportSource = crpExpiryDate;
                        expirydate.Show();

                    }
                }
                else if ((ComboBox1.Text) == "All Drugs")
                {
                    
                      // Use TimeSpan and some date calculaton, this should work:
                        dtgetproduct = obj.getdatabase("Select * From expirydate order by productname");
                        if (dtgetproduct.Rows.Count > 0)
                        {
                            //ListViewItem lstitem = new ListViewItem();
                            //lsvitems.Items.Clear();
                            //for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                            //{
                            //    lstitem = new ListViewItem();
                            //    lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                            //    lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                            //    lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                            //    lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                            //    lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                            //    lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                            //    lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                            //    lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                            //    lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            //    lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                            //    lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                            //    lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //    lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                            //    lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                            //    lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());

                            //    lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            //    lsvitems.Items.Add(lstitem);
                            //}
                            //txttotal.Text = dtgetproduct.Rows.Count.ToString();
                        }

                    //lsvitems.ForeColor = Color.IndianRed;
                    //txttotal.Text = lsvitems.Items.Count.ToString();
                    ReportGenerators.CrystalReport.crpExpirydateInfo crpExpiryDate = new ReportGenerators.CrystalReport.crpExpirydateInfo();
                    ReportGenerators.ReportForms.ExpiryDateReport expirydate = new ReportGenerators.ReportForms.ExpiryDateReport();
                    // crpExpiryDate.SetDataSource(ds);
                    crpExpiryDate.Database.Tables["dtPerSection"].SetDataSource(dtgetproduct);

                    // crvPerSection.DisplayGroupTree = false;
                    expirydate.crvExpiryDateinfo.ReportSource = null;
                    expirydate.crvExpiryDateinfo.ReportSource = crpExpiryDate;
                    expirydate.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lsvitems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        GetDataBase obj = new GetDataBase();
        utility u = new utility();
        private void expiryDateInfo_Load(object sender, EventArgs e)
        {
            try
            {
                utility u = new utility();
                //u.fitFormToScreen(this, 900, 1600);
                //this.CenterToScreen();
                System.Data.DataTable dtidentity = new System.Data.DataTable();
                dtidentity = obj.getdatabase("Select * from identity");

                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                // lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

                // Use TimeSpan and some date calculaton, this should work:
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                dtgetproduct = obj.getdatabase("Select * From expirydate order by productname");
                if (dtgetproduct.Rows.Count > 0)
                {
                    ListViewItem lstitem = new ListViewItem();
                    lsvitems.Items.Clear();
                    for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                    {
                        lstitem = new ListViewItem();
                        lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                        // lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                        lsvitems.Items.Add(lstitem);
                    }
                    txttotal.Text = dtgetproduct.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                dtgetproduct = obj.getdatabase("Select * From product Where productname Like '%" + txtsearch.Text + "%' Order By productname;");
                if (dtgetproduct.Rows.Count > 0)
                {
                    ListViewItem lstitem = new ListViewItem();
                    lsvitems.Items.Clear();
                    for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                    {
                        if (Convert.ToInt32(dtgetproduct.Rows[j]["quantity"].ToString()) < 6)
                        {

                            lstitem = new ListViewItem();
                            lstitem.ForeColor = Color.Red;
                            lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvitems.Items.Add(lstitem);
                        }
                        else
                        {
                            lstitem = new ListViewItem();
                            lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvitems.Items.Add(lstitem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                int i = 1;
                int i2 = 1;
                foreach (ListViewItem lvi in lsvitems.Items)
                {
                    i = 1;
                    foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                    {
                        xlWorkSheet.Cells[i2, i] = lvs.Text;
                        i++;
                    }
                    i2++;
                }
                saveFileDialog1.ShowDialog();
                xlWorkBook.SaveAs(txtfile1.Text, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                u.releaseObject(xlWorkSheet);
                u.releaseObject(xlWorkBook);
                u.releaseObject(xlApp);

                MessageBox.Show("Excel file created , you can find the file c:\\" + txtfile1.Text);
                              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
    }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            txtfile1.Text = saveFileDialog1.FileName + ".xls";

        }
    } }

