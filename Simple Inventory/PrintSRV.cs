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
    public partial class PrintSRV : Form
    {
        public PrintSRV()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        GetDataBase obj = new GetDataBase();
        private void PrintSRV_Load(object sender, EventArgs e)
        {
            try
            {
                if (txtrepeatreceipt.Text == "")
                {

                    DataTable dtidentity = new DataTable();
                    dtidentity = obj.getdatabase("Select * from identity");

                    txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                    txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                    System.Data.DataTable dtgetsales = new System.Data.DataTable();
                    if (txtForm.Text == "update")
                    {
                        dtgetsales = obj.getdatabase("Select * from preupdate order by productid");
                        if (dtgetsales.Rows.Count > 0)
                        {
                            ListViewItem lstitem = new ListViewItem();
                            lsvitems.Items.Clear();

                            for (var i = 0; i < dtgetsales.Rows.Count; i++)
                            {
                                lstitem = new ListViewItem();
                                lstitem.Text = (i + 1).ToString();
                                lstitem.SubItems.Add(dtgetsales.Rows[i]["productname"].ToString());

                                lstitem.SubItems.Add(dtgetsales.Rows[i]["unitpack"].ToString());

                                lstitem.SubItems.Add(dtgetsales.Rows[i]["quantity"].ToString());
                                lstitem.SubItems.Add(dtgetsales.Rows[i]["unitrate"].ToString());
                                lstitem.SubItems.Add(dtgetsales.Rows[i]["costprice"].ToString());
                                lsvitems.Items.Add(lstitem);
                            }
                        }
                        txtstaffname1.Text = txtstaffname1.Text;
                        string time1 = null;
                        time1 = DateTime.Now.ToShortTimeString();
                        txttime.Text = time1;
                        txtlpo.Text = "EDP. ";
                        // insert Copyright symbol
                        lbcopywrite.Text = "Powered By Nozemen Nigeria Enterprise(08163775990)"; //+ Microsoft.VisualBasic.Strings.Chr(169) + ;

                    }
                    else
                    {
                        dtgetsales = obj.getdatabase("Select * from preentry order by productid");
                        if (dtgetsales.Rows.Count > 0)
                        {
                            ListViewItem lstitem = new ListViewItem();
                            lsvitems.Items.Clear();

                            for (var i = 0; i < dtgetsales.Rows.Count; i++)
                            {
                                lstitem = new ListViewItem();
                                lstitem.Text = (i + 1).ToString();
                                lstitem.SubItems.Add(dtgetsales.Rows[i]["productname"].ToString());

                                lstitem.SubItems.Add(dtgetsales.Rows[i]["unitpack"].ToString());

                                lstitem.SubItems.Add(dtgetsales.Rows[i]["quantity"].ToString());
                                lstitem.SubItems.Add(dtgetsales.Rows[i]["unitrate"].ToString());
                                lstitem.SubItems.Add(dtgetsales.Rows[i]["costprice"].ToString());
                                lsvitems.Items.Add(lstitem);
                            }
                        }
                        txtstaffname1.Text = txtstaffname1.Text;
                        string time1 = null;
                        time1 = DateTime.Now.ToShortTimeString();
                        txttime.Text = time1;
                        // insert Copyright symbol
                        lbcopywrite.Text = "Powered By Nozemen Nigeria Enterprise(08163775990)"; //+ Microsoft.VisualBasic.Strings.Chr(169) + ;

                    }
                }
                else
                {
                    DataTable dtidentity = new DataTable();
                    dtidentity = obj.getdatabase("Select * from identity");
                    double temp = 0;
                    txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
                    txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                    System.Data.DataTable dtgetsaleslog = new System.Data.DataTable();
                    dtgetsaleslog = obj.getdatabase("select * from product where srv= '" + txtrepeatreceipt.Text + "' order by productname");
                    if (dtgetsaleslog.Rows.Count > 0)
                    {
                        ListViewItem lstitem = new ListViewItem();
                        lsvitems.Items.Clear();

                        for (var i = 0; i < dtgetsaleslog.Rows.Count; i++)
                        {
                            double unitprice = Convert.ToDouble(dtgetsaleslog.Rows[i]["costprice"].ToString());
                            int quantity = Convert.ToInt16(dtgetsaleslog.Rows[i]["quantity"].ToString());
                            double unitcost = unitprice / quantity;
                            lstitem = new ListViewItem();
                            lstitem.Text = (i + 1).ToString();
                            lstitem.SubItems.Add(dtgetsaleslog.Rows[i]["productname"].ToString());

                            lstitem.SubItems.Add(dtgetsaleslog.Rows[i]["unitpack"].ToString());

                            lstitem.SubItems.Add(dtgetsaleslog.Rows[i]["quantity"].ToString());
                            lstitem.SubItems.Add(dtgetsaleslog.Rows[i]["unitrate"].ToString());
                            lstitem.SubItems.Add(dtgetsaleslog.Rows[i]["costprice"].ToString());
                            lsvitems.Items.Add(lstitem);
                            temp = temp + Convert.ToDouble(dtgetsaleslog.Rows[i]["costprice"].ToString());
                        }
                        txttotal.Text = temp.ToString();
                        //txtcash.Text = dtgetsaleslog.Rows[0]["cashpaid"].ToString();
                        //     txtdiscount1.Text = dtgetsaleslog.Rows[0]["discount"].ToString();
                        //  txtchange.Text = dtgetsaleslog.Rows[0]["changegiven"].ToString();
                        txtsrv.Text = txtrepeatreceipt.Text;
                        txtstaffname1.Text = dtgetsaleslog.Rows[0]["staffname"].ToString();
                        string time1 = null;
                        string datesold = null;
                        DateTime date = Convert.ToDateTime(dtgetsaleslog.Rows[0]["entrydate"].ToString());

                        time1 = date.ToShortTimeString();
                        datesold = date.ToLongDateString();
                        DateTimePicker1.Text = datesold;
                        txttime.Text = time1;
                        // insert Copyright symbol
                        //  lbcopywrite.Text = "Copyright " + Microsoft.VisualBasic.Strings.Chr(169) + "2020 OZ Concepts(08163775990)";
                        lbcopywrite.Text = "Powered By Nozemen Nigeria Enterprise(08163775990)"; //+ Microsoft.VisualBasic.Strings.Chr(169) + ;

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font font = new Font("arial", 18F, FontStyle.Bold);
                Font fontx = new Font("arial", 16F, FontStyle.Bold);
                Font font1 = new Font("arial", 14F, FontStyle.Regular);
                Font font2 = new Font("arial", 14F, FontStyle.Regular);
                Font font3 = new Font("arial", 16F, FontStyle.Regular);
                int j = 30;
                e.Graphics.DrawString(txtname.Text, font, Brushes.Black, 80, j);
                e.Graphics.DrawString(txtaddress.Text, fontx, Brushes.Black, 170, j+30);
                e.Graphics.DrawString(label8.Text, fontx, Brushes.Black, 280, j + 60);
                e.Graphics.DrawString(label9.Text, fontx, Brushes.Black, 250, j + 90);
                e.Graphics.DrawString(label10.Text, fontx, Brushes.Black, 280, j + 120);
                Pen mypen1 = null;
                mypen1 = new Pen(Color.Black, Height = 1);
                e.Graphics.DrawLine(mypen1, x1: 10,y1: j + 140, x2: 700, y2: j + 140);

                e.Graphics.DrawString(lbhospital.Text, font3, Brushes.Black, 10, j + 150);
                e.Graphics.DrawString(txtsuppliername.Text, fontx, Brushes.Black, 200, j + 150);
                e.Graphics.DrawString(Label5.Text, font2, Brushes.Black, 450, j + 150);
                e.Graphics.DrawString(txttime.Text, font2, Brushes.Black, 500, j + 150);
                e.Graphics.DrawString(Label6.Text, font2, Brushes.Black, 600, j + 150);
                e.Graphics.DrawString(DateTimePicker1.Value.Date.ToShortDateString(), font2, Brushes.Black, 650, j + 150);

                e.Graphics.DrawString(Label4.Text, font2, Brushes.Black, 10, j + 180);
                e.Graphics.DrawString(txtsrv.Text, font3, Brushes.Black, 100, j + 180);
                e.Graphics.DrawString(lbsection.Text, font2, Brushes.Black, 300, j + 180);
                e.Graphics.DrawString(txtsection.Text, font3, Brushes.Black, 370, j + 180);
                e.Graphics.DrawString(label1.Text, font2, Brushes.Black, 450, j + 180);
                e.Graphics.DrawString(txtlpo.Text, font3, Brushes.Black, 550, j + 180);

                e.Graphics.DrawString(Label3.Text, font2, Brushes.Black, 10, j + 210);
                e.Graphics.DrawString(txtstaffname1.Text, font3, Brushes.Black, 70, j + 210);
                 j = 240;
                int k = 10;
                Font headerFont = new Font("Arial", 14F, FontStyle.Bold);
                j = j + 30;

                foreach (ColumnHeader ch in lsvitems.Columns)
                {
                    if (ch.DisplayIndex == 1)
                    {
                        e.Graphics.DrawString(ch.Text, headerFont, Brushes.Black, k, j);
                        k = k + 250;

                    }
                    else
                    {
                        e.Graphics.DrawString(ch.Text, headerFont, Brushes.Black, k, j);
                        k = k + 100;

                    }


                }
                j = j + 30;
                for (var i = 0; i < lsvitems.Items.Count; i++)
                {
                    string snumber = lsvitems.Items[i].Text;
                    e.Graphics.DrawString(snumber, font2, Brushes.Black, 10, j);

                    string intlistname = lsvitems.Items[i].SubItems[1].Text;
                    e.Graphics.DrawString(intlistname, font2, Brushes.Black, 40, j);
                    string unitpack = lsvitems.Items[i].SubItems[2].Text;
                    e.Graphics.DrawString(unitpack, font2, Brushes.Black, 360, j);

                    int intlistquantity = Convert.ToInt32(lsvitems.Items[i].SubItems[3].Text);
                    e.Graphics.DrawString(intlistquantity.ToString(), font2, Brushes.Black, 460, j);
                    //e.Graphics.DrawString(ch., headerFont, Brushes.Black, 50, j + 15)
                    double dblunitprice = Convert.ToDouble(lsvitems.Items[i].SubItems[4].Text);
                    e.Graphics.DrawString(dblunitprice.ToString(), font2, Brushes.Black, 560, j);
                    //e.Graphics.DrawString(ch.Text, headerFont, Brushes.Black, 140, j + 15)
                    double dblamount = Convert.ToDouble(lsvitems.Items[i].SubItems[5].Text);
                    e.Graphics.DrawString(dblamount.ToString(), font2, Brushes.Black, 660, j);
                    j = j + 30;
                    k = 10;
                }
                j = j + 30;
                Pen mypen = null;
                mypen = new Pen(Color.Black, Height = 1);
                e.Graphics.DrawLine(mypen, x1: 10, y1: j, x2: 700, y2: j);
                j = j + 30;
                e.Graphics.DrawString(Label7.Text, font3, Brushes.Black, 400, j);
                e.Graphics.DrawString(Label13.Text, font2, Brushes.Black, 550, j);
                e.Graphics.DrawString(txttotal.Text, font3, Brushes.Black, 600, j);
                //e.Graphics.DrawString(Label8.Text, font2, Brushes.Black, 400, j + 30);
                //e.Graphics.DrawString(Label14.Text, font2, Brushes.Black, 550, j + 30);
                //e.Graphics.DrawString(txtcash.Text, font3, Brushes.Black, 600, j + 30);
                ////e.Graphics.DrawString(Label16.Text, font2, Brushes.Black, 100, j + 40);
                ////e.Graphics.DrawString(Label17.Text, font2, Brushes.Black, 160, j + 40);
                ////e.Graphics.DrawString(txtdiscount1.Text, font3, Brushes.Black, 210, j + 40);
                //e.Graphics.DrawString(Label9.Text, font2, Brushes.Black, 400, j + 60);
                //e.Graphics.DrawString(Label15.Text, font2, Brushes.Black, 550, j + 60);
                //e.Graphics.DrawString(txtchange.Text, font3, Brushes.Black, 600, j + 60);
                ////e.Graphics.DrawString(Label10.Text, font, Brushes.Black, 60, j + 80)
                //e.Graphics.DrawString(Label11.Text, font2, Brushes.Black, 80, j + 120);
                //e.Graphics.DrawString(Label12.Text, font2, Brushes.Black, 30, j + 150);
                e.Graphics.DrawString(lbissuer.Text, font2, Brushes.Black, 10, j + 520);

                e.Graphics.DrawString(lbreceiver.Text, font2, Brushes.Black, 550, j + 520);

                e.Graphics.DrawString(lbcopywrite.Text, font2, Brushes.Black, 10, j + 580);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            printDocument1.Print();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                if (txtForm.Text == "update")
                {
                    dtgetsales = obj.getdatabase("Select* from preupdate");
                    string strconnection = "";
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Delete from preupdate where productid>0";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    txttotal.Text = "";
                    // txtcash.Text = "";
                    //txtchange.Text = "";
                    txtsrv.Text = "";
                    //  txtdiscount1.Text = "";
                    //sales x = new sales();
                    //x.discount = 0;
                    lsvitems.Clear();
                    txtForm.Text = "";
                    MessageBox.Show("Thanks You! You Don Succeed To Update The Items");

                }
                else
                {
                    dtgetsales = obj.getdatabase("Select* from preentry");
                    string strconnection = "";
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Delete from preentry where productid>0";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    txttotal.Text = "";
                    // txtcash.Text = "";
                    //txtchange.Text = "";
                    txtsrv.Text = "";
                    //  txtdiscount1.Text = "";
                    //sales x = new sales();
                    //x.discount = 0;
                    lsvitems.Clear();
                    txtForm.Text = "";

                    MessageBox.Show("Thanks You! You Don Succeed To Update The Items");

                }
                this.Close();

                //  MessageBox.Show("Well done! Just CLICK ON THE FORM to get update from the Database.");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
 
        
    }
}
