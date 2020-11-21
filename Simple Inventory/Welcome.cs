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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        GetDataBase x = new GetDataBase();

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin obj = new Admin();
            obj.MdiParent = Form1.ActiveForm;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            this.Close();
            StaffLogin obj = new StaffLogin();
            obj.MdiParent = Form1.ActiveForm;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            button2.Hide();
            //BackColor = Color.Orange;
            DataTable dtidentity = new DataTable();
            dtidentity = x.getdatabase("Select * from identity");
            if (dtidentity.Rows.Count > 0)
            {
                txtname.Text = " WELCOME TO " + dtidentity.Rows[0]["businessName"].ToString();
                txtaddress.Text = dtidentity.Rows[0]["address"].ToString();
                txttel.Text = dtidentity.Rows[0]["telephone"].ToString();

            }
            else
            {

                button2.Show();
            }

        }
    }
}
