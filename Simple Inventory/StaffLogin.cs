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
    public partial class StaffLogin : Form
    {
        public StaffLogin()
        {
            InitializeComponent();
        }
        GetDataBase x = new GetDataBase();
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtbackupname.Text))
                {
                    MessageBox.Show("Please Enter Your User Name");
                }
                else if (string.IsNullOrEmpty(txtbackuppassword.Text))
                {
                    MessageBox.Show("Please Enter Your Password");
                }
                else
                {
                    System.Data.DataTable dtgetadmin = new System.Data.DataTable();
                    dtgetadmin = x.getdatabase("select * from staff");
                    for (var i = 0; i < dtgetadmin.Rows.Count; i++)
                    {
                        if (txtbackupname.Text.ToUpper() == Convert.ToString(dtgetadmin.Rows[i]["staffname"]).ToUpper() && txtbackuppassword.Text == (dtgetadmin.Rows[i]["staffpassword"]).ToString())
                        {
                            Manage_Stock obj = new Manage_Stock();
                            //obj.MdiParent = Form1.ActiveForm;
                            //obj.WindowState = FormWindowState.Maximized;
                            obj.txtstaffname1.Text = txtbackupname.Text;
                            this.Close();
                            obj.Show();
                            //goto breake1;
                        }
                        else
                        {
                            MessageBox.Show("Please Examine Your Entry carefully");
                        }
                    }
                }
                txtbackupname.Text = "";
                txtbackuppassword.Text = "";
                //breake1:;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

                  }

        private void StaffLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
