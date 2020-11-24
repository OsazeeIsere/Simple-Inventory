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

        private void Button1_Click(object sender, EventArgs e)
        {
            Manage_Stock obj = new Manage_Stock();
            //obj.MdiParent = Form1.ActiveForm;
            //obj.WindowState = FormWindowState.Maximized;
            obj.Show();

        }
    }
}
