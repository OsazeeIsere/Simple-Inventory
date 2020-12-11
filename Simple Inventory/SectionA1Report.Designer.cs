namespace Simple_Inventory
{
    partial class SectionA1Report
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
            this.A1rptview = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // A1rptview
            // 
            this.A1rptview.ActiveViewIndex = -1;
            this.A1rptview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A1rptview.Cursor = System.Windows.Forms.Cursors.Default;
            this.A1rptview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.A1rptview.Location = new System.Drawing.Point(0, 0);
            this.A1rptview.Name = "A1rptview";
            this.A1rptview.Size = new System.Drawing.Size(906, 450);
            this.A1rptview.TabIndex = 0;
            // 
            // SectionA1Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.A1rptview);
            this.Name = "SectionA1Report";
            this.Text = "SectionA1Report";
            this.Load += new System.EventHandler(this.SectionA1Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer A1rptview;
    }
}