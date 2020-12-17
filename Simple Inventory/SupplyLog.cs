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
using MySql.Data.MySqlClient;
namespace Simple_Inventory
{
    public partial class SupplyLog : Form
    {
        public SupplyLog()
        {
            InitializeComponent();
        }
        GetDataBase obj = new GetDataBase();
        private void SupplyLog_Load(object sender, EventArgs e)
        {
            try
            {
                utility u = new utility();
               // u.fitFormToScreen(this, 900, 1600);
              //  this.CenterToScreen();
                ReportGenerators.CrystalReport.SectionA1Stock crp = new ReportGenerators.CrystalReport.SectionA1Stock();
                DataTable dtidentity = new DataTable();
                dtidentity = obj. getdatabase("Select * from identity");

                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                //            lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();
                // x = new supplylog();
                double totalsales = 0;
                double totalprofit = 0;
                System.Data.DataTable dtgetsupplylog = new System.Data.DataTable();
                System.Data.DataTable dtgetsupplylog_dgv = new System.Data.DataTable();

                dtgetsupplylog_dgv = obj.getdatabase("select staffname,supplyid,productid,itemsupplied,quantitysupplied," +
                    "unitsalesprice,amountsupplied,siv,entrydate from supplylog order by entrydate");
                dtgetsupplylog = obj.getdatabase("select * from supplylog order by entrydate");

                System.Data.DataTable dtgetsupplylog1 = new System.Data.DataTable();
                dtgetsupplylog1 = obj.getdatabase("select amountsupplied,profit from supplylog");
                double temp = 0;
                double temp1 = 0;
                int c = 0;
                System.Data.DataTable dtgetcashier = new System.Data.DataTable();
                System.Data.DataTable dtgetadmin = new System.Data.DataTable();
                dtgetadmin = obj.getdatabase("select * from administrator");
                        dtgetsupplylog = obj.getdatabase("select * from supplylog order by date");
                        dgvsaleslog.DataSource = dtgetsupplylog_dgv;
                        // generate another table for necessary calculation

                        dtgetsupplylog1 = obj.getdatabase("select amountsupplied,profit from supplylog");

                        if (dtgetsupplylog1.Rows.Count > 0)
                        {
                            //to sum the 2 columns
                            for (var k = 0; k < dtgetsupplylog1.Rows.Count; k++)
                            {
                                temp = temp + Convert.ToDouble(dtgetsupplylog1.Rows[k]["amountsupplied"]);
                                temp1 = temp1 + Convert.ToDouble(dtgetsupplylog1.Rows[k]["profit"]);
                            }
                        }
                        c = dtgetsupplylog1.Rows.Count;
                        txtcustomer.Text = c.ToString();

                        totalsales = temp;
                        totalprofit = temp1;
                        txttotalsales.Text = totalsales.ToString();
                        txttotaprofit.Text = totalprofit.ToString();
                    
                
              
                dtgetcashier = obj.getdatabase("select * from staff");
                System.Data.DataTable dtgetbackup = new System.Data.DataTable();
                dtgetadmin = obj.getdatabase("select * from administrator");
                cbocashier.Items.Add("All Supplies").ToString();
                cbocashier.Items.Add("Daily Supply").ToString();
                if (dtgetcashier.Rows.Count > 0)
                {
                    for (var i = 0; i < dtgetcashier.Rows.Count; i++)
                    {
                        cbocashier.Items.Add(dtgetcashier.Rows[i]["staffname"]).ToString();
                    }
                }
                if (dtgetadmin.Rows.Count > 0)
                {
                    for (var i = 0; i < dtgetadmin.Rows.Count; i++)
                    {
                        cbocashier.Items.Add(dtgetadmin.Rows[i]["adminname"]).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double temp = 0;
                double temp1 = 0;
                int c = 0;
                System.Data.DataTable dtgetsupplylog = new System.Data.DataTable();
                System.Data.DataTable dtgetsupplylog1 = new System.Data.DataTable();
                double totalsales = 0;
                double totalprofit = 0;
                System.Data.DataTable dtgetadmin = new System.Data.DataTable();
                System.Data.DataTable dtgetsupplylog_dgv = new System.Data.DataTable();

                dtgetsupplylog_dgv = obj.getdatabase("select staffname,supplyid,productid,itemsupplied,quantitysupplied," +
                     "unitsalesprice,amountsupplied,siv,entrydate from supplylog order by entrydate");

                
                    if (cbocashier.Text == "All Supplies")
                    {
                        SupplyLog x = new SupplyLog();
                        dtgetsupplylog_dgv = obj.getdatabase("select staffname,supplyid,productid,itemsupplied,quantitysupplied," +
                     "unitsalesprice,amountsupplied,siv,entrydate from supplylog order by entrydate");
                        dgvsaleslog.DataSource = dtgetsupplylog_dgv;
                        // generate another table for necessary calculation

                        dtgetsupplylog1 = obj.getdatabase("select amountsupplied,profit from supplylog");

                        if (dtgetsupplylog1.Rows.Count > 0)
                        {
                            //to sum the 2 columns
                            for (var k = 0; k < dtgetsupplylog1.Rows.Count; k++)
                            {
                                temp = temp + Convert.ToDouble(dtgetsupplylog1.Rows[k]["amountsupplied"]);
                                temp1 = temp1 + Convert.ToDouble(dtgetsupplylog1.Rows[k]["profit"]);
                            }
                        }
                        totalsales = temp;
                        totalprofit = temp1;
                        txttotalsales.Text = totalsales.ToString();
                        txttotaprofit.Text = totalprofit.ToString();
                        txtcustomer.Text = dtgetsupplylog_dgv.Rows.Count.ToString();
                    }
                    else if ( DateTimePicker1.Value.Date.ToShortDateString() == DateTimePicker2.Value.Date.ToShortDateString() && cbocashier.Text != "Daily Supply")
                    {
                        dtgetsupplylog_dgv = obj.getdatabase("select staffname,supplyid,productid,itemsupplied,quantitysupplied," +
                     "unitsalesprice,amountsupplied,siv,entrydate from supplylog where  staffname='" + cbocashier.Text + "' And date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
                        dgvsaleslog.DataSource = dtgetsupplylog_dgv;
                        if (dtgetsupplylog.Rows.Count > 0)
                        {
                            c = dtgetsupplylog.Rows.Count;
                        }
                        txtcustomer.Text = c.ToString();
                        dtgetsupplylog1 = obj.getdatabase("select amountsupplied,profit from supplylog where staffname='" + cbocashier.Text + "' And date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
                        if (dtgetsupplylog1.Rows.Count > 0)
                        {
                            for (var k = 0; k < dtgetsupplylog1.Rows.Count; k++)
                            {
                                temp = temp + Convert.ToDouble(dtgetsupplylog1.Rows[k]["amountsupplied"]);
                                temp1 = temp1 + Convert.ToDouble(dtgetsupplylog1.Rows[k]["profit"]);
                            }
                            txtcustomer.Text = dtgetsupplylog_dgv.Rows.Count.ToString();
                        }
                        totalsales = temp;
                        totalprofit = temp1;
                        txttotalsales.Text = totalsales.ToString();
                        txttotaprofit.Text = totalprofit.ToString();
                    }
                    else if (DateTimePicker1.Value.Date.ToShortDateString() != DateTimePicker2.Value.Date.ToShortDateString() && cbocashier.Text != "Daily Supply")
                    {
                        DateTime stdate = Convert.ToDateTime(DateTimePicker1.Value.Date.ToShortDateString());
                        DateTime eddate = Convert.ToDateTime(DateTimePicker2.Value.Date.ToShortDateString());
                        dtgetsupplylog_dgv = obj.getdatabase("select staffname,supplyid,productid,itemsupplied,quantitysupplied," +
                     "unitsalesprice,amountsupplied,siv,entrydate from supplylog where date >='" + stdate + "' and date <='" + eddate + "'and  staffname='" + cbocashier.Text + "'");
                        if (dtgetsupplylog.Rows.Count > 0)
                        {
                            c = dtgetsupplylog.Rows.Count;
                        }
                        txtcustomer.Text = dtgetsupplylog_dgv.Rows.Count.ToString();
                        dgvsaleslog.DataSource = dtgetsupplylog_dgv;
                        dtgetsupplylog1 = obj.getdatabase("select amountsupplied,profit from supplylog where date >='" + stdate + "' and date <='" + eddate + "' and staffname='" + cbocashier.Text + "'");
                        if (dtgetsupplylog1.Rows.Count > 0)
                        {
                            for (var j = 0; j < dtgetsupplylog1.Rows.Count; j++)
                            {
                                temp = temp + Convert.ToDouble(dtgetsupplylog1.Rows[j]["amountsupplied"]);
                                temp1 = temp1 + Convert.ToDouble(dtgetsupplylog1.Rows[j]["profit"]);
                            }
                            txtcustomer.Text = dtgetsupplylog_dgv.Rows.Count.ToString();
                        }
                        totalsales = temp;
                        totalprofit = temp1;
                        txttotalsales.Text = totalsales.ToString();
                        txttotaprofit.Text = totalprofit.ToString();
                    }
                    else if (cbocashier.Text == "Daily Supply" && DateTimePicker1.Value.Date.ToShortDateString() == DateTimePicker2.Value.Date.ToShortDateString())
                    {
                        dtgetsupplylog_dgv = obj.getdatabase("select staffname,supplyid,productid,itemsupplied,quantitysupplied," +
                     "unitsalesprice,amountsupplied,siv,entrydate from supplylog where date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
                        dgvsaleslog.DataSource = dtgetsupplylog_dgv;
                        if (dtgetsupplylog_dgv.Rows.Count > 0)
                        {
                            c = dtgetsupplylog.Rows.Count;
                        }
                        txtcustomer.Text = dtgetsupplylog_dgv.Rows.Count.ToString();
                        dtgetsupplylog1 = obj.getdatabase("select amountsupplied,profit from supplylog where date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
                        if (dtgetsupplylog1.Rows.Count > 0)
                        {
                            for (var k = 0; k < dtgetsupplylog1.Rows.Count; k++)
                            {
                                temp = temp + Convert.ToDouble(dtgetsupplylog1.Rows[k]["amountsupplied"]);
                                temp1 = temp1 + Convert.ToDouble(dtgetsupplylog1.Rows[k]["profit"]);
                            }
                            txtcustomer.Text = dtgetsupplylog_dgv.Rows.Count.ToString();
                        }
                        totalsales = temp;
                        totalprofit = temp1;
                        txttotalsales.Text = totalsales.ToString();
                        txttotaprofit.Text = totalprofit.ToString();
                    }
                    else if (cbocashier.Text == "Daily Supply" && DateTimePicker1.Value.Date.ToShortDateString().ToString() != DateTimePicker2.Value.Date.ToShortDateString().ToString())
                    {
                        string stdate = DateTimePicker1.Value.Date.ToShortDateString();
                        string eddate = DateTimePicker2.Value.Date.ToShortDateString();
                        dtgetsupplylog_dgv = obj.getdatabase("select staffname,supplyid,productid,itemsupplied,quantitysupplied," +
                     "unitsalesprice,amountsupplied,siv,entrydate from supplylog where date >='" + stdate + "' and date <='" + eddate + "'");
                        if (dtgetsupplylog.Rows.Count > 0)
                        {
                            c = dtgetsupplylog.Rows.Count;
                        }
                        txtcustomer.Text = dtgetsupplylog_dgv.Rows.Count.ToString();
                        dgvsaleslog.DataSource = dtgetsupplylog_dgv;
                        dtgetsupplylog1 = obj.getdatabase("select amountsupplied,profit from supplylog where date >='" + stdate + "' and date <='" + eddate + "'");
                        if (dtgetsupplylog1.Rows.Count > 0)
                        {
                            for (var j = 0; j < dtgetsupplylog1.Rows.Count; j++)
                            {
                                temp = temp + Convert.ToDouble(dtgetsupplylog1.Rows[j]["amountsupplied"]);
                                temp1 = temp1 + Convert.ToDouble(dtgetsupplylog1.Rows[j]["profit"]);
                            }
                            c = dtgetsupplylog.Rows.Count;
                            txtcustomer.Text = dtgetsupplylog_dgv.Rows.Count.ToString();
                        }
                        totalsales = temp;
                        totalprofit = temp1;
                        txttotalsales.Text = totalsales.ToString();
                        txttotaprofit.Text = totalprofit.ToString();
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
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Records";

                try
                {
                    for (int i = 1; i < dgvsaleslog.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dgvsaleslog.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dgvsaleslog.Rows.Count - 0; i++)
                    {
                        for (int j = 0; j < dgvsaleslog.Columns.Count; j++)
                        {
                            if (dgvsaleslog.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = dgvsaleslog.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                worksheet.Cells[i + 2, j + 1] = "";
                            }
                        }
                    }

                    //Getting the location and file name of the excel to save from user. 
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveDialog.FilterIndex = 2;

                    if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Export Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    app.Quit();
                    workbook = null;
                    worksheet = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
