﻿using System;
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
    public partial class expiryDateInfo : Form
    {
        public expiryDateInfo()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {
            try
            {
                int months = 0;
                int months1 = 0;
                int year = 0;
                int year1 = 0;
                int monthdiff1 = 0;
                int yeardiff = 0;
                int totalmonths = 0;
                DateTime dateOne = default(DateTime);
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                System.Data.DataTable dtgetproduct1 = new System.Data.DataTable();
                if (string.IsNullOrEmpty(ComboBox1.Text))
                {
                    MessageBox.Show("Please Select the period under which to examine the EXPIRY DATE INFO");
                    ComboBox1.Focus();
                }
                else if ((ComboBox1.Text) == "Three Months(3) Time")
                {
                    dtgetproduct = obj.getdatabase("Select * from expirydate");
                    if (dtgetproduct.Rows.Count > 0)
                    {
                        ListViewItem lstitem = new ListViewItem();
                        lsvitems.Items.Clear();
                        for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                        {
                            lstitem = new ListViewItem();
                            dateOne = Convert.ToDateTime(dtgetproduct.Rows[j]["expirydate"]);
                            months = dateOne.Month;
                            months1 = DateTimePicker1.Value.Month;
                            monthdiff1 = 12 - months1;
                            year = dateOne.Year;
                            year1 = DateTimePicker1.Value.Year;
                            //this helps to capture the full years  
                            yeardiff = ((year - 1) - (year1 + 1)) + 1;
                            totalmonths = (months + monthdiff1) + (12 * yeardiff);
                            if (totalmonths > -1 && totalmonths < 4)
                            {
                                lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["costperunitrate"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                                lsvitems.Items.Add(lstitem);
                            }
                        }
                        lsvitems.ForeColor = Color.IndianRed;
                        txttotal.Text = lsvitems.Items.Count.ToString();
                    }
                }
                else if ((ComboBox1.Text) == "Six Months(6) Time")
                {
                    dtgetproduct = obj.getdatabase("Select * from expirydate");
                    if (dtgetproduct.Rows.Count > 0)
                    {
                        ListViewItem lstitem = new ListViewItem();
                        lsvitems.Items.Clear();
                        for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                        {
                            lstitem = new ListViewItem();
                            dateOne = Convert.ToDateTime(dtgetproduct.Rows[j]["expirydate"]);
                            months = dateOne.Month;
                            months1 = DateTimePicker1.Value.Month;
                            monthdiff1 = 12 - months1;
                            year = dateOne.Year;
                            year1 = DateTimePicker1.Value.Year;
                            //this helps to capture the full years  
                            yeardiff = ((year - 1) - (year1 + 1)) + 1;
                            totalmonths = (months + monthdiff1) + (12 * yeardiff);
                            if (totalmonths > -1 && totalmonths < 7)
                            {
                                lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["costperunitrate"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                                lsvitems.Items.Add(lstitem);

                            }
                        }
                        lsvitems.ForeColor = Color.Red;
                        txttotal.Text = lsvitems.Items.Count.ToString();
                    }
                }
                else if ((ComboBox1.Text) == "Above Six Months(6) Time")
                {
                    dtgetproduct = obj.getdatabase("Select * from expirydate");
                    if (dtgetproduct.Rows.Count > 0)
                    {
                        ListViewItem lstitem = new ListViewItem();
                        lsvitems.Items.Clear();
                        for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                        {
                            lstitem = new ListViewItem();
                            dateOne = Convert.ToDateTime(dtgetproduct.Rows[j]["expirydate"]);
                            months = dateOne.Month;
                            months1 = DateTimePicker1.Value.Month;
                            monthdiff1 = 12 - months1;
                            year = dateOne.Year;
                            year1 = DateTimePicker1.Value.Year;
                            //this helps to capture the full years  
                            yeardiff = ((year - 1) - (year1 + 1)) + 1;
                            totalmonths = (months + monthdiff1) + (12 * yeardiff);
                            if (totalmonths > 6)
                            {
                                lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["costperunitrate"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                                lsvitems.Items.Add(lstitem);
                            }
                        }
                        lsvitems.ForeColor = Color.Green;
                        txttotal.Text = lsvitems.Items.Count.ToString();
                    }
                }
                else if ((ComboBox1.Text) == "Drugs Already Expired")
                {
                    dtgetproduct = obj.getdatabase("Select * from expirydate");
                    if (dtgetproduct.Rows.Count > 0)
                    {
                        ListViewItem lstitem = new ListViewItem();
                        lsvitems.Items.Clear();
                        for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                        {
                            lstitem = new ListViewItem();
                            dateOne = Convert.ToDateTime(dtgetproduct.Rows[j]["expirydate"]);
                            months = dateOne.Month;
                            months1 = DateTimePicker1.Value.Month;
                            monthdiff1 = 12 - months1;
                            year = dateOne.Year;
                            year1 = DateTimePicker1.Value.Year;
                            //this helps to capture the full years  
                            yeardiff = ((year - 1) - (year1 + 1)) + 1;
                            totalmonths = (months + monthdiff1) + (12 * yeardiff);
                            if (totalmonths < 0)
                            {
                                lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["costperunitrate"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                                lsvitems.Items.Add(lstitem);

                            }
                        }
                        lsvitems.ForeColor = Color.Black;
                        txttotal.Text = lsvitems.Items.Count.ToString();
                    }
                }
                else if ((ComboBox1.Text) == "Drugs That Will Expire This Month")
                {
                    dtgetproduct = obj.getdatabase("Select * from expirydate");
                    if (dtgetproduct.Rows.Count > 0)
                    {
                        ListViewItem lstitem = new ListViewItem();
                        lsvitems.Items.Clear();
                        for (var j = 0; j < dtgetproduct.Rows.Count; j++)
                        {
                            lstitem = new ListViewItem();
                            dateOne = Convert.ToDateTime(dtgetproduct.Rows[j]["expirydate"]);
                            months = dateOne.Month;
                            months1 = DateTimePicker1.Value.Month;
                            monthdiff1 = 12 - months1;
                            year = dateOne.Year;
                            year1 = DateTimePicker1.Value.Year;
                            //this helps to capture the full years  
                            yeardiff = ((year - 1) - (year1 + 1)) + 1;
                            totalmonths = (months + monthdiff1) + (12 * yeardiff);
                            if (totalmonths == 0)
                            {
                                lstitem.Text = dtgetproduct.Rows[j]["productid"].ToString();
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["productname"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["quantity"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["section"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitpack"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["costperunitrate"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["entrydate"].ToString());
                                lsvitems.Items.Add(lstitem);
                            }
                        }
                        lsvitems.ForeColor = Color.Red;
                        txttotal.Text = lsvitems.Items.Count.ToString();
                    }
                }
                else if ((ComboBox1.Text) == "All Drugs")
                {
                    try
                    {
                        // Use TimeSpan and some date calculaton, this should work:
                        dtgetproduct = obj.getdatabase("Select * From expirydate order by productname");
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
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["costperunitrate"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                                lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());

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
            }
            catch (Exception ex)
            {
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lsvitems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        GetDataBase obj = new GetDataBase();
        private void expiryDateInfo_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtidentity = new DataTable();
                dtidentity = obj.getdatabase("Select * from identity");

                txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                // lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

                // Use TimeSpan and some date calculaton, this should work:
                System.Data.DataTable dtgetproduct = new System.Data.DataTable();
                dtgetproduct = obj.getdatabase("Select * From expirydate order by productname");
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
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["costprice"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitrate"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["costperunitrate"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["unitsalesprice"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["batch"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["srv"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["datepurchased"].ToString());

                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["expirydate"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["suppliername"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["supplierphonenumber"].ToString());
                        lstitem.SubItems.Add(dtgetproduct.Rows[j]["invoicenumber"].ToString());

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
    }
}