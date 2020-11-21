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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnmanageuser_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtadminname.Text))
                {
                    MessageBox.Show("Please Enter Your User Name");
                }
                else if (string.IsNullOrEmpty(txtadminpassword.Text))
                {
                    MessageBox.Show("Please Enter Your Password");
                }
                else
                {
                    System.Data.DataTable dtgetadmin = new System.Data.DataTable();
                    dtgetadmin =x. getdatabase("select * from administrator");
                    for (var i = 0; i < dtgetadmin.Rows.Count; i++)
                    {
                        if (txtadminname.Text.ToUpper() == Convert.ToString(dtgetadmin.Rows[i]["adminname"]).ToUpper() && txtadminpassword.Text == (dtgetadmin.Rows[i]["adminpassword"]).ToString())
                        {
                            ManageUsers obj = new ManageUsers();
                            obj.MdiParent = Form1.ActiveForm;
                            obj.WindowState = FormWindowState.Maximized;
                            obj.lbadmin.Text = txtadminname.Text;
                            this.Close();
                            obj.Show();
                            //goto breake1;
                        }
                        else
                        {
                            MessageBox.Show("Please Examine Your Entry carefully or look for the ADMINISTRATOR");
                        }
                    }
                }
                txtadminname.Text = "";
                txtadminpassword.Text = "";


               
                //breake1:;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
        GetDataBase x = new GetDataBase();
        private void Admin_Load(object sender, EventArgs e)
        {
            DataTable dtidentity = new DataTable();
            dtidentity = x.getdatabase("Select * from identity");
            txtname.Text = dtidentity.Rows[0]["businessName"].ToString();
            txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
            lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();

        }
    }
}
