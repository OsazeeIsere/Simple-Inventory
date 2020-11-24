using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
                        lsvitems.Items.Add(lstitem);
                    }
                    txttotal.Text = dtgetproduct.Rows.Count.ToString();
                  
                }
                txtcode.Focus();


            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());

            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {

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

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

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
                    MessageBox.Show("Please enter the Expiry Date of the Product Purchased");
                }
                else if (string.IsNullOrEmpty(txtsection.Text))
                {
                    MessageBox.Show("Please enter the Section of the Product Purchased");
                }
                else if (string.IsNullOrEmpty(txtcostunitrate.Text))
                {
                    MessageBox.Show("Please enter the Cost Per Unit Rate of the Product Purchased");
                }
                else if (string.IsNullOrEmpty(txtbatch.Text))
                {
                    MessageBox.Show("Please enter the Batch of the Product Purchased");
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
                    cm.CommandText = "Insert Into product(productname,quantity,section,unitpack,costprice,unitrate,costperunitrate,unitsalesprice,batch,expirydate,datepurchased,barcode) Values('" + txtproductname.Text + "','" + txtquantity.Text + "','" + txtsection.Text + "','" + txtUnitPack.Text + "','" + txtCostPrice.Text + "','" + txtUnitRate.Text + "','" + txtcostunitrate.Text + "','" + txtunitprice.Text + "','" + txtbatch.Text + "','" + txtdatepurchased.Text + "','"+ txtexpirydate.Text + "','" + txtcode.Text + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    //dtgetproduct = getdatabase("Select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate,entrydate from product")
                    //dtgetproduct1 = getdatabase("Select productid from product");
                    //dtgetproduct2 = getdatabase("Select productid From product where productid=" + dtgetproduct1.Rows.Count);
                    //string productname = null;
                    //productname = dtgetproduct.Rows[0]["productname"].ToString();
                    //dtgetproduct1 = getdatabase("Select productid from product where productname=" + dtgetproduct.Rows[0]["productname"]);
                    cn.Open();
                    cm.CommandText = "Insert Into expirydate(productname,quantity,section,unitpack,costprice,unitrate,costperunitrate,unitsalesprice,batch,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber) Values('" + txtproductname.Text + "','" + txtquantity.Text + "','" + txtsection.Text + "','" + txtUnitPack.Text + "','" + txtCostPrice.Text + "','" + txtUnitRate.Text + "','" + txtcostunitrate.Text + "','" + txtunitprice.Text + "','" + txtbatch.Text + "','" + txtdatepurchased.Text + "','" + txtexpirydate.Text + "','" + txtcode.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtinvoicenumber.Text + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    cn.Open();
                    cm.CommandText = "Insert Into purchasehistory(productname,quantity,section,unitpack,costprice,unitrate,costperunitrate,unitsalesprice,batch,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber) Values('" + txtproductname.Text + "','" + txtquantity.Text + "','" + txtsection.Text + "','" + txtUnitPack.Text + "','" + txtCostPrice.Text + "','" + txtUnitRate.Text + "','" + txtcostunitrate.Text + "','" + txtunitprice.Text + "','" + txtbatch.Text + "','" + txtdatepurchased.Text + "','" + txtexpirydate.Text + "','" + txtcode.Text + "','" + txtsuppliername.Text + "','" + txtsupplierphonenumber.Text + "','" + txtinvoicenumber.Text + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();

                    //computeresult(intpersonid, CDbl(txtscore.Text), cbosubject.Text)
                    dtgetproduct = x.getdatabase("Select * from product");
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

                            //           lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["costperunitrate"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvitems.Items.Add(lstitem);

                        }
                        txttotal.Text = dtgetproduct.Rows.Count.ToString();
                    }
                    txtproductname.Text = "";
                    txtquantity.Text = "";
                    txtunitprice.Text = "";
                    txtsection.Text = "";
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
            txtcode.Focus();
        }

        private void txtunitprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
           try
            {
                strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;
                int newquantity = 0;
                intproductid = Convert.ToInt32(txtproductid.Text);
                dtgetproduct =x. getdatabase("Select * From product where productid=" + intproductid);
                cn.Open();
                newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) + Convert.ToInt32(txtquantity1.Text);
                cm.CommandText = "Update product Set productname='" + txtproductname1.Text + "',quantity =" + newquantity + ",section='" + txtsection1.Text + "',unitpack='" + txtunitpack1.Text + "',costprice=" + txtcostprice1.Text + ",unitrate=" + txtunitrate1.Text + ",costperunitrate=" + txtcostperunitrate.Text + ",unitsalesprice=" + txtunitsalesprice.Text + ",batch='" + txtbatch1.Text + "',expirydate='" + txtexpirydate1.Text + "',datepurchased='" + txtdatepurchased1.Text + "',barcode='" + txtcode1.Text + "' Where productid=" + intproductid + ";";
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                cn.Close();
                cn.Close();
                cn.Open();
                cm.CommandText = "Insert Into expirydate(productname,quantity,section,unitpack,costprice,unitrate,costperunitrate,unitsalesprice,batch,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber) Values('" + txtproductname1.Text + "','" + txtquantity1.Text + "','" + txtsection1.Text + "','" + txtunitpack1.Text + "','" + txtcostprice1.Text + "','" + txtunitrate1.Text + "','" + txtcostperunitrate.Text + "','" + txtunitsalesprice.Text + "','" + txtbatch1.Text + "','" + txtdatepurchased1.Text + "','" + txtexpirydate1.Text + "','" + txtcode1.Text + "','" + txtsuppliername1.Text + "','" + txtsupplierphonenumber1.Text + "','" + txtinvoice1.Text + "')";
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                cn.Close();
                cn.Open();
                cm.CommandText = "Insert Into purchasehistory(productname,quantity,section,unitpack,costprice,unitrate,costperunitrate,unitsalesprice,batch,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber) Values('" + txtproductname1.Text + "','" + txtquantity1.Text + "','" + txtsection1.Text + "','" + txtunitpack1.Text + "','" + txtcostprice1.Text + "','" + txtunitrate1.Text + "','" + txtcostperunitrate.Text + "','" + txtunitsalesprice.Text + "','" + txtbatch1.Text + "','" + txtdatepurchased1.Text + "','" + txtexpirydate1.Text + "','" + txtcode1.Text + "','" + txtsuppliername1.Text + "','" + txtsupplierphonenumber1.Text + "','" + txtinvoice1.Text + "')";
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                cn.Close();
                dtgetproduct =x. getdatabase("Select * from product");
                if (dtgetproduct.Rows.Count > 0)
                {
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
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["costperunitrate"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            listView1.Items.Add(lstitem);
                        }
                        txttotal.Text = dtgetproduct.Rows.Count.ToString();
                        txtcode.Focus();
                    
                }
                txtproductname1.Text = "";
                txtquantity1.Text = "";
                txtunitsalesprice.Text = "";
                txtsection1.Text = "";
                txtexpirydate1.Text = "";
              //  txtsuppliername1.Text = "";
                //txtdatepurchased1.Text = "";
                txtunitpack1.Text = "";
                txtbatch1.Text = "";
                txtunitrate1.Text = "";
                txtcostperunitrate.Text = "";
                txtproductid.Text = "";

              //  txtsupplierphonenumber1.Text = "";
                txtcode1.Text = "";
                txtcode.Focus();
            }
            catch(Exception ex)
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
                    txtcode.Focus();


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
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["costperunitrate"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            listView1.Items.Add(lstitem);
                        }
                        txttotal.Text = dtgetproduct.Rows.Count.ToString();
                        txtcode.Focus();
                    }
                    
                    else if (StockTab.SelectedTab == requisitionTab)
                    {
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
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["costperunitrate"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            listView2.Items.Add(lstitem);
                        }
                        txttotal.Text = dtgetproduct.Rows.Count.ToString();
                        txtquantity2.Text = "1";
                        txtcode2.Focus();
                    }
                    else if(StockTab.SelectedTab == DispensaryTab)
                    {
                        ListViewItem lstitem = new ListViewItem();
                        listView3.Items.Clear();
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
                            listView3.Items.Add(lstitem);
                        }
                        txttotal.Text = dtgetproduct.Rows.Count.ToString();
                        txtcode.Focus();

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

        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                double amount = 0;
                string strconnection = "";
                if (string.IsNullOrEmpty(txtquantity2.Text))
                {
                    MessageBox.Show("Please Type The Quantity of Drug To Be Sold");
                }

                else if (Simulate.IsNumeric(txtquantity2.Text))
                {
                    if (txtproductid2.Text != "")
                    {
                        intproductid = Convert.ToInt32(listView2.SelectedItems[0].Text);




                        dtgetsales = x.getdatabase(" select * from product where productid=" + intproductid);
                        double v = 0;
                        v = Convert.ToDouble(dtgetsales.Rows[0]["unitsalesprice"]);
                        amount = v * Convert.ToInt32(txtquantity2.Text);
                        strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                        cn.ConnectionString = strconnection;
                        cn.Open();
                        cm.CommandText = "Insert Into sales(cashiername,itemsold,quantitysold,unitcostprice,unitprice,amount,discount,productid) Values('" + txtcashiername1.Text + "','" + dtgetsales.Rows[0]["productname"].ToString() + "','" + txtquantity2.Text + "','" + dtgetsales.Rows[0]["costprice"] + "','" + dtgetsales.Rows[0]["unitsalesprice"] + "'," + amount + "," + discount + "," + Convert.ToInt32(txtproductid2.Text) + ")";
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        cn.Close();
                        RequestAlert pop = new RequestAlert();
                        pop.ShowDialog();



                        //Define the waitSomeTime method for display time and then disappear without interrupting the main thread

                        // MessageBox.Show. ("Successfully Added To Cart");

                        txtcode2.Text = "";
                        txtproductid2.Text = "";
                    }
                    else if (txtcode2.Text != "")
                    {
                        dtgetsales = x.getdatabase(" select * from product where barcode=" + txtcode2.Text);
                        double v = 0;
                        v = Convert.ToDouble(dtgetsales.Rows[0]["unitsalesprice"]);
                        amount = v * Convert.ToInt32(txtquantity2.Text);
                        strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                        cn.ConnectionString = strconnection;
                        cn.Open();
                        cm.CommandText = "Insert Into sales(cashiername,itemsold,quantitysold,unitcostprice,unitprice,amount,discount,productid) Values('" + txtcashiername1.Text + "','" + dtgetsales.Rows[0]["productname"].ToString() + "','" + txtquantity2.Text + "','" + dtgetsales.Rows[0]["unitcostprice"] + "','" + dtgetsales.Rows[0]["unitsalesprice"] + "'," + amount + "," + discount + ",'" + dtgetsales.Rows[0]["productid"] + "')";
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        cn.Close();
                        RequestAlert pop = new RequestAlert();
                        pop.ShowDialog();
                        txtcode2.Text = "";
                        txtproductid2.Text = "";
                        txtproductname.Text = dtgetsales.Rows[0]["productname"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Please, If you want to sell, snap product's barcode or select product from list");
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
                dtgetsales = x.getdatabase("select amount from sales");
                double temp = 0;
                if (dtgetsales.Rows.Count > 0)
                {
                    for (var i = 0; i < dtgetsales.Rows.Count; i++)
                    {
                        temp = temp + Convert.ToDouble(dtgetsales.Rows[i]["amount"]);
                    }
                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Insert Into receipt() values()";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    totalamount = temp;
                    viewsales obj = new viewsales();
                    obj.txtcashiername1.Text = txtcashiername1.Text;
                    obj.txttotal.Text = totalamount.ToString();
                    obj.txtdiscount.Text = 0.ToString();
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
    }
}
