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
using Excel = Microsoft.Office.Interop.Excel;

namespace Simple_Inventory
{
    public partial class SectionA2_SupplyLog : Form
    {
        public SectionA2_SupplyLog()
        {
            InitializeComponent();
        }
        GetDataBase obj = new GetDataBase();

        private void SectionA2_SupplyLog_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtidentity = new DataTable();
                dtidentity = obj.getdatabase("Select * from identity");

                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                //            lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();
                // x = new supplylog();
                double totalsales = 0;
                double totalprofit = 0;
                System.Data.DataTable dtgetsupplylog = new System.Data.DataTable();
                System.Data.DataTable dtgetsupplylog_dgv = new System.Data.DataTable();

                dtgetsupplylog_dgv = obj.getdatabase("select staffname,supplyid,productid,itemsupplied,quantitysupplied," +
                    "unitsalesprice,amountsupplied,siv,entrydate from a2supplylog order by entrydate");
                dtgetsupplylog = obj.getdatabase("select * from a2supplylog order by entrydate");

                System.Data.DataTable dtgetsupplylog1 = new System.Data.DataTable();
                dtgetsupplylog1 = obj.getdatabase("select amountsupplied,profit from a2supplylog");
                double temp = 0;
                double temp1 = 0;
                int c = 0;
                System.Data.DataTable dtgetcashier = new System.Data.DataTable();
                System.Data.DataTable dtgetadmin = new System.Data.DataTable();
                dtgetadmin = obj.getdatabase("select * from administrator");
                dtgetsupplylog = obj.getdatabase("select * from a2supplylog order by date");
                dgvsaleslog.DataSource = dtgetsupplylog_dgv;
                // generate another table for necessary calculation

                dtgetsupplylog1 = obj.getdatabase("select amountsupplied,profit from a2supplylog");

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
           
        }

        private void Button1_Click_1(object sender, EventArgs e)
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
                     "unitsalesprice,amountsupplied,siv,entrydate from a2supplylog order by entrydate");


                if (cbocashier.Text == "All Supplies")
                {
                    SupplyLog x = new SupplyLog();
                    dtgetsupplylog_dgv = obj.getdatabase("select staffname,supplyid,productid,itemsupplied,quantitysupplied," +
                 "unitsalesprice,amountsupplied,siv,entrydate from a2supplylog order by entrydate");
                    dgvsaleslog.DataSource = dtgetsupplylog_dgv;
                    // generate another table for necessary calculation

                    dtgetsupplylog1 = obj.getdatabase("select amountsupplied,profit from a2supplylog");

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
                else if (DateTimePicker1.Value.Date.ToShortDateString() == DateTimePicker2.Value.Date.ToShortDateString() && cbocashier.Text != "Daily Supply")
                {
                    dtgetsupplylog_dgv = obj.getdatabase("select staffname,supplyid,productid,itemsupplied,quantitysupplied," +
                 "unitsalesprice,amountsupplied,siv,entrydate from a2supplylog where  staffname='" + cbocashier.Text + "' And date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
                    dgvsaleslog.DataSource = dtgetsupplylog_dgv;
                    if (dtgetsupplylog.Rows.Count > 0)
                    {
                        c = dtgetsupplylog.Rows.Count;
                    }
                    txtcustomer.Text = c.ToString();
                    dtgetsupplylog1 = obj.getdatabase("select amountsupplied,profit from a2supplylog where staffname='" + cbocashier.Text + "' And date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
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
                 "unitsalesprice,amountsupplied,siv,entrydate from a2supplylog where date >='" + stdate + "' and date <='" + eddate + "'and  staffname='" + cbocashier.Text + "'");
                    if (dtgetsupplylog.Rows.Count > 0)
                    {
                        c = dtgetsupplylog.Rows.Count;
                    }
                    txtcustomer.Text = dtgetsupplylog_dgv.Rows.Count.ToString();
                    dgvsaleslog.DataSource = dtgetsupplylog_dgv;
                    dtgetsupplylog1 = obj.getdatabase("select amountsupplied,profit from a2supplylog where date >='" + stdate + "' and date <='" + eddate + "' and staffname='" + cbocashier.Text + "'");
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
                 "unitsalesprice,amountsupplied,siv,entrydate from a2supplylog where date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
                    dgvsaleslog.DataSource = dtgetsupplylog_dgv;
                    if (dtgetsupplylog_dgv.Rows.Count > 0)
                    {
                        c = dtgetsupplylog.Rows.Count;
                    }
                    txtcustomer.Text = dtgetsupplylog_dgv.Rows.Count.ToString();
                    dtgetsupplylog1 = obj.getdatabase("select amountsupplied,profit from a2supplylog where date='" + DateTimePicker1.Value.Date.ToShortDateString() + "'");
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
                 "unitsalesprice,amountsupplied,siv,entrydate from a2supplylog where date >='" + stdate + "' and date <='" + eddate + "'");
                    if (dtgetsupplylog.Rows.Count > 0)
                    {
                        c = dtgetsupplylog.Rows.Count;
                    }
                    txtcustomer.Text = dtgetsupplylog_dgv.Rows.Count.ToString();
                    dgvsaleslog.DataSource = dtgetsupplylog_dgv;
                    dtgetsupplylog1 = obj.getdatabase("select amountsupplied,profit from a2supplylog where date >='" + stdate + "' and date <='" + eddate + "'");
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
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


        private void exportDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn;
            string connectionString = null;
            string sql = null;
            string data = null;
            string column = null;
            int i = 0;
            int j = 0;
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            connectionString = "Server=localhost;Port=3306;Database=edp;Uid=root;Pwd=prayer";
            cnn = new MySqlConnection(connectionString);
            cnn.Open();
            sql = "SELECT * FROM a2supplylog";
            MySqlDataAdapter dscmd = new MySqlDataAdapter(sql, cnn);
            DataTable ds = new DataTable();
            dscmd.Fill(ds);
            // DataColumn dc = new DataColumn();
            xlWorkSheet.Cells[1, 1] = "Products DataBase As At " + DateTimePicker1.Value.ToLongDateString();

            for (j = 0; j <= ds.Columns.Count - 1; j++)
            {
                // data = ds.Rows[i].ItemArray[j].ToString();
                column = ds.Columns[j].ColumnName.ToString();

                xlWorkSheet.Cells[2, j + 1] = column;
            }
            for (i = 0; i <= ds.Rows.Count - 1; i++)
            {
                for (j = 0; j <= ds.Columns.Count - 1; j++)
                {
                    data = ds.Rows[i].ItemArray[j].ToString();
                    xlWorkSheet.Cells[i + 3, j + 1] = data;
                }
            }
            // workbook = APP.Workbooks.Open(txtfile.Text);
            saveFileDialog1.ShowDialog();
            xlWorkBook.SaveAs(txtfile1.Text, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file c:\\" + txtfile1.Text);

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            txtfile1.Text = saveFileDialog1.FileName + ".xls";

        }
    }
}
