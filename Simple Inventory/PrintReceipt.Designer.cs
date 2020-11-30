namespace Simple_Inventory
{
    partial class PrintReceipt
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtreceiptnumber = new System.Windows.Forms.TextBox();
            this.txttime = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtstaffname1 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lsvitems = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtrepeatreceipt = new System.Windows.Forms.TextBox();
            this.lbcopywrite = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbissuer = new System.Windows.Forms.Label();
            this.lbreceiver = new System.Windows.Forms.Label();
            this.txthospital = new System.Windows.Forms.TextBox();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(770, 60);
            this.panel1.TabIndex = 0;
            // 
            // txtaddress
            // 
            this.txtaddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtaddress.Location = new System.Drawing.Point(0, 26);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(770, 26);
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
            this.txtname.Size = new System.Drawing.Size(770, 26);
            this.txtname.TabIndex = 186;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtsection);
            this.panel2.Controls.Add(this.txthospital);
            this.panel2.Controls.Add(this.txtreceiptnumber);
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
            this.panel2.Size = new System.Drawing.Size(770, 199);
            this.panel2.TabIndex = 1;
            // 
            // txtreceiptnumber
            // 
            this.txtreceiptnumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtreceiptnumber.Location = new System.Drawing.Point(112, 157);
            this.txtreceiptnumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtreceiptnumber.Name = "txtreceiptnumber";
            this.txtreceiptnumber.ReadOnly = true;
            this.txtreceiptnumber.Size = new System.Drawing.Size(158, 26);
            this.txtreceiptnumber.TabIndex = 138;
            // 
            // txttime
            // 
            this.txttime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txttime.Location = new System.Drawing.Point(473, 96);
            this.txttime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttime.Name = "txttime";
            this.txttime.ReadOnly = true;
            this.txttime.Size = new System.Drawing.Size(248, 26);
            this.txttime.TabIndex = 137;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DateTimePicker1.Location = new System.Drawing.Point(392, 158);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(329, 26);
            this.DateTimePicker1.TabIndex = 136;
            // 
            // txtstaffname1
            // 
            this.txtstaffname1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtstaffname1.Location = new System.Drawing.Point(112, 92);
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
            this.Label6.Location = new System.Drawing.Point(323, 164);
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
            this.Label5.Location = new System.Drawing.Point(406, 100);
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
            this.Label4.Location = new System.Drawing.Point(39, 164);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(72, 20);
            this.Label4.TabIndex = 132;
            this.Label4.Text = "S.I.V No:";
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(39, 97);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(44, 20);
            this.Label3.TabIndex = 131;
            this.Label3.Text = "Staff";
            // 
            // lsvitems
            // 
            this.lsvitems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvitems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4});
            this.lsvitems.FullRowSelect = true;
            this.lsvitems.GridLines = true;
            this.lsvitems.HideSelection = false;
            this.lsvitems.Location = new System.Drawing.Point(1, 8);
            this.lsvitems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvitems.MaximumSize = new System.Drawing.Size(787, 936);
            this.lsvitems.Name = "lsvitems";
            this.lsvitems.Size = new System.Drawing.Size(766, 403);
            this.lsvitems.TabIndex = 201;
            this.lsvitems.UseCompatibleStateImageBehavior = false;
            this.lsvitems.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Item ";
            this.ColumnHeader1.Width = 133;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Qty ";
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(387, 416);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(136, 25);
            this.Label7.TabIndex = 187;
            this.Label7.Text = "Grand Total";
            // 
            // Label11
            // 
            this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(171, 488);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(199, 20);
            this.Label11.TabIndex = 189;
            this.Label11.Text = "Thanks for your patronage.";
            // 
            // Label12
            // 
            this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(137, 525);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(268, 20);
            this.Label12.TabIndex = 190;
            this.Label12.Text = "Goods Bought Cannot Be Returned.";
            // 
            // txttotal
            // 
            this.txttotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txttotal.Location = new System.Drawing.Point(581, 414);
            this.txttotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(161, 26);
            this.txttotal.TabIndex = 191;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(624, 488);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(118, 45);
            this.Button1.TabIndex = 193;
            this.Button1.Text = "Clear Sales";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(500, 491);
            this.Button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(118, 40);
            this.Button3.TabIndex = 196;
            this.Button3.Text = "Print";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Label13
            // 
            this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(530, 420);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(44, 20);
            this.Label13.TabIndex = 197;
            this.Label13.Text = "NGN";
            // 
            // txtrepeatreceipt
            // 
            this.txtrepeatreceipt.Location = new System.Drawing.Point(48, 450);
            this.txtrepeatreceipt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtrepeatreceipt.Name = "txtrepeatreceipt";
            this.txtrepeatreceipt.Size = new System.Drawing.Size(255, 26);
            this.txtrepeatreceipt.TabIndex = 200;
            this.txtrepeatreceipt.Visible = false;
            // 
            // lbcopywrite
            // 
            this.lbcopywrite.AutoSize = true;
            this.lbcopywrite.Location = new System.Drawing.Point(158, 614);
            this.lbcopywrite.Name = "lbcopywrite";
            this.lbcopywrite.Size = new System.Drawing.Size(51, 20);
            this.lbcopywrite.TabIndex = 202;
            this.lbcopywrite.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Bisque;
            this.panel3.Controls.Add(this.lbreceiver);
            this.panel3.Controls.Add(this.lbissuer);
            this.panel3.Controls.Add(this.lbcopywrite);
            this.panel3.Controls.Add(this.lsvitems);
            this.panel3.Controls.Add(this.txtrepeatreceipt);
            this.panel3.Controls.Add(this.Label13);
            this.panel3.Controls.Add(this.Button3);
            this.panel3.Controls.Add(this.Button1);
            this.panel3.Controls.Add(this.txttotal);
            this.panel3.Controls.Add(this.Label12);
            this.panel3.Controls.Add(this.Label11);
            this.panel3.Controls.Add(this.Label7);
            this.panel3.Location = new System.Drawing.Point(0, 267);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 605);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbissuer
            // 
            this.lbissuer.AutoSize = true;
            this.lbissuer.Location = new System.Drawing.Point(65, 496);
            this.lbissuer.Name = "lbissuer";
            this.lbissuer.Size = new System.Drawing.Size(99, 20);
            this.lbissuer.TabIndex = 203;
            this.lbissuer.Text = "Approved By";
            this.lbissuer.Visible = false;
            // 
            // lbreceiver
            // 
            this.lbreceiver.AutoSize = true;
            this.lbreceiver.Location = new System.Drawing.Point(65, 533);
            this.lbreceiver.Name = "lbreceiver";
            this.lbreceiver.Size = new System.Drawing.Size(97, 20);
            this.lbreceiver.TabIndex = 204;
            this.lbreceiver.Text = "Received By";
            this.lbreceiver.Visible = false;
            // 
            // txthospital
            // 
            this.txthospital.Location = new System.Drawing.Point(79, 23);
            this.txthospital.Name = "txthospital";
            this.txthospital.Size = new System.Drawing.Size(393, 26);
            this.txthospital.TabIndex = 139;
            // 
            // txtsection
            // 
            this.txtsection.Location = new System.Drawing.Point(560, 21);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(182, 26);
            this.txtsection.TabIndex = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 141;
            this.label1.Text = "Hospital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 142;
            this.label2.Text = "Section";
            // 
            // PrintReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 873);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(786, 928);
            this.MinimumSize = new System.Drawing.Size(786, 858);
            this.Name = "PrintReceipt";
            this.Text = "PrintReceipt";
            this.Load += new System.EventHandler(this.PrintReceipt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.TextBox txttime;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.TextBox txtstaffname1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtreceiptnumber;
        internal System.Windows.Forms.ListView lsvitems;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txttotal;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox txtrepeatreceipt;
        private System.Windows.Forms.Label lbcopywrite;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbreceiver;
        private System.Windows.Forms.Label lbissuer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtsection;
        internal System.Windows.Forms.TextBox txthospital;
    }
}