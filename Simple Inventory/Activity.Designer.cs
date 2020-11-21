namespace Simple_Inventory
{
    partial class Activity
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
            this.lbtel = new System.Windows.Forms.Label();
            this.txtcashiername1 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.btndrugs = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.lbtel);
            this.panel1.Controls.Add(this.txtcashiername1);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // txtaddress
            // 
            this.txtaddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtaddress.Location = new System.Drawing.Point(0, 20);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(800, 20);
            this.txtaddress.TabIndex = 115;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtname
            // 
            this.txtname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtname.Location = new System.Drawing.Point(0, 0);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(800, 20);
            this.txtname.TabIndex = 114;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbtel
            // 
            this.lbtel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbtel.AutoSize = true;
            this.lbtel.Location = new System.Drawing.Point(308, 103);
            this.lbtel.Name = "lbtel";
            this.lbtel.Size = new System.Drawing.Size(35, 13);
            this.lbtel.TabIndex = 113;
            this.lbtel.Text = "label1";
            // 
            // txtcashiername1
            // 
            this.txtcashiername1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcashiername1.Location = new System.Drawing.Point(370, 138);
            this.txtcashiername1.Name = "txtcashiername1";
            this.txtcashiername1.Size = new System.Drawing.Size(191, 20);
            this.txtcashiername1.TabIndex = 110;
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(259, 138);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(60, 13);
            this.Label5.TabIndex = 109;
            this.Label5.Text = "User Name";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.Button2);
            this.panel3.Controls.Add(this.Button1);
            this.panel3.Controls.Add(this.btndrugs);
            this.panel3.ForeColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(109, 200);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(631, 204);
            this.panel3.TabIndex = 107;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(111, 78);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(386, 50);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "Manag Requisition";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(111, 138);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(386, 50);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Manage Dispensary";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // btndrugs
            // 
            this.btndrugs.Location = new System.Drawing.Point(111, 16);
            this.btndrugs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndrugs.Name = "btndrugs";
            this.btndrugs.Size = new System.Drawing.Size(386, 50);
            this.btndrugs.TabIndex = 0;
            this.btndrugs.Text = "Manage Stock";
            this.btndrugs.UseVisualStyleBackColor = true;
            this.btndrugs.Click += new System.EventHandler(this.btndrugs_Click);
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "Activity";
            this.Text = "Activity";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbtel;
        internal System.Windows.Forms.TextBox txtcashiername1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button btndrugs;
    }
}