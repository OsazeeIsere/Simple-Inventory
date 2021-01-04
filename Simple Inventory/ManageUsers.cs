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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void btnoperation_Click(object sender, EventArgs e)
        {
            Manage_Stock obj = new Manage_Stock();
            obj.txtstaffname1.Text = lbadmin.Text;
            obj.Show();

        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {

        }

        private void btnaddbackup_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                MySqlCommand cm = new MySqlCommand();
                System.Data.DataTable dtgetbackup = new System.Data.DataTable();
                string strconnection = "";
                strconnection = "server= localhost;port=3306;database=edp;uid=root;pwd=prayer";
                cn.ConnectionString = strconnection;
                cn.Open();
               // dtgetbackup = x.getdatabase("Select * From staff");
                if (string.IsNullOrEmpty(txtbackupname.Text))
                {
                    MessageBox.Show("Please Enter Your User Name");
                }
                else if (string.IsNullOrEmpty(txtbackuppassword1.Text))
                {
                    MessageBox.Show("Please Enter Your Password");
                }
                else if (txtbackuppassword1.Text != txtbackuppassword2.Text)
                {
                    MessageBox.Show("Please there is PASSWORD MISMATCH");
                    //the next code ensure that backup is not more than 2
                }
                else
                {
                    cm.CommandText = "Insert Into staff(staffname,staffpassword) Values('" + txtbackupname.Text + "','" + txtbackuppassword1.Text + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("The User is Registered");
                    txtbackupname.Text = "";
                    txtbackuppassword1.Text = "";
                    txtbackuppassword2.Text = "";
                }
                txtbackupname.Text = "";
                txtbackuppassword1.Text = "";
                txtbackuppassword2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
