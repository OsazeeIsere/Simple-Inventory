namespace Simple_Inventory
{
    partial class editesupply
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
            this.txtcashiername1 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txttransactionid = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtitemsold = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.txtsiv = new System.Windows.Forms.TextBox();
            this.txtgrandtotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtcashiername1
            // 
            this.txtcashiername1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcashiername1.Location = new System.Drawing.Point(118, 20);
            this.txtcashiername1.Name = "txtcashiername1";
            this.txtcashiername1.Size = new System.Drawing.Size(107, 26);
            this.txtcashiername1.TabIndex = 28;
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(45, 23);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(43, 20);
            this.Label3.TabIndex = 27;
            this.Label3.Text = "User";
            // 
            // txttransactionid
            // 
            this.txttransactionid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txttransactionid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttransactionid.Location = new System.Drawing.Point(230, 121);
            this.txttransactionid.Name = "txttransactionid";
            this.txttransactionid.Size = new System.Drawing.Size(96, 26);
            this.txttransactionid.TabIndex = 26;
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(56, 126);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(168, 20);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "With Transaction ID";
            // 
            // Button2
            // 
            this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(381, 176);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(107, 39);
            this.Button2.TabIndex = 24;
            this.Button2.Text = "NO";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(63, 176);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(120, 43);
            this.Button1.TabIndex = 23;
            this.Button1.Text = "YES";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtitemsold
            // 
            this.txtitemsold.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtitemsold.Location = new System.Drawing.Point(50, 95);
            this.txtitemsold.Name = "txtitemsold";
            this.txtitemsold.Size = new System.Drawing.Size(468, 26);
            this.txtitemsold.TabIndex = 22;
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(52, 68);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(426, 20);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "Are You Sure You Want To Delet This Transaction? ";
            // 
            // txtsection
            // 
            this.txtsection.Location = new System.Drawing.Point(226, 167);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(100, 26);
            this.txtsection.TabIndex = 29;
            this.txtsection.Visible = false;
            this.txtsection.TextChanged += new System.EventHandler(this.txtsection_TextChanged);
            // 
            // txtsiv
            // 
            this.txtsiv.Location = new System.Drawing.Point(226, 200);
            this.txtsiv.Name = "txtsiv";
            this.txtsiv.Size = new System.Drawing.Size(100, 26);
            this.txtsiv.TabIndex = 30;
            this.txtsiv.Visible = false;
            this.txtsiv.TextChanged += new System.EventHandler(this.txtsiv_TextChanged);
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.Location = new System.Drawing.Point(352, 123);
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.Size = new System.Drawing.Size(100, 26);
            this.txtgrandtotal.TabIndex = 31;
            this.txtgrandtotal.Visible = false;
            this.txtgrandtotal.TextChanged += new System.EventHandler(this.txtgrandtotal_TextChanged);
            // 
            // editesupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 238);
            this.Controls.Add(this.txtgrandtotal);
            this.Controls.Add(this.txtsiv);
            this.Controls.Add(this.txtsection);
            this.Controls.Add(this.txtcashiername1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txttransactionid);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtitemsold);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "editesupply";
            this.Text = "editesupply";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtcashiername1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txttransactionid;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtitemsold;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtsection;
        internal System.Windows.Forms.TextBox txtsiv;
        internal System.Windows.Forms.TextBox txtgrandtotal;
    }
}