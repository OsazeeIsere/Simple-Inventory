namespace Simple_Inventory
{
    partial class PrintSRV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtrepeatreceipt = new System.Windows.Forms.TextBox();
            this.lbreceiver = new System.Windows.Forms.Label();
            this.lbissuer = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbsection = new System.Windows.Forms.Label();
            this.lbhospital = new System.Windows.Forms.Label();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.txtsuppliername = new System.Windows.Forms.TextBox();
            this.txtsrv = new System.Windows.Forms.TextBox();
            this.txttime = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtstaffname1 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lsvitems = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtlpo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtForm = new System.Windows.Forms.TextBox();
            this.lbcopywrite = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSalmon;
            this.panel4.Controls.Add(this.lbcopywrite);
            this.panel4.Controls.Add(this.txtForm);
            this.panel4.Controls.Add(this.txtrepeatreceipt);
            this.panel4.Controls.Add(this.lbreceiver);
            this.panel4.Controls.Add(this.lbissuer);
            this.panel4.Controls.Add(this.Label13);
            this.panel4.Controls.Add(this.Button3);
            this.panel4.Controls.Add(this.Button1);
            this.panel4.Controls.Add(this.txttotal);
            this.panel4.Controls.Add(this.Label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 659);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1360, 206);
            this.panel4.TabIndex = 208;
            // 
            // txtrepeatreceipt
            // 
            this.txtrepeatreceipt.Location = new System.Drawing.Point(183, 89);
            this.txtrepeatreceipt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtrepeatreceipt.Name = "txtrepeatreceipt";
            this.txtrepeatreceipt.Size = new System.Drawing.Size(255, 26);
            this.txtrepeatreceipt.TabIndex = 200;
            this.txtrepeatreceipt.Visible = false;
            // 
            // lbreceiver
            // 
            this.lbreceiver.AutoSize = true;
            this.lbreceiver.Location = new System.Drawing.Point(65, 126);
            this.lbreceiver.Name = "lbreceiver";
            this.lbreceiver.Size = new System.Drawing.Size(97, 20);
            this.lbreceiver.TabIndex = 204;
            this.lbreceiver.Text = "Received By";
            this.lbreceiver.Visible = false;
            // 
            // lbissuer
            // 
            this.lbissuer.AutoSize = true;
            this.lbissuer.Location = new System.Drawing.Point(65, 89);
            this.lbissuer.Name = "lbissuer";
            this.lbissuer.Size = new System.Drawing.Size(99, 20);
            this.lbissuer.TabIndex = 203;
            this.lbissuer.Text = "Approved By";
            this.lbissuer.Visible = false;
            // 
            // Label13
            // 
            this.Label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(1119, 77);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(44, 20);
            this.Label13.TabIndex = 197;
            this.Label13.Text = "NGN";
            // 
            // Button3
            // 
            this.Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button3.Location = new System.Drawing.Point(46, 57);
            this.Button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(118, 40);
            this.Button3.TabIndex = 196;
            this.Button3.Text = "Print";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button1.Location = new System.Drawing.Point(217, 53);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(118, 45);
            this.Button1.TabIndex = 193;
            this.Button1.Text = "Clear Sales";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txttotal
            // 
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotal.Location = new System.Drawing.Point(1170, 71);
            this.txttotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(161, 26);
            this.txttotal.TabIndex = 191;
            // 
            // Label7
            // 
            this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(976, 73);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(136, 25);
            this.Label7.TabIndex = 187;
            this.Label7.Text = "Grand Total";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtlpo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbsection);
            this.panel2.Controls.Add(this.lbhospital);
            this.panel2.Controls.Add(this.txtsection);
            this.panel2.Controls.Add(this.txtsuppliername);
            this.panel2.Controls.Add(this.txtsrv);
            this.panel2.Controls.Add(this.txttime);
            this.panel2.Controls.Add(this.DateTimePicker1);
            this.panel2.Controls.Add(this.txtstaffname1);
            this.panel2.Controls.Add(this.Label6);
            this.panel2.Controls.Add(this.Label5);
            this.panel2.Controls.Add(this.Label4);
            this.panel2.Controls.Add(this.Label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 237);
            this.panel2.TabIndex = 207;
            // 
            // lbsection
            // 
            this.lbsection.AutoSize = true;
            this.lbsection.Location = new System.Drawing.Point(266, 191);
            this.lbsection.Name = "lbsection";
            this.lbsection.Size = new System.Drawing.Size(67, 20);
            this.lbsection.TabIndex = 142;
            this.lbsection.Text = "Section:";
            // 
            // lbhospital
            // 
            this.lbhospital.AutoSize = true;
            this.lbhospital.Location = new System.Drawing.Point(9, 144);
            this.lbhospital.Name = "lbhospital";
            this.lbhospital.Size = new System.Drawing.Size(142, 40);
            this.lbhospital.TabIndex = 141;
            this.lbhospital.Text = "Name Of Supplier :\r\n ";
            // 
            // txtsection
            // 
            this.txtsection.Location = new System.Drawing.Point(338, 188);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(182, 26);
            this.txtsection.TabIndex = 140;
            // 
            // txtsuppliername
            // 
            this.txtsuppliername.Location = new System.Drawing.Point(149, 144);
            this.txtsuppliername.Multiline = true;
            this.txtsuppliername.Name = "txtsuppliername";
            this.txtsuppliername.ReadOnly = true;
            this.txtsuppliername.Size = new System.Drawing.Size(371, 26);
            this.txtsuppliername.TabIndex = 139;
            // 
            // txtsrv
            // 
            this.txtsrv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtsrv.Location = new System.Drawing.Point(101, 188);
            this.txtsrv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsrv.Name = "txtsrv";
            this.txtsrv.ReadOnly = true;
            this.txtsrv.Size = new System.Drawing.Size(158, 26);
            this.txtsrv.TabIndex = 138;
            // 
            // txttime
            // 
            this.txttime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txttime.Location = new System.Drawing.Point(1090, 138);
            this.txttime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttime.Name = "txttime";
            this.txttime.ReadOnly = true;
            this.txttime.Size = new System.Drawing.Size(160, 26);
            this.txttime.TabIndex = 137;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DateTimePicker1.Location = new System.Drawing.Point(1090, 191);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(257, 26);
            this.DateTimePicker1.TabIndex = 136;
            // 
            // txtstaffname1
            // 
            this.txtstaffname1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtstaffname1.Location = new System.Drawing.Point(621, 138);
            this.txtstaffname1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtstaffname1.Name = "txtstaffname1";
            this.txtstaffname1.ReadOnly = true;
            this.txtstaffname1.Size = new System.Drawing.Size(158, 26);
            this.txtstaffname1.TabIndex = 135;
            // 
            // Label6
            // 
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(1034, 196);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(48, 20);
            this.Label6.TabIndex = 134;
            this.Label6.Text = "Date:";
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(1035, 144);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(47, 20);
            this.Label5.TabIndex = 133;
            this.Label5.Text = "Time:";
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(21, 188);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(79, 20);
            this.Label4.TabIndex = 132;
            this.Label4.Text = "S.R.V No:";
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(568, 144);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 20);
            this.Label3.TabIndex = 131;
            this.Label3.Text = "Staff:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 60);
            this.panel1.TabIndex = 206;
            // 
            // txtaddress
            // 
            this.txtaddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtaddress.Location = new System.Drawing.Point(0, 26);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(1360, 26);
            this.txtaddress.TabIndex = 187;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtname
            // 
            this.txtname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtname.Location = new System.Drawing.Point(0, 0);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(1360, 26);
            this.txtname.TabIndex = 186;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lsvitems
            // 
            this.lsvitems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.ColumnHeader1,
            this.columnHeader6,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4});
            this.lsvitems.FullRowSelect = true;
            this.lsvitems.GridLines = true;
            this.lsvitems.HideSelection = false;
            this.lsvitems.Location = new System.Drawing.Point(0, 305);
            this.lsvitems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvitems.Name = "lsvitems";
            this.lsvitems.Size = new System.Drawing.Size(1347, 347);
            this.lsvitems.TabIndex = 209;
            this.lsvitems.UseCompatibleStateImageBehavior = false;
            this.lsvitems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "S/N";
            this.columnHeader5.Width = 40;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Item ";
            this.ColumnHeader1.Width = 280;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Unit Pack";
            this.columnHeader6.Width = 100;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Qty ";
            this.ColumnHeader2.Width = 50;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Unit Rate";
            this.ColumnHeader3.Width = 130;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Cost Price";
            this.ColumnHeader4.Width = 142;
            // 
            // txtlpo
            // 
            this.txtlpo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtlpo.Location = new System.Drawing.Point(638, 183);
            this.txtlpo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtlpo.Name = "txtlpo";
            this.txtlpo.Size = new System.Drawing.Size(158, 26);
            this.txtlpo.TabIndex = 144;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 143;
            this.label1.Text = "LPO  No:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1360, 113);
            this.panel3.TabIndex = 145;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(656, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 31);
            this.label8.TabIndex = 1;
            this.label8.Text = "Items Purchased";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(634, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "Information In The Store";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(655, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Receipt Voucher (SRV)";
            // 
            // txtForm
            // 
            this.txtForm.Location = new System.Drawing.Point(529, 47);
            this.txtForm.Name = "txtForm";
            this.txtForm.Size = new System.Drawing.Size(100, 26);
            this.txtForm.TabIndex = 205;
            this.txtForm.Visible = false;
            // 
            // lbcopywrite
            // 
            this.lbcopywrite.AutoSize = true;
            this.lbcopywrite.Location = new System.Drawing.Point(594, 140);
            this.lbcopywrite.Name = "lbcopywrite";
            this.lbcopywrite.Size = new System.Drawing.Size(51, 20);
            this.lbcopywrite.TabIndex = 206;
            this.lbcopywrite.Text = "label2";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PrintSRV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 865);
            this.Controls.Add(this.lsvitems);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrintSRV";
            this.Text = "PrintSRV";
            this.Load += new System.EventHandler(this.PrintSRV_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.TextBox txtrepeatreceipt;
        private System.Windows.Forms.Label lbreceiver;
        private System.Windows.Forms.Label lbissuer;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txttotal;
        internal System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbsection;
        private System.Windows.Forms.Label lbhospital;
        internal System.Windows.Forms.TextBox txtsection;
        internal System.Windows.Forms.TextBox txtsuppliername;
        internal System.Windows.Forms.TextBox txtsrv;
        internal System.Windows.Forms.TextBox txttime;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.TextBox txtstaffname1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtname;
        internal System.Windows.Forms.ListView lsvitems;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.TextBox txtlpo;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbcopywrite;
        private System.Drawing.Printing.PrintDocument printDocument1;
        public System.Windows.Forms.TextBox txtForm;
    }
}