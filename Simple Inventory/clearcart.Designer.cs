namespace Simple_Inventory
{
    partial class clearcart
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
            this.txtcashiername = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtgrandtotal = new System.Windows.Forms.TextBox();
            this.txtsiv = new System.Windows.Forms.TextBox();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtcashiername
            // 
            this.txtcashiername.Location = new System.Drawing.Point(182, 222);
            this.txtcashiername.Name = "txtcashiername";
            this.txtcashiername.Size = new System.Drawing.Size(199, 26);
            this.txtcashiername.TabIndex = 7;
            this.txtcashiername.Visible = false;
            // 
            // Button2
            // 
            this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(356, 165);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(119, 33);
            this.Button2.TabIndex = 6;
            this.Button2.Text = "NO";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(77, 166);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(118, 33);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "YES";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(75, 57);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(370, 20);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Are You Sure You Want To Clear The CART?";
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.Location = new System.Drawing.Point(349, 90);
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.Size = new System.Drawing.Size(100, 26);
            this.txtgrandtotal.TabIndex = 34;
            this.txtgrandtotal.Visible = false;
            // 
            // txtsiv
            // 
            this.txtsiv.Location = new System.Drawing.Point(223, 167);
            this.txtsiv.Name = "txtsiv";
            this.txtsiv.Size = new System.Drawing.Size(100, 26);
            this.txtsiv.TabIndex = 33;
            this.txtsiv.Visible = false;
            // 
            // txtsection
            // 
            this.txtsection.Location = new System.Drawing.Point(223, 134);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(100, 26);
            this.txtsection.TabIndex = 32;
            this.txtsection.Visible = false;
            // 
            // clearcart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(550, 289);
            this.Controls.Add(this.txtgrandtotal);
            this.Controls.Add(this.txtsiv);
            this.Controls.Add(this.txtsection);
            this.Controls.Add(this.txtcashiername);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "clearcart";
            this.Text = "clearcart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtcashiername;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtgrandtotal;
        internal System.Windows.Forms.TextBox txtsiv;
        internal System.Windows.Forms.TextBox txtsection;
    }
}