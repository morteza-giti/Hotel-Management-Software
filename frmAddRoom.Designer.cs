namespace HotelManagementSoftware
{
    partial class frmAddRoom
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( frmAddRoom ) );
			this.button1 = new System.Windows.Forms.Button ();
			this.label1 = new System.Windows.Forms.Label ();
			this.label2 = new System.Windows.Forms.Label ();
			this.txtPrice = new System.Windows.Forms.TextBox ();
			this.button3 = new System.Windows.Forms.Button ();
			this.txtNumsOfBeds = new System.Windows.Forms.NumericUpDown ();
			this.lblCode = new System.Windows.Forms.Label ();
			( (System.ComponentModel.ISupportInitialize) ( this.txtNumsOfBeds ) ).BeginInit ();
			this.SuspendLayout ();
			// 
			// button1
			// 
			this.button1.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button1.Image" ) ) );
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point ( 11, 95 );
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size ( 64, 33 );
			this.button1.TabIndex = 3;
			this.button1.Text = "ثبت";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler ( this.button1_Click );
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point ( 199, 16 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 68, 16 );
			this.label1.TabIndex = 2;
			this.label1.Text = "تعداد تخت:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point ( 199, 45 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size ( 30, 16 );
			this.label2.TabIndex = 4;
			this.label2.Text = "نرخ:";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point ( 12, 38 );
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size ( 181, 23 );
			this.txtPrice.TabIndex = 1;
			// 
			// button3
			// 
			this.button3.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button3.Image" ) ) );
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.Location = new System.Drawing.Point ( 81, 95 );
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size ( 75, 33 );
			this.button3.TabIndex = 2;
			this.button3.Text = "جدید";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler ( this.button3_Click );
			// 
			// txtNumsOfBeds
			// 
			this.txtNumsOfBeds.Location = new System.Drawing.Point ( 12, 12 );
			this.txtNumsOfBeds.Maximum = new decimal ( new int[] {
            10,
            0,
            0,
            0} );
			this.txtNumsOfBeds.Minimum = new decimal ( new int[] {
            1,
            0,
            0,
            0} );
			this.txtNumsOfBeds.Name = "txtNumsOfBeds";
			this.txtNumsOfBeds.Size = new System.Drawing.Size ( 181, 23 );
			this.txtNumsOfBeds.TabIndex = 0;
			this.txtNumsOfBeds.Value = new decimal ( new int[] {
            1,
            0,
            0,
            0} );
			// 
			// lblCode
			// 
			this.lblCode.BackColor = System.Drawing.Color.Transparent;
			this.lblCode.Font = new System.Drawing.Font ( "Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ( (byte) ( 178 ) ) );
			this.lblCode.ForeColor = System.Drawing.Color.Black;
			this.lblCode.Location = new System.Drawing.Point ( 12, 67 );
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size ( 181, 22 );
			this.lblCode.TabIndex = 16;
			// 
			// frmAddRoom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 16F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ( (System.Drawing.Image) ( resources.GetObject ( "$this.BackgroundImage" ) ) );
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size ( 268, 140 );
			this.Controls.Add ( this.lblCode );
			this.Controls.Add ( this.txtNumsOfBeds );
			this.Controls.Add ( this.button3 );
			this.Controls.Add ( this.label2 );
			this.Controls.Add ( this.txtPrice );
			this.Controls.Add ( this.label1 );
			this.Controls.Add ( this.button1 );
			this.Font = new System.Drawing.Font ( "Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 178 ) ) );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding ( 3, 4, 3, 4 );
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAddRoom";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "نرم افزار مدیریت هتل - افزودن اتاق";
			( (System.ComponentModel.ISupportInitialize) ( this.txtNumsOfBeds ) ).EndInit ();
			this.ResumeLayout ( false );
			this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown txtNumsOfBeds;
        private System.Windows.Forms.Label lblCode;
    }
}