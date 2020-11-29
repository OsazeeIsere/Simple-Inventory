namespace Simple_Inventory
{
    partial class Delete
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
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtstaffname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtproductid
            // 
            this.txtproductid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtproductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductid.Location = new System.Drawing.Point(198, 97);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(96, 26);
            this.txtproductid.TabIndex = 12;
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(56, 100);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(136, 20);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "With Product ID";
            // 
            // Button2
            // 
            this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(381, 150);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(107, 39);
            this.Button2.TabIndex = 10;
            this.Button2.Text = "NO";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(63, 150);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(120, 43);
            this.Button1.TabIndex = 9;
            this.Button1.Text = "YES";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtproductname
            // 
            this.txtproductname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtproductname.BackColor = System.Drawing.Color.Red;
            this.txtproductname.ForeColor = System.Drawing.Color.White;
            this.txtproductname.Location = new System.Drawing.Point(50, 69);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(468, 20);
            this.txtproductname.TabIndex = 8;
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(52, 42);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(294, 20);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Are You Sure You Want To Delete: ";
            // 
            // txtstaffname
            // 
            this.txtstaffname.Location = new System.Drawing.Point(171, 207);
            this.txtstaffname.Name = "txtstaffname";
            this.txtstaffname.Size = new System.Drawing.Size(250, 20);
            this.txtstaffname.TabIndex = 13;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 239);
            this.Controls.Add(this.txtstaffname);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.Label1);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtproductid;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtproductname;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtstaffname;
    }
}