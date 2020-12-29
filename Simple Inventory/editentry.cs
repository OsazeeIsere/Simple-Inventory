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
    public partial class editentry : Form
    {
        public editentry()
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

                if (txtgrandtotal.Text == "")
                {
                dtgetsales = obj.getdatabase("Select* from preentry");
                string strconnection = "";
                strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;
                cn.Open();
                cm.CommandText = "Delete from preentry where productid=" + Convert.ToInt32(txttransactionid.Text) + ";";
                //& intproductid & ";"
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                viewEntry v = new viewEntry();
                v.txtsection.Text = txtsection.Text;
                v.txtstaffname1.Text = txtcashiername1.Text;
                v.txtSrv.Text = txtsiv.Text;
                    v.txtsuppliername.Text = txtsuppliername.Text;
                v.Show();
                }
                else if(txtgrandtotal.Text == "update")
                {
                    dtgetsales = obj.getdatabase("Select* from preupdate");
                    string strconnection = "";
                    strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                    cn.ConnectionString = strconnection;
                    cn.Open();
                    cm.CommandText = "Delete from preupdate where productid=" + Convert.ToInt32(txttransactionid.Text) + ";";
                    //& intproductid & ";"
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    viewUpdate  v= new viewUpdate();
                    v.txtsection.Text = txtsection.Text;
                    v.txtstaffname1.Text = txtcashiername1.Text;
                    v.txtSrv.Text = txtsiv.Text;
                    v.txtsuppliername.Text = txtsuppliername.Text;

                    v.Show();
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (txtgrandtotal.Text == "")
            {
                viewEntry v = new viewEntry();
                v.txtsection.Text = txtsection.Text;
                v.txtstaffname1.Text = txtcashiername1.Text;
                v.txtSrv.Text = txtsiv.Text;
                v.txtsuppliername.Text = txtsuppliername.Text;

                this.Close();
                v.Show();

            }
            else if (txtgrandtotal.Text == "update")
            {
                       
            viewUpdate v = new viewUpdate();
            v.txtsection.Text = txtsection.Text;
            v.txtstaffname1.Text = txtcashiername1.Text;
            v.txtSrv.Text = txtsiv.Text;
                v.txtsuppliername.Text = txtsuppliername.Text;

                this.Close();
            v.Show();
            }
        }
    }
}
