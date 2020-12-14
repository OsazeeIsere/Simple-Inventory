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
        MySqlConnection cn = new MySqlConnection();
        MySqlDataAdapter ad = new MySqlDataAdapter();
        MySqlCommand cm = new MySqlCommand();


        private void ViewSupply_Load(object sender, EventArgs e)
        {
            try
            {
                utility u = new utility();
                //u.fitFormToScreen(this, 900, 1600);
                //this.CenterToScreen();
                double temp1 = 0;
                string strconnection;
                strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;

                DataTable dtidentity = new DataTable();
                dtidentity= obj. getdatabase("Select * from identity");
                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                //lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();
                //txtcash.Focus();
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                dtgetsales = obj. getdatabase("select * from supply order by transactionid");
                if (dtgetsales.Rows.Count > 0)
                {
                    ListViewItem lstitem = new ListViewItem();
                    lsvitems.Items.Clear();
                    for (var i = 0; i < dtgetsales.Rows.Count; i++)
                    {
                        lstitem = new ListViewItem();
                        lstitem.Text = dtgetsales.Rows[i]["transactionid"].ToString();
                        lstitem.SubItems.Add(dtgetsales.Rows[i]["itemsupplied"].ToString());
                        lstitem.SubItems.Add(dtgetsales.Rows[i]["unitpack"].ToString());
                        lstitem.SubItems.Add(dtgetsales.Rows[i]["quantitysupplied"].ToString());
                        lstitem.SubItems.Add(dtgetsales.Rows[i]["unitsalesprice"].ToString());
                        lstitem.SubItems.Add(dtgetsales.Rows[i]["amount"].ToString());
                        lsvitems.Items.Add(lstitem);
                        temp1 = temp1 + Convert.ToDouble(dtgetsales.Rows[i]["amount"]);
                        cn.Open();
                        cm.CommandText = "Update supply Set runningtotal=" + temp1 + " Where transactionid=" + dtgetsales.Rows[i]["transactionid"].ToString() + ";";
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        cn.Close();

                    }
                    string time1 = null;
                    time1 = DateTime.Now.ToShortTimeString();
                    txtsection.Text= dtgetsales.Rows[0]["section"].ToString();
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
                ComboBox cb = new ComboBox();
                      if (cbhospital.Text == "Please, Select The Hospital To Supply")
                        {
                            MessageBox.Show("Please Select The Hospital To Supply");

                        }
                
                else if (txtsection.Text == "A1")
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
                                                    cm.CommandText = "Insert Into purchasehistory(productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,batch,srv,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber) Values('" + dtgetexpirydate.Rows[k]["productname"].ToString() + "','" + newquantity1 + "','" + dtgetexpirydate.Rows[k]["section"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitpack"].ToString() + "','" + dtgetexpirydate.Rows[k]["costprice"].ToString() + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["unitrate"]) + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["unitsalesprice"]) + "','" + dtgetexpirydate.Rows[k]["batch"].ToString() + "','" + dtgetexpirydate.Rows[k]["srv"].ToString() + "','" + Convert.ToDateTime(dtgetexpirydate.Rows[k]["expirydate"]).ToShortDateString() + "','" + dtgetexpirydate.Rows[k]["datepurchased"] + "','" + dtgetexpirydate.Rows[k]["barcode"].ToString() + "','" + dtgetexpirydate.Rows[k]["suppliername"].ToString() + "','" + dtgetexpirydate.Rows[k]["supplierphonenumber"].ToString() + "','" + dtgetexpirydate.Rows[k]["invoicenumber"].ToString() + "')";
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
                                                    cm.CommandText = "Insert Into supplylog(productid,staffname,itemsupplied,quantitysupplied,section,unitpack,unitrate,costprice,unitsalesprice,amountsupplied,batch,srv,siv,expirydate,barcode,profit,date,destination) Values(" + intproductid + ",'" + txtstaffname1.Text + "','" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "','" + dtgetproduct.Rows[0]["section"].ToString() + "','" + dtgetproduct.Rows[0]["unitpack"].ToString() + "','" + dtgetproduct.Rows[0]["unitrate"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + ",'" + dtgetproduct.Rows[0]["batch"].ToString() + "','" + dtgetproduct.Rows[0]["srv"].ToString() + "','" + txtreceiptnumber.Text + "','" + dtgetproduct.Rows[0]["expirydate"].ToString() + "','" + dtgetproduct.Rows[0]["barcode"].ToString() + "'," + profit + ",'" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + cbhospital.Text + "')";
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
                                                cn.Open();
                                                cm.CommandText = "Update supply Set destination='" + cbhospital.Text + "',siv='" + txtreceiptnumber.Text + "' Where transactionid=" + dtgetsales.Rows[0]["transactionid"].ToString() + ";";
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
                                                    cm.CommandText = "Insert Into purchasehistory(productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,batch,srv,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber) Values(" + intproductid + ",'" + dtgetexpirydate.Rows[k]["productname"].ToString() + "'," + newquantity1 + ",'" + dtgetexpirydate.Rows[k]["section"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitpack"].ToString() + "','" + dtgetexpirydate.Rows[k]["costprice"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitrate"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitsalesprice"].ToString() + "','" + dtgetexpirydate.Rows[k]["batch"].ToString() + "','" + dtgetexpirydate.Rows[k]["srv"].ToString() + "','" + dtgetexpirydate.Rows[k]["expirydate"].ToString() + "','" + dtgetexpirydate.Rows[k]["datepurchased"].ToString() + "','" + dtgetexpirydate.Rows[k]["barcode"].ToString() + "','" + dtgetexpirydate.Rows[k]["suppliername"].ToString() + "','" + dtgetexpirydate.Rows[k]["supplierphonenumber"].ToString() + "','" + dtgetexpirydate.Rows[k]["invoicenumber"].ToString() + "')";
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
                                                    cm.CommandText = "Insert Into supplylog(productid,staffname,itemsupplied,quantitysupplied,section,unitpack,unitrate,costprice,unitsalesprice,amountsupplied,batch,srv,siv,expirydate,barcode,profit,date,destination) Values(" + intproductid + ",'" + txtstaffname1.Text + "','" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "','" + dtgetproduct.Rows[0]["section"].ToString() + "','" + dtgetproduct.Rows[0]["unitpack"].ToString() + "','" + dtgetproduct.Rows[0]["unitrate"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + ",'" + dtgetproduct.Rows[0]["batch"].ToString() + "','" + dtgetproduct.Rows[0]["srv"].ToString() + "','" + txtreceiptnumber.Text + "','" + dtgetproduct.Rows[0]["expirydate"].ToString() + "','" + dtgetproduct.Rows[0]["barcode"].ToString() + "'," + profit + ",'" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + cbhospital.Text + "')";
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
                                                cn.Open();
                                                cm.CommandText = "Update supply Set destination='" + cbhospital.Text + "',siv='" + txtreceiptnumber.Text + "' Where transactionid=" + dtgetsales.Rows[0]["transactionid"].ToString() + ";";
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
                                                cm.CommandText = "Insert Into supplylog(productid,staffname,itemsupplied,quantitysupplied,section,unitpack,unitrate,costprice,unitsalesprice,amountsupplied,batch,srv,siv,expirydate,barcode,profit,date,destination) Values(" + intproductid + ",'" + txtstaffname1.Text + "','" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "','" + dtgetproduct.Rows[0]["section"].ToString() + "','" + dtgetproduct.Rows[0]["unitpack"].ToString() + "','" + dtgetproduct.Rows[0]["unitrate"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + ",'" + dtgetproduct.Rows[0]["batch"].ToString() + "','" + dtgetproduct.Rows[0]["srv"].ToString() + "','" + txtreceiptnumber.Text + "','" + dtgetproduct.Rows[0]["expirydate"].ToString() + "','" + dtgetproduct.Rows[0]["barcode"].ToString() + "'," + profit + ",'" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + cbhospital.Text + "')";
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
                                            cn.Open();
                                            cm.CommandText = "Update supply Set destination='" + cbhospital.Text + "',siv='" + txtreceiptnumber.Text + "' Where transactionid=" + dtgetsales.Rows[0]["transactionid"].ToString() + ";";
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
                        }
                    }
                        ReceipFromcrp x = new ReceipFromcrp();
                        //x.txtstaffname1.Text = txtstaffname1.Text;
                        //x.txttotal.Text = txtgrandtotal.Text;
                        //x.txthospital.Text = cbhospital.Text;
                        //x.txtsection.Text = txtsection.Text;
                        //x.txtreceiptnumber.Text =txtreceiptnumber.Text;
                        x.Show();
                        txtgrandtotal.Text = "";
                      //  lsvitems.Clear();
                       // this.Close();
                }
                else if (txtsection.Text == "A2")
                {
                    for (var i = 0; i < dtgetsales.Rows.Count; i++)
                    {
                        temp = temp + Convert.ToDouble(dtgetsales.Rows[i]["amount"]);
                    }
                    // cbotesttype.Items.Add(dtgettesttype.Rows(i).Item("testname").ToString)

                    totalamount = temp;
                    dtgetsales = obj.getdatabase("select * from supply");
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
                                                cm.CommandText = "Insert Into purchasehistory(productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,batch,srv,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber) Values(" + Convert.ToInt32(dtgetexpirydate.Rows[k]["productid"]) + ",'" + Convert.ToString(dtgetexpirydate.Rows[k]["productname"]) + "','" + newquantity1 + "','" + dtgetexpirydate.Rows[k]["section"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitpack"].ToString() + "','" + dtgetexpirydate.Rows[k]["costprice"].ToString() + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["unitrate"]) + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["unitsalesprice"]) + "','" + dtgetexpirydate.Rows[k]["batch"].ToString() + "','" + dtgetexpirydate.Rows[k]["srv"].ToString() + "','" + Convert.ToDateTime(dtgetexpirydate.Rows[k]["expirydate"]).ToShortDateString() + "','" + dtgetexpirydate.Rows[k]["datepurchased"] + "','" + dtgetexpirydate.Rows[k]["barcode"] + "','" + dtgetexpirydate.Rows[k]["suppliername"] + "','" + dtgetexpirydate.Rows[k]["supplierphonenumber"] + "','" + dtgetexpirydate.Rows[k]["invoicenumber"] + "')";
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
                                                cm.CommandText = "Insert Into a2supplylog(productid,staffname,itemsupplied,quantitysupplied,section,unitpack,unitrate,costprice,unitsalesprice,amountsupplied,batch,srv,siv,expirydate,barcode,profit,date,destination) Values(" + intproductid + ",'" + txtstaffname1.Text + "','" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "',,'" + dtgetproduct.Rows[0]["sction"].ToString() + "',,'" + dtgetproduct.Rows[0]["unitpack"].ToString() + "','" + dtgetproduct.Rows[0]["unitrate"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + ",'" + dtgetproduct.Rows[0]["batch"].ToString() + "','" + dtgetproduct.Rows[0]["srv"].ToString() + "','" + txtreceiptnumber.Text + "','" + dtgetproduct.Rows[0]["expirydate"].ToString() + "','" + dtgetproduct.Rows[0]["barcode"].ToString() + "'," + profit + ",'" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + cbhospital.Text + "')";
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
                                                cn.Open();
                                                cm.CommandText = "Update supply Set destination='" + cbhospital.Text + "',siv='" + txtreceiptnumber.Text + "' Where transactionid=" + dtgetsales.Rows[0]["transactionid"].ToString() + ";";
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
                                                cm.CommandText = "Insert Into purchasehistory(productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,batch,srv,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber) Values(" + intproductid + ",'" + dtgetexpirydate.Rows[k]["productname"].ToString() + "'," + newquantity1 + ",'" + dtgetexpirydate.Rows[k]["section"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitpack"].ToString() + "','" + dtgetexpirydate.Rows[k]["costprice"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitrate"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitsalesprice"].ToString() + "','" + dtgetexpirydate.Rows[k]["batch"].ToString() + "','" + dtgetexpirydate.Rows[k]["srv"].ToString() + "','" + dtgetexpirydate.Rows[k]["expirydate"].ToString() + "','" + dtgetexpirydate.Rows[k]["datepurchased"].ToString() + "','" + dtgetexpirydate.Rows[k]["barcode"].ToString() + "','" + dtgetexpirydate.Rows[k]["suppliername"].ToString() + "','" + dtgetexpirydate.Rows[k]["supplierphonenumber"].ToString() + "','" + dtgetexpirydate.Rows[k]["invoicenumber"].ToString() + "')";
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
                                                cm.CommandText = "Insert Into a2supplylog(productid,staffname,itemsupplied,quantitysupplied,section,unitpack,unitrate,costprice,unitsalesprice,amountsupplied,batch,srv,siv,expirydate,barcode,profit,date,destination) Values(" + intproductid + ",'" + txtstaffname1.Text + "','" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "','" + dtgetproduct.Rows[0]["section"].ToString() + "','" + dtgetproduct.Rows[0]["unitpack"].ToString() + "','" + dtgetproduct.Rows[0]["unitrate"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + ",'" + dtgetproduct.Rows[0]["batch"].ToString() + "','" + dtgetproduct.Rows[0]["srv"].ToString() + "','" + txtreceiptnumber.Text + "','" + dtgetproduct.Rows[0]["expirydate"].ToString() + "','" + dtgetproduct.Rows[0]["barcode"].ToString() + "'," + profit + ",'" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + cbhospital.Text + "')";
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
                                                cn.Open();
                                                cm.CommandText = "Update supply Set destination='" + cbhospital.Text + "',siv='" + txtreceiptnumber.Text + "' Where transactionid=" + dtgetsales.Rows[0]["transactionid"].ToString() + ";";
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
                                            cm.CommandText = "Insert Into a2supplylog(productid,staffname,itemsupplied,quantitysupplied,section,unitpack,unitrate,costprice,unitsalesprice,amountsupplied,batch,srv,siv,expirydate,barcode,profit,date,destination) Values(" + intproductid + ",'" + txtstaffname1.Text + "','" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "','" + dtgetproduct.Rows[0]["section"].ToString() + "','" + dtgetproduct.Rows[0]["unitpack"].ToString() + "','" + dtgetproduct.Rows[0]["unitrate"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + ",'" + dtgetproduct.Rows[0]["batch"].ToString() + "','" + dtgetproduct.Rows[0]["srv"].ToString() + "','" + txtreceiptnumber.Text + "','" + dtgetproduct.Rows[0]["expirydate"].ToString() + "','" + dtgetproduct.Rows[0]["barcode"].ToString() + "'," + profit + ",'" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + cbhospital.Text + "')";
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
                                            cn.Open();
                                            cm.CommandText = "Update supply Set destination='" + cbhospital.Text + "',siv='" + txtreceiptnumber.Text + "' Where transactionid=" + dtgetsales.Rows[0]["transactionid"].ToString() + ";";
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
                        }
                    }
                    ReceipFromcrp x = new ReceipFromcrp();
                    //x.txtstaffname1.Text = txtstaffname1.Text;
                    //x.txttotal.Text = txtgrandtotal.Text;
                    //x.txthospital.Text = cbhospital.Text;
                    //x.txtsection.Text = txtsection.Text;
                    //x.txtreceiptnumber.Text =txtreceiptnumber.Text;
                    x.Show();
                    txtgrandtotal.Text = "";
                    //lsvitems.Clear();
                    //this.Close();
                }
                else if (txtsection.Text == "A3")
                {
                    for (var i = 0; i < dtgetsales.Rows.Count; i++)
                    {
                        temp = temp + Convert.ToDouble(dtgetsales.Rows[i]["amount"]);
                    }
                    // cbotesttype.Items.Add(dtgettesttype.Rows(i).Item("testname").ToString)

                    totalamount = temp;
                    dtgetsales = obj.getdatabase("select * from supply");
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
                                                cm.CommandText = "Insert Into purchasehistory(productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,batch,srv,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber) Values(" + dtgetexpirydate.Rows[k]["productid"] + ",'" + dtgetexpirydate.Rows[k]["productname"] + "'," + newquantity1 + ",'" + dtgetexpirydate.Rows[k]["section"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitpack"].ToString() + "','" + dtgetexpirydate.Rows[k]["costprice"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitrate"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitsalesprice"].ToString() + "','" + dtgetexpirydate.Rows[k]["batch"].ToString() + "','" + dtgetexpirydate.Rows[k]["srv"].ToString() + "','" + Convert.ToDateTime(dtgetexpirydate.Rows[k]["expirydate"]).ToShortDateString() + "','" + dtgetexpirydate.Rows[k]["datepurchased"].ToString() + "','" + dtgetexpirydate.Rows[k]["barcode"].ToString() + "','" + dtgetexpirydate.Rows[k]["suppliername"].ToString() + "','" + dtgetexpirydate.Rows[k]["supplierphonenumber"].ToString() + "','" + dtgetexpirydate.Rows[k]["invoicenumber"].ToString() + "')";
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
                                                cm.CommandText = "Insert Into a3supplylog(productid,staffname,itemsupplied,quantitysupplied,section,unitpack,unitrate,costprice,unitsalesprice,amountsupplied,batch,srv,siv,expirydate,barcode,profit,date,destination) Values(" + intproductid + ",'" + txtstaffname1.Text + "','" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "',,'" + dtgetproduct.Rows[0]["sction"].ToString() + "',,'" + dtgetproduct.Rows[0]["unitpack"].ToString() + "','" + dtgetproduct.Rows[0]["unitrate"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + ",'" + dtgetproduct.Rows[0]["batch"].ToString() + "','" + dtgetproduct.Rows[0]["srv"].ToString() + "','" + txtreceiptnumber.Text + "','" + dtgetproduct.Rows[0]["expirydate"].ToString() + "','" + dtgetproduct.Rows[0]["barcode"].ToString() + "'," + profit + ",'" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + cbhospital.Text + "')";
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
                                                cn.Open();
                                                cm.CommandText = "Update supply Set destination='" + cbhospital.Text + "',siv='" + txtreceiptnumber.Text + "' Where transactionid=" + dtgetsales.Rows[0]["transactionid"].ToString() + ";";
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
                                                cm.CommandText = "Insert Into purchasehistory(productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,batch,srv,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber) Values(" + intproductid + ",'" + dtgetexpirydate.Rows[k]["productname"].ToString() + "'," + newquantity1 + ",'" + dtgetexpirydate.Rows[k]["section"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitpack"].ToString() + "','" + dtgetexpirydate.Rows[k]["costprice"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitrate"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitsalesprice"].ToString() + "','" + dtgetexpirydate.Rows[k]["batch"].ToString() + "','" + dtgetexpirydate.Rows[k]["srv"].ToString() + "','" + dtgetexpirydate.Rows[k]["expirydate"].ToString() + "','" + dtgetexpirydate.Rows[k]["datepurchased"].ToString() + "','" + dtgetexpirydate.Rows[k]["barcode"].ToString() + "','" + dtgetexpirydate.Rows[k]["suppliername"].ToString() + "','" + dtgetexpirydate.Rows[k]["supplierphonenumber"].ToString() + "','" + dtgetexpirydate.Rows[k]["invoicenumber"].ToString() + "')";
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
                                                cm.CommandText = "Insert Into a3supplylog(productid,staffname,itemsupplied,quantitysupplied,section,unitpack,unitrate,costprice,unitsalesprice,amountsupplied,batch,srv,siv,expirydate,barcode,profit,date,destination) Values(" + intproductid + ",'" + txtstaffname1.Text + "','" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "','" + dtgetproduct.Rows[0]["section"].ToString() + "','" + dtgetproduct.Rows[0]["unitpack"].ToString() + "','" + dtgetproduct.Rows[0]["unitrate"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + ",'" + dtgetproduct.Rows[0]["batch"].ToString() + "','" + dtgetproduct.Rows[0]["srv"].ToString() + "','" + txtreceiptnumber.Text + "','" + dtgetproduct.Rows[0]["expirydate"].ToString() + "','" + dtgetproduct.Rows[0]["barcode"].ToString() + "'," + profit + ",'" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + cbhospital.Text + "')";
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
                                                cn.Open();
                                                cm.CommandText = "Update supply Set destination='" + cbhospital.Text + "',siv='" + txtreceiptnumber.Text + "' Where transactionid=" + dtgetsales.Rows[0]["transactionid"].ToString() + ";";
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
                                            cm.CommandText = "Insert Into a3supplylog(productid,staffname,itemsupplied,quantitysupplied,section,unitpack,unitrate,costprice,unitsalesprice,amountsupplied,batch,srv,siv,expirydate,barcode,profit,date,destination) Values(" + intproductid + ",'" + txtstaffname1.Text + "','" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "','" + dtgetproduct.Rows[0]["section"].ToString() + "','" + dtgetproduct.Rows[0]["unitpack"].ToString() + "','" + dtgetproduct.Rows[0]["unitrate"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + ",'" + dtgetproduct.Rows[0]["batch"].ToString() + "','" + dtgetproduct.Rows[0]["srv"].ToString() + "','" + txtreceiptnumber.Text + "','" + dtgetproduct.Rows[0]["expirydate"].ToString() + "','" + dtgetproduct.Rows[0]["barcode"].ToString() + "'," + profit + ",'" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + cbhospital.Text + "')";
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
                                            cn.Open();
                                            cm.CommandText = "Update supply Set destination='" + cbhospital.Text + "',siv='" + txtreceiptnumber.Text + "' Where transactionid=" + dtgetsales.Rows[0]["transactionid"].ToString() + ";";
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
                        }
                    }
                    ReceipFromcrp x = new ReceipFromcrp();
                    //x.txtstaffname1.Text = txtstaffname1.Text;
                    //x.txttotal.Text = txtgrandtotal.Text;
                    //x.txthospital.Text = cbhospital.Text;
                    //x.txtsection.Text = txtsection.Text;
                    //x.txtreceiptnumber.Text =txtreceiptnumber.Text;
                    x.Show();
                    txtgrandtotal.Text = "";
                   // lsvitems.Clear();
                    //this.Close();
                }
                else if (txtsection.Text == "D")
                {
                    for (var i = 0; i < dtgetsales.Rows.Count; i++)
                    {
                        temp = temp + Convert.ToDouble(dtgetsales.Rows[i]["amount"]);
                    }
                    // cbotesttype.Items.Add(dtgettesttype.Rows(i).Item("testname").ToString)

                    totalamount = temp;
                    dtgetsales = obj.getdatabase("select * from supply");
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
                                                cm.CommandText = "Insert Into purchasehistory(productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,batch,srv,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber) Values(" + Convert.ToInt32(dtgetexpirydate.Rows[k]["productid"]) + ",'" + Convert.ToString(dtgetexpirydate.Rows[k]["productname"]) + "','" + newquantity1 + "','" + dtgetexpirydate.Rows[k]["section"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitpack"].ToString() + "','" + dtgetexpirydate.Rows[k]["costprice"].ToString() + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["unitrate"]) + "','" + Convert.ToDouble(dtgetexpirydate.Rows[k]["unitsalesprice"]) + "','" + dtgetexpirydate.Rows[k]["batch"].ToString() + "','" + dtgetexpirydate.Rows[k]["srv"].ToString() + "','" + Convert.ToDateTime(dtgetexpirydate.Rows[k]["expirydate"]).ToShortDateString() + "','" + dtgetexpirydate.Rows[k]["datepurchased"] + "','" + dtgetexpirydate.Rows[k]["barcode"] + "','" + dtgetexpirydate.Rows[k]["suppliername"] + "','" + dtgetexpirydate.Rows[k]["supplierphonenumber"] + "','" + dtgetexpirydate.Rows[k]["invoicenumber"] + "')";
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
                                                cm.CommandText = "Insert Into dsupplylog(productid,staffname,itemsupplied,quantitysupplied,section,unitpack,unitrate,costprice,unitsalesprice,amountsupplied,batch,srv,siv,expirydate,barcode,profit,date,destination) Values(" + intproductid + ",'" + txtstaffname1.Text + "','" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "',,'" + dtgetproduct.Rows[0]["sction"].ToString() + "',,'" + dtgetproduct.Rows[0]["unitpack"].ToString() + "','" + dtgetproduct.Rows[0]["unitrate"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + ",'" + dtgetproduct.Rows[0]["batch"].ToString() + "','" + dtgetproduct.Rows[0]["srv"].ToString() + "','" + txtreceiptnumber.Text + "','" + dtgetproduct.Rows[0]["expirydate"].ToString() + "','" + dtgetproduct.Rows[0]["barcode"].ToString() + "'," + profit + ",'" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + cbhospital.Text + "')";
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
                                                cn.Open();
                                                cm.CommandText = "Update supply Set destination='" + cbhospital.Text + "',siv='" + txtreceiptnumber.Text + "' Where transactionid=" + dtgetsales.Rows[0]["transactionid"].ToString() + ";";
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
                                                cm.CommandText = "Insert Into purchasehistory(productid,productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,batch,srv,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber) Values(" + intproductid + ",'" + dtgetexpirydate.Rows[k]["productname"].ToString() + "'," + newquantity1 + ",'" + dtgetexpirydate.Rows[k]["section"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitpack"].ToString() + "','" + dtgetexpirydate.Rows[k]["costprice"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitrate"].ToString() + "','" + dtgetexpirydate.Rows[k]["unitsalesprice"].ToString() + "','" + dtgetexpirydate.Rows[k]["batch"].ToString() + "','" + dtgetexpirydate.Rows[k]["srv"].ToString() + "','" + dtgetexpirydate.Rows[k]["expirydate"].ToString() + "','" + dtgetexpirydate.Rows[k]["datepurchased"].ToString() + "','" + dtgetexpirydate.Rows[k]["barcode"].ToString() + "','" + dtgetexpirydate.Rows[k]["suppliername"].ToString() + "','" + dtgetexpirydate.Rows[k]["supplierphonenumber"].ToString() + "','" + dtgetexpirydate.Rows[k]["invoicenumber"].ToString() + "')";
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
                                                cm.CommandText = "Insert Into dsupplylog(productid,staffname,itemsupplied,quantitysupplied,section,unitpack,unitrate,costprice,unitsalesprice,amountsupplied,batch,srv,siv,expirydate,barcode,profit,date,destination) Values(" + intproductid + ",'" + txtstaffname1.Text + "','" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "','" + dtgetproduct.Rows[0]["section"].ToString() + "','" + dtgetproduct.Rows[0]["unitpack"].ToString() + "','" + dtgetproduct.Rows[0]["unitrate"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + ",'" + dtgetproduct.Rows[0]["batch"].ToString() + "','" + dtgetproduct.Rows[0]["srv"].ToString() + "','" + txtreceiptnumber.Text + "','" + dtgetproduct.Rows[0]["expirydate"].ToString() + "','" + dtgetproduct.Rows[0]["barcode"].ToString() + "'," + profit + ",'" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + cbhospital.Text + "')";
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
                                                cn.Open();
                                                cm.CommandText = "Update supply Set destination='" + cbhospital.Text + "',siv='" + txtreceiptnumber.Text + "' Where transactionid=" + dtgetsales.Rows[0]["transactionid"].ToString() + ";";
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
                                            cm.CommandText = "Insert Into dsupplylog(productid,staffname,itemsupplied,quantitysupplied,section,unitpack,unitrate,costprice,unitsalesprice,amountsupplied,batch,srv,siv,expirydate,barcode,profit,date,destination) Values(" + intproductid + ",'" + txtstaffname1.Text + "','" + dtgetproduct.Rows[0]["productname"].ToString() + "','" + Convert.ToInt32(dtgetsales.Rows[i]["quantitysupplied"]) + "','" + dtgetproduct.Rows[0]["section"].ToString() + "','" + dtgetproduct.Rows[0]["unitpack"].ToString() + "','" + dtgetproduct.Rows[0]["unitrate"].ToString() + "'," + amountcost + ",'" + dtgetproduct.Rows[0]["unitsalesprice"].ToString() + "'," + amount + ",'" + dtgetproduct.Rows[0]["batch"].ToString() + "','" + dtgetproduct.Rows[0]["srv"].ToString() + "','" + txtreceiptnumber.Text + "','" + dtgetproduct.Rows[0]["expirydate"].ToString() + "','" + dtgetproduct.Rows[0]["barcode"].ToString() + "'," + profit + ",'" + DateTimePicker1.Value.Date.ToShortDateString() + "','" + cbhospital.Text + "')";
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
                                            cn.Open();
                                            cm.CommandText = "Update supply Set destination='" + cbhospital.Text + "',siv='" + txtreceiptnumber.Text + "' Where transactionid=" + dtgetsales.Rows[0]["transactionid"].ToString() + ";";
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
                        }
                    }
                    ReceipFromcrp x = new ReceipFromcrp();
                    //x.txtstaffname1.Text = txtstaffname1.Text;
                    //x.txttotal.Text = txtgrandtotal.Text;
                    //x.txthospital.Text = cbhospital.Text;
                    //x.txtsection.Text = txtsection.Text;
                    //x.txtreceiptnumber.Text =txtreceiptnumber.Text;
                    x.Show();
                    txtgrandtotal.Text = "";
                   // lsvitems.Clear();
                    //this.Close();
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

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                editesupply x = new editesupply();
                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                string strconnection = "";
                strconnection = "server=localhost;port=3306;database=edp;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                inttransactionid = Convert.ToInt32((txttransactionid.Text).ToString());
                dtgetproduct = obj.getdatabase("Select * From supply where transactionid=" + inttransactionid);
                x.txttransactionid.Text = inttransactionid.ToString();
                x.txtitemsold.Text = (dtgetproduct.Rows[0]["itemsupplied"]).ToString();
                x.txtcashiername1.Text = txtstaffname1.Text;
                x.txtsection.Text = txtsection.Text;
                x.txtsiv.Text = txtreceiptnumber.Text;
                x.txtgrandtotal.Text = txtgrandtotal.Text;
                this.Close();
                x.Show();

                //cn.Open();
                //cm.CommandText = "Delete from sales where transactionid=" + inttransactionid + ";";
                //cm.Connection = cn;
                //cm.ExecuteNonQuery();
                //cn.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lsvitems_MouseClick(object sender, MouseEventArgs e)
        {
            try
			{
				int inttransactionid = 0;
				MySqlConnection cn = new MySqlConnection();
				MySqlDataAdapter ad = new MySqlDataAdapter();
				MySqlCommand cm = new MySqlCommand();
				System.Data.DataTable dtgetsales = new System.Data.DataTable();
				if (Simulate.IsNumeric(Convert.ToInt32(lsvitems.SelectedItems[0].Text)))
				{
					inttransactionid = Convert.ToInt32(lsvitems.SelectedItems[0].Text);
					//Dim dblunitsalesprice = CDbl(dgvsales.SelectedCells(0).Value)
					dtgetsales =obj. getdatabase(" select * from supply where transactionid=" + inttransactionid);
					txtproductname.Text = (dtgetsales.Rows[0]["itemsupplied"]).ToString();
					txttransactionid.Text = (dtgetsales.Rows[0]["transactionid"]).ToString();
					txtquantity.Text = (dtgetsales.Rows[0]["quantitysupplied"]).ToString();
					inttransactionid = Convert.ToInt32(txttransactionid.Text);
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

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string strconnection = null;
                double x = 0;
                int inttransactionid = 0;
                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                if (Simulate.IsNumeric(Convert.ToInt32(lsvitems.SelectedItems[0].Text)))
                {
                    inttransactionid = Convert.ToInt32(lsvitems.SelectedItems[0].Text);
                    dtgetsales =obj. getdatabase(" select * from supply where transactionid=" + inttransactionid);
                    x = Convert.ToInt32(txtquantity.Text) * Convert.ToDouble(dtgetsales.Rows[0]["unitsalesprice"]);
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Update supply Set quantitysupplied='" + txtquantity.Text + "', amount=" + x + " Where transactionid=" + inttransactionid + ";";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    dtgetsales =obj. getdatabase("select * from supply order by itemsupplied");
                    if (dtgetsales.Rows.Count > 0)
                    {
                        ListViewItem lstitem = new ListViewItem();
                        lsvitems.Items.Clear();
                        for (var i = 0; i < dtgetsales.Rows.Count; i++)
                        {
                            lstitem = new ListViewItem();
                            lstitem.Text = dtgetsales.Rows[i]["transactionid"].ToString();
                            lstitem.SubItems.Add(dtgetsales.Rows[i]["itemsupplied"].ToString());
                            lstitem.SubItems.Add(dtgetsales.Rows[i]["unitpack"].ToString());
                            lstitem.SubItems.Add(dtgetsales.Rows[i]["quantitysupplied"].ToString());
                            lstitem.SubItems.Add(dtgetsales.Rows[i]["unitsalesprice"].ToString());
                            lstitem.SubItems.Add(dtgetsales.Rows[i]["amount"].ToString());
                            lsvitems.Items.Add(lstitem);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please Select The ProductID");
                }
                //Dim totalamount As Double
                dtgetsales =obj. getdatabase("select amount from supply");
                double temp = 0;
                if (dtgetsales.Rows.Count > 0)
                {
                    for (var i = 0; i < dtgetsales.Rows.Count; i++)
                    {
                        temp = temp + Convert.ToDouble(dtgetsales.Rows[i]["amount"]);
                    }
                }
                txtgrandtotal.Text = temp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            clearcart v = new clearcart();
            v.txtcashiername.Text = txtstaffname1.Text;
            v.txtgrandtotal.Text = txtgrandtotal.Text;
            v.txtsiv.Text = txtreceiptnumber.Text;
            v.txtsection.Text = txtsection.Text;
            this.Close();
            v.Show();
        }
    }
}
