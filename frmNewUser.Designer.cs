namespace HotelManagementSoftware
{
    partial class frmNewUser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( frmNewUser ) );
			this.label2 = new System.Windows.Forms.Label ();
			this.txtPassword = new System.Windows.Forms.TextBox ();
			this.button3 = new System.Windows.Forms.Button ();
			this.label1 = new System.Windows.Forms.Label ();
			this.txtUsername = new System.Windows.Forms.TextBox ();
			this.button1 = new System.Windows.Forms.Button ();
			this.label3 = new System.Windows.Forms.Label ();
			this.txtConfirmation = new System.Windows.Forms.TextBox ();
			this.SuspendLayout ();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point ( 255, 44 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size ( 50, 16 );
			this.label2.TabIndex = 11;
			this.label2.Text = "گذرواژه:";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point ( 12, 41 );
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size ( 237, 23 );
			this.txtPassword.TabIndex = 1;
			// 
			// button3
			// 
			this.button3.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button3.Image" ) ) );
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.Location = new System.Drawing.Point ( 174, 99 );
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size ( 75, 32 );
			this.button3.TabIndex = 3;
			this.button3.Text = "ثبت";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler ( this.button3_Click );
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point ( 255, 15 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 68, 16 );
			this.label1.TabIndex = 8;
			this.label1.Text = "نام کاربری:";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point ( 12, 12 );
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size ( 237, 23 );
			this.txtUsername.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button1.Image" ) ) );
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point ( 12, 99 );
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size ( 87, 32 );
			this.button1.TabIndex = 4;
			this.button1.Text = "بازگشت";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler ( this.button1_Click );
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point ( 255, 73 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size ( 50, 16 );
			this.label3.TabIndex = 14;
			this.label3.Text = "گذرواژه:";
			// 
			// txtConfirmation
			// 
			this.txtConfirmation.Location = new System.Drawing.Point ( 12, 70 );
			this.txtConfirmation.Name = "txtConfirmation";
			this.txtConfirmation.PasswordChar = '*';
			this.txtConfirmation.Size = new System.Drawing.Size ( 237, 23 );
			this.txtConfirmation.TabIndex = 2;
			// 
			// frmNewUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 16F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ( (System.Drawing.Image) ( resources.GetObject ( "$this.BackgroundImage" ) ) );
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size ( 330, 141 );
			this.ControlBox = false;
			this.Controls.Add ( this.label3 );
			this.Controls.Add ( this.txtConfirmation );
			this.Controls.Add ( this.button1 );
			this.Controls.Add ( this.label2 );
			this.Controls.Add ( this.txtPassword );
			this.Controls.Add ( this.button3 );
			this.Controls.Add ( this.label1 );
			this.Controls.Add ( this.txtUsername );
			this.Font = new System.Drawing.Font ( "Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 178 ) ) );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding ( 3, 4, 3, 4 );
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmNewUser";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "نرم افزار مدیریت هتل - کاربر جدید";
			this.ResumeLayout ( false );
			this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmation;
    }
}