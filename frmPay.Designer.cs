namespace HotelManagementSoftware
{
    partial class frmPay
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
            if ( disposing && ( components != null ) )
            {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( frmPay ) );
			this.button1 = new System.Windows.Forms.Button ();
			this.label1 = new System.Windows.Forms.Label ();
			this.txtReCode = new System.Windows.Forms.TextBox ();
			this.txtPay = new System.Windows.Forms.TextBox ();
			this.label2 = new System.Windows.Forms.Label ();
			this.txtBalance = new System.Windows.Forms.TextBox ();
			this.label3 = new System.Windows.Forms.Label ();
			this.button2 = new System.Windows.Forms.Button ();
			this.txtOwe = new System.Windows.Forms.TextBox ();
			this.label4 = new System.Windows.Forms.Label ();
			this.SuspendLayout ();
			// 
			// button1
			// 
			this.button1.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button1.Image" ) ) );
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point ( 157, 126 );
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size ( 75, 35 );
			this.button1.TabIndex = 4;
			this.button1.Text = "جدید";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler ( this.button1_Click );
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point ( 238, 12 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 50, 16 );
			this.label1.TabIndex = 1;
			this.label1.Text = "کد رزرو:";
			// 
			// txtReCode
			// 
			this.txtReCode.Location = new System.Drawing.Point ( 12, 9 );
			this.txtReCode.Name = "txtReCode";
			this.txtReCode.Size = new System.Drawing.Size ( 220, 23 );
			this.txtReCode.TabIndex = 0;
			this.txtReCode.Leave += new System.EventHandler ( this.txtReCode_Leave );
			// 
			// txtPay
			// 
			this.txtPay.Location = new System.Drawing.Point ( 12, 38 );
			this.txtPay.Name = "txtPay";
			this.txtPay.Size = new System.Drawing.Size ( 220, 23 );
			this.txtPay.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point ( 238, 41 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size ( 38, 16 );
			this.label2.TabIndex = 3;
			this.label2.Text = "مبلغ:";
			// 
			// txtBalance
			// 
			this.txtBalance.Location = new System.Drawing.Point ( 12, 97 );
			this.txtBalance.Name = "txtBalance";
			this.txtBalance.ReadOnly = true;
			this.txtBalance.Size = new System.Drawing.Size ( 220, 23 );
			this.txtBalance.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point ( 238, 100 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size ( 100, 16 );
			this.label3.TabIndex = 5;
			this.label3.Text = "مجموع پرداختی:";
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button2.Image" ) ) );
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.Location = new System.Drawing.Point ( 12, 126 );
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size ( 80, 35 );
			this.button2.TabIndex = 5;
			this.button2.Text = "پرداخت";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler ( this.button2_Click );
			// 
			// txtOwe
			// 
			this.txtOwe.Location = new System.Drawing.Point ( 12, 67 );
			this.txtOwe.Name = "txtOwe";
			this.txtOwe.ReadOnly = true;
			this.txtOwe.Size = new System.Drawing.Size ( 220, 23 );
			this.txtOwe.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point ( 238, 70 );
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size ( 60, 16 );
			this.label4.TabIndex = 8;
			this.label4.Text = "بدهکاری:";
			// 
			// frmPay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 16F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ( (System.Drawing.Image) ( resources.GetObject ( "$this.BackgroundImage" ) ) );
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size ( 343, 171 );
			this.Controls.Add ( this.txtOwe );
			this.Controls.Add ( this.label4 );
			this.Controls.Add ( this.button2 );
			this.Controls.Add ( this.txtBalance );
			this.Controls.Add ( this.label3 );
			this.Controls.Add ( this.txtPay );
			this.Controls.Add ( this.label2 );
			this.Controls.Add ( this.txtReCode );
			this.Controls.Add ( this.label1 );
			this.Controls.Add ( this.button1 );
			this.Font = new System.Drawing.Font ( "Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 178 ) ) );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding ( 3, 4, 3, 4 );
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPay";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "نرم افزار مدیریت هتل - پرداخت";
			this.ResumeLayout ( false );
			this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReCode;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtOwe;
        private System.Windows.Forms.Label label4;
    }
}