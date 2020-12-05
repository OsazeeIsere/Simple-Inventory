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
    public partial class ReorderLevel : Form
    {
        public ReorderLevel()
        {
            InitializeComponent();
        }
        GetDataBase obj = new GetDataBase();
        private void check_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                System.Data.DataTable dtgetproduct1 = new System.Data.DataTable();
                if (string.IsNullOrEmpty(ComboBox1.Text))
                {
                    MessageBox.Show("Please Select the ReOrder Level");
                    ComboBox1.Focus();
                }
                else if ((ComboBox1.Text) == "Products Less Than 10 units in Stock")
                {
                    dtgetproduct =obj. getdatabase("select * from product where quantity <" + 10 + "");
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
                            // lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                            //lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                            //lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvitems.Items.Add(lstitem);
                        }
                        lsvitems.ForeColor = Color.Red;
                        txttotal.Text = lsvitems.Items.Count.ToString();
                    }
                    else
                    {
                        ListViewItem lstitem = new ListViewItem();
                        lsvitems.Items.Clear();
                    }
                }
                else if ((ComboBox1.Text) == "Products Less Than 20 units in Stock")
                {
                    dtgetproduct = obj.getdatabase("select * from product where quantity <" + 20 + "");
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
                            // lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                            //lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                            //lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvitems.Items.Add(lstitem);
                        }
                        lsvitems.ForeColor = Color.DeepPink;
                        txttotal.Text = lsvitems.Items.Count.ToString();
                    }
                    else
                    {
                        ListViewItem lstitem = new ListViewItem();
                        lsvitems.Items.Clear();
                    }
                }
                else if ((ComboBox1.Text) == "Products Less Than 50 units in Stock")
                {
                    dtgetproduct = obj.getdatabase("select * from product where quantity <" + 50 + "");
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
                            // lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                            //lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                            //lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvitems.Items.Add(lstitem);
                        }
                        lsvitems.ForeColor = Color.Green;
                        txttotal.Text = lsvitems.Items.Count.ToString();
                    }
                    else
                    {
                        ListViewItem lstitem = new ListViewItem();
                        lsvitems.Items.Clear();
                    }
                }
                else if ((ComboBox1.Text) == "Products Above  50 units in Stock")
                {
                    dtgetproduct = obj.getdatabase("select * from product where quantity >" + 50 + "");
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
                            // lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                            //lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                            //lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvitems.Items.Add(lstitem);
                        }
                        lsvitems.ForeColor = Color.Green;
                        txttotal.Text = lsvitems.Items.Count.ToString();
                    }
                    else
                    {
                        ListViewItem lstitem = new ListViewItem();
                        lsvitems.Items.Clear();
                    }
                }
                else if ((ComboBox1.Text) == "Products Less Than 5 units in Stock")
                {
                    dtgetproduct = obj.getdatabase("select * from product where quantity <" + 5 + "");
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
                            // lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                            //lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                            //lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                            //lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());

                            lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                            lsvitems.Items.Add(lstitem);
                        }
                        lsvitems.ForeColor = Color.Red;
                        txttotal.Text = lsvitems.Items.Count.ToString();
                    }
                    else
                    {
                        ListViewItem lstitem = new ListViewItem();
                        lsvitems.Items.Clear();
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                
                
        }
        utility u = new utility();
        private void ReorderLevel_Load(object sender, EventArgs e)
        {
            try
            {
                u.fitFormToScreen(this, 900, 1600);
                this.CenterToScreen();

                DataTable dtidentity = new DataTable();
                dtidentity = obj.getdatabase("Select * from identity");

                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                // lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

                // Use TimeSpan and some date calculaton, this should work:
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                dtgetproduct = obj.getdatabase("Select * From product order by productname");
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
                        // lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                        //lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                        //lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                        //lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                        lsvitems.Items.Add(lstitem);
                    }
                    txttotal.Text = dtgetproduct.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
    }
}
