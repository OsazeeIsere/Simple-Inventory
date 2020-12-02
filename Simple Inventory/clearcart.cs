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
    public partial class clearcart : Form
    {
        public clearcart()
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
                cm.CommandText = "Delete from supply where transactionid>0";
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                ViewSupply v = new ViewSupply();
                v.txtgrandtotal.Text = "";
                v.txtsection.Text = "";
                v.txtreceiptnumber.Text = "";
                v.txtstaffname1.Text = txtcashiername.Text;
                this.Close();
                v.lsvitems.Clear();
                v.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ViewSupply v = new ViewSupply();
            v.txtstaffname1.Text = txtcashiername.Text;
            v.txtgrandtotal.Text = txtgrandtotal.Text;
            v.txtreceiptnumber.Text = txtsiv.Text;
            v.txtsection.Text = txtsection.Text;
            this.Close();
            v.Show();

        }
    }
}
