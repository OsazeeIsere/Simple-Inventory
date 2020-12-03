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
    public partial class viewEntry : Form
    {
        public viewEntry()
        {
            InitializeComponent();
        }

        private void Label10_Click(object sender, EventArgs e)
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

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Dim intpersonid = CInt(studentinfo.dgvnames.SelectedCells(0).Value)
                DataTable dtgetpreentry = new DataTable();
                dtgetpreentry = x.getdatabase("Select * from preentry");
                strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;
                for(int i=0;i< dtgetpreentry.Rows.Count; i++)
                {
                
                cn.Open();
                cm.CommandText = "Insert Into product(productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,batch,srv,expirydate,datepurchased,barcode) Values('" + dtgetpreentry.Rows[i]["productname"].ToString() + "','" + dtgetpreentry.Rows[i]["quantity"].ToString() + "','" + dtgetpreentry.Rows[i]["section"].ToString() + "','" + dtgetpreentry.Rows[i]["unitpack"].ToString() + "','" + dtgetpreentry.Rows[i]["costprice"].ToString() + "','" + dtgetpreentry.Rows[i]["unitrate"].ToString() + "','" + dtgetpreentry.Rows[i]["unitsalesprice"].ToString() + "','" + dtgetpreentry.Rows[i]["batch"].ToString() + "','" + txtSrv.Text + "','" + dtgetpreentry.Rows[i]["datepurchased"].ToString() + "','" + dtgetpreentry.Rows[i]["expirydate"].ToString() + "','" + dtgetpreentry.Rows[i]["barcode"].ToString() + "')";
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
                cm.CommandText = "Insert Into expirydate(productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,batch,srv,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber) Values('" + dtgetpreentry.Rows[i]["productname"].ToString() + "','" + dtgetpreentry.Rows[i]["quantity"].ToString() + "','" + dtgetpreentry.Rows[i]["section"].ToString() + "','" + dtgetpreentry.Rows[i]["unitpack"].ToString() + "','" + dtgetpreentry.Rows[i]["costprice"].ToString() + "','" + dtgetpreentry.Rows[i]["unitrate"].ToString() + "','" + dtgetpreentry.Rows[i]["unitsalesprice"].ToString() + "','" + dtgetpreentry.Rows[i]["batch"].ToString() + "','" + txtSrv.Text + "','" + dtgetpreentry.Rows[i]["datepurchased"].ToString() + "','" + dtgetpreentry.Rows[i]["expirydate"].ToString() + "','" + dtgetpreentry.Rows[i]["barcode"].ToString() + "','" + dtgetpreentry.Rows[i]["suppliername"].ToString() + "','" + dtgetpreentry.Rows[i]["supplierphonenumber"].ToString() + "','"+ dtgetpreentry.Rows[i]["invoicenumber"].ToString() + "')";
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                cn.Close();
                cn.Open();
                cm.CommandText = "Insert Into purchasehistory(productname,quantity,section,unitpack,costprice,unitrate,unitsalesprice,batch,srv,expirydate,datepurchased,barcode,suppliername,supplierphonenumber,invoicenumber) Values('" + dtgetpreentry.Rows[i]["productname"].ToString() + "','" + dtgetpreentry.Rows[i]["quantity"].ToString() + "','" + dtgetpreentry.Rows[i]["section"].ToString() + "','" + dtgetpreentry.Rows[i]["unitpack"].ToString() + "','" + dtgetpreentry.Rows[i]["costprice"].ToString() + "','" + dtgetpreentry.Rows[i]["unitrate"].ToString() + "','" + dtgetpreentry.Rows[i]["unitsalesprice"].ToString() + "','" + dtgetpreentry.Rows[i]["batch"].ToString() + "','" + txtSrv.Text + "','" + dtgetpreentry.Rows[i]["datepurchased"].ToString() + "','" + dtgetpreentry.Rows[i]["expirydate"].ToString() + "','" + dtgetpreentry.Rows[i]["barcode"].ToString() + "','" + dtgetpreentry.Rows[i]["suppliername"].ToString() + "','" + dtgetpreentry.Rows[i]["supplierphonenumber"].ToString() + "','" + dtgetpreentry.Rows[i]["invoicenumber"].ToString() + "')";
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                cn.Close();
                }
              
                    
                    //txttotal.Text = dtgetproduct.Rows.Count.ToString();
                
                txtproductname.Text = "";
                txtquantity.Text = "";
                for(int v=0; v< dtgetpreentry.Rows.Count; v++)
                {
                    string strconnection = "";
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Delete from preentry where productid>0";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    lsvitems.Clear();

                }
                MessageBox.Show("Thanks You! You Don Succeed To Enter The New Items");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

}

        private void viewEntry_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtidentity = new DataTable();
                dtidentity = x.getdatabase("Select * from identity");
                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                //       lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                dtgetproduct = x.getdatabase("Select * from preentry");
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
