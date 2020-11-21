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
                newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) + Convert.ToInt32(txtquantity.Text);
                cm.CommandText = "Update product Set productname='" + txtproductname.Text + "',quantity =" + newquantity + ",section='" + txtsection.Text + "',unitpack='" + txtUnitPack.Text + "',costprice=" + txtCostPrice.Text + ",unitrate=" + txtUnitRate.Text + ",costperunitrate=" + txtcostunitrate.Text + ",unitsalesprice=" + txtunitprice.Text + ",batch='" + txtbatch.Text + "',expirydate='" + txtexpirydate.Text + "',datepurchased='" + txtdatepurchased + "',barcode='" + txtcode + "' Where productid=" + intproductid + ";";
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                cn.Close();
                cn.Close();
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
                dtgetproduct =x. getdatabase("Select productid,productname,quantity,unitsalesprice,unitcostprice,expirydate,entrydate from product");
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
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitcostprice"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                        lsvitems.Items.Add(lstitem);
                    }
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
                txtcode.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
