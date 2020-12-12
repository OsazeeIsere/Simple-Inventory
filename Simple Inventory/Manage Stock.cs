using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using MySql.Data.MySqlClient;
using xlapp = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace Simple_Inventory
{
    public partial class Manage_Stock : Form
    {
        public Manage_Stock()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        utility u = new utility();
        GetDataBase x = new GetDataBase();
        System.Data.DataTable dtgetproduct = new System.Data.DataTable();
        System.Data.DataTable dtgetproduct1 = new System.Data.DataTable();
        MySqlConnection cn = new MySqlConnection();
        MySqlDataAdapter ad = new MySqlDataAdapter();
        MySqlCommand cm = new MySqlCommand();
        string strconnection = "";
        int intproductid = 0;
        public double discount;

        private void Manage_Stock_Load(object sender, EventArgs e)
        {
            try
            {
                //inside form load event
                //send the width and height of the screen you designed the form for
                //hp elitebook resolution 1600x900 Dimensions1 (w x d x h) (at front)
                //  33.8 x 23.1 x 3.4 cm(13.31 x 9.11 x 1.34 in)
                // size from online method: 788,1280
                //u.fitFormToScreen(this, 1600, 900);
                //this.CenterToScreen();
                DataTable dtidentity = new DataTable();
                dtidentity =x. getdatabase("Select * from identity");
                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                //       lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();
               System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                dtgetproduct =x. getdatabase("Select * from product");
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
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                      //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                        lsvitems.Items.Add(lstitem);
                    }
                    txttotal.Text = dtgetproduct.Rows.Count.ToString();
                  
                }
              //  txtcode.Focus();


            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());

            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            expiryDateInfo x = new expiryDateInfo();
            x.Show();
        }

        private void txtitems_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                string strconnection = "";
                int intproductid = 0;
                strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
                intproductid = Convert.ToInt32(lsvitems.SelectedItems[0].Text);
                dtgetproduct =obj. getdatabase("Select * From product where productid=" + intproductid);
                //dtgetexpirydate = getdatabase("Select * From expirydate where productid=" & intproductid)
                cn.Open();
                Delete x = new Delete();
                x.txtproductid.Text = intproductid.ToString();
                x.txtproductname.Text = (dtgetproduct.Rows[0]["productname"]).ToString();
                x.txtstaffname.Text = txtstaffname1.Text;
                x.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ReorderLevel x = new ReorderLevel();
            x.Show();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void txtproductname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void tabRequisition_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtquantity.Text))
                {
                    MessageBox.Show("Please enter the Quantity of Product Purchased");
                }
                else if (string.IsNullOrEmpty(txtexpirydate.Text))
                {
                    MessageBox.Show("Please enter the Expiry Date of the Product Purchased as (MM/DD/YYY)");
                }
                else if (cbsection.Text== "Please, Select The Section.")
                {
                    MessageBox.Show("Please Select the Section of the Product Purchased");
                }
               
                //else if (string.IsNullOrEmpty(txtbatch.Text))
                //{
                //    MessageBox.Show("Please enter the Batch of the Product Purchased");
                //}
                else if (string.IsNullOrEmpty(txtsuppliername.Text))
                {
                    MessageBox.Show("Please enter the  Name of The Supplier");
                }
                else if (string.IsNullOrEmpty(txtdatepurchased.Text))
                {
                    MessageBox.Show("Please enter the  Date the Product is Purchased");
                }

                else if (string.IsNullOrEmpty(txtunitprice.Text))
                {
                    MessageBox.Show("Please enter the Unit Sales Price of Product Purchased");

                }
                else if (string.IsNullOrEmpty(txtCostPrice.Text))
                {
                    MessageBox.Show("Please enter the Amount Paid for The Product Purchased");
                }

                else if (string.IsNullOrEmpty(txtUnitRate.Text))
                {
                    MessageBox.Show("Please enter the Unit Rate of The Product Purchased");
                }
                else
                {
                    //Dim intpersonid = CInt(studentinfo.dgvnames.SelectedCells(0).Value)
                    DataTable dtgetproduct2 = new DataTable();
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Insert Into preentry(productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,batch,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber,staffname) Values('" + txtproductname.Text + "','" + txtquantity.Text + "','" + cbsection.Text + "','" + txtUnitPack.Text + "','" + txtCostPrice.Text + "','" + txtUnitRate.Text + "','" + txtunitprice.Text + "','" + txtbatch.Text + "','" + txtdatepurchased.Text + "','" + txtexpirydate.Text + "','" + txtcode.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtinvoicenumber.Text + "', '" + txtstaffname1.Text + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Thanks You, The Item Don Join List Of New Products");
                    txtproductname.Text = "";
                    txtquantity.Text = "";
                    txtunitprice.Text = "";
                    cbsection.Text = "Please, Select The Section.";
                    txtexpirydate.Text = "";
                    txtsuppliername.Text = "";
                    txtdatepurchased.Text = "";
                    txtUnitPack.Text = "";
                    txtbatch.Text = "";
                    txtUnitRate.Text = "";
                    txtCostPrice.Text = "";
                    txtinvoicenumber.Text = "";


                    txtsupplierphonenumber.Text = "";
                    txtcode.Text = "";
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            txtcode.Focus();
        }

        private void txtunitprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtquantity1.Text))
                {
                    MessageBox.Show("Please enter the Quantity of Product Purchased");
                }
                else if (string.IsNullOrEmpty(txtexpirydate1.Text))
                {
                    MessageBox.Show("Please enter the Expiry Date of the Product Purchased as (MM/DD/YYY)");
                }
                else if (txtsection1.Text == "Please, Select The Section.")
                {
                    MessageBox.Show("Please Select the Section of the Product Purchased");
                }

                else if (string.IsNullOrEmpty(txtsuppliername1.Text))
                {
                    MessageBox.Show("Please enter the Name of the Supplier");
                }

                else if (string.IsNullOrEmpty(txtdatepurchased1.Text))
                {
                    MessageBox.Show("Please enter the  Date the Product is Purchased");
                }

                else if (string.IsNullOrEmpty(txtunitsalesprice.Text))
                {
                    MessageBox.Show("Please enter the Unit Sales Price of Product Purchased");

                }
                else if (string.IsNullOrEmpty(txtcostprice1.Text))
                {
                    MessageBox.Show("Please enter the Amount Paid for The Product Purchased");
                }

                else if (string.IsNullOrEmpty(txtunitrate1.Text))
                {
                    MessageBox.Show("Please enter the Unit Rate of The Product Purchased");
                }
                else
                {
                    //Dim intpersonid = CInt(studentinfo.dgvnames.SelectedCells(0).Value)
                    DataTable dtgetproduct2 = new DataTable();
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Insert Into preupdate(productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,batch,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber,staffname) Values('" + txtproductname1.Text + "','" + txtquantity1.Text + "','" + txtsection1.Text + "','" + txtunitpack1.Text + "','" + txtcostprice1.Text + "','" + txtunitrate1.Text + "','" + txtunitsalesprice.Text + "','" + txtbatch1.Text + "','" + txtdatepurchased1.Text + "','" + txtexpirydate1.Text + "','" + txtcode1.Text + "','" + txtsuppliername1.Text + "','" + txtsupplierphonenumber1.Text + "','" + txtinvoice1.Text + "','" + txtstaffname1.Text + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Thanks You, The Item Don Join List Wey We Want Update");
                    txtproductname.Text = "";
                    txtquantity.Text = "";
                    txtunitprice.Text = "";
                    cbsection.Text = "";
                    txtexpirydate.Text = "";
                    txtsuppliername.Text = "";
                    txtdatepurchased.Text = "";
                    txtUnitPack.Text = "";
                    txtbatch.Text = "";
                    txtUnitRate.Text = "";


                    txtsupplierphonenumber.Text = "";
                    txtcode.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void StockTab_TabIndexChanged(object sender, EventArgs e)
        {
            int ind = Convert.ToInt16(e);
            if (StockTab.SelectedTab == updateStockTab)
            {
                try
                {
                    //       lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

                    System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                    dtgetproduct = x.getdatabase("Select * from product");
                    if (dtgetproduct.Rows.Count > 0)
                    {
                        ListViewItem lstitem = new ListViewItem();
                        listView1.Items.Clear();
                        listView1.Items.Clear();
                        for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                        {
                            lstitem = new ListViewItem();
                            lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                            //           lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["costperunitrate"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            listView1.Items.Add(lstitem);
                        }
                        txttotal.Text = dtgetproduct.Rows.Count.ToString();

                    }
                    txtcode1.Focus();


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());

                }
            }
        }

        private void StockTab_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                dtgetproduct = x.getdatabase("Select * from product");
                if (dtgetproduct.Rows.Count > 0)
                {
                    if (StockTab.SelectedTab == updateStockTab)
                    {
                        //       lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();


                        ListViewItem lstitem = new ListViewItem();
                        listView1.Items.Clear();
                        for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                        {
                            lstitem = new ListViewItem();
                            lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                            //           lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            listView1.Items.Add(lstitem);
                        }
                        txtstock1.Text = dtgetproduct.Rows.Count.ToString();
                        txtcode1.Focus();
                    }
                    else if (StockTab.SelectedTab == NewStockTab)
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
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                            //           lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvitems.Items.Add(lstitem);
                        }
                        txttotal.Text = dtgetproduct.Rows.Count.ToString();
                        txtcode.Focus();

                    }
                    else if (StockTab.SelectedTab == A1supplyTab)
                    {
                        dtgetproduct = x.getdatabase("Select * from product WHERE section = 'A1'");

                        ListViewItem lstitem = new ListViewItem();
                        listView2.Items.Clear();
                        for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                        {
                            lstitem = new ListViewItem();
                            lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                            //           lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            listView2.Items.Add(lstitem);
                        }
                        txttotal.Text = dtgetproduct.Rows.Count.ToString();
                        txtquantity2.Text = "1";
                        txtcode2.Focus();
                        txttimeA1.Text = DateTimePicker1.Value.ToShortTimeString();
                    }
                    else if (StockTab.SelectedTab == A2supplyTab)
                    {
                        dtgetproduct = x.getdatabase("Select * from product WHERE section = 'A2'");
                        ListViewItem lstitem = new ListViewItem();
                        lsvA2.Items.Clear();
                        for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                        {
                            lstitem = new ListViewItem();
                            lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                            //           lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvA2.Items.Add(lstitem);
                        }
                        txttotal.Text = dtgetproduct.Rows.Count.ToString();
                        txtquantityA2.Text = "1";
                        txtbarcodeA2.Focus();
                        txttimeA2.Text = dateTimePicker2.Value.ToShortTimeString();

                    }
                    else if (StockTab.SelectedTab == A3supplyTab)
                    {
                        dtgetproduct = x.getdatabase("Select * from product WHERE section = 'A3'");

                        ListViewItem lstitem = new ListViewItem();
                        lsvA3.Items.Clear();
                        for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                        {
                            lstitem = new ListViewItem();
                            lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                            //           lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvA3.Items.Add(lstitem);
                        }
                        txttotal.Text = dtgetproduct.Rows.Count.ToString();
                        txtquantityA3.Text = "1";
                        txtbarcodeA3.Focus();
                        txttimeA3.Text = dateTimePicker5.Value.ToShortTimeString();

                    }
                    else if (StockTab.SelectedTab == DsupplyTab)
                    {
                        dtgetproduct = x.getdatabase("Select * from product WHERE section = 'D'");

                        ListViewItem lstitem = new ListViewItem();
                        lsvD.Items.Clear();
                        for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                        {
                            lstitem = new ListViewItem();
                            lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                            //           lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvD.Items.Add(lstitem);
                        }
                        txttotal.Text = dtgetproduct.Rows.Count.ToString();
                        txtquantityD.Text = "1";
                        txttimeD.Text = dateTimePicker6.Value.ToShortTimeString();

                        txtbarcodeD.Focus();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
			{
				MySqlConnection cn = new MySqlConnection();
				MySqlDataAdapter ad = new MySqlDataAdapter();
				MySqlCommand cm = new MySqlCommand();
				System.Data.DataTable dtgetsales = new System.Data.DataTable();
				System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
                if (Simulate.IsNumeric(Convert.ToInt32(listView1.SelectedItems[0].Text)))
                {
                    intproductid = Convert.ToInt32(listView1.SelectedItems[0].Text);
					//Dim dblunitsalesprice = CDbl(dgvsales.SelectedCells(0).Value)
					dtgetsales = x.getdatabase(" select * from product where productid=" + intproductid);
					txtproductid.Text = Convert.ToDouble(dtgetsales.Rows[0]["productid"]).ToString();
					txtproductname1.Text = Convert.ToString(dtgetsales.Rows[0]["productname"]);
					txtquantity1.Text = Convert.ToString(dtgetsales.Rows[0]["quantity"]);
                    txtsection1.Text = Convert.ToString(dtgetsales.Rows[0]["section"]);
                    txtunitpack1.Text = Convert.ToString(dtgetsales.Rows[0]["unitpack"]);

                    //txtamountpaid.Text = CStr(dtgetexpirydate.Rows(0).Item("amountpaid"))
                    txtcostprice1.Text = Convert.ToString(dtgetsales.Rows[0]["costprice"]);
					txtunitsalesprice.Text = Convert.ToString(dtgetsales.Rows[0]["unitsalesprice"]);
					txtexpirydate1.Text = (dtgetsales.Rows[0]["expirydate"]).ToString();
					//txtsuppliername.Text = CStr(dtgetexpirydate.Rows(0).Item("suppliername"))
					//txtsupplierphonenumber.Text = CStr(dtgetexpirydate.Rows(0).Item("supplierphonenumber"))
					//txtdatepurchased.Text = CStr(dtgetexpirydate.Rows(0).Item("datepurchased"))
					//txtinvoicenumber .Text = CStr(dtgetexpirydate .Rows(0).Item(""))
					intproductid = Convert.ToInt32(txtproductid.Text);
				}
				else
				{
					MessageBox.Show("Please Select The ProductID");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                string strconnection = "";
                int intproductid = 0;
                strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
                intproductid = Convert.ToInt32(listView1.SelectedItems[0].Text);
                dtgetproduct = obj.getdatabase("Select * From product where productid=" + intproductid);
                //dtgetexpirydate = getdatabase("Select * From expirydate where productid=" & intproductid)
                cn.Open();
                Delete x = new Delete();
                x.txtproductid.Text = intproductid.ToString();
                x.txtproductname.Text = (dtgetproduct.Rows[0]["productname"]).ToString();
                x.txtstaffname.Text = txtstaffname1.Text;
                x.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsupply = new System.Data.DataTable();
                double amount = 0;
                string strconnection = "";
                if (string.IsNullOrEmpty(txtquantity2.Text))
                {
                    MessageBox.Show("Please Type The Quantity of Item To Be Supplied");
                }

                else if (Simulate.IsNumeric(txtquantity2.Text))
                {
                    if (txtproductid2.Text != "")
                    {
                        intproductid = Convert.ToInt32(listView2.SelectedItems[0].Text);




                        dtgetsupply = x.getdatabase(" select * from product where productid=" + intproductid);
                        double v = 0;
                        v = Convert.ToDouble(dtgetsupply.Rows[0]["unitsalesprice"]);
                        amount = v * Convert.ToInt32(txtquantity2.Text);
                        strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                        cn.ConnectionString = strconnection;
                        cn.Open();
                        cm.CommandText = "Insert Into supply(staffname,itemsupplied,quantitysupplied,productid,section,unitpack,costprice,unitrate,unitsalesprice,amount,batch,srv,expirydate,barcode) Values('" + txtstaffname1.Text +"','" + txtproductname2.Text + "','" + txtquantity2.Text + "','" + txtproductid2.Text +"','" + dtgetsupply.Rows[0]["section"] + "','" + dtgetsupply.Rows[0]["unitpack"] + "','" + dtgetsupply.Rows[0]["costprice"] + "','" + dtgetsupply.Rows[0]["unitrate"] + "','" + dtgetsupply.Rows[0]["unitsalesprice"] + "','" + amount + "','" + dtgetsupply.Rows[0]["batch"] + "','" + dtgetsupply.Rows[0]["srv"] + "','" + dtgetsupply.Rows[0]["expirydate"] + "','" + dtgetsupply.Rows[0]["barcode"] + "')";
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        cn.Close();
                        SalesAlert pop = new SalesAlert();
                        pop.ShowDialog();



                        //Define the waitSomeTime method for display time and then disappear without interrupting the main thread

                        // MessageBox.Show. ("Successfully Added To Cart");

                        txtcode2.Text = "";
                        txtproductid2.Text = "";
                    }
                    else if (txtcode2.Text != "")
                    {
                        dtgetsupply = x.getdatabase(" select * from product where barcode=" + txtcode2.Text);
                        double v = 0;
                        //expirydate = Convert.ToDateTime(expirydate).ToShortDateString();

                        v = Convert.ToDouble(dtgetsupply.Rows[0]["unitsalesprice"]);
                        amount = v * Convert.ToInt32(txtquantity2.Text);
                        strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                        cn.ConnectionString = strconnection;
                        cn.Open();
                        cm.CommandText = "Insert Into supply(staffname,itemsupplied,quantitysupplied,productid,section,unitpack,costprice,unitrate,unitsalesprice,amount,batch,srv,expirydate,barcode) Values('" + txtstaffname1.Text + "','" + dtgetsupply.Rows[0]["productname"] + "','" + txtquantity2.Text + "','" + dtgetsupply.Rows[0]["productid"] + "','" + dtgetsupply.Rows[0]["section"] + "','" + dtgetsupply.Rows[0]["unitpack"] + "','" + dtgetsupply.Rows[0]["costprice"] + "','" + dtgetsupply.Rows[0]["unitrate"] + "','" + dtgetsupply.Rows[0]["unitsalesprice"] + "','" + amount + "','" + dtgetsupply.Rows[0]["batch"] + "','" + dtgetsupply.Rows[0]["srv"] + "','" + dtgetsupply.Rows[0]["expirydate"] + "','" + txtcode2.Text + "')";
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        cn.Close();
                        SalesAlert pop = new SalesAlert();
                        pop.ShowDialog();
                        txtcode2.Text = "";
                        txtproductid2.Text = "";
                        txtproductname.Text = dtgetsupply.Rows[0]["productname"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Please, If you want to Prepare Supply, snap product's barcode or select product from list");
                    }
                }
                else
                {
                    MessageBox.Show("please Enter a Number");
                }
               

                txtquantity2.Text = 1.ToString();
                txtcode2.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
                if (Simulate.IsNumeric(Convert.ToInt32(listView2.SelectedItems[0].Text)))
                {
                    intproductid = Convert.ToInt32(listView2.SelectedItems[0].Text);
                    //Dim dblunitsalesprice = CDbl(dgvsales.SelectedCells(0).Value)
                    dtgetsales = x.getdatabase(" select * from product where productid=" + intproductid);
                    txtproductid2.Text = Convert.ToDouble(dtgetsales.Rows[0]["productid"]).ToString();
                    txtproductname2.Text = Convert.ToString(dtgetsales.Rows[0]["productname"]);
                    
                 intproductid = Convert.ToInt32(txtproductid2.Text);
                }
                else
                {
                    MessageBox.Show("Please Select The ProductID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listView2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                string strconnection = "";
                System.Data.DataTable dtgetreceipt = new System.Data.DataTable();
                double totalamount = 0;
                dtgetsales = x.getdatabase("select amount,section from supply");
                double temp = 0;
                if (dtgetsales.Rows.Count > 0)
                {
                    for (var i = 0; i < dtgetsales.Rows.Count; i++)
                    {
                        temp = temp + Convert.ToDouble(dtgetsales.Rows[i]["amount"]);
                    }
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Insert Into receipt() values()";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    totalamount = temp;
                    dtgetreceipt = x. getdatabase("select * from receipt");
               

                    ViewSupply obj = new ViewSupply();
                    if (dtgetreceipt.Rows.Count > 0)
                    {
                       obj. txtreceiptnumber.Text ="SIVA1- "+ dtgetreceipt.Rows.Count.ToString();
                    }
                    obj.txtstaffname1.Text = txtstaffname1.Text;
                    obj.txtsection.Text= dtgetsales.Rows[0]["section"].ToString();
                    obj.txtgrandtotal.Text = totalamount.ToString();
                    obj.Show();
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

        private void btncode_Click(object sender, EventArgs e)
        {

        }
        GetDataBase obj = new GetDataBase();
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                int intitems = 0;
                if (!string.IsNullOrEmpty(txtitems.Text))
                {
                    if (Simulate.IsNumeric(txtitems.Text))
                    {
                        intitems = Convert.ToInt32(txtitems.Text);
                        xlapp.Application APP = new xlapp.Application();
                        xlapp.Worksheet worksheet = null;
                        xlapp.Workbook workbook = null;
                        openFileDialog1.ShowDialog();
                        workbook = APP.Workbooks.Open(txtfile.Text);
                        worksheet = (xlapp.Worksheet)workbook.Worksheets["sheet1"];
                        int intproductid = 0;
                        string strproductname = "";
                        int intquantity = 0;
                        double dblcost = 0;
                        double unitrate = 0;
                        double dblcostprice = 0;

                        double dblprice = 0;
                        string expirydate, barcode,section,unitpack;
                        for (var i = 2; i < 2 + intitems; i++)
                        {
                            intproductid = 0;
                            if (!((worksheet.Cells[i, 1].Value == null)))
                            {
                                if (!string.IsNullOrEmpty(worksheet.Cells[i, 1].Value.ToString()))
                                {
                                    if (Simulate.IsNumeric(worksheet.Cells[i, 1].Value.ToString()))
                                    {
                                        intproductid = Convert.ToInt32(worksheet.Cells[i, 1].Value);
                                    }
                                }
                            }
                            strproductname = worksheet.Cells[i, 2].Value;
                            intquantity = Convert.ToInt32(worksheet.Cells[i, 3].Value);
                            section = Convert.ToString(worksheet.Cells[i, 4].Value);
                            unitpack = Convert.ToString(worksheet.Cells[i, 5].Value);
                            dblcostprice = Convert.ToDouble(worksheet.Cells[i, 6].Value);


                            dblcost = Convert.ToDouble(worksheet.Cells[i, 7].Value);

                         //   costperunitrate = Convert.ToDouble(worksheet.Cells[i, 7].Value);

                            dblprice = Convert.ToDouble(worksheet.Cells[i, 8].Value);
                            expirydate = Convert.ToString(worksheet.Cells[i, 9].Value);
                            expirydate = Convert.ToDateTime(expirydate).ToShortDateString();
                            barcode = Convert.ToString(worksheet.Cells[i, 10].Value);
                            if (intproductid > 0)
                            {
                                //MySqlConnection cn = new MySqlConnection();
                                //MySqlDataAdapter ad = new MySqlDataAdapter();
                                //MySqlCommand cm = new MySqlCommand();
                                //string strconnection = "";
                                //strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                //cn.ConnectionString = strconnection;
                                //int newquantity = 0;
                                //dtgetproduct = obj.getdatabase("Select * From product where productid=" + intproductid);
                                //cn.Open();
                                //newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) + Convert.ToInt32(intquantity);
                                //cm.CommandText = "Update product Set quantity =" + newquantity + ",unitcostprice=" + dblcost + ",unitsalesprice=" + dblprice + ",expirydate='" + expirydate + "',barcode='" + barcode + "' Where productid=" + intproductid + ";";
                                //cm.Connection = cn;
                                //cm.ExecuteNonQuery();
                                //cn.Close();
                                //dtgetproduct = obj. getdatabase("Select * from product");
                                //if (dtgetproduct.Rows.Count > 0)
                                //{
                                //    ListViewItem lstitem = new ListViewItem();
                                //    lsvitems.Items.Clear();
                                //    listView1.Items.Clear();
                                //    for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                                //    {
                                //        lstitem = new ListViewItem();
                                //        lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                                //        lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                                //        lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                                //        lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                                //        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                                //        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                                //        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                                //        //           lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                                //        lstitem.SubItems.Add(dtgetproduct.Rows[j]["costperunitrate"].ToString());

                                //        lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                                //        lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                                //        //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                                //        lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                                //        lsvitems.Items.Add(lstitem);
                                //    }
                                //}
                                //txttotal.Text = dtgetproduct.Rows.Count.ToString();
                            }
                            else
                            {
                                MySqlConnection cn = new MySqlConnection();
                                MySqlDataAdapter ad = new MySqlDataAdapter();
                                MySqlCommand cm = new MySqlCommand();
                                //Dim intpersonid = CInt(studentinfo.dgvnames.SelectedCells(0).Value)
                                string strconnection = "";
                                strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                                cn.ConnectionString = strconnection;
                                cn.Open();
                                cm.CommandText = "Insert Into product(productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,expirydate,barcode) Values('" + strproductname + "'," + intquantity + ",'" + section + "','" + unitpack + "'," + dblcostprice + "," + dblcost + "," + dblprice + ",'" + expirydate + "','" + barcode + "')";
                                cm.Connection = cn;
                                cm.ExecuteNonQuery();
                                cn.Close();

                                cn.ConnectionString = strconnection;
                                cn.Open();
                                cm.CommandText = "Insert Into expirydate(productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,expirydate,barcode) Values('" + strproductname + "'," + intquantity + ",'" + section + "','" + unitpack + "'," + dblcostprice + "," + dblcost + "," + dblprice + ",'" + expirydate + "','" + barcode + "')";
                                cm.Connection = cn;
                                cm.ExecuteNonQuery();
                                cn.Close();

                                //computeresult(intpersonid, CDbl(txtscore.Text), cbosubject.Text)
                                dtgetproduct = obj.getdatabase("Select * from product");
                                if (dtgetproduct.Rows.Count > 0)
                                {
                                    ListViewItem lstitem = new ListViewItem();
                                    lsvitems.Items.Clear();
                                    listView1.Items.Clear();
                                    for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                                    {
                                        lstitem = new ListViewItem();
                                        lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());
                                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                                        //           lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                                        //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                                        lsvitems.Items.Add(lstitem);
                                    }
                                }
                            }
                            txttotal.Text = dtgetproduct.Rows.Count.ToString();
                        }
                        MessageBox.Show(intitems + " Records Entered Successfully");
                        workbook.Save();
                        workbook.Close(System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                        APP.Quit();
                        txtfile.Text = "";
                        txtitems.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("please enter a Value");
                        txtitems.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("please enter the TOTAL number of items to be UPLOADED");
                    txtitems.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            txtfile.Text = openFileDialog1.FileName;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            SectionA1Report x = new SectionA1Report();
          //  x.txtadmin.Text = txtstaffname1.Text;
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SupplyLog x = new SupplyLog();
            x.txtadmin.Text = txtstaffname1.Text;
            x.Show();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SupplyLog x = new SupplyLog();
            x.txtadmin.Text = txtstaffname1.Text;
            x.Show();

        }

        private void txtseachdrugs_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                dtgetproduct =obj. getdatabase("Select * From product Where productname Like '%" + txtseachdrugs.Text + "%' And section= 'A1' Order By productname;");
                if (dtgetproduct.Rows.Count > 0)
                {
                    ListViewItem lstitem = new ListViewItem();
                    listView2.Items.Clear();
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
                            listView2.Items.Add(lstitem);
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
                            listView2.Items.Add(lstitem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                dtgetproduct = obj.getdatabase("Select * From product Where productname Like '%" + txtsearch1.Text + "%' Order By productname;");
                if (dtgetproduct.Rows.Count > 0)
                {
                    ListViewItem lstitem = new ListViewItem();
                    listView1.Items.Clear();
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
                            listView1.Items.Add(lstitem);
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
                            listView1.Items.Add(lstitem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtcode2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            expiryDateInfo x = new expiryDateInfo();
            x.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            expiryDateInfo x = new expiryDateInfo();
            x.Show();
        }

        private void A1supplyTab_Click(object sender, EventArgs e)
        {

        }

        private void lsvA2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
                if (Simulate.IsNumeric(Convert.ToInt32(lsvA2.SelectedItems[0].Text)))
                {
                    intproductid = Convert.ToInt32(lsvA2.SelectedItems[0].Text);
                    //Dim dblunitsalesprice = CDbl(dgvsales.SelectedCells(0).Value)
                    dtgetsales = x.getdatabase(" select * from product where productid=" + intproductid);
                    txtproductidA2.Text = Convert.ToDouble(dtgetsales.Rows[0]["productid"]).ToString();
                    txtproductnameA2.Text = Convert.ToString(dtgetsales.Rows[0]["productname"]);

                    intproductid = Convert.ToInt32(txtproductidA2.Text);
                }
                else
                {
                    MessageBox.Show("Please Select The ProductID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void lsvA3_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
                if (Simulate.IsNumeric(Convert.ToInt32(lsvA3.SelectedItems[0].Text)))
                {
                    intproductid = Convert.ToInt32(lsvA3.SelectedItems[0].Text);
                    //Dim dblunitsalesprice = CDbl(dgvsales.SelectedCells(0).Value)
                    dtgetsales = x.getdatabase(" select * from product where productid=" + intproductid);
                    txtproductidA3.Text = Convert.ToDouble(dtgetsales.Rows[0]["productid"]).ToString();
                    txtproductnameA3.Text = Convert.ToString(dtgetsales.Rows[0]["productname"]);

                    intproductid = Convert.ToInt32(txtproductidA3.Text);
                }
                else
                {
                    MessageBox.Show("Please Select The ProductID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void lsvD_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
                if (Simulate.IsNumeric(Convert.ToInt32(lsvD.SelectedItems[0].Text)))
                {
                    intproductid = Convert.ToInt32(lsvD.SelectedItems[0].Text);
                    //Dim dblunitsalesprice = CDbl(dgvsales.SelectedCells(0).Value)
                    dtgetsales = x.getdatabase(" select * from product where productid=" + intproductid);
                    txtproductidD.Text = Convert.ToDouble(dtgetsales.Rows[0]["productid"]).ToString();
                    txtproductnameD.Text = Convert.ToString(dtgetsales.Rows[0]["productname"]);

                    intproductid = Convert.ToInt32(txtproductidD.Text);
                }
                else
                {
                    MessageBox.Show("Please Select The ProductID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsupply = new System.Data.DataTable();
                double amount = 0;
                string strconnection = "";
                if (string.IsNullOrEmpty(txtquantityA2.Text))
                {
                    MessageBox.Show("Please Type The Quantity of Item To Be Supplied");
                }

                else if (Simulate.IsNumeric(txtquantityA2.Text))
                {
                    if (txtproductidA2.Text != "")
                    {
                        intproductid = Convert.ToInt32(lsvA2.SelectedItems[0].Text);




                        dtgetsupply = x.getdatabase(" select * from product where productid=" + intproductid);
                        double v = 0;
                        v = Convert.ToDouble(dtgetsupply.Rows[0]["unitsalesprice"]);
                        amount = v * Convert.ToInt32(txtquantityA2.Text);
                        strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                        cn.ConnectionString = strconnection;
                        cn.Open();
                        cm.CommandText = "Insert Into supply(staffname,itemsupplied,quantitysupplied,productid,section,unitpack,costprice,unitrate,unitsalesprice,amount,batch,srv,expirydate,barcode) Values('" + txtstaffname1.Text + "','" + txtproductnameA2.Text + "','" + txtquantityA2.Text + "','" + txtproductidA2.Text + "','" + dtgetsupply.Rows[0]["section"] + "','" + dtgetsupply.Rows[0]["unitpack"] + "','" + dtgetsupply.Rows[0]["costprice"] + "','" + dtgetsupply.Rows[0]["unitrate"] + "','" + dtgetsupply.Rows[0]["unitsalesprice"] + "','" + amount + "','" + dtgetsupply.Rows[0]["batch"] + "','" + dtgetsupply.Rows[0]["srv"] + "','" + dtgetsupply.Rows[0]["expirydate"] + "','" + dtgetsupply.Rows[0]["barcode"] + "')";
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        cn.Close();
                        SalesAlert pop = new SalesAlert();
                        pop.ShowDialog();



                        //Define the waitSomeTime method for display time and then disappear without interrupting the main thread

                        // MessageBox.Show. ("Successfully Added To Cart");

                        txtbarcodeA2.Text = "";
                        txtproductidA2.Text = "";
                    }
                    else if (txtbarcodeA2.Text != "")
                    {
                        dtgetsupply = x.getdatabase(" select * from product where barcode=" + txtbarcodeA2.Text);
                        double v = 0;
                        //expirydate = Convert.ToDateTime(expirydate).ToShortDateString();

                        v = Convert.ToDouble(dtgetsupply.Rows[0]["unitsalesprice"]);
                        amount = v * Convert.ToInt32(txtquantityA2.Text);
                        strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                        cn.ConnectionString = strconnection;
                        cn.Open();
                        cm.CommandText = "Insert Into supply(staffname,itemsupplied,quantitysupplied,productid,section,unitpack,costprice,unitrate,unitsalesprice,amount,batch,srv,expirydate,barcode) Values('" + txtstaffname1.Text + "','" + dtgetsupply.Rows[0]["productname"] + "','" + txtquantityA2.Text + "','" + dtgetsupply.Rows[0]["productid"] + "','" + dtgetsupply.Rows[0]["section"] + "','" + dtgetsupply.Rows[0]["unitpack"] + "','" + dtgetsupply.Rows[0]["costprice"] + "','" + dtgetsupply.Rows[0]["unitrate"] + "','" + dtgetsupply.Rows[0]["unitsalesprice"] + "','" + amount + "','" + dtgetsupply.Rows[0]["batch"] + "','" + dtgetsupply.Rows[0]["srv"] + "','" + dtgetsupply.Rows[0]["expirydate"] + "','" + txtbarcodeA2.Text + "')";
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        cn.Close();
                        SalesAlert pop = new SalesAlert();
                        pop.ShowDialog();
                        txtbarcodeA2.Text = "";
                        txtproductidA2.Text = "";
                        txtproductnameA2.Text = dtgetsupply.Rows[0]["productname"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Please, If you want to Prepare Supply, snap product's barcode or select product from list");
                    }
                }
                else
                {
                    MessageBox.Show("please Enter a Number");
                }


                txtquantityA2.Text = 1.ToString();
                txtbarcodeA2.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsupply = new System.Data.DataTable();
                double amount = 0;
                string strconnection = "";
                if (string.IsNullOrEmpty(txtquantityA3.Text))
                {
                    MessageBox.Show("Please Type The Quantity of Item To Be Supplied");
                }

                else if (Simulate.IsNumeric(txtquantityA3.Text))
                {
                    if (txtproductidA3.Text != "")
                    {
                        intproductid = Convert.ToInt32(lsvA3.SelectedItems[0].Text);




                        dtgetsupply = x.getdatabase(" select * from product where productid=" + intproductid);
                        double v = 0;
                        v = Convert.ToDouble(dtgetsupply.Rows[0]["unitsalesprice"]);
                        amount = v * Convert.ToInt32(txtquantityA3.Text);
                        strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                        cn.ConnectionString = strconnection;
                        cn.Open();
                        cm.CommandText = "Insert Into supply(staffname,itemsupplied,quantitysupplied,productid,section,unitpack,costprice,unitrate,unitsalesprice,amount,batch,srv,expirydate,barcode) Values('" + txtstaffname1.Text + "','" + txtproductnameA3.Text + "','" + txtquantityA3.Text + "','" + txtproductidA3.Text + "','" + dtgetsupply.Rows[0]["section"] + "','" + dtgetsupply.Rows[0]["unitpack"] + "','" + dtgetsupply.Rows[0]["costprice"] + "','" + dtgetsupply.Rows[0]["unitrate"] + "','" + dtgetsupply.Rows[0]["unitsalesprice"] + "','" + amount + "','" + dtgetsupply.Rows[0]["batch"] + "','" + dtgetsupply.Rows[0]["srv"] + "','" + dtgetsupply.Rows[0]["expirydate"] + "','" + dtgetsupply.Rows[0]["barcode"] + "')";
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        cn.Close();
                        SalesAlert pop = new SalesAlert();
                        pop.ShowDialog();



                        //Define the waitSomeTime method for display time and then disappear without interrupting the main thread

                        // MessageBox.Show. ("Successfully Added To Cart");

                        txtbarcodeA3.Text = "";
                        txtproductidA3.Text = "";
                    }
                    else if (txtbarcodeA3.Text != "")
                    {
                        dtgetsupply = x.getdatabase(" select * from product where barcode=" + txtbarcodeA3.Text);
                        double v = 0;
                        //expirydate = Convert.ToDateTime(expirydate).ToShortDateString();

                        v = Convert.ToDouble(dtgetsupply.Rows[0]["unitsalesprice"]);
                        amount = v * Convert.ToInt32(txtquantityA3.Text);
                        strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                        cn.ConnectionString = strconnection;
                        cn.Open();
                        cm.CommandText = "Insert Into supply(staffname,itemsupplied,quantitysupplied,productid,section,unitpack,costprice,unitrate,unitsalesprice,amount,batch,srv,expirydate,barcode) Values('" + txtstaffname1.Text + "','" + dtgetsupply.Rows[0]["productname"] + "','" + txtquantityA3.Text + "','" + dtgetsupply.Rows[0]["productid"] + "','" + dtgetsupply.Rows[0]["section"] + "','" + dtgetsupply.Rows[0]["unitpack"] + "','" + dtgetsupply.Rows[0]["costprice"] + "','" + dtgetsupply.Rows[0]["unitrate"] + "','" + dtgetsupply.Rows[0]["unitsalesprice"] + "','" + amount + "','" + dtgetsupply.Rows[0]["batch"] + "','" + dtgetsupply.Rows[0]["srv"] + "','" + dtgetsupply.Rows[0]["expirydate"] + "','" + txtbarcodeA3.Text + "')";
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        cn.Close();
                        SalesAlert pop = new SalesAlert();
                        pop.ShowDialog();
                        txtbarcodeA3.Text = "";
                        txtproductidA3.Text = "";
                        txtproductname.Text = dtgetsupply.Rows[0]["productname"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Please, If you want to Prepare Supply, snap product's barcode or select product from list");
                    }
                }
                else
                {
                    MessageBox.Show("please Enter a Number");
                }


                txtquantityA3.Text = 1.ToString();
                txtbarcodeA3.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsupply = new System.Data.DataTable();
                double amount = 0;
                string strconnection = "";
                if (string.IsNullOrEmpty(txtquantityD.Text))
                {
                    MessageBox.Show("Please Type The Quantity of Item To Be Supplied");
                }

                else if (Simulate.IsNumeric(txtquantityD.Text))
                {
                    if (txtproductidD.Text != "")
                    {
                        intproductid = Convert.ToInt32(lsvD.SelectedItems[0].Text);




                        dtgetsupply = x.getdatabase(" select * from product where productid=" + intproductid);
                        double v = 0;
                        v = Convert.ToDouble(dtgetsupply.Rows[0]["unitsalesprice"]);
                        amount = v * Convert.ToInt32(txtquantityD.Text);
                        strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                        cn.ConnectionString = strconnection;
                        cn.Open();
                        cm.CommandText = "Insert Into supply(staffname,itemsupplied,quantitysupplied,productid,section,unitpack,costprice,unitrate,unitsalesprice,amount,batch,srv,expirydate,barcode) Values('" + txtstaffname1.Text + "','" + txtproductnameD.Text + "','" + txtquantityD.Text + "','" + txtproductidD.Text + "','" + dtgetsupply.Rows[0]["section"] + "','" + dtgetsupply.Rows[0]["unitpack"] + "','" + dtgetsupply.Rows[0]["costprice"] + "','" + dtgetsupply.Rows[0]["unitrate"] + "','" + dtgetsupply.Rows[0]["unitsalesprice"] + "','" + amount + "','" + dtgetsupply.Rows[0]["batch"] + "','" + dtgetsupply.Rows[0]["srv"] + "','" + dtgetsupply.Rows[0]["expirydate"] + "','" + dtgetsupply.Rows[0]["barcode"] + "')";
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        cn.Close();
                        SalesAlert pop = new SalesAlert();
                        pop.ShowDialog();



                        //Define the waitSomeTime method for display time and then disappear without interrupting the main thread

                        // MessageBox.Show. ("Successfully Added To Cart");

                        txtbarcodeD.Text = "";
                        txtproductidD.Text = "";
                    }
                    else if (txtbarcodeD.Text != "")
                    {
                        dtgetsupply = x.getdatabase(" select * from product where barcode=" + txtbarcodeD.Text);
                        double v = 0;
                        //expirydate = Convert.ToDateTime(expirydate).ToShortDateString();

                        v = Convert.ToDouble(dtgetsupply.Rows[0]["unitsalesprice"]);
                        amount = v * Convert.ToInt32(txtquantityD.Text);
                        strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                        cn.ConnectionString = strconnection;
                        cn.Open();
                        cm.CommandText = "Insert Into supply(staffname,itemsupplied,quantitysupplied,productid,section,unitpack,costprice,unitrate,unitsalesprice,amount,batch,srv,expirydate,barcode) Values('" + txtstaffname1.Text + "','" + dtgetsupply.Rows[0]["productname"] + "','" + txtquantityD.Text + "','" + dtgetsupply.Rows[0]["productid"] + "','" + dtgetsupply.Rows[0]["section"] + "','" + dtgetsupply.Rows[0]["unitpack"] + "','" + dtgetsupply.Rows[0]["costprice"] + "','" + dtgetsupply.Rows[0]["unitrate"] + "','" + dtgetsupply.Rows[0]["unitsalesprice"] + "','" + amount + "','" + dtgetsupply.Rows[0]["batch"] + "','" + dtgetsupply.Rows[0]["srv"] + "','" + dtgetsupply.Rows[0]["expirydate"] + "','" + txtbarcodeD.Text + "')";
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        cn.Close();
                        SalesAlert pop = new SalesAlert();
                        pop.ShowDialog();
                        txtbarcodeD.Text = "";
                        txtproductidD.Text = "";
                        txtproductnameD.Text = dtgetsupply.Rows[0]["productname"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Please, If you want to Prepare Supply, snap product's barcode or select product from list");
                    }
                }
                else
                {
                    MessageBox.Show("please Enter a Number");
                }


                txtquantityD.Text = 1.ToString();
                txtbarcodeD.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                string strconnection = "";
                System.Data.DataTable dtgetreceipt = new System.Data.DataTable();
                double totalamount = 0;
                dtgetsales = x.getdatabase("select amount,section from supply");
                double temp = 0;
                if (dtgetsales.Rows.Count > 0)
                {
                    for (var i = 0; i < dtgetsales.Rows.Count; i++)
                    {
                        temp = temp + Convert.ToDouble(dtgetsales.Rows[i]["amount"]);
                    }
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Insert Into dreceipt() values()";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    totalamount = temp;
                    dtgetreceipt = x.getdatabase("select * from dreceipt");


                    ViewSupply obj = new ViewSupply();
                    if (dtgetreceipt.Rows.Count > 0)
                    {
                        obj.txtreceiptnumber.Text = "SIVD- " + dtgetreceipt.Rows.Count.ToString();
                    }
                    obj.txtstaffname1.Text = txtstaffname1.Text;
                    obj.txtsection.Text = dtgetsales.Rows[0]["section"].ToString();
                    obj.txtgrandtotal.Text = totalamount.ToString();
                    obj.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                string strconnection = "";
                System.Data.DataTable dtgetreceipt = new System.Data.DataTable();
                double totalamount = 0;
                dtgetsales = x.getdatabase("select amount,section from supply");
                double temp = 0;
                if (dtgetsales.Rows.Count > 0)
                {
                    for (var i = 0; i < dtgetsales.Rows.Count; i++)
                    {
                        temp = temp + Convert.ToDouble(dtgetsales.Rows[i]["amount"]);
                    }
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Insert Into a2receipt() values()";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    totalamount = temp;
                    dtgetreceipt = x.getdatabase("select * from a2receipt");


                    ViewSupply obj = new ViewSupply();
                    if (dtgetreceipt.Rows.Count > 0)
                    {
                        obj.txtreceiptnumber.Text = "SIVA2- " + dtgetreceipt.Rows.Count.ToString();
                    }
                    obj.txtstaffname1.Text = txtstaffname1.Text;
                    obj.txtsection.Text = dtgetsales.Rows[0]["section"].ToString();
                    obj.txtgrandtotal.Text = totalamount.ToString();
                    obj.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                string strconnection = "";
                System.Data.DataTable dtgetreceipt = new System.Data.DataTable();
                double totalamount = 0;
                dtgetsales = x.getdatabase("select amount,section from supply");
                double temp = 0;
                if (dtgetsales.Rows.Count > 0)
                {
                    for (var i = 0; i < dtgetsales.Rows.Count; i++)
                    {
                        temp = temp + Convert.ToDouble(dtgetsales.Rows[i]["amount"]);
                    }
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Insert Into a3receipt() values()";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    totalamount = temp;
                    dtgetreceipt = x.getdatabase("select * from a3receipt");


                    ViewSupply obj = new ViewSupply();
                    if (dtgetreceipt.Rows.Count > 0)
                    {
                        obj.txtreceiptnumber.Text = "SIVA3- " + dtgetreceipt.Rows.Count.ToString();
                    }
                    obj.txtstaffname1.Text = txtstaffname1.Text;
                    obj.txtsection.Text = dtgetsales.Rows[0]["section"].ToString();
                    obj.txtgrandtotal.Text = totalamount.ToString();
                    obj.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void txtexpirydate1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            SectionD_SupplyLog x = new SectionD_SupplyLog();
            x.txtadmin.Text = txtstaffname1.Text;
            x.Show();

        }

        private void button26_Click(object sender, EventArgs e)
        {
           SectionA3_SupplyLog x = new SectionA3_SupplyLog();
            x.txtadmin.Text = txtstaffname1.Text;
            x.Show();

        }

        private void button20_Click(object sender, EventArgs e)
        {
           SectionA2_SupplyLog x = new SectionA2_SupplyLog();
            x.txtadmin.Text = txtstaffname1.Text;
            x.Show();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                dtgetproduct = obj.getdatabase("Select * From product Where productname Like '%" + txtseachdrugsA2.Text + "%' And section= 'A2' Order By productname;");
                if (dtgetproduct.Rows.Count > 0)
                {
                    ListViewItem lstitem = new ListViewItem();
                    lsvA2.Items.Clear();
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
                            lsvA2.Items.Add(lstitem);
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
                            lsvA2.Items.Add(lstitem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                dtgetproduct = obj.getdatabase("Select * From product Where productname Like '%" + txtseachdrugsA3.Text + "%' And section= 'A3' Order By productname;");
                if (dtgetproduct.Rows.Count > 0)
                {
                    ListViewItem lstitem = new ListViewItem();
                    lsvA3.Items.Clear();
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
                            lsvA3.Items.Add(lstitem);
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
                            lsvA3.Items.Add(lstitem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                dtgetproduct = obj.getdatabase("Select * From product Where productname Like '%" + txtseachdrugsD.Text + "%' And section= 'D' Order By productname;");
                if (dtgetproduct.Rows.Count > 0)
                {
                    ListViewItem lstitem = new ListViewItem();
                    lsvD.Items.Clear();
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
                            lsvD.Items.Add(lstitem);
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
                            lsvD.Items.Add(lstitem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            expiryDateInfo x = new expiryDateInfo();
            x.Show();

        }

        private void button28_Click(object sender, EventArgs e)
        {
            expiryDateInfo x = new expiryDateInfo();
            x.Show();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            expiryDateInfo x = new expiryDateInfo();
            x.Show();

        }

        private void txtUnitRate_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCostPrice.Text == "")
            {
            MessageBox.Show("Please Put The Cost Price First Before You Click Here");

            }
            else
            {
                txtUnitRate.Text = (Convert.ToDouble(txtCostPrice.Text) / Convert.ToDouble(txtquantity.Text)).ToString();

            }

        }

        private void txtunitprice_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUnitRate.Text == "")
            {
                MessageBox.Show("Please Put The Cost Price And Click On The Unit Rate To Get The Value There First Before You Click On The Unit Sales Price");

            }
            else
            {
                txtunitprice.Text = (Convert.ToDouble(txtUnitRate.Text) + (0.25 * (Convert.ToDouble(txtUnitRate.Text)))).ToString();

            }
        }

        private void txtunitrate1_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtcostprice1.Text == "")
            {
                MessageBox.Show("Please Put The Cost Price First Before You Click Here");

            }
            else
            {
                txtunitrate1.Text = (Convert.ToDouble(txtcostprice1.Text) / Convert.ToDouble(txtquantity1.Text)).ToString();

            }
        }

        private void txtunitprice_ModifiedChanged(object sender, EventArgs e)
        {

        }

        private void txtunitsalesprice_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtunitrate1.Text == "")
            {
                MessageBox.Show("Please Put The Cost Price And Click On The Unit Rate To Get The Value There First Before You Click On The Unit Sales Price");

            }
            else
            {
                txtunitsalesprice.Text = (Convert.ToDouble(txtunitrate1.Text) + (0.25 * (Convert.ToDouble(txtunitrate1.Text)))).ToString();

            }

        }

        private void txtexpirydate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex reg = new Regex(@"^(\d{1,2})/(\d{1,2})/(\d{4})");
            Match m = reg.Match(txtexpirydate.Text);
            if (m.Success)
            {
                int mm = int.Parse(m.Groups[1].Value);
                int dd = int.Parse(m.Groups[2].Value);
                int yyyy = int.Parse(m.Groups[3].Value);
                e.Cancel = mm < 1 || mm > 12 || dd < 1 || dd > 31 || yyyy < 2019;
            }
            else e.Cancel = true;
            if (e.Cancel)
            {
                if (MessageBox.Show("Wrong date format. The correct format is mm/dd/yyyy\n+ mm should be between 1 and 12\n+ dd should be between 1 and 31.\n+ yyyy should be after 2019", "Invalid date", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    e.Cancel = false;
            }

        }

        private void txtexpirydate1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex reg = new Regex(@"^(\d{1,2})/(\d{1,2})/(\d{4})");
            Match m = reg.Match(txtexpirydate1.Text);
            if (m.Success)
            {
                int mm = int.Parse(m.Groups[1].Value);
                int dd = int.Parse(m.Groups[2].Value);
                int yyyy = int.Parse(m.Groups[3].Value);
                e.Cancel = mm < 1 || mm > 12 || dd < 1 || dd > 31 || yyyy < 2019;
            }
            else e.Cancel = true;
            if (e.Cancel)
            {
                if (MessageBox.Show("Wrong date format. The correct format is mm/dd/yyyy\n+ mm should be between 1 and 12\n+ dd should be between 1 and 31.\n+ yyyy should be after 2019", "Invalid date", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    e.Cancel = false;
            }

        }

        private void txtexpirydate1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void txtexpirydate_MouseEnter(object sender, EventArgs e)
        {

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataTable dtgetpreentry = new DataTable();
            DataTable dtgetsrv = new DataTable();

            dtgetpreentry = x.getdatabase("Select * from preentry");
            if (dtgetpreentry.Rows.Count > 0)
            {
                if (dtgetpreentry.Rows[0]["section"].ToString() == "A1")
                {
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Insert Into a1srv() values()";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    dtgetsrv = x.getdatabase("select * from a1srv");


                    viewEntry obj = new viewEntry();
                    if (dtgetsrv.Rows.Count > 0)
                    {
                        obj.txtSrv.Text = "A1SRV- " + dtgetsrv.Rows.Count.ToString();
                    }
                    obj.txtsection.Text = dtgetpreentry.Rows[0]["section"].ToString();
                    obj.txtstaffname1.Text = txtstaffname1.Text;
                    obj.Show();
                }
               else if (dtgetpreentry.Rows[0]["section"].ToString() == "A2")
                {
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Insert Into a2srv() values()";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    dtgetsrv = x.getdatabase("select * from a2srv");


                    viewEntry obj = new viewEntry();
                    if (dtgetsrv.Rows.Count > 0)
                    {
                        obj.txtSrv.Text = "A2SRV- " + dtgetsrv.Rows.Count.ToString();
                    }
                    obj.txtsection.Text = dtgetpreentry.Rows[0]["section"].ToString();
                    obj.txtstaffname1.Text = txtstaffname1.Text;
                    obj.Show();

                }
                if (dtgetpreentry.Rows[0]["section"].ToString() == "A3")
                {
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Insert Into a3srv() values()";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    dtgetsrv = x.getdatabase("select * from a3srv");


                    viewEntry obj = new viewEntry();
                    if (dtgetsrv.Rows.Count > 0)
                    {
                        obj.txtSrv.Text = "A3SRV- " + dtgetsrv.Rows.Count.ToString();
                    }
                    obj.txtsection.Text = dtgetpreentry.Rows[0]["section"].ToString();
                    obj.txtstaffname1.Text = txtstaffname1.Text;
                    obj.Show();

                }
                if (dtgetpreentry.Rows[0]["section"].ToString() == "D")
                {
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Insert Into dsrv() values()";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    dtgetsrv = x.getdatabase("select * from dsrv");


                    viewEntry obj = new viewEntry();
                    if (dtgetsrv.Rows.Count > 0)
                    {
                        obj.txtSrv.Text = "DSRV- " + dtgetsrv.Rows.Count.ToString();
                    }
                    obj.txtsection.Text = dtgetpreentry.Rows[0]["section"].ToString();
                    obj.txtstaffname1.Text = txtstaffname1.Text;
                    obj.Show();

                }
            }

        }

        private void btnviewupdate_Click(object sender, EventArgs e)
        {
            DataTable dtgetpreupdate = new DataTable();
            DataTable dtgetsrv = new DataTable();

            dtgetpreupdate = x.getdatabase("Select * from preupdate");
            if (dtgetpreupdate.Rows.Count > 0)
            {
                if (dtgetpreupdate.Rows[0]["section"].ToString() == "A1")
                {
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Insert Into a1srv() values()";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    dtgetsrv = x.getdatabase("select * from a1srv");


                    viewUpdate obj = new viewUpdate();
                    if (dtgetsrv.Rows.Count > 0)
                    {
                        obj.txtSrv.Text = "A1SRV- " + dtgetsrv.Rows.Count.ToString();
                    }
                    obj.txtsection.Text = dtgetpreupdate.Rows[0]["section"].ToString();
                    obj.txtstaffname1.Text = txtstaffname1.Text;
                    obj.txtsuppliername.Text = dtgetpreupdate.Rows[0]["suppliername"].ToString();
                    obj.Show();
                }
                else if (dtgetpreupdate.Rows[0]["section"].ToString() == "A2")
                {
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Insert Into a2srv() values()";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    dtgetsrv = x.getdatabase("select * from a2srv");


                    viewUpdate obj = new viewUpdate();
                    if (dtgetsrv.Rows.Count > 0)
                    {
                        obj.txtSrv.Text = "A2SRV- " + dtgetsrv.Rows.Count.ToString();
                    }
                    obj.txtsection.Text = dtgetpreupdate.Rows[0]["section"].ToString();
                    obj.txtstaffname1.Text = txtstaffname1.Text;
                    obj.txtsuppliername.Text = dtgetpreupdate.Rows[0]["suppliername"].ToString();

                    obj.Show();

                }
                if (dtgetpreupdate.Rows[0]["section"].ToString() == "A3")
                {
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Insert Into a3srv() values()";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    dtgetsrv = x.getdatabase("select * from a3srv");


                    viewUpdate obj = new viewUpdate();
                    if (dtgetsrv.Rows.Count > 0)
                    {
                        obj.txtSrv.Text = "A3SRV- " + dtgetsrv.Rows.Count.ToString();
                    }
                    obj.txtsection.Text = dtgetpreupdate.Rows[0]["section"].ToString();
                    obj.txtstaffname1.Text = txtstaffname1.Text;
                    obj.txtsuppliername.Text = dtgetpreupdate.Rows[0]["suppliername"].ToString();

                    obj.Show();

                }
                if (dtgetpreupdate.Rows[0]["section"].ToString() == "D")
                {
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Insert Into dsrv() values()";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    dtgetsrv = x.getdatabase("select * from dsrv");


                    viewUpdate obj = new viewUpdate();
                    if (dtgetsrv.Rows.Count > 0)
                    {
                        obj.txtSrv.Text = "DSRV- " + dtgetsrv.Rows.Count.ToString();
                    }
                    obj.txtsection.Text = dtgetpreupdate.Rows[0]["section"].ToString();
                    obj.txtstaffname1.Text = dtgetpreupdate.Rows[0]["staffname"].ToString();
                    obj.txtsuppliername.Text = dtgetpreupdate.Rows[0]["suppliername"].ToString();

                    obj.Show();

                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
           ReorderLevel x=new ReorderLevel();
            x.Show();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            ReorderLevel x = new ReorderLevel();
            x.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ReorderLevel x = new ReorderLevel();
            x.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            ReorderLevel x = new ReorderLevel();
            x.Show();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            ReorderLevel x = new ReorderLevel();
            x.Show();
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
            sql = "SELECT * FROM Product";
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

           u. releaseObject(xlWorkSheet);
           u. releaseObject(xlWorkBook);
          u.  releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file c:\\" + txtfile1.Text);
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            txtfile1.Text = saveFileDialog1.FileName + ".xls";

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void txtdatepurchased1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void txtsuppliername1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

