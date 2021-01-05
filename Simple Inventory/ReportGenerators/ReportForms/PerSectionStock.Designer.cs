namespace Simple_Inventory.ReportGenerators.ReportForms
{
    partial class PerSectionStock
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
            this.crvPerSection = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // crvPerSection
            // 
            this.crvPerSection.ActiveViewIndex = -1;
            this.crvPerSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPerSection.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPerSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPerSection.Location = new System.Drawing.Point(0, 0);
            this.crvPerSection.Name = "crvPerSection";
            this.crvPerSection.Size = new System.Drawing.Size(800, 450);
            this.crvPerSection.TabIndex = 0;
            // 
            // txtsection
            // 
            this.txtsection.Location = new System.Drawing.Point(336, 261);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(100, 20);
            this.txtsection.TabIndex = 1;
            this.txtsection.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(506, 401);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Visible = false;
            // 
            // PerSectionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtsection);
            this.Controls.Add(this.crvPerSection);
            this.Name = "PerSectionStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PerSectionStock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PerSectionStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPerSection;
        internal System.Windows.Forms.TextBox txtsection;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}