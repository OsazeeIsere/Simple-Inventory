﻿using System;
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
            this.Close();
            Activity obj = new Activity();
            obj.MdiParent = Form1.ActiveForm;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();

        }
    }
}
