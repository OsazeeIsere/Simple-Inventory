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
            this.Close();
            ManageUsers obj = new ManageUsers();
            obj.MdiParent = Form1.ActiveForm;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();

        }
    }
}
