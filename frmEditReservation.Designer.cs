namespace HotelManagementSoftware
{
    partial class frmEditReservation
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( frmEditReservation ) );
			this.txtReCode = new System.Windows.Forms.TextBox ();
			this.label1 = new System.Windows.Forms.Label ();
			this.label2 = new System.Windows.Forms.Label ();
			this.txtReRoom = new System.Windows.Forms.TextBox ();
			this.label3 = new System.Windows.Forms.Label ();
			this.txtRoomPrice = new System.Windows.Forms.TextBox ();
			this.label4 = new System.Windows.Forms.Label ();
			this.txtCost = new System.Windows.Forms.TextBox ();
			this.button2 = new System.Windows.Forms.Button ();
			this.button3 = new System.Windows.Forms.Button ();
			this.button1 = new System.Windows.Forms.Button ();
			this.button4 = new System.Windows.Forms.Button ();
			this.SuspendLayout ();
			// 
			// txtReCode
			// 
			this.txtReCode.Enabled = false;
			this.txtReCode.Location = new System.Drawing.Point ( 12, 12 );
			this.txtReCode.Name = "txtReCode";
			this.txtReCode.Size = new System.Drawing.Size ( 232, 23 );
			this.txtReCode.TabIndex = 0;
			this.txtReCode.Leave += new System.EventHandler ( this.textBox1_Leave );
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.label1.Location = new System.Drawing.Point ( 250, 15 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 50, 16 );
			this.label1.TabIndex = 2;
			this.label1.Text = "کد رزرو:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.label2.Location = new System.Drawing.Point ( 250, 44 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size ( 75, 16 );
			this.label2.TabIndex = 4;
			this.label2.Text = "شماره اتاق:";
			// 
			// txtReRoom
			// 
			this.txtReRoom.Enabled = false;
			this.txtReRoom.Location = new System.Drawing.Point ( 47, 41 );
			this.txtReRoom.Name = "txtReRoom";
			this.txtReRoom.Size = new System.Drawing.Size ( 197, 23 );
			this.txtReRoom.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.label3.Location = new System.Drawing.Point ( 250, 73 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size ( 56, 16 );
			this.label3.TabIndex = 6;
			this.label3.Text = "نرخ اتاق:";
			// 
			// txtRoomPrice
			// 
			this.txtRoomPrice.Enabled = false;
			this.txtRoomPrice.Location = new System.Drawing.Point ( 12, 70 );
			this.txtRoomPrice.Name = "txtRoomPrice";
			this.txtRoomPrice.Size = new System.Drawing.Size ( 232, 23 );
			this.txtRoomPrice.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.label4.Location = new System.Drawing.Point ( 250, 102 );
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size ( 78, 16 );
			this.label4.TabIndex = 8;
			this.label4.Text = "هزینه اقامت:";
			// 
			// txtCost
			// 
			this.txtCost.Enabled = false;
			this.txtCost.Location = new System.Drawing.Point ( 12, 99 );
			this.txtCost.Name = "txtCost";
			this.txtCost.Size = new System.Drawing.Size ( 232, 23 );
			this.txtCost.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point ( 12, 41 );
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size ( 29, 23 );
			this.button2.TabIndex = 2;
			this.button2.Text = "...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler ( this.button2_Click );
			// 
			// button3
			// 
			this.button3.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button3.Image" ) ) );
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.Location = new System.Drawing.Point ( 211, 129 );
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size ( 75, 35 );
			this.button3.TabIndex = 5;
			this.button3.Text = "جدید";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler ( this.button3_Click );
			// 
			// button1
			// 
			this.button1.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button1.Image" ) ) );
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point ( 11, 129 );
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size ( 113, 35 );
			this.button1.TabIndex = 7;
			this.button1.Text = "به روز رسانی";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler ( this.button1_Click );
			// 
			// button4
			// 
			this.button4.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button4.Image" ) ) );
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button4.Location = new System.Drawing.Point ( 130, 129 );
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size ( 75, 35 );
			this.button4.TabIndex = 6;
			this.button4.Text = "ابطال";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler ( this.button4_Click );
			// 
			// frmEditReservation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 16F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ( (System.Drawing.Image) ( resources.GetObject ( "$this.BackgroundImage" ) ) );
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size ( 334, 173 );
			this.Controls.Add ( this.button4 );
			this.Controls.Add ( this.button1 );
			this.Controls.Add ( this.button3 );
			this.Controls.Add ( this.button2 );
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
			this.Name = "frmEditReservation";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "نرم افزار مدیریت هتل - ویرایش رزرو";
			this.Activated += new System.EventHandler ( this.frmEditReservation_Activated );
			this.Load += new System.EventHandler ( this.frmEditReservation_Load );
			this.ResumeLayout ( false );
			this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}