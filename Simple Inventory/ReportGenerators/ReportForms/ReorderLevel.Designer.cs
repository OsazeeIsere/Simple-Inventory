namespace Simple_Inventory.ReportGenerators.ReportForms
{
    partial class ReorderLevel
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
            this.crvReorderLevel = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // crvReorderLevel
            // 
            this.crvReorderLevel.ActiveViewIndex = -1;
            this.crvReorderLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReorderLevel.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReorderLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReorderLevel.Location = new System.Drawing.Point(0, 0);
            this.crvReorderLevel.Name = "crvReorderLevel";
            this.crvReorderLevel.Size = new System.Drawing.Size(800, 450);
            this.crvReorderLevel.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(447, 407);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Visible = false;
            // 
            // ReorderLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.crvReorderLevel);
            this.Name = "ReorderLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReorderLevel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReorderLevel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvReorderLevel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}