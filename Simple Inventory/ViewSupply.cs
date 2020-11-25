using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Simple_Inventory
{
    public partial class ViewSupply : Form
    {
        public ViewSupply()
        {
            InitializeComponent();
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void txtgrandtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcash_TextChanged(object sender, EventArgs e)
        {

        }
        GetDataBase obj = new GetDataBase();
        Regex rg = new Regex("^[0-9]+$");
        public double discount;
        public string txttotal1;
        public string txtcash1;
        public int inttransactionid;

        private void ViewSupply_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtidentity = new DataTable();
                dtidentity= obj. getdatabase("Select * from identity");
                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                //lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();
                txtcash.Focus();
                DataTable dtgetreceipt = obj. getdatabase("select * from receipt");
                if (dtgetreceipt.Rows.Count > 0)
                {
                    txtreceiptnumber.Text = dtgetreceipt.Rows.Count.ToString();
                }
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                dtgetsales = obj. getdatabase("select * from supply order by itemsupplied");
                if (dtgetsales.Rows.Count > 0)
                {
                    ListViewItem lstitem = new ListViewItem();
                    lsvitems.Items.Clear();
                    for (var i = 0; i < dtgetsales.Rows.Count; i++)
                    {
                        lstitem = new ListViewItem();
                        lstitem.Text = dtgetsales.Rows[i]["transactionid"].ToString();
                        lstitem.SubItems.Add(dtgetsales.Rows[i]["itemsupplied"].ToString());
                        lstitem.SubItems.Add(dtgetsales.Rows[i]["quantitysupplied"].ToString());
                        lstitem.SubItems.Add(dtgetsales.Rows[i]["unitsalesprice"].ToString());
                        lstitem.SubItems.Add(dtgetsales.Rows[i]["amount"].ToString());
                        lsvitems.Items.Add(lstitem);
                    }

                    string time1 = null;
                    time1 = DateTime.Now.ToShortTimeString();
                    txttime.Text = time1;
                  
                }
                else
                {
                    lsvitems.Clear();
                    // txtcashiername1.Text = txtcashiername1.Text;
                    txtreceiptnumber.Text = "";
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
                if (rg.Match(txtcash.Text).Success)
                {
                    MySqlConnection cn = new MySqlConnection();
                    MySqlDataAdapter ad = new MySqlDataAdapter();
                    MySqlCommand cm = new MySqlCommand();
                    string strconnection = null;
                    double amount = 0;
                    System.Data.DataTable dtgetsales = new System.Data.DataTable();
                    System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                    System.Data.DataTable dtgetcosmetics = new System.Data.DataTable();
                    double totalamount = 0;
                    dtgetsales =obj. getdatabase("select amount from supply");
                    double temp = 0;
                    double change = Convert.ToDouble(txtcash.Text) - Convert.ToDouble(txtgrandtotal.Text);

                    if (txtcash.Text == "")
                    {
                        MessageBox.Show("Please Enter the Cash Paid");
                        txtcash.Focus();
                    }
                    else if (Convert.ToDouble(txtcash.Text) < Convert.ToDouble(txtgrandtotal.Text))
                    {
                        MessageBox.Show("Please  the Cash Paid is less Than the Cost of items Purchased");
                        txtcash.Focus();
                    }
                    if (dtgetsales.Rows.Count > 0 && Convert.ToDouble(txtcash.Text) >= Convert.ToDouble(txtgrandtotal.Text))
                    {
                        for (var i = 0; i < dtgetsales.Rows.Count; i++)
                        {
                            temp = temp + Convert.ToDouble(dtgetsales.Rows[i]["amount"]);
                        }
                        // cbotesttype.Items.Add(dtgettesttype.Rows(i).Item("testname").ToString)
                    }
                    totalamount = temp;
                    dtgetsales =obj. getdatabase("select * from supply");
                    if (dtgetsales.Rows.Count > 0 && (Convert.ToDouble(txtcash.Text) >= Convert.ToDouble(txtgrandtotal.Text)))
                    {
                        for (var i = 0; i < dtgetsales.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(dtgetsales.Rows[i]["productid"]) != Convert.ToInt32("0"))
                            {
                                double v = 0;
                                double amountcost = 0;
                                double profit = 0;
                                int newquantity = 0;
                                int newquantity1 = 0;
                                string ProductName1 = null;
                                int intproductid = 0;
                                ProductName1 = dtgetsales.Rows[i]["itemsupplied"].ToString();
                                v = Convert.ToDouble(dtgetsales.Rows[i]["unitrate"]);
                                amountcost = v * Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]);
                                double a = 0;
                                a = Convert.ToDouble(dtgetsales.Rows[i]["unitsalesprice"]);
                                amount = a * Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]);
                                profit = amount - amountcost;

                                discount = 0;
                                intproductid = Convert.ToInt32(dtgetsales.Rows[i]["productid"]);
                                dtgetproduct =obj. getdatabase("select * from product where productid=" + intproductid);
                                if (Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) >= Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]))
                                {
                                    System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
                                    dtgetexpirydate = obj.getdatabase("select * from expirydate where productname ='" + ProductName1 + "'order by expirydateid");
                                    if (dtgetexpirydate.Rows.Count > 0)
                                    {
                                        for (var k = 0; k < dtgetexpirydate.Rows.Count; k++)
                                        {
                                            if (Convert.ToInt32(dtgetexpirydate.Rows[k]["quantity"]) <= Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]))
                                            {
                                                if (dtgetexpirydate.Rows.Count > 1)
                                                {
                                                    newquantity1 = (Convert.ToInt32(dtgetexpirydate.Rows[k]["quantity"]) + Convert.ToInt32(dtgetexpirydate.Rows[k + 1]["quantity"])) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]);
                                                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    cm.CommandText = "Update expirydate Set quantity=" + newquantity1 + " Where productname='" + ProductName1 + "' And expirydateid =" + Convert.ToInt32(dtgetexpirydate.Rows[k + 1]["expirydateid"]) + ";";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    //Dim intnewproductid As Integer
                                                    //intnewproductid = CInt(dtgetexpirydate.Rows(0).Item("quantity"))
                                                    cn.Open();
                                                    newquantity1 = 0;
                                                    cm.CommandText = "Update expirydate Set quantity=" + newquantity1 + " Where productname='" + ProductName1 + "' And expirydateid=" + Convert.ToInt32(dtgetexpirydate.Rows[k]["expirydateid"]) + ";";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    cn.Open();
                                                    cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + Convert.ToString(dtgetexpirydate.Rows[k]["productname"]) + "','" + newquantity1 + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["unitrate"]) + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["unitsalesprice"]) + "','" + Convert.ToDateTime(dtgetexpirydate.Rows[k]["expirydate"]).ToShortDateString() + "','" + dtgetexpirydate.Rows[k]["suppliername"] + "','" + dtgetexpirydate.Rows[k]["supplierphonenumber"] + "','" + dtgetexpirydate.Rows[k]["datepurchased"] + "','" + dtgetexpirydate.Rows[k]["amountpaid"] + "','" + dtgetexpirydate.Rows[k]["invoicenumber"] + "')";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    cn.Open();
                                                    cm.CommandText = "Delete from expirydate where expirydateid= " + Convert.ToInt32(dtgetexpirydate.Rows[k]["expirydateid"]) + "";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    cm.CommandText = "Insert Into drugslog(cashiername,productid,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,receiptnumber,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "'," + intproductid + ",'" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetproduct.Rows[0]["unitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtreceiptnumber.Text + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    cm.CommandText = "Insert Into generalsaleslog(cashiername,productid,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,receiptnumber,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "'," + intproductid + ",'" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetproduct.Rows[0]["unitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtreceiptnumber.Text + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                                    cm.CommandText = "Update product Set quantity=" + newquantity + " Where productid=" + intproductid + ";";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    goto brake1;
                                                }
                                                else if (dtgetexpirydate.Rows.Count == 1 && Convert.ToInt32(dtgetexpirydate.Rows[k]["quantity"]) == Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]))
                                                {
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    newquantity1 = Convert.ToInt32(dtgetexpirydate.Rows[k]["quantity"]);
                                                    cm.CommandText = "Update expirydate Set quantity=" + newquantity1 + " Where productname='" + ProductName1 + "' And expirydateid=" + Convert.ToInt32(dtgetexpirydate.Rows[k]["expirydateid"]) + ";";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    cn.Open();
                                                    cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + Convert.ToString(dtgetexpirydate.Rows[k]["productname"]) + "','" + newquantity1 + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["unitcostprice"]) + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["unitsalesprice"]) + "','" + Convert.ToDateTime(dtgetexpirydate.Rows[k]["expirydate"]).ToShortDateString() + "','" + dtgetexpirydate.Rows[k]["suppliername"] + "','" + dtgetexpirydate.Rows[k]["supplierphonenumber"] + "','" + dtgetexpirydate.Rows[k]["datepurchased"] + "','" + dtgetexpirydate.Rows[k]["amountpaid"] + "','" + dtgetexpirydate.Rows[k]["invoicenumber"] + "')";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    cn.Open();
                                                    cm.CommandText = "Delete from expirydate where expirydateid= " + Convert.ToInt32(dtgetexpirydate.Rows[k]["expirydateid"]) + "";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    cm.CommandText = "Insert Into drugslog(cashiername,productid,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,receiptnumber,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "'," + intproductid + ",'" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetproduct.Rows[0]["unitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtreceiptnumber.Text + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    cm.CommandText = "Insert Into generalsaleslog(cashiername,productid,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,receiptnumber,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "'," + intproductid + ",'" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetproduct.Rows[0]["unitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtreceiptnumber.Text + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                                    cm.CommandText = "Update product Set quantity=" + newquantity + " Where productid=" + intproductid + ";";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    goto brake1;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please The Total Quantity in the DRUGS TABLE and  EXPIRYDATE TABLE Is Different.Remove from CART And Harmonise First.The  DRUG's  ID Is: " + Convert.ToInt32(dtgetsales.Rows[i]["productid"]));
                                                }
                                            }

                                            else
                                            {
                                                newquantity1 = Convert.ToInt32(dtgetexpirydate.Rows[0]["quantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                                strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                cn.ConnectionString = strconnection;
                                                cn.Open();
                                                cm.CommandText = "Update expirydate Set quantity=" + newquantity1 + " Where productname='" + ProductName1 + "' And expirydateid=" + Convert.ToInt32(dtgetexpirydate.Rows[0]["expirydateid"]) + ";";
                                                cm.Connection = cn;
                                                cm.ExecuteNonQuery();
                                                cn.Close();
                                                strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                cn.ConnectionString = strconnection;
                                                cn.Open();
                                                cm.CommandText = "Insert Into drugslog(cashiername,productid,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,receiptnumber,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "'," + intproductid + ",'" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetproduct.Rows[0]["unitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtreceiptnumber.Text + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                cm.Connection = cn;
                                                cm.ExecuteNonQuery();
                                                cn.Close();
                                                cn.ConnectionString = strconnection;
                                                cn.Open();
                                                cm.CommandText = "Insert Into generalsaleslog(cashiername,productid,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,receiptnumber,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "'," + intproductid + ",'" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetproduct.Rows[0]["unitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtreceiptnumber.Text + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                cm.Connection = cn;
                                                cm.ExecuteNonQuery();
                                                cn.Close();
                                                strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                cn.ConnectionString = strconnection;
                                                cn.Open();
                                                newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                                cm.CommandText = "Update product Set quantity=" + newquantity + " Where productid=" + intproductid + ";";
                                                cm.Connection = cn;
                                                cm.ExecuteNonQuery();
                                                cn.Close();
                                                goto brake1;
                                            }
                                        }
                                    brake1:;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please There a Product Quantity Less Than The Quatity You Are Trying Sell.The  DRUG's  ID Is: " + intproductid);
                                }
                            }
                            else
                            {
                                double v = 0;
                                double amountcost = 0;
                                double profit = 0;
                                string ProductName1 = null;
                                ProductName1 = dtgetsales.Rows[i]["itemsold"].ToString();
                                int newquantity = 0;
                                int newquantity1 = 0;
                                v = Convert.ToDouble(dtgetsales.Rows[i]["unitcostprice"]);
                                amountcost = v * Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                double a = 0;
                                a = Convert.ToDouble(dtgetsales.Rows[0]["unitprice"]);
                                amount = a * Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                profit = amount - amountcost;
                                dtgetcosmetics = getdatabase("select * from cosmetics where cosmeticsid=" + Convert.ToInt32(dtgetsales.Rows[i]["cosmeticsid"]) + "");
                                if (Convert.ToInt32(dtgetcosmetics.Rows[0]["cosmeticsquantity"]) >= Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]))
                                {
                                    System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
                                    dtgetexpirydate = getdatabase("select * from cosmeticsexpirydate where cosmeticsname ='" + ProductName1 + "'order by cosmeticsexpirydateid");
                                    if (dtgetexpirydate.Rows.Count > 0)
                                    {
                                        for (var k = 0; k < dtgetexpirydate.Rows.Count; k++)
                                        {
                                            if (Convert.ToInt32(dtgetexpirydate.Rows[0]["cosmeticsquantity"]) <= Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]))
                                            {
                                                if (dtgetexpirydate.Rows.Count > 1)
                                                {
                                                    newquantity1 = (Convert.ToInt32(dtgetexpirydate.Rows[0]["cosmeticsquantity"]) + Convert.ToInt32(dtgetexpirydate.Rows[k + 1]["cosmeticsquantity"])) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    cm.CommandText = "Update cosmeticsexpirydate Set cosmeticsquantity=" + newquantity1 + " Where cosmeticsname='" + ProductName1 + "' And cosmeticsexpirydateid =" + Convert.ToInt32(dtgetexpirydate.Rows[k + 1]["cosmeticsexpirydateid"]) + ";";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    //Dim intnewproductid As Integer
                                                    //intnewproductid = CInt(dtgetexpirydate.Rows(0).Item("quantity"))
                                                    newquantity1 = 0;
                                                    cn.Open();
                                                    cm.CommandText = "Update cosmeticsexpirydate Set cosmeticsquantity=" + newquantity1 + " Where cosmeticsname='" + ProductName1 + "' And cosmeticsexpirydateid=" + Convert.ToInt32(dtgetexpirydate.Rows[k]["cosmeticsexpirydateid"]) + ";";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    cn.Open();
                                                    cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + dtgetexpirydate.Rows[k]["cosmeticsname"] + "','" + newquantity1 + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["cosmeticsunitcostprice"]) + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["cosmeticsunitsalesprice"]) + "','" + Convert.ToDateTime(dtgetexpirydate.Rows[k]["expirydate"]).ToShortDateString() + "','" + dtgetexpirydate.Rows[k]["suppliername"] + "','" + dtgetexpirydate.Rows[k]["supplierphonenumber"] + "','" + dtgetexpirydate.Rows[k]["datepurchased"] + "','" + dtgetexpirydate.Rows[k]["amountpaid"] + "','" + dtgetexpirydate.Rows[k]["invoicenumber"] + "')";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    cn.Open();
                                                    cm.CommandText = "Delete from cosmeticsexpirydate where cosmeticsexpirydateid= " + Convert.ToInt32(dtgetexpirydate.Rows[k]["cosmeticsexpirydateid"]) + "";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    cm.CommandText = "Insert Into cosmeticslog(cashiername,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "','" + dtgetcosmetics.Rows[0]["cosmeticsname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetcosmetics.Rows[0]["cosmeticsunitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetcosmetics.Rows[0]["cosmeticsunitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    cm.CommandText = "Insert Into generalsaleslog(cashiername,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "','" + dtgetcosmetics.Rows[0]["cosmeticsname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetcosmetics.Rows[0]["cosmeticsunitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetcosmetics.Rows[0]["cosmeticsunitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                    cn.ConnectionString = strconnection;
                                                    cn.Open();
                                                    newquantity = Convert.ToInt32(dtgetcosmetics.Rows[0]["cosmeticsquantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                                    cm.CommandText = "Update cosmetics Set cosmeticsquantity=" + newquantity + " Where cosmeticsid=" + Convert.ToInt32(dtgetsales.Rows[i]["cosmeticsid"]) + ";";
                                                    cm.Connection = cn;
                                                    cm.ExecuteNonQuery();
                                                    cn.Close();
                                                    goto brake2;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please The Total Quantity in the COSMETICS TABLE and COSMETICS EXPIRYDATE TABLE Is Diferent.Remove from CART And Harmonise First.The  COSMETICS's  ID Is: " + Convert.ToInt32(dtgetsales.Rows[i]["cosmeticsid"]));

                                                }
                                            }
                                            else
                                            {
                                                newquantity1 = Convert.ToInt32(dtgetexpirydate.Rows[0]["cosmeticsquantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                                strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                cn.ConnectionString = strconnection;
                                                cn.Open();
                                                cm.CommandText = "Update cosmeticsexpirydate Set cosmeticsquantity=" + newquantity1 + " Where cosmeticsname='" + ProductName1 + "' And cosmeticsid=" + Convert.ToInt32(dtgetexpirydate.Rows[0]["cosmeticsid"]) + ";";
                                                cm.Connection = cn;
                                                cm.ExecuteNonQuery();
                                                cn.Close();
                                                strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                cn.ConnectionString = strconnection;
                                                cn.Open();
                                                cm.CommandText = "Insert Into cosmeticslog(cashiername,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "','" + dtgetcosmetics.Rows[0]["cosmeticsname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetcosmetics.Rows[0]["cosmeticsunitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetcosmetics.Rows[0]["cosmeticsunitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                cm.Connection = cn;
                                                cm.ExecuteNonQuery();
                                                cn.Close();
                                                cn.ConnectionString = strconnection;
                                                cn.Open();
                                                cm.CommandText = "Insert Into generalsaleslog(cashiername,itemsold,quantitysold,unitcostprice,amountcost,unitsalesprice,amountsold,profit,date,cashpaid,discount,changegiven) Values('" + txtcashiername1.Text + "','" + dtgetcosmetics.Rows[0]["cosmeticsname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]) + "','" + dtgetcosmetics.Rows[0]["cosmeticsunitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetcosmetics.Rows[0]["cosmeticsunitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                                cm.Connection = cn;
                                                cm.ExecuteNonQuery();
                                                cn.Close();
                                                strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
                                                cn.ConnectionString = strconnection;
                                                cn.Open();
                                                newquantity = Convert.ToInt32(dtgetcosmetics.Rows[0]["cosmeticsquantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysold"]);
                                                cm.CommandText = "Update cosmetics Set cosmeticsquantity=" + newquantity + " Where cosmeticsid=" + Convert.ToInt32(dtgetsales.Rows[i]["cosmeticsid"]) + ";";
                                                cm.Connection = cn;
                                                cm.ExecuteNonQuery();
                                                cn.Close();
                                            }
                                            goto brake2;
                                        }
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Please There a Product Quantity Less Than The Quatity You Are Trying Sell.The  COSMETICS's  ID Is: " + Convert.ToInt32(dtgetsales.Rows[i]["cosmeticsid"]));
                                    goto brake2;
                                }
                            brake2:;
                            }

                        }
                        //Dim x As New finalreceipt
                        //x.txtcashiername1.Text = txtcashiername1.Text
                        receiptmidip x = new receiptmidip();
                        x.txtcashiername1.Text = txtcashiername1.Text;
                        x.txttotal.Text = txtgrandtotal.Text;
                        x.txtdiscount1.Text = txtdiscount.Text;
                        x.txtcash.Text = txtcash.Text;
                        x.txtreceiptnumber.Text = txtreceiptnumber.Text;
                        x.txtchange.Text = change.ToString();
                        x.Show();
                        txttotal.Text = "";
                        txtcash.Text = "";
                        txtdiscount.Text = "";
                        txtgrandtotal.Text = "";
                        cbldiscount.Text = "";
                        txtdiscountapproval.Text = "";
                        lsvitems.Clear();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please, Enter Only Numeric Values");
                    txtcash.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
