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
    public partial class Delete : Form
    {
        public Delete()
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
                System.Data.DataTable dtgetexpirydate = new System.Data.DataTable();
                dtgetexpirydate = obj.getdatabase("Select * From expirydate where productid=" + Convert.ToInt32(txtproductid.Text));
                string strconnection = "";
                strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;
                cn.Open();
                cm.CommandText = "Delete from product where productid=" + Convert.ToInt32(txtproductid.Text) + ";";
                //& intproductid & ";"
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                cn.Close();
                cn.Open();
                cm.CommandText = "Delete from expirydate where productid=" + Convert.ToInt32(txtproductid.Text) + ";";
                //& intproductid & ";"
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                cn.Close();
                Manage_Stock v = new Manage_Stock();
                v.txtstaffname1.Text = txtstaffname.Text;
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
            this.Close();
            Manage_Stock v = new Manage_Stock();
            v.txtstaffname1.Text = txtstaffname.Text;

            v.Show();

        }

        private void Delete_Load(object sender, EventArgs e)
        {
            txtstaffname.Visible = false;
        }

        private void txtproductname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtproductid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void txtstaffname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

