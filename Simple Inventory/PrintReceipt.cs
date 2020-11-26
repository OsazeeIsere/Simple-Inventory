using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using System.Drawing.Printing;
using MySql.Data.MySqlClient;

namespace Simple_Inventory
{
    public partial class PrintReceipt : Form
    {
        public PrintReceipt()
        {
            InitializeComponent();
        }
        GetDataBase obj = new GetDataBase();
        private void PrintReceipt_Load(object sender, EventArgs e)
        {
            try
            {
                if (txtrepeatreceipt.Text == "")
                {

                    DataTable dtidentity = new DataTable();
                    dtidentity = obj.getdatabase("Select * from identity");

                    txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                    txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                    txttel.Text = dtidentity.Rows[0]["telephone"].ToString();
                    System.Data.DataTable dtgetsales = new System.Data.DataTable();
                    dtgetsales = obj.getdatabase("Select * from supply order by itemsupplied");
                    if (dtgetsales.Rows.Count > 0)
                    {
                        ListViewItem lstitem = new ListViewItem();
                        lsvitems.Items.Clear();

                        for (var i = 0; i < dtgetsales.Rows.Count; i++)
                        {
                            lstitem = new ListViewItem();
                            lstitem.Text = dtgetsales.Rows[i]["itemsupplied"].ToString();
                            lstitem.SubItems.Add(dtgetsales.Rows[i]["quantitysupplied"].ToString());
                            lstitem.SubItems.Add(dtgetsales.Rows[i]["unitsalesprice"].ToString());
                            lstitem.SubItems.Add(dtgetsales.Rows[i]["amount"].ToString());
                            lsvitems.Items.Add(lstitem);
                        }
                    }
                    txtcashiername1.Text = txtcashiername1.Text;
                    string time1 = null;
                    time1 = DateTime.Now.ToShortTimeString();
                    txttime.Text = time1;
                    // insert Copyright symbol
                    lbcopywrite.Text = "Copyright 2020:  OZ Concepts(08163775990)"; //+ Microsoft.VisualBasic.Strings.Chr(169) + ;
                }
                else
                {
                    DataTable dtidentity = new DataTable();
                    dtidentity = obj.getdatabase("Select * from identity");
                    double temp = 0;
                    txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                    txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                    txttel.Text = dtidentity.Rows[0]["telephone"].ToString();
                    System.Data.DataTable dtgetsaleslog = new System.Data.DataTable();
                    dtgetsaleslog = obj.getdatabase("select * from supplylog where siv= '" + txtrepeatreceipt.Text + "' order by itemsupplied");
                    if (dtgetsaleslog.Rows.Count > 0)
                    {
                        ListViewItem lstitem = new ListViewItem();
                        lsvitems.Items.Clear();

                        for (var i = 0; i < dtgetsaleslog.Rows.Count; i++)
                        {
                            double unitprice = Convert.ToDouble(dtgetsaleslog.Rows[i]["amountsupplied"].ToString());
                            int quantity = Convert.ToInt16(dtgetsaleslog.Rows[i]["quantitysupplied"].ToString());
                            double unitcost = unitprice / quantity;
                            lstitem = new ListViewItem();
                            lstitem.Text = dtgetsaleslog.Rows[i]["itemsupplied"].ToString();
                            lstitem.SubItems.Add(dtgetsaleslog.Rows[i]["quantitysupplied"].ToString());
                            lstitem.SubItems.Add(unitcost.ToString());
                            lstitem.SubItems.Add(dtgetsaleslog.Rows[i]["amountsupplied"].ToString());
                            lsvitems.Items.Add(lstitem);
                            temp = temp + Convert.ToDouble(dtgetsaleslog.Rows[i]["amountsupplied"].ToString());
                        }
                        txttotal.Text = temp.ToString();
                        txtcash.Text = dtgetsaleslog.Rows[0]["cashpaid"].ToString();
                   //     txtdiscount1.Text = dtgetsaleslog.Rows[0]["discount"].ToString();
                        txtchange.Text = dtgetsaleslog.Rows[0]["changegiven"].ToString();
                        txtreceiptnumber.Text = txtrepeatreceipt.Text;
                        txtcashiername1.Text = dtgetsaleslog.Rows[0]["staffname"].ToString();
                        string time1 = null;
                        string datesold = null;
                        DateTime date = Convert.ToDateTime(dtgetsaleslog.Rows[0]["entrydate"].ToString());

                        time1 = date.ToShortTimeString();
                        datesold = date.ToLongDateString();
                        DateTimePicker1.Text = datesold;
                        txttime.Text = time1;
                        // insert Copyright symbol
                        //  lbcopywrite.Text = "Copyright " + Microsoft.VisualBasic.Strings.Chr(169) + "2020 OZ Concepts(08163775990)";
                        lbcopywrite.Text = "Copyright 2020:  OZ Concepts(08163775990)"; //+ Microsoft.VisualBasic.Strings.Chr(169) + ;

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                dtgetsales =obj. getdatabase("Select* from supply");
                string strconnection = "";
                strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;
                cn.Open();
                cm.CommandText = "Delete from supply where transactionid>0";
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                txttotal.Text = "";
                txtcash.Text = "";
                txtchange.Text = "";
                txtreceiptnumber.Text = "";
              //  txtdiscount1.Text = "";
                //sales x = new sales();
                //x.discount = 0;
                lsvitems.Clear();
                this.Close();
                MessageBox.Show("Well done! Just CLICK ON THE FORM to get update from the Database.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
