namespace Simple_Inventory
{
    partial class ReceipFromcrp
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
            this.cachedcrpReceipt1 = new Simple_Inventory.ReportGenerators.CrystalReport.CachedcrpReceipt();
            this.crvReceipt1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtrepeatreceipt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // crvReceipt1
            // 
            this.crvReceipt1.ActiveViewIndex = -1;
            this.crvReceipt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReceipt1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReceipt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReceipt1.Location = new System.Drawing.Point(0, 0);
            this.crvReceipt1.Name = "crvReceipt1";
            this.crvReceipt1.Size = new System.Drawing.Size(800, 450);
            this.crvReceipt1.TabIndex = 0;
            // 
            // txtrepeatreceipt
            // 
            this.txtrepeatreceipt.Location = new System.Drawing.Point(267, 226);
            this.txtrepeatreceipt.Name = "txtrepeatreceipt";
            this.txtrepeatreceipt.Size = new System.Drawing.Size(100, 20);
            this.txtrepeatreceipt.TabIndex = 1;
            this.txtrepeatreceipt.Visible = false;
            // 
            // ReceipFromcrp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtrepeatreceipt);
            this.Controls.Add(this.crvReceipt1);
            this.Name = "ReceipFromcrp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceipFromcrp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReceipFromcrp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReportGenerators.CrystalReport.CachedcrpReceipt cachedcrpReceipt1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReceipt1;
        private System.Windows.Forms.TextBox txtrepeatreceipt;
    }
}