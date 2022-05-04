namespace HotelManagementSoftware
{
    partial class frmFinishReservation
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( frmFinishReservation ) );
			this.label4 = new System.Windows.Forms.Label ();
			this.txtCost = new System.Windows.Forms.TextBox ();
			this.label3 = new System.Windows.Forms.Label ();
			this.txtRoomPrice = new System.Windows.Forms.TextBox ();
			this.label2 = new System.Windows.Forms.Label ();
			this.txtReRoom = new System.Windows.Forms.TextBox ();
			this.label1 = new System.Windows.Forms.Label ();
			this.txtReCode = new System.Windows.Forms.TextBox ();
			this.button3 = new System.Windows.Forms.Button ();
			this.button1 = new System.Windows.Forms.Button ();
			this.txtOwe = new System.Windows.Forms.TextBox ();
			this.label5 = new System.Windows.Forms.Label ();
			this.txtBalance = new System.Windows.Forms.TextBox ();
			this.label6 = new System.Windows.Forms.Label ();
			this.SuspendLayout ();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point ( 248, 102 );
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size ( 78, 16 );
			this.label4.TabIndex = 16;
			this.label4.Text = "هزینه اقامت:";
			// 
			// txtCost
			// 
			this.txtCost.Location = new System.Drawing.Point ( 22, 99 );
			this.txtCost.Name = "txtCost";
			this.txtCost.ReadOnly = true;
			this.txtCost.Size = new System.Drawing.Size ( 220, 23 );
			this.txtCost.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point ( 248, 73 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size ( 56, 16 );
			this.label3.TabIndex = 14;
			this.label3.Text = "نرخ اتاق:";
			// 
			// txtRoomPrice
			// 
			this.txtRoomPrice.Location = new System.Drawing.Point ( 22, 70 );
			this.txtRoomPrice.Name = "txtRoomPrice";
			this.txtRoomPrice.ReadOnly = true;
			this.txtRoomPrice.Size = new System.Drawing.Size ( 220, 23 );
			this.txtRoomPrice.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point ( 248, 44 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size ( 75, 16 );
			this.label2.TabIndex = 12;
			this.label2.Text = "شماره اتاق:";
			// 
			// txtReRoom
			// 
			this.txtReRoom.Location = new System.Drawing.Point ( 22, 41 );
			this.txtReRoom.Name = "txtReRoom";
			this.txtReRoom.ReadOnly = true;
			this.txtReRoom.Size = new System.Drawing.Size ( 220, 23 );
			this.txtReRoom.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point ( 248, 15 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 50, 16 );
			this.label1.TabIndex = 10;
			this.label1.Text = "کد رزرو:";
			// 
			// txtReCode
			// 
			this.txtReCode.Location = new System.Drawing.Point ( 22, 12 );
			this.txtReCode.Name = "txtReCode";
			this.txtReCode.Size = new System.Drawing.Size ( 220, 23 );
			this.txtReCode.TabIndex = 0;
			this.txtReCode.Leave += new System.EventHandler ( this.txtReCode_Leave );
			// 
			// button3
			// 
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button3.Image" ) ) );
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.Location = new System.Drawing.Point ( 153, 187 );
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size ( 75, 35 );
			this.button3.TabIndex = 6;
			this.button3.Text = "جدید";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler ( this.button3_Click );
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button1.Image" ) ) );
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point ( 22, 187 );
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size ( 125, 35 );
			this.button1.TabIndex = 7;
			this.button1.Text = "تسویه حساب";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler ( this.button1_Click );
			// 
			// txtOwe
			// 
			this.txtOwe.Location = new System.Drawing.Point ( 22, 128 );
			this.txtOwe.Name = "txtOwe";
			this.txtOwe.ReadOnly = true;
			this.txtOwe.Size = new System.Drawing.Size ( 220, 23 );
			this.txtOwe.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point ( 248, 131 );
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size ( 60, 16 );
			this.label5.TabIndex = 21;
			this.label5.Text = "بدهکاری:";
			// 
			// txtBalance
			// 
			this.txtBalance.Location = new System.Drawing.Point ( 22, 158 );
			this.txtBalance.Name = "txtBalance";
			this.txtBalance.ReadOnly = true;
			this.txtBalance.Size = new System.Drawing.Size ( 220, 23 );
			this.txtBalance.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point ( 248, 161 );
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size ( 100, 16 );
			this.label6.TabIndex = 19;
			this.label6.Text = "مجموع پرداختی:";
			// 
			// frmFinishReservation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 16F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ( (System.Drawing.Image) ( resources.GetObject ( "$this.BackgroundImage" ) ) );
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size ( 350, 229 );
			this.Controls.Add ( this.txtOwe );
			this.Controls.Add ( this.label5 );
			this.Controls.Add ( this.txtBalance );
			this.Controls.Add ( this.label6 );
			this.Controls.Add ( this.button3 );
			this.Controls.Add ( this.button1 );
			this.Controls.Add ( this.label4 );
			this.Controls.Add ( this.txtCost );
			this.Controls.Add ( this.label3 );
			this.Controls.Add ( this.txtRoomPrice );
			this.Controls.Add ( this.label2 );
			this.Controls.Add ( this.txtReRoom );
			this.Controls.Add ( this.label1 );
			this.Controls.Add ( this.txtReCode );
			this.Font = new System.Drawing.Font ( "Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 178 ) ) );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding ( 3, 4, 3, 4 );
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFinishReservation";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "نرم افزار مدیریت هتل - تسویه حساب";
			this.Load += new System.EventHandler ( this.frmFinishReservation_Load );
			this.ResumeLayout ( false );
			this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReCode;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOwe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBalance;
		private System.Windows.Forms.Label label6;
    }
}