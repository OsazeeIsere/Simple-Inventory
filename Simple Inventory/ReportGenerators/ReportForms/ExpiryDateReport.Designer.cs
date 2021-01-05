namespace Simple_Inventory.ReportGenerators.ReportForms
{
    partial class ExpiryDateReport
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
            this.crvExpiryDateinfo = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // crvExpiryDateinfo
            // 
            this.crvExpiryDateinfo.ActiveViewIndex = -1;
            this.crvExpiryDateinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvExpiryDateinfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvExpiryDateinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvExpiryDateinfo.Location = new System.Drawing.Point(0, 0);
            this.crvExpiryDateinfo.Name = "crvExpiryDateinfo";
            this.crvExpiryDateinfo.Size = new System.Drawing.Size(800, 450);
            this.crvExpiryDateinfo.TabIndex = 0;
            // 
            // txtsection
            // 
            this.txtsection.Location = new System.Drawing.Point(350, 215);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(100, 20);
            this.txtsection.TabIndex = 2;
            this.txtsection.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(249, 418);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Visible = false;
            // 
            // ExpiryDateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtsection);
            this.Controls.Add(this.crvExpiryDateinfo);
            this.Name = "ExpiryDateReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpiryDateReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExpiryDateReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txtsection;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvExpiryDateinfo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}