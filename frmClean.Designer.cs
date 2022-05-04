namespace HotelManagementSoftware
{
    partial class frmClean
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( frmClean ) );
			this.txtStatus = new System.Windows.Forms.TextBox ();
			this.label2 = new System.Windows.Forms.Label ();
			this.txtRoomCode = new System.Windows.Forms.TextBox ();
			this.label1 = new System.Windows.Forms.Label ();
			this.button1 = new System.Windows.Forms.Button ();
			this.button2 = new System.Windows.Forms.Button ();
			this.SuspendLayout ();
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point ( 12, 41 );
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.ReadOnly = true;
			this.txtStatus.Size = new System.Drawing.Size ( 164, 23 );
			this.txtStatus.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point ( 182, 44 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size ( 51, 16 );
			this.label2.TabIndex = 10;
			this.label2.Text = "وضعیت:";
			// 
			// txtRoomCode
			// 
			this.txtRoomCode.Location = new System.Drawing.Point ( 12, 12 );
			this.txtRoomCode.Name = "txtRoomCode";
			this.txtRoomCode.Size = new System.Drawing.Size ( 164, 23 );
			this.txtRoomCode.TabIndex = 0;
			this.txtRoomCode.Leave += new System.EventHandler ( this.txtReCode_Leave );
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point ( 182, 15 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 75, 16 );
			this.label1.TabIndex = 8;
			this.label1.Text = "شماره اتاق:";
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button1.Image" ) ) );
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point ( 12, 70 );
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size ( 83, 35 );
			this.button1.TabIndex = 3;
			this.button1.Text = "نظافت";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler ( this.button1_Click );
			// 
			// button2
			// 
			this.button2.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button2.Image" ) ) );
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.Location = new System.Drawing.Point ( 101, 70 );
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size ( 75, 35 );
			this.button2.TabIndex = 2;
			this.button2.Text = "جدید";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler ( this.button2_Click );
			// 
			// frmClean
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 16F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ( (System.Drawing.Image) ( resources.GetObject ( "$this.BackgroundImage" ) ) );
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size ( 269, 116 );
			this.Controls.Add ( this.button2 );
			this.Controls.Add ( this.txtStatus );
			this.Controls.Add ( this.label2 );
			this.Controls.Add ( this.txtRoomCode );
			this.Controls.Add ( this.label1 );
			this.Controls.Add ( this.button1 );
			this.Font = new System.Drawing.Font ( "Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 178 ) ) );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding ( 3, 4, 3, 4 );
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmClean";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "نرم افزار مدیریت هتل - نظافت";
			this.Load += new System.EventHandler ( this.frmClean_Load );
			this.ResumeLayout ( false );
			this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoomCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}