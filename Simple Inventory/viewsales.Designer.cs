namespace Simple_Inventory
{
    partial class viewsales
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
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.txttransactionid = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtgrandtotal = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.lsvitems = new System.Windows.Forms.ListView();
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Button1 = new System.Windows.Forms.Button();
            this.txtcash = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txttime = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtreceiptnumber = new System.Windows.Forms.TextBox();
            this.txtstaffname1 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtaddress
            // 
            this.txtaddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtaddress.Location = new System.Drawing.Point(0, 24);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(982, 24);
            this.txtaddress.TabIndex = 215;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtname
            // 
            this.txtname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtname.Location = new System.Drawing.Point(0, 0);
            this.txtname.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(982, 24);
            this.txtname.TabIndex = 214;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Button6
            // 
            this.Button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button6.BackColor = System.Drawing.Color.Red;
            this.Button6.ForeColor = System.Drawing.Color.White;
            this.Button6.Location = new System.Drawing.Point(708, 1512);
            this.Button6.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(213, 61);
            this.Button6.TabIndex = 192;
            this.Button6.Text = "Clear Cart";
            this.Button6.UseVisualStyleBackColor = false;
            // 
            // Button3
            // 
            this.Button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button3.BackColor = System.Drawing.Color.White;
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.Red;
            this.Button3.Location = new System.Drawing.Point(763, 239);
            this.Button3.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(186, 49);
            this.Button3.TabIndex = 197;
            this.Button3.Text = "Remove Item";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button2.BackColor = System.Drawing.Color.Lime;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(882, 344);
            this.Button2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(84, 49);
            this.Button2.TabIndex = 201;
            this.Button2.Text = "ok";
            this.Button2.UseVisualStyleBackColor = false;
            // 
            // txttransactionid
            // 
            this.txttransactionid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txttransactionid.Location = new System.Drawing.Point(113, 357);
            this.txttransactionid.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txttransactionid.Name = "txttransactionid";
            this.txttransactionid.ReadOnly = true;
            this.txttransactionid.Size = new System.Drawing.Size(85, 24);
            this.txttransactionid.TabIndex = 213;
            // 
            // Label16
            // 
            this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(42, 359);
            this.Label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(22, 18);
            this.Label16.TabIndex = 212;
            this.Label16.Text = "ID";
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(114, 85);
            this.txtproductname.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.ReadOnly = true;
            this.txtproductname.Size = new System.Drawing.Size(277, 24);
            this.txtproductname.TabIndex = 211;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(12, 88);
            this.Label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(48, 18);
            this.Label15.TabIndex = 210;
            this.Label15.Text = "Name";
            // 
            // txtquantity
            // 
            this.txtquantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(790, 349);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(82, 24);
            this.txtquantity.TabIndex = 200;
            // 
            // Label14
            // 
            this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(646, 355);
            this.Label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(121, 18);
            this.Label14.TabIndex = 209;
            this.Label14.Text = "Change Quantity ";
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtgrandtotal.Location = new System.Drawing.Point(697, 969);
            this.txtgrandtotal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.ReadOnly = true;
            this.txtgrandtotal.Size = new System.Drawing.Size(150, 24);
            this.txtgrandtotal.TabIndex = 189;
            // 
            // Label10
            // 
            this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(506, 969);
            this.Label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(104, 20);
            this.Label10.TabIndex = 208;
            this.Label10.Text = "Grand Total";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtdiscount.Location = new System.Drawing.Point(697, 902);
            this.txtdiscount.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.ReadOnly = true;
            this.txtdiscount.Size = new System.Drawing.Size(150, 24);
            this.txtdiscount.TabIndex = 188;
            // 
            // Label9
            // 
            this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(459, 910);
            this.Label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(148, 20);
            this.Label9.TabIndex = 207;
            this.Label9.Text = "Discount In Naira";
            // 
            // lsvitems
            // 
            this.lsvitems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvitems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader5,
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4});
            this.lsvitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvitems.FullRowSelect = true;
            this.lsvitems.GridLines = true;
            this.lsvitems.HideSelection = false;
            this.lsvitems.Location = new System.Drawing.Point(33, 401);
            this.lsvitems.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lsvitems.Name = "lsvitems";
            this.lsvitems.Size = new System.Drawing.Size(933, 307);
            this.lsvitems.TabIndex = 206;
            this.lsvitems.UseCompatibleStateImageBehavior = false;
            this.lsvitems.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "ID";
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Item Description";
            this.ColumnHeader1.Width = 176;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Quantity Sold";
            this.ColumnHeader2.Width = 134;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Unit Price";
            this.ColumnHeader3.Width = 130;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Amount";
            this.ColumnHeader4.Width = 142;
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(632, 1118);
            this.Button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(213, 83);
            this.Button1.TabIndex = 191;
            this.Button1.Text = "Get receipt";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // txtcash
            // 
            this.txtcash.AcceptsTab = true;
            this.txtcash.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtcash.Location = new System.Drawing.Point(697, 1035);
            this.txtcash.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtcash.Name = "txtcash";
            this.txtcash.Size = new System.Drawing.Size(146, 24);
            this.txtcash.TabIndex = 190;
            // 
            // txttotal
            // 
            this.txttotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txttotal.Location = new System.Drawing.Point(702, 858);
            this.txttotal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(145, 24);
            this.txttotal.TabIndex = 187;
            // 
            // txttime
            // 
            this.txttime.Location = new System.Drawing.Point(462, 94);
            this.txttime.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txttime.Name = "txttime";
            this.txttime.ReadOnly = true;
            this.txttime.Size = new System.Drawing.Size(236, 24);
            this.txttime.TabIndex = 205;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker1.Location = new System.Drawing.Point(461, 128);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(236, 24);
            this.DateTimePicker1.TabIndex = 204;
            // 
            // txtreceiptnumber
            // 
            this.txtreceiptnumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtreceiptnumber.Location = new System.Drawing.Point(137, 292);
            this.txtreceiptnumber.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtreceiptnumber.Name = "txtreceiptnumber";
            this.txtreceiptnumber.ReadOnly = true;
            this.txtreceiptnumber.Size = new System.Drawing.Size(159, 24);
            this.txtreceiptnumber.TabIndex = 203;
            // 
            // txtstaffname1
            // 
            this.txtstaffname1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtstaffname1.Location = new System.Drawing.Point(137, 233);
            this.txtstaffname1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtstaffname1.Name = "txtstaffname1";
            this.txtstaffname1.ReadOnly = true;
            this.txtstaffname1.Size = new System.Drawing.Size(159, 24);
            this.txtstaffname1.TabIndex = 202;
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(506, 1038);
            this.Label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(123, 24);
            this.Label8.TabIndex = 199;
            this.Label8.Text = "Cash To Paid";
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(580, 858);
            this.Label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(66, 25);
            this.Label7.TabIndex = 198;
            this.Label7.Text = " Total";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(406, 133);
            this.Label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(43, 18);
            this.Label6.TabIndex = 196;
            this.Label6.Text = "Date:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(418, 94);
            this.Label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(45, 18);
            this.Label5.TabIndex = 195;
            this.Label5.Text = "Time:";
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(33, 295);
            this.Label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(86, 18);
            this.Label4.TabIndex = 194;
            this.Label4.Text = "Receipt No:";
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(77, 239);
            this.Label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(42, 18);
            this.Label3.TabIndex = 193;
            this.Label3.Text = "Staff:";
            // 
            // viewsales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 873);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.txttransactionid);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.txtgrandtotal);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.lsvitems);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtcash);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.txtreceiptnumber);
            this.Controls.Add(this.txtstaffname1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "viewsales";
            this.Text = "viewsales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtname;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox txttransactionid;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox txtproductname;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox txtquantity;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.TextBox txtgrandtotal;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtdiscount;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ListView lsvitems;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtcash;
        internal System.Windows.Forms.TextBox txttotal;
        internal System.Windows.Forms.TextBox txttime;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.TextBox txtreceiptnumber;
        internal System.Windows.Forms.TextBox txtstaffname1;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
    }
}