namespace Simple_Inventory
{
    partial class SupplyLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtadmin = new System.Windows.Forms.TextBox();
            this.dgvsaleslog = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Label8 = new System.Windows.Forms.Label();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.cbocashier = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Button1 = new System.Windows.Forms.Button();
            this.txttotaprofit = new System.Windows.Forms.TextBox();
            this.txttotalsales = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsaleslog)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 57);
            this.panel1.TabIndex = 0;
            // 
            // txtaddress
            // 
            this.txtaddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtaddress.Location = new System.Drawing.Point(0, 26);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(1253, 26);
            this.txtaddress.TabIndex = 112;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtname
            // 
            this.txtname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtname.Location = new System.Drawing.Point(0, 0);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(1253, 26);
            this.txtname.TabIndex = 111;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtadmin);
            this.panel2.Controls.Add(this.dgvsaleslog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1253, 580);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(563, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 36);
            this.button3.TabIndex = 123;
            this.button3.Text = "Export";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(127, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 45);
            this.button2.TabIndex = 61;
            this.button2.Text = "Cancel Sales";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // txtadmin
            // 
            this.txtadmin.AccessibleName = "txtadmin";
            this.txtadmin.Location = new System.Drawing.Point(13, 19);
            this.txtadmin.Name = "txtadmin";
            this.txtadmin.ReadOnly = true;
            this.txtadmin.Size = new System.Drawing.Size(100, 26);
            this.txtadmin.TabIndex = 60;
            // 
            // dgvsaleslog
            // 
            this.dgvsaleslog.AllowUserToAddRows = false;
            this.dgvsaleslog.AllowUserToDeleteRows = false;
            this.dgvsaleslog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvsaleslog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsaleslog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsaleslog.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvsaleslog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvsaleslog.Location = new System.Drawing.Point(13, 63);
            this.dgvsaleslog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvsaleslog.Name = "dgvsaleslog";
            this.dgvsaleslog.ReadOnly = true;
            this.dgvsaleslog.Size = new System.Drawing.Size(1130, 346);
            this.dgvsaleslog.TabIndex = 59;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel3.Controls.Add(this.Label8);
            this.panel3.Controls.Add(this.DateTimePicker2);
            this.panel3.Controls.Add(this.txtcustomer);
            this.panel3.Controls.Add(this.Label7);
            this.panel3.Controls.Add(this.Label4);
            this.panel3.Controls.Add(this.cbocashier);
            this.panel3.Controls.Add(this.Label3);
            this.panel3.Controls.Add(this.DateTimePicker1);
            this.panel3.Controls.Add(this.Button1);
            this.panel3.Controls.Add(this.txttotaprofit);
            this.panel3.Controls.Add(this.txttotalsales);
            this.panel3.Controls.Add(this.Label2);
            this.panel3.Controls.Add(this.Label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 474);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1253, 163);
            this.panel3.TabIndex = 2;
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(391, 76);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(125, 20);
            this.Label8.TabIndex = 66;
            this.Label8.Text = "To Second Date";
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DateTimePicker2.Location = new System.Drawing.Point(514, 70);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(254, 26);
            this.DateTimePicker2.TabIndex = 65;
            // 
            // txtcustomer
            // 
            this.txtcustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcustomer.Location = new System.Drawing.Point(1092, 119);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.ReadOnly = true;
            this.txtcustomer.Size = new System.Drawing.Size(149, 26);
            this.txtcustomer.TabIndex = 64;
            // 
            // Label7
            // 
            this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(925, 128);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(155, 20);
            this.Label7.TabIndex = 63;
            this.Label7.Text = "Customer Response";
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(391, 15);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(120, 20);
            this.Label4.TabIndex = 62;
            this.Label4.Text = "From First Date";
            // 
            // cbocashier
            // 
            this.cbocashier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbocashier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbocashier.FormattingEnabled = true;
            this.cbocashier.Location = new System.Drawing.Point(177, 15);
            this.cbocashier.Name = "cbocashier";
            this.cbocashier.Size = new System.Drawing.Size(163, 28);
            this.cbocashier.TabIndex = 61;
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(59, 18);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(92, 20);
            this.Label3.TabIndex = 60;
            this.Label3.Text = "Select User";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DateTimePicker1.Location = new System.Drawing.Point(509, 12);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(260, 26);
            this.DateTimePicker1.TabIndex = 59;
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button1.Location = new System.Drawing.Point(514, 117);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(254, 31);
            this.Button1.TabIndex = 58;
            this.Button1.Text = "Sales For The Cashier";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txttotaprofit
            // 
            this.txttotaprofit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotaprofit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaprofit.Location = new System.Drawing.Point(1092, 71);
            this.txttotaprofit.Name = "txttotaprofit";
            this.txttotaprofit.ReadOnly = true;
            this.txttotaprofit.Size = new System.Drawing.Size(149, 29);
            this.txttotaprofit.TabIndex = 57;
            // 
            // txttotalsales
            // 
            this.txttotalsales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotalsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalsales.Location = new System.Drawing.Point(1092, 18);
            this.txttotalsales.Name = "txttotalsales";
            this.txttotalsales.ReadOnly = true;
            this.txttotalsales.Size = new System.Drawing.Size(149, 31);
            this.txttotalsales.TabIndex = 56;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(983, 73);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(97, 24);
            this.Label2.TabIndex = 55;
            this.Label2.Text = "Total Profit";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(878, 22);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(202, 24);
            this.Label1.TabIndex = 54;
            this.Label1.Text = "Total Amount Supplied";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 57);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1253, 417);
            this.crystalReportViewer1.TabIndex = 3;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // SupplyLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 637);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "SupplyLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SectionA1 SupplyLog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SupplyLog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsaleslog)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.DateTimePicker DateTimePicker2;
        internal System.Windows.Forms.TextBox txtcustomer;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox cbocashier;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txttotaprofit;
        internal System.Windows.Forms.TextBox txttotalsales;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.DataGridView dgvsaleslog;
        internal System.Windows.Forms.TextBox txtadmin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}