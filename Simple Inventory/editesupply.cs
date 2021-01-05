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
    public partial class editesupply : Form
    {
        public editesupply()
        {
            InitializeComponent();
        }
        GetDataBase obj = new GetDataBase();
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
                dtgetsales = obj.getdatabase("Select* from supply");
                string strconnection = "";
                strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;
                cn.Open();
                cm.CommandText = "Delete from supply where transactionid=" + Convert.ToInt32(txttransactionid.Text) + ";";
                //& intproductid & ";"
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                dtgetsales =obj. getdatabase("select amount from supply");
                double temp = 0;
                if (dtgetsales.Rows.Count > 0)
                {
                    for (var i = 0; i < dtgetsales.Rows.Count; i++)
                    {
                        temp = temp + Convert.ToDouble(dtgetsales.Rows[i]["amount"]);
                    }
                }
                ViewSupply v = new ViewSupply();
                v.txtsection.Text = txtsection.Text;
                v.txtstaffname1.Text = txtcashiername1.Text;
                v.txtreceiptnumber.Text = txtsiv.Text;
                v.txtgrandtotal.Text = temp.ToString();
                v.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ViewSupply v = new ViewSupply();
            v.txtsection.Text = txtsection.Text;
            v.txtstaffname1.Text = txtcashiername1.Text;
            v.txtreceiptnumber.Text = txtsiv.Text;
            v.txtgrandtotal.Text = txtgrandtotal.Text;
            this.Close();
            v.Show();
        }

        private void txtsection_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsiv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgrandtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void editesupply_Load(object sender, EventArgs e)
        {

        }
    }
}
