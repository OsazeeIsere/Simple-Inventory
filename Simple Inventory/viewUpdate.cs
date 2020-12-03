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
                dtgetpreupdate = x.getdatabase("Select * from preupdate");
                strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;
                for (int i = 0; i < dtgetpreupdate.Rows.Count; i++)
                {
                    intproductid = Convert.ToInt32(dtgetpreupdate.Rows[i]["productid"].ToString());
                    
                    dtgetproduct = x.getdatabase("Select quantity from product where productid= '" + dtgetpreupdate.Rows[i]["productid"].ToString() + "'");

                    cn.Open();
                    newquantity = Convert.ToInt32(dtgetproduct.Rows[0]["quantity"]) + Convert.ToInt32(dtgetpreupdate.Rows[i]["quantity"].ToString());
                    cm.CommandText = "Update product Set productname='" + dtgetpreupdate.Rows[i]["productname"].ToString() + "',quantity =" + newquantity + ",section='" + dtgetpreupdate.Rows[i]["section"].ToString() + "',unitpack='" + dtgetpreupdate.Rows[i]["unitpack"].ToString() + "',costprice=" + dtgetpreupdate.Rows[i]["costprice"].ToString() + ",unitrate=" + dtgetpreupdate.Rows[i]["unitrate"].ToString() + ",unitsalesprice=" + dtgetpreupdate.Rows[i]["unitsalesprice"].ToString() + ",batch='" + dtgetpreupdate.Rows[i]["batch"].ToString() + "',expirydate='" + dtgetpreupdate.Rows[i]["expirydate"].ToString() + "',datepurchased='" + dtgetpreupdate.Rows[i]["datepurchased"].ToString() + "',barcode='" + dtgetpreupdate.Rows[i]["barcode"].ToString() + "' Where productid=" + intproductid + ";";
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
                for (int v = 0; v < dtgetpreupdate.Rows.Count; v++)
                {
                    string strconnection = "";
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Delete from preupdate where productid>0";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    lsvitems.Clear();

                }
                MessageBox.Show("Thanks You! You Don Succeed To Update The Items");
                this.Close();

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
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                        //  lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                        lsvitems.Items.Add(lstitem);
                    }
                    // txttotal.Text = dtgetproduct.Rows.Count.ToString();

                }
                //  txtcode.Focus();
                txttime.Text = DateTimePicker1.Value.ToShortTimeString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }

        }
    }
}
