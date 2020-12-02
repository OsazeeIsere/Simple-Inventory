namespace Simple_Inventory
{
    partial class ViewSupply
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
            this.lsvitems = new System.Windows.Forms.ListView();
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Button1 = new System.Windows.Forms.Button();
            this.txttime = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtreceiptnumber = new System.Windows.Forms.TextBox();
            this.txtstaffname1 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.cbhospital = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtaddress
            // 
            this.txtaddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtaddress.Location = new System.Drawing.Point(0, 26);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(1176, 26);
            this.txtaddress.TabIndex = 244;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtname
            // 
            this.txtname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtname.Location = new System.Drawing.Point(0, 0);
            this.txtname.Margin = new System.Windows.Forms.Padding(5);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(1176, 26);
            this.txtname.TabIndex = 243;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Button6
            // 
            this.Button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button6.BackColor = System.Drawing.Color.Red;
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.ForeColor = System.Drawing.Color.White;
            this.Button6.Location = new System.Drawing.Point(610, 80);
            this.Button6.Margin = new System.Windows.Forms.Padding(5);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(213, 44);
            this.Button6.TabIndex = 221;
            this.Button6.Text = "Cancel Supply";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button3
            // 
            this.Button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button3.BackColor = System.Drawing.Color.White;
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.Red;
            this.Button3.Location = new System.Drawing.Point(985, 156);
            this.Button3.Margin = new System.Windows.Forms.Padding(5);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(185, 55);
            this.Button3.TabIndex = 226;
            this.Button3.Text = "Remove Item";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button2.BackColor = System.Drawing.Color.Lime;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(912, 220);
            this.Button2.Margin = new System.Windows.Forms.Padding(5);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(84, 43);
            this.Button2.TabIndex = 230;
            this.Button2.Text = "ok";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txttransactionid
            // 
            this.txttransactionid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txttransactionid.Location = new System.Drawing.Point(121, 232);
            this.txttransactionid.Margin = new System.Windows.Forms.Padding(5);
            this.txttransactionid.Name = "txttransactionid";
            this.txttransactionid.ReadOnly = true;
            this.txttransactionid.Size = new System.Drawing.Size(85, 26);
            this.txttransactionid.TabIndex = 242;
            // 
            // Label16
            // 
            this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(51, 236);
            this.Label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(21, 16);
            this.Label16.TabIndex = 241;
            this.Label16.Text = "ID";
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(352, 232);
            this.txtproductname.Margin = new System.Windows.Forms.Padding(5);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.ReadOnly = true;
            this.txtproductname.Size = new System.Drawing.Size(277, 26);
            this.txtproductname.TabIndex = 240;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(216, 238);
            this.Label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(45, 16);
            this.Label15.TabIndex = 239;
            this.Label15.Text = "Name";
            // 
            // txtquantity
            // 
            this.txtquantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtquantity.Location = new System.Drawing.Point(789, 232);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(5);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(82, 26);
            this.txtquantity.TabIndex = 229;
            // 
            // Label14
            // 
            this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(670, 236);
            this.Label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(109, 16);
            this.Label14.TabIndex = 238;
            this.Label14.Text = "Change Quantity ";
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtgrandtotal.Location = new System.Drawing.Point(975, 28);
            this.txtgrandtotal.Margin = new System.Windows.Forms.Padding(5);
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.ReadOnly = true;
            this.txtgrandtotal.Size = new System.Drawing.Size(150, 26);
            this.txtgrandtotal.TabIndex = 218;
            this.txtgrandtotal.TextChanged += new System.EventHandler(this.txtgrandtotal_TextChanged);
            // 
            // Label10
            // 
            this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(838, 34);
            this.Label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(104, 20);
            this.Label10.TabIndex = 237;
            this.Label10.Text = "Grand Total";
            this.Label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // lsvitems
            // 
            this.lsvitems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader5,
            this.ColumnHeader1,
            this.columnHeader6,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4});
            this.lsvitems.FullRowSelect = true;
            this.lsvitems.GridLines = true;
            this.lsvitems.HideSelection = false;
            this.lsvitems.Location = new System.Drawing.Point(23, 5);
            this.lsvitems.Margin = new System.Windows.Forms.Padding(5);
            this.lsvitems.Name = "lsvitems";
            this.lsvitems.Size = new System.Drawing.Size(1139, 382);
            this.lsvitems.TabIndex = 235;
            this.lsvitems.UseCompatibleStateImageBehavior = false;
            this.lsvitems.View = System.Windows.Forms.View.Details;
            this.lsvitems.SelectedIndexChanged += new System.EventHandler(this.lsvitems_SelectedIndexChanged);
            this.lsvitems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvitems_MouseClick);
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
            // columnHeader6
            // 
            this.columnHeader6.Text = "Unit Pack";
            this.columnHeader6.Width = 120;
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
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(912, 59);
            this.Button1.Margin = new System.Windows.Forms.Padding(5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(213, 69);
            this.Button1.TabIndex = 220;
            this.Button1.Text = "Get Receipt";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txttime
            // 
            this.txttime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttime.Location = new System.Drawing.Point(939, 57);
            this.txttime.Margin = new System.Windows.Forms.Padding(5);
            this.txttime.Name = "txttime";
            this.txttime.ReadOnly = true;
            this.txttime.Size = new System.Drawing.Size(231, 26);
            this.txttime.TabIndex = 234;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker1.Location = new System.Drawing.Point(939, 102);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(5);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(231, 22);
            this.DateTimePicker1.TabIndex = 233;
            // 
            // txtreceiptnumber
            // 
            this.txtreceiptnumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtreceiptnumber.Location = new System.Drawing.Point(111, 105);
            this.txtreceiptnumber.Margin = new System.Windows.Forms.Padding(5);
            this.txtreceiptnumber.Name = "txtreceiptnumber";
            this.txtreceiptnumber.ReadOnly = true;
            this.txtreceiptnumber.Size = new System.Drawing.Size(159, 26);
            this.txtreceiptnumber.TabIndex = 232;
            // 
            // txtstaffname1
            // 
            this.txtstaffname1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtstaffname1.Location = new System.Drawing.Point(81, 169);
            this.txtstaffname1.Margin = new System.Windows.Forms.Padding(5);
            this.txtstaffname1.Name = "txtstaffname1";
            this.txtstaffname1.ReadOnly = true;
            this.txtstaffname1.Size = new System.Drawing.Size(159, 26);
            this.txtstaffname1.TabIndex = 231;
            // 
            // Label6
            // 
            this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(875, 102);
            this.Label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(40, 16);
            this.Label6.TabIndex = 225;
            this.Label6.Text = "Date:";
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(873, 63);
            this.Label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(42, 16);
            this.Label5.TabIndex = 224;
            this.Label5.Text = "Time:";
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(14, 110);
            this.Label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(59, 16);
            this.Label4.TabIndex = 223;
            this.Label4.Text = "S.I.V No:";
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(23, 174);
            this.Label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 20);
            this.Label3.TabIndex = 222;
            this.Label3.Text = "Staff:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.txtgrandtotal);
            this.panel1.Controls.Add(this.Label10);
            this.panel1.Controls.Add(this.Button6);
            this.panel1.Controls.Add(this.Button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 686);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 187);
            this.panel1.TabIndex = 245;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel2.Controls.Add(this.lsvitems);
            this.panel2.Location = new System.Drawing.Point(0, 268);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1176, 408);
            this.panel2.TabIndex = 246;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 247;
            this.label1.Text = "Name Of Hospital/Institution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 248;
            this.label2.Text = "Section";
            // 
            // txtsection
            // 
            this.txtsection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtsection.Location = new System.Drawing.Point(396, 99);
            this.txtsection.Margin = new System.Windows.Forms.Padding(5);
            this.txtsection.Name = "txtsection";
            this.txtsection.ReadOnly = true;
            this.txtsection.Size = new System.Drawing.Size(159, 26);
            this.txtsection.TabIndex = 249;
            this.txtsection.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbhospital
            // 
            this.cbhospital.FormattingEnabled = true;
            this.cbhospital.Items.AddRange(new object[] {
            "Central Hosp., B/City",
            "Central Hosp., Auchi",
            "Central Hosp., Uromi",
            "Stella Obasanjo Hospital",
            "Women & Children Hosp. Ewohim",
            "General Hosp., Abudu",
            "Government Hospital, Igbanke",
            "Government Hospital, Urhonigbe",
            "District Hospital, Egba",
            "Cottage Hospital, Egbokor",
            "General Hospital, Iguobazuwa",
            "General Hospital, Usen",
            "District Hospital, Ekiadolor",
            "GeneralHospital, Ekpoma",
            "General Hospital , Iruekpen",
            "District Hospital , Ewu",
            "District Hospital ,Usugbenu-Irrua",
            "General Hospital, Ubiaja",
            "General Hospital, Igueben.",
            "General Hospital, Afuze",
            "General Hospital, Sabo-Ora",
            "General Hospital ,Uzebba",
            "District Hospital, Otuo",
            "General Hospital ,Igarra",
            "Government Hospital ,Ibillo",
            "District Hospital, Uneme-Osu.",
            "General Hospital, Fugar",
            "General Hospital, Bode",
            "Government Hospital ,Agbede",
            "District Hospital, Anegbette",
            "District Hospital, Apana",
            "FSP Hospital, Obayantor",
            "Cottage Hospital, Oben",
            "Specialist Hosp., Ossiomo."});
            this.cbhospital.Location = new System.Drawing.Point(237, 60);
            this.cbhospital.Name = "cbhospital";
            this.cbhospital.Size = new System.Drawing.Size(318, 28);
            this.cbhospital.TabIndex = 250;
            this.cbhospital.Text = "Please, Select The Hospital To Supply";
            // 
            // ViewSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 873);
            this.Controls.Add(this.cbhospital);
            this.Controls.Add(this.txtsection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.txttransactionid);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.txtreceiptnumber);
            this.Controls.Add(this.txtstaffname1);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1192, 1133);
            this.MinimumSize = new System.Drawing.Size(1192, 721);
            this.Name = "ViewSupply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supply";
            this.Load += new System.EventHandler(this.ViewSupply_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        internal System.Windows.Forms.ListView lsvitems;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txttime;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.TextBox txtreceiptnumber;
        internal System.Windows.Forms.TextBox txtstaffname1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtsection;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        internal System.Windows.Forms.ComboBox cbhospital;
    }
}