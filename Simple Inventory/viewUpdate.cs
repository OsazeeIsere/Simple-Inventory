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

namespace Simple_Inventory
{
    public partial class viewUpdate : Form
    {
        public viewUpdate()
        {
            InitializeComponent();
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
        int newquantity = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Dim intpersonid = CInt(studentinfo.dgvnames.SelectedCells(0).Value)
                DataTable dtgetpreupdate = new DataTable();
               // int intproductid = 0;
                dtgetpreupdate = x.getdatabase("Select * from preupdate");
                strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;
                for (int i = 0; i < dtgetpreupdate.Rows.Count; i++)
                {
                    intproductid = Convert.ToInt32(dtgetpreupdate.Rows[i]["productid"].ToString());
                    
                    dtgetproduct = x.getdatabase("Select quantity from product where productid= " + intproductid + "");

                    cn.Open();
                    newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"].ToString()) + Convert.ToInt32(dtgetpreupdate.Rows[i]["quantity"].ToString());
                    cm.CommandText = "Update product Set productname='" + dtgetpreupdate.Rows[i]["productname"].ToString() + "',quantity =" + newquantity + ",section='" + dtgetpreupdate.Rows[i]["section"].ToString() + "',unitpack='" + dtgetpreupdate.Rows[i]["unitpack"].ToString() + "',costprice=" + dtgetpreupdate.Rows[i]["costprice"].ToString() + ",unitrate=" + dtgetpreupdate.Rows[i]["unitrate"].ToString() + ",unitsalesprice=" + dtgetpreupdate.Rows[i]["unitsalesprice"].ToString() + ",batch='" + dtgetpreupdate.Rows[i]["batch"].ToString() + "',expirydate='" + dtgetpreupdate.Rows[i]["expirydate"].ToString() + "',datepurchased='" + dtgetpreupdate.Rows[i]["datepurchased"].ToString() + "',srv='" + txtSrv.Text +"',barcode='" + dtgetpreupdate.Rows[i]["barcode"].ToString() + "' Where productid=" + intproductid + ";";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm.CommandText = "Update preupdate Set srv='" + txtSrv.Text + "', suppliername='" + txtsuppliername.Text + "' Where productid=" + intproductid + ";";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm.CommandText = "Insert Into expirydate(productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,batch,srv,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber) Values('" + dtgetpreupdate.Rows[i]["productname"].ToString() + "','" + dtgetpreupdate.Rows[i]["quantity"].ToString() + "','" + dtgetpreupdate.Rows[i]["section"].ToString() + "','" + dtgetpreupdate.Rows[i]["unitpack"].ToString() + "','" + dtgetpreupdate.Rows[i]["costprice"].ToString() + "','" + dtgetpreupdate.Rows[i]["unitrate"].ToString() + "','" + dtgetpreupdate.Rows[i]["unitsalesprice"].ToString() + "','" + dtgetpreupdate.Rows[i]["batch"].ToString() + "','" + txtSrv.Text + "','" + dtgetpreupdate.Rows[i]["datepurchased"].ToString() + "','" + dtgetpreupdate.Rows[i]["expirydate"].ToString() + "','" + dtgetpreupdate.Rows[i]["barcode"].ToString() + "','" + dtgetpreupdate.Rows[i]["suppliername"].ToString() + "','" + dtgetpreupdate.Rows[i]["supplierphonenumber"].ToString() + "','" + dtgetpreupdate.Rows[i]["invoicenumber"].ToString() + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    cn.Open();
                    cm.CommandText = "Insert Into purchasehistory(productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,batch,srv,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber) Values('" + dtgetpreupdate.Rows[i]["productname"].ToString() + "','" + dtgetpreupdate.Rows[i]["quantity"].ToString() + "','" + dtgetpreupdate.Rows[i]["section"].ToString() + "','" + dtgetpreupdate.Rows[i]["unitpack"].ToString() + "','" + dtgetpreupdate.Rows[i]["costprice"].ToString() + "','" + dtgetpreupdate.Rows[i]["unitrate"].ToString() + "','" + dtgetpreupdate.Rows[i]["unitsalesprice"].ToString() + "','" + dtgetpreupdate.Rows[i]["batch"].ToString() + "','" + txtSrv.Text + "','" + dtgetpreupdate.Rows[i]["datepurchased"].ToString() + "','" + dtgetpreupdate.Rows[i]["expirydate"].ToString() + "','" + dtgetpreupdate.Rows[i]["barcode"].ToString() + "','" + dtgetpreupdate.Rows[i]["suppliername"].ToString() + "','" + dtgetpreupdate.Rows[i]["supplierphonenumber"].ToString() + "','" + dtgetpreupdate.Rows[i]["invoicenumber"].ToString() + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                }
                //computeresult(intpersonid, CDbl(txtscore.Text), cbosubject.Text)
                txtproductname.Text = "";
                txtquantity.Text = "";
                PrintVoucher v = new PrintVoucher();
                //v.txtstaffname1.Text = txtstaffname1.Text;
                //v.txttotal.Text = txtgrandtotal.Text;
                //v.txtsuppliername.Text = txtsuppliername.Text;
                //v.txtsection.Text = txtsection.Text;
                //v.txtsrv.Text = txtSrv.Text;
                v.txtForm.Text = "update";
                v.Show();
                //txtgrandtotal.Text = "";
                //lsvitems.Clear();
                //this.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        private void viewUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                utility u = new utility();
                //u.fitFormToScreen(this, 900, 1600);
                //this.CenterToScreen();
                double temp = 0;
                strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;

                DataTable dtidentity = new DataTable();
                dtidentity = x.getdatabase("Select * from identity");
                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                //       lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                dtgetproduct = x.getdatabase("Select * from preupdate");
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
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                        //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                        lsvitems.Items.Add(lstitem);
                        temp = temp + Convert.ToDouble(dtgetproduct.Rows[j]["costprice"]);
                        cn.Open();
                        cm.CommandText = "Update preupdate Set runningtotal=" + temp + " Where productid=" + dtgetproduct.Rows[j]["productid"].ToString() + ";";
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        cn.Close();

                    }
                    // txttotal.Text = dtgetproduct.Rows.Count.ToString();
                    txtgrandtotal.Text = temp.ToString();
                    txttime.Text = DateTimePicker1.Value.ToShortTimeString();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                int inttransactionid = 0;
                editentry v = new editentry();
                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                string strconnection = "";
                strconnection = "server=localhost;port=3306;database=edp;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                inttransactionid = Convert.ToInt32((txttransactionid.Text).ToString());
                dtgetproduct = x.getdatabase("Select * From preupdate where productid=" + inttransactionid);
                v.txttransactionid.Text = inttransactionid.ToString();
                v.txtitemsold.Text = (dtgetproduct.Rows[0]["productname"]).ToString();
                v.txtcashiername1.Text = txtstaffname1.Text;
                v.txtsection.Text = txtsection.Text;
                v.txtsiv.Text = txtSrv.Text;
                v.txtsuppliername.Text = txtsuppliername.Text;
               // v.txtForm.Text="update"
                //vthe line below helps to use editentry form for both insersion and update
                if (ActiveForm ==viewUpdate.ActiveForm) { v.txtgrandtotal.Text = "update"; }
                //    x.txtgrandtotal.Text = txtgrandtotal.Text;
                this.Close();
                v.Show();
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

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string strconnection = null;
                int inttransactionid = 0;
                double temp = 0;
                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                if (Simulate.IsNumeric(Convert.ToInt32(lsvitems.SelectedItems[0].Text)))
                {
                    inttransactionid = Convert.ToInt32(lsvitems.SelectedItems[0].Text);
                    dtgetsales = x.getdatabase(" select * from preupdate where productid=" + inttransactionid);
                    double unitrate = Convert.ToDouble(txtcostprice.Text) / Convert.ToInt32(txtquantity.Text);
                    double unitsalesprice = unitrate + (0.25 * unitrate);
                  //  double costprice = unitrate + (0.25 * unitrate);

                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Update preupdate Set quantity='" + txtquantity.Text + "', section='" + txtsection.Text + "',unitrate=" + unitrate + ",costprice='" + txtcostprice.Text + "',unitsalesprice=" + unitsalesprice + ",productname='" + txtproductname.Text + "' Where productid=" + inttransactionid + ";";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    dtgetproduct = x.getdatabase("select * from preupdate order by productname");
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
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvitems.Items.Add(lstitem);
                            temp = temp + Convert.ToDouble(dtgetproduct.Rows[j]["costprice"]);
                        }
                        // txttotal.Text = dtgetproduct.Rows.Count.ToString();
                        txtgrandtotal.Text = temp.ToString();


                    }
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
                    dtgetsales = x.getdatabase(" select * from preupdate where productid=" + inttransactionid);
                    txtproductname.Text = (dtgetsales.Rows[0]["productname"]).ToString();
                    txttransactionid.Text = (dtgetsales.Rows[0]["productid"]).ToString();
                    txtquantity.Text = (dtgetsales.Rows[0]["quantity"]).ToString();
                    txtcostprice.Text = (dtgetsales.Rows[0]["costprice"]).ToString();
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

        private void txtSrv_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtgetsales = new DataTable();
                dtgetsales = x.getdatabase("Select* from preupdate");
                string strconnection = "";
                strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;
                cn.Open();
                cm.CommandText = "Delete from preupdate where productid>0";
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                lsvitems.Clear();
               
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
    }
}
