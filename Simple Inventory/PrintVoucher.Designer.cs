namespace Simple_Inventory
{
    partial class PrintVoucher
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
            this.crvVoucher = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtrepeatreceipt = new System.Windows.Forms.TextBox();
            this.txtForm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // crvVoucher
            // 
            this.crvVoucher.ActiveViewIndex = -1;
            this.crvVoucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVoucher.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVoucher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVoucher.Location = new System.Drawing.Point(0, 0);
            this.crvVoucher.Name = "crvVoucher";
            this.crvVoucher.Size = new System.Drawing.Size(800, 450);
            this.crvVoucher.TabIndex = 0;
            // 
            // txtrepeatreceipt
            // 
            this.txtrepeatreceipt.Location = new System.Drawing.Point(382, 281);
            this.txtrepeatreceipt.Name = "txtrepeatreceipt";
            this.txtrepeatreceipt.Size = new System.Drawing.Size(100, 20);
            this.txtrepeatreceipt.TabIndex = 1;
            this.txtrepeatreceipt.Visible = false;
            // 
            // txtForm
            // 
            this.txtForm.Location = new System.Drawing.Point(498, 281);
            this.txtForm.Name = "txtForm";
            this.txtForm.Size = new System.Drawing.Size(100, 20);
            this.txtForm.TabIndex = 2;
            this.txtForm.Visible = false;
            // 
            // PrintVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtForm);
            this.Controls.Add(this.txtrepeatreceipt);
            this.Controls.Add(this.crvVoucher);
            this.Name = "PrintVoucher";
            this.Text = "PrintVoucher";
            this.Load += new System.EventHandler(this.PrintVoucher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvVoucher;
        public System.Windows.Forms.TextBox txtrepeatreceipt;
        internal System.Windows.Forms.TextBox txtForm;
    }
}