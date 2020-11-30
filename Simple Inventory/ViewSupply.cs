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
                //txtcash.Focus();
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
                    // txtstaffname1.Text = txtstaffname1.Text;
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
                   // double change = Convert.ToDouble(txtcash.Text) - Convert.ToDouble(txtgrandtotal.Text);
                 if (cbhospital.Text == "Please, Select The Hospital To Supply")
                        {
                            MessageBox.Show("Please Select The Hospital To Supply");

                        }
                else
                {

                
                        for (var i = 0; i < dtgetsales.Rows.Count; i++)
                        {
                            temp = temp + Convert.ToDouble(dtgetsales.Rows[i]["amount"]);
                        }
                        // cbotesttype.Items.Add(dtgettesttype.Rows(i).Item("testname").ToString)
                    
                    totalamount = temp;
                    dtgetsales =obj. getdatabase("select * from supply");
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
                        dtgetproduct = obj.getdatabase("select * from product where productid=" + intproductid);
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
                                            cm.CommandText = "Insert Into purchasehistory(productid,productname,quantity,section,unitpack,costprice,unitrate,costperunitrate,unitsalesprice,batch,srv,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber) Values(" + Convert.ToInt32(dtgetexpirydate.Rows[k]["productid"]) + ",'" + Convert.ToString(dtgetexpirydate.Rows[k]["productname"]) + "','" + newquantity1 + "','" + dtgetexpirydate.Rows[k]["section"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitpack"].ToString() + "','" + dtgetexpirydate.Rows[k]["costprice"].ToString() + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["unitrate"]) + "','" + dtgetexpirydate.Rows[k]["costperunitrate"].ToString() + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["unitsalesprice"]) + "','" + dtgetexpirydate.Rows[k]["batch"].ToString() + "','" + dtgetexpirydate.Rows[k]["srv"].ToString() + "','" + Convert.ToDateTime(dtgetexpirydate.Rows[k]["expirydate"]).ToShortDateString() + "','" + dtgetexpirydate.Rows[k]["datepurchased"] + "','" + dtgetexpirydate.Rows[k]["barcode"] + "','" + dtgetexpirydate.Rows[k]["suppliername"] + "','" + dtgetexpirydate.Rows[k]["supplierphonenumber"] + "','" + dtgetexpirydate.Rows[k]["invoicenumber"] + "')";
                                            cm.Connection = cn;
                                            cm.ExecuteNonQuery();
                                            cn.Close();
                                            cn.Open();
                                            cm.CommandText = "Delete from expirydate where expirydateid= " + Convert.ToInt32(dtgetexpirydate.Rows[k]["expirydateid"]) + "";
                                            cm.Connection = cn;
                                            cm.ExecuteNonQuery();
                                            cn.Close();
                                            strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                                            cn.ConnectionString = strconnection;
                                            //cn.Open();
                                            //cm.CommandText = "Insert Into drugslog(staffname,productid,itemsold,quantitysupplied,unitcostprice,amountcost,unitsalesprice,amountsupplied,profit,date,receiptnumber,cashpaid,discount,changegiven) Values('" + txtstaffname1.Text + "'," + intproductid + ",'" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "','" + dtgetproduct.Rows[0]["unitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtreceiptnumber.Text + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                            //cm.Connection = cn;
                                            //cm.ExecuteNonQuery();
                                            //cn.Close();
                                            //cn.ConnectionString = strconnection;
                                            cn.Open();
                                            cm.CommandText = "Insert Into supplylog(productid,staffname,itemsupplied,quantitysupplied,section,unitpack,unitrate,costperunitrate,costprice,unitsalesprice,amountsupplied,batch,srv,siv,expirydate,barcode,profit,date) Values(" + intproductid + ",'" + txtstaffname1.Text + "','" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "',,'" + dtgetproduct.Rows[0]["sction"].ToString() + "',,'" + dtgetproduct.Rows[0]["unitpack"].ToString() + "','" + dtgetproduct.Rows[0]["unitrate"].ToString() + "','" + dtgetproduct.Rows[0]["costperunitrate"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + ",'" + dtgetproduct.Rows[0]["batch"].ToString() + "','" + dtgetproduct.Rows[0]["srv"].ToString() + "','" + txtreceiptnumber.Text + "','" + dtgetproduct.Rows[0]["expirydate"].ToString() + "','" + dtgetproduct.Rows[0]["barcode"].ToString() + "'," + profit + ",'" + DateTimePicker1.Value.Date.ToShortDateString() + "')";
                                            cm.Connection = cn;
                                            cm.ExecuteNonQuery();
                                            cn.Close();
                                            strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                                            cn.ConnectionString = strconnection;
                                            cn.Open();
                                            newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]);
                                            cm.CommandText = "Update product Set quantity=" + newquantity + " Where productid=" + intproductid + ";";
                                            cm.Connection = cn;
                                            cm.ExecuteNonQuery();
                                            cn.Close();
                                            goto brake1;
                                        }
                                        else if (dtgetexpirydate.Rows.Count == 1 && Convert.ToInt32(dtgetexpirydate.Rows[k]["quantity"]) == Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]))
                                        {
                                            strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                                            cn.ConnectionString = strconnection;
                                            cn.Open();
                                            newquantity1 = Convert.ToInt32(dtgetexpirydate.Rows[k]["quantity"]);
                                            cm.CommandText = "Update expirydate Set quantity=" + newquantity1 + " Where productname='" + ProductName1 + "' And expirydateid=" + Convert.ToInt32(dtgetexpirydate.Rows[k]["expirydateid"]) + ";";
                                            cm.Connection = cn;
                                            cm.ExecuteNonQuery();
                                            cn.Close();
                                            cn.Open();
                                            cm.CommandText = "Insert Into purchasehistory(productid,productname,quantity,section,unitpack,costprice,unitrate,costperunitrate,unitsalesprice,batch,srv,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber) Values(" + intproductid + ",'" + dtgetexpirydate.Rows[k]["productname"].ToString() + "'," + newquantity1 + ",'" + dtgetexpirydate.Rows[k]["section"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitpack"].ToString() + "','" + dtgetexpirydate.Rows[k]["costprice"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitrate"].ToString() + "','" + dtgetexpirydate.Rows[k]["costperunitrate"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitsalesprice"].ToString() + "','" + dtgetexpirydate.Rows[k]["batch"].ToString() + "','" + dtgetexpirydate.Rows[k]["srv"].ToString() + "','" + dtgetexpirydate.Rows[k]["expirydate"].ToString() + "','" + dtgetexpirydate.Rows[k]["datepurchased"].ToString() + "','" + dtgetexpirydate.Rows[k]["barcode"].ToString() + "','" + dtgetexpirydate.Rows[k]["suppliername"].ToString() + "','" + dtgetexpirydate.Rows[k]["supplierphonenumber"].ToString() + "','" + dtgetexpirydate.Rows[k]["invoicenumber"].ToString() + "')";
                                            cm.Connection = cn;
                                            cm.ExecuteNonQuery();
                                            cn.Close();
                                            cn.Open();
                                            cm.CommandText = "Delete from expirydate where expirydateid= " + Convert.ToInt32(dtgetexpirydate.Rows[k]["expirydateid"]) + "";
                                            cm.Connection = cn;
                                            cm.ExecuteNonQuery();
                                            cn.Close();
                                            strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                                            cn.ConnectionString = strconnection;
                                            cn.Open();
                                            cm.CommandText = "Insert Into supplylog(productid,staffname,itemsupplied,quantitysupplied,section,unitpack,unitrate,costperunitrate,costprice,unitsalesprice,amountsupplied,batch,srv,siv,expirydate,barcode,profit,date) Values(" + intproductid + ",'" + txtstaffname1.Text + "','" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "','" + dtgetproduct.Rows[0]["section"].ToString() + "','" + dtgetproduct.Rows[0]["unitpack"].ToString() + "','" + dtgetproduct.Rows[0]["unitrate"].ToString() + "','" + dtgetproduct.Rows[0]["costperunitrate"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + ",'" + dtgetproduct.Rows[0]["batch"].ToString() + "','" + dtgetproduct.Rows[0]["srv"].ToString() + "','" + txtreceiptnumber.Text + "','" + dtgetproduct.Rows[0]["expirydate"].ToString() + "','" + dtgetproduct.Rows[0]["barcode"].ToString() + "'," + profit + ",'" + DateTimePicker1.Value.Date.ToShortDateString() + "')";
                                            cm.Connection = cn;
                                            cm.ExecuteNonQuery();
                                            cn.Close();
                                            //cn.ConnectionString = strconnection;
                                            //cn.Open();
                                            //cm.CommandText = "Insert Into supplylog(staffname,productid,itemsold,quantitysupplied,unitcostprice,amountcost,unitsalesprice,amountsupplied,profit,date,receiptnumber,cashpaid,discount,changegiven) Values('" + txtstaffname1.Text + "'," + intproductid + ",'" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "','" + dtgetproduct.Rows[0]["unitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtreceiptnumber.Text + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                            //cm.Connection = cn;
                                            //cm.ExecuteNonQuery();
                                            //cn.Close();
                                            strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                                            cn.ConnectionString = strconnection;
                                            cn.Open();
                                            newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]);
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
                                        newquantity1 = Convert.ToInt32(dtgetexpirydate.Rows[0]["quantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]);
                                        strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                                        cn.ConnectionString = strconnection;
                                        cn.Open();
                                        cm.CommandText = "Update expirydate Set quantity=" + newquantity1 + " Where productname='" + ProductName1 + "' And expirydateid=" + Convert.ToInt32(dtgetexpirydate.Rows[0]["expirydateid"]) + ";";
                                        cm.Connection = cn;
                                        cm.ExecuteNonQuery();
                                        cn.Close();
                                        strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                                        cn.ConnectionString = strconnection;
                                        cn.Open();
                                        cm.CommandText = "Insert Into supplylog(productid,staffname,itemsupplied,quantitysupplied,section,unitpack,unitrate,costperunitrate,costprice,unitsalesprice,amountsupplied,batch,srv,siv,expirydate,barcode,profit,date) Values(" + intproductid + ",'" + txtstaffname1.Text + "','" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "','" + dtgetproduct.Rows[0]["section"].ToString() + "','" + dtgetproduct.Rows[0]["unitpack"].ToString() + "','" + dtgetproduct.Rows[0]["unitrate"].ToString() + "','" + dtgetproduct.Rows[0]["costperunitrate"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + ",'" + dtgetproduct.Rows[0]["batch"].ToString() + "','" + dtgetproduct.Rows[0]["srv"].ToString() + "','" + txtreceiptnumber.Text + "','" + dtgetproduct.Rows[0]["expirydate"].ToString() + "','" + dtgetproduct.Rows[0]["barcode"].ToString() + "'," + profit + ",'" + DateTimePicker1.Value.Date.ToShortDateString() + "')";
                                        cm.Connection = cn;
                                        cm.ExecuteNonQuery();
                                        cn.Close();
                                        cn.ConnectionString = strconnection;
                                        //cn.Open();
                                        //cm.CommandText = "Insert Into supplylog(staffname,productid,itemsold,quantitysupplied,unitcostprice,amountcost,unitsalesprice,amountsupplied,profit,date,receiptnumber,cashpaid,discount,changegiven) Values('" + txtstaffname1.Text + "'," + intproductid + ",'" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "','" + dtgetproduct.Rows[0]["unitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtreceiptnumber.Text + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                                        //cm.Connection = cn;
                                        //cm.ExecuteNonQuery();
                                        //cn.Close();
                                        strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                                        cn.ConnectionString = strconnection;
                                        cn.Open();
                                        newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]);
                                        cm.CommandText = "Update product Set quantity=" + newquantity + " Where productid=" + intproductid + ";";
                                        cm.Connection = cn;
                                        cm.ExecuteNonQuery();
                                        cn.Close();
                                        goto brake1;
                                    }
                                }
                            brake1:;
                            }

                            else
                            {
                                MessageBox.Show("Please There is a Product Quantity Less Than The Quatity You Are Trying Sell.The  DRUG's  ID Is: " + intproductid);
                            }
                        }
                        //else
                        //{
                        //    double v = 0;
                        //    double amountcost = 0;
                        //    double profit = 0;
                        //    string ProductName1 = null;
                        //    ProductName1 = dtgetsales.Rows[i]["itemsold"].ToString();
                        //    int newquantity = 0;
                        //    int newquantity1 = 0;
                        //    v = Convert.ToDouble(dtgetsales.Rows[i]["unitcostprice"]);
                        //    amountcost = v * Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]);
                        //    double a = 0;
                        //    a = Convert.ToDouble(dtgetsales.Rows[0]["unitprice"]);
                        //    amount = a * Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]);
                        //    profit = amount - amountcost;
                        //    dtgetcosmetics = getdatabase("select * from cosmetics where cosmeticsid=" + Convert.ToInt32(dtgetsales.Rows[i]["cosmeticsid"]) + "");
                        //    if (Convert.ToInt32(dtgetcosmetics.Rows[0]["cosmeticsquantity"]) >= Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]))
                        //    {
                        //        System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
                        //        dtgetexpirydate = getdatabase("select * from cosmeticsexpirydate where cosmeticsname ='" + ProductName1 + "'order by cosmeticsexpirydateid");
                        //        if (dtgetexpirydate.Rows.Count > 0)
                        //        {
                        //            for (var k = 0; k < dtgetexpirydate.Rows.Count; k++)
                        //            {
                        //                if (Convert.ToInt32(dtgetexpirydate.Rows[0]["cosmeticsquantity"]) <= Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]))
                        //                {
                        //                    if (dtgetexpirydate.Rows.Count > 1)
                        //                    {
                        //                        newquantity1 = (Convert.ToInt32(dtgetexpirydate.Rows[0]["cosmeticsquantity"]) + Convert.ToInt32(dtgetexpirydate.Rows[k + 1]["cosmeticsquantity"])) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]);
                        //                        strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                        //                        cn.ConnectionString = strconnection;
                        //                        cn.Open();
                        //                        cm.CommandText = "Update cosmeticsexpirydate Set cosmeticsquantity=" + newquantity1 + " Where cosmeticsname='" + ProductName1 + "' And cosmeticsexpirydateid =" + Convert.ToInt32(dtgetexpirydate.Rows[k + 1]["cosmeticsexpirydateid"]) + ";";
                        //                        cm.Connection = cn;
                        //                        cm.ExecuteNonQuery();
                        //                        cn.Close();
                        //                        strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                        //                        cn.ConnectionString = strconnection;
                        //                        //Dim intnewproductid As Integer
                        //                        //intnewproductid = CInt(dtgetexpirydate.Rows(0).Item("quantity"))
                        //                        newquantity1 = 0;
                        //                        cn.Open();
                        //                        cm.CommandText = "Update cosmeticsexpirydate Set cosmeticsquantity=" + newquantity1 + " Where cosmeticsname='" + ProductName1 + "' And cosmeticsexpirydateid=" + Convert.ToInt32(dtgetexpirydate.Rows[k]["cosmeticsexpirydateid"]) + ";";
                        //                        cm.Connection = cn;
                        //                        cm.ExecuteNonQuery();
                        //                        cn.Close();
                        //                        cn.Open();
                        //                        cm.CommandText = "Insert Into purchasehistory(productname,quantity,unitcostprice,unitsalesprice,expirydate,suppliername,supplierphonenumber,datepurchased,amountpaid,invoicenumber) Values('" + dtgetexpirydate.Rows[k]["cosmeticsname"] + "','" + newquantity1 + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["cosmeticsunitcostprice"]) + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["cosmeticsunitsalesprice"]) + "','" + Convert.ToDateTime(dtgetexpirydate.Rows[k]["expirydate"]).ToShortDateString() + "','" + dtgetexpirydate.Rows[k]["suppliername"] + "','" + dtgetexpirydate.Rows[k]["supplierphonenumber"] + "','" + dtgetexpirydate.Rows[k]["datepurchased"] + "','" + dtgetexpirydate.Rows[k]["amountpaid"] + "','" + dtgetexpirydate.Rows[k]["invoicenumber"] + "')";
                        //                        cm.Connection = cn;
                        //                        cm.ExecuteNonQuery();
                        //                        cn.Close();
                        //                        cn.Open();
                        //                        cm.CommandText = "Delete from cosmeticsexpirydate where cosmeticsexpirydateid= " + Convert.ToInt32(dtgetexpirydate.Rows[k]["cosmeticsexpirydateid"]) + "";
                        //                        cm.Connection = cn;
                        //                        cm.ExecuteNonQuery();
                        //                        cn.Close();
                        //                        strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                        //                        cn.ConnectionString = strconnection;
                        //                        cn.Open();
                        //                        cm.CommandText = "Insert Into cosmeticslog(staffname,itemsold,quantitysupplied,unitcostprice,amountcost,unitsalesprice,amountsupplied,profit,date,cashpaid,discount,changegiven) Values('" + txtstaffname1.Text + "','" + dtgetcosmetics.Rows[0]["cosmeticsname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "','" + dtgetcosmetics.Rows[0]["cosmeticsunitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetcosmetics.Rows[0]["cosmeticsunitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                        //                        cm.Connection = cn;
                        //                        cm.ExecuteNonQuery();
                        //                        cn.Close();
                        //                        cn.ConnectionString = strconnection;
                        //                        cn.Open();
                        //                        cm.CommandText = "Insert Into supplylog(staffname,itemsold,quantitysupplied,unitcostprice,amountcost,unitsalesprice,amountsupplied,profit,date,cashpaid,discount,changegiven) Values('" + txtstaffname1.Text + "','" + dtgetcosmetics.Rows[0]["cosmeticsname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "','" + dtgetcosmetics.Rows[0]["cosmeticsunitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetcosmetics.Rows[0]["cosmeticsunitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                        //                        cm.Connection = cn;
                        //                        cm.ExecuteNonQuery();
                        //                        cn.Close();
                        //                        strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                        //                        cn.ConnectionString = strconnection;
                        //                        cn.Open();
                        //                        newquantity = Convert.ToInt32(dtgetcosmetics.Rows[0]["cosmeticsquantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]);
                        //                        cm.CommandText = "Update cosmetics Set cosmeticsquantity=" + newquantity + " Where cosmeticsid=" + Convert.ToInt32(dtgetsales.Rows[i]["cosmeticsid"]) + ";";
                        //                        cm.Connection = cn;
                        //                        cm.ExecuteNonQuery();
                        //                        cn.Close();
                        //                        goto brake2;
                        //                    }
                        //                    else
                        //                    {
                        //                        MessageBox.Show("Please The Total Quantity in the COSMETICS TABLE and COSMETICS EXPIRYDATE TABLE Is Diferent.Remove from CART And Harmonise First.The  COSMETICS's  ID Is: " + Convert.ToInt32(dtgetsales.Rows[i]["cosmeticsid"]));

                        //                    }
                        //                }
                        //                else
                        //                {
                        //                    newquantity1 = Convert.ToInt32(dtgetexpirydate.Rows[0]["cosmeticsquantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]);
                        //                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                        //                    cn.ConnectionString = strconnection;
                        //                    cn.Open();
                        //                    cm.CommandText = "Update cosmeticsexpirydate Set cosmeticsquantity=" + newquantity1 + " Where cosmeticsname='" + ProductName1 + "' And cosmeticsid=" + Convert.ToInt32(dtgetexpirydate.Rows[0]["cosmeticsid"]) + ";";
                        //                    cm.Connection = cn;
                        //                    cm.ExecuteNonQuery();
                        //                    cn.Close();
                        //                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                        //                    cn.ConnectionString = strconnection;
                        //                    cn.Open();
                        //                    cm.CommandText = "Insert Into cosmeticslog(staffname,itemsold,quantitysupplied,unitcostprice,amountcost,unitsalesprice,amountsupplied,profit,date,cashpaid,discount,changegiven) Values('" + txtstaffname1.Text + "','" + dtgetcosmetics.Rows[0]["cosmeticsname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "','" + dtgetcosmetics.Rows[0]["cosmeticsunitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetcosmetics.Rows[0]["cosmeticsunitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                        //                    cm.Connection = cn;
                        //                    cm.ExecuteNonQuery();
                        //                    cn.Close();
                        //                    cn.ConnectionString = strconnection;
                        //                    cn.Open();
                        //                    cm.CommandText = "Insert Into supplylog(staffname,itemsold,quantitysupplied,unitcostprice,amountcost,unitsalesprice,amountsupplied,profit,date,cashpaid,discount,changegiven) Values('" + txtstaffname1.Text + "','" + dtgetcosmetics.Rows[0]["cosmeticsname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "','" + dtgetcosmetics.Rows[0]["cosmeticsunitcostprice"].ToString() + "'," + amountcost + ",'" + dtgetcosmetics.Rows[0]["cosmeticsunitsalesprice"].ToString() + "'," + amount + "," + profit + ", '" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + txtcash.Text + "','" + txtdiscount.Text + "','" + change.ToString() + "')";
                        //                    cm.Connection = cn;
                        //                    cm.ExecuteNonQuery();
                        //                    cn.Close();
                        //                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                        //                    cn.ConnectionString = strconnection;
                        //                    cn.Open();
                        //                    newquantity = Convert.ToInt32(dtgetcosmetics.Rows[0]["cosmeticsquantity"]) - Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]);
                        //                    cm.CommandText = "Update cosmetics Set cosmeticsquantity=" + newquantity + " Where cosmeticsid=" + Convert.ToInt32(dtgetsales.Rows[i]["cosmeticsid"]) + ";";
                        //                    cm.Connection = cn;
                        //                    cm.ExecuteNonQuery();
                        //                    cn.Close();
                        //                }
                        //                goto brake2;
                        //            }
                        //        }

                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("Please There a Product Quantity Less Than The Quatity You Are Trying Sell.The  COSMETICS's  ID Is: " + Convert.ToInt32(dtgetsales.Rows[i]["cosmeticsid"]));
                        //        goto brake2;
                        //    }
                        //brake2:;
                        //}

                    }
                }
                        //Dim x As New finalreceipt
                        //x.txtstaffname1.Text = txtstaffname1.Text
                        PrintReceipt x = new PrintReceipt();
                        x.txtstaffname1.Text = txtstaffname1.Text;
                        x.txttotal.Text = txtgrandtotal.Text;
                        x.txthospital.Text = cbhospital.Text;
                    x.txtsection.Text = txtsection.Text;
                     //   x.txtdiscount1.Text = txtdiscount.Text;
                       // x.txtcash.Text = txtcash.Text;
                        x.txtreceiptnumber.Text =txtsection.Text + txtreceiptnumber.Text;
                      //  x.txtchange.Text = change.ToString();
                        x.Show();
                        txtgrandtotal.Text = "";
                        //txtcash.Text = "";
                       // txtdiscount.Text = "";
                        //cbldiscount.Text = "";
                        //txtdiscountapproval.Text = "";
                        lsvitems.Clear();
                        this.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void lsvitems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
