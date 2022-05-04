namespace HotelManagementSoftware
{
    partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( frmMain ) );
			this.panel1 = new System.Windows.Forms.Panel ();
			this.dataGridView1 = new System.Windows.Forms.DataGridView ();
			this.label1 = new System.Windows.Forms.Label ();
			this.label2 = new System.Windows.Forms.Label ();
			this.label3 = new System.Windows.Forms.Label ();
			this.button1 = new System.Windows.Forms.Button ();
			this.button2 = new System.Windows.Forms.Button ();
			this.button3 = new System.Windows.Forms.Button ();
			this.button4 = new System.Windows.Forms.Button ();
			this.button6 = new System.Windows.Forms.Button ();
			this.button5 = new System.Windows.Forms.Button ();
			this.pictureBox1 = new System.Windows.Forms.PictureBox ();
			this.lblHint = new System.Windows.Forms.Label ();
			this.button7 = new System.Windows.Forms.Button ();
			this.button8 = new System.Windows.Forms.Button ();
			this.button9 = new System.Windows.Forms.Button ();
			this.panel1.SuspendLayout ();
			( (System.ComponentModel.ISupportInitialize) ( this.dataGridView1 ) ).BeginInit ();
			( (System.ComponentModel.ISupportInitialize) ( this.pictureBox1 ) ).BeginInit ();
			this.SuspendLayout ();
			// 
			// panel1
			// 
			this.panel1.Controls.Add ( this.dataGridView1 );
			this.panel1.Location = new System.Drawing.Point ( 0, 147 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size ( 966, 378 );
			this.panel1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point ( 0, 0 );
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size ( 966, 378 );
			this.dataGridView1.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Yellow;
			this.label1.Location = new System.Drawing.Point ( 671, 528 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 107, 16 );
			this.label1.TabIndex = 1;
			this.label1.Text = "نیاز به نظافت دارد.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb ( ( (int) ( ( (byte) ( 0 ) ) ) ), ( (int) ( ( (byte) ( 192 ) ) ) ), ( (int) ( ( (byte) ( 0 ) ) ) ) );
			this.label2.Location = new System.Drawing.Point ( 784, 528 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size ( 94, 16 );
			this.label2.TabIndex = 2;
			this.label2.Text = "رزرو شده است.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point ( 884, 528 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size ( 74, 16 );
			this.label3.TabIndex = 3;
			this.label3.Text = "خالی است.";
			// 
			// button1
			// 
			this.button1.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button1.Image" ) ) );
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point ( 331, 16 );
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size ( 79, 36 );
			this.button1.TabIndex = 5;
			this.button1.Tag = "برای انجام نظافت اتاق های هتل کلیک کنید.";
			this.button1.Text = "نظافت";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler ( this.button1_Click );
			this.button1.MouseHover += new System.EventHandler ( this.button4_MouseHover );
			// 
			// button2
			// 
			this.button2.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button2.Image" ) ) );
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.Location = new System.Drawing.Point ( 416, 16 );
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size ( 102, 36 );
			this.button2.TabIndex = 4;
			this.button2.Tag = "برای افزودن اتاق به لیست اتاق های هتل کلیک کنید.";
			this.button2.Text = "افزودن اتاق";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler ( this.button2_Click );
			this.button2.MouseHover += new System.EventHandler ( this.button4_MouseHover );
			// 
			// button3
			// 
			this.button3.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button3.Image" ) ) );
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.Location = new System.Drawing.Point ( 766, 16 );
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size ( 102, 36 );
			this.button3.TabIndex = 1;
			this.button3.Tag = "برای ایجاد تغییرات بر روی جزییات یک رزرو موجود و ثبت آن تغییرات و یا ابطال کلی یک" +
				" رزرو کلیک کنید.";
			this.button3.Text = "ویرایش رزرو";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler ( this.button3_Click );
			this.button3.MouseHover += new System.EventHandler ( this.button4_MouseHover );
			// 
			// button4
			// 
			this.button4.Cursor = System.Windows.Forms.Cursors.Default;
			this.button4.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button4.Image" ) ) );
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button4.Location = new System.Drawing.Point ( 873, 16 );
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size ( 73, 36 );
			this.button4.TabIndex = 0;
			this.button4.Tag = "برای انجام یک رزرو جدید و ثبت جزییات مربوط به آن کلیک کنید.";
			this.button4.Text = "رزرو";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler ( this.button4_Click );
			this.button4.MouseHover += new System.EventHandler ( this.button4_MouseHover );
			// 
			// button6
			// 
			this.button6.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button6.Image" ) ) );
			this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button6.Location = new System.Drawing.Point ( 524, 16 );
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size ( 116, 36 );
			this.button6.TabIndex = 3;
			this.button6.Tag = "برای مشاهده جزییات مالی یک رزرو و انجام پرداخت مبلغ هزینه رزرو ها کلیک کنید.";
			this.button6.Text = "وضعیت مالی";
			this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler ( this.button6_Click );
			this.button6.MouseHover += new System.EventHandler ( this.button4_MouseHover );
			// 
			// button5
			// 
			this.button5.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button5.Image" ) ) );
			this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button5.Location = new System.Drawing.Point ( 644, 16 );
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size ( 116, 36 );
			this.button5.TabIndex = 2;
			this.button5.Tag = "برای انجام تسویه حساب مربوط به یک رزرو کلیک کنید.";
			this.button5.Text = "تسویه حساب";
			this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler ( this.button5_Click );
			this.button5.MouseHover += new System.EventHandler ( this.button4_MouseHover );
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ( (System.Drawing.Image) ( resources.GetObject ( "pictureBox1.Image" ) ) );
			this.pictureBox1.Location = new System.Drawing.Point ( -56, -39 );
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size ( 1024, 272 );
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// lblHint
			// 
			this.lblHint.Font = new System.Drawing.Font ( "Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ( (byte) ( 178 ) ) );
			this.lblHint.ForeColor = System.Drawing.Color.Blue;
			this.lblHint.Location = new System.Drawing.Point ( 313, 59 );
			this.lblHint.Name = "lblHint";
			this.lblHint.Size = new System.Drawing.Size ( 635, 19 );
			this.lblHint.TabIndex = 12;
			// 
			// button7
			// 
			this.button7.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button7.Image" ) ) );
			this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button7.Location = new System.Drawing.Point ( 249, 16 );
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size ( 76, 36 );
			this.button7.TabIndex = 6;
			this.button7.Tag = "برای دیدن سوابق هتل و رزرو ها کلیک کنید.";
			this.button7.Text = "سوابق";
			this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler ( this.button7_Click );
			this.button7.MouseHover += new System.EventHandler ( this.button4_MouseHover );
			// 
			// button8
			// 
			this.button8.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button8.Image" ) ) );
			this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button8.Location = new System.Drawing.Point ( 69, 16 );
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size ( 76, 36 );
			this.button8.TabIndex = 8;
			this.button8.Tag = "برای خروج از برنامه کلیلک کنید.";
			this.button8.Text = "خروج";
			this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler ( this.button8_Click );
			// 
			// button9
			// 
			this.button9.Image = ( (System.Drawing.Image) ( resources.GetObject ( "button9.Image" ) ) );
			this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button9.Location = new System.Drawing.Point ( 151, 16 );
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size ( 92, 36 );
			this.button9.TabIndex = 7;
			this.button9.Tag = "برای دیدن اطلاعات همراهان یک رزرو کلیلک کنید.";
			this.button9.Text = "همرامان";
			this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler ( this.button9_Click );
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 16F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size ( 967, 553 );
			this.Controls.Add ( this.button9 );
			this.Controls.Add ( this.button8 );
			this.Controls.Add ( this.button7 );
			this.Controls.Add ( this.lblHint );
			this.Controls.Add ( this.button5 );
			this.Controls.Add ( this.button6 );
			this.Controls.Add ( this.button4 );
			this.Controls.Add ( this.button3 );
			this.Controls.Add ( this.button2 );
			this.Controls.Add ( this.button1 );
			this.Controls.Add ( this.label1 );
			this.Controls.Add ( this.label2 );
			this.Controls.Add ( this.panel1 );
			this.Controls.Add ( this.label3 );
			this.Controls.Add ( this.pictureBox1 );
			this.Font = new System.Drawing.Font ( "Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 178 ) ) );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding ( 3, 4, 3, 4 );
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "نرم افزار مدیریت هتل - فرم اصلی";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler ( this.frmMain_FormClosed );
			this.Load += new System.EventHandler ( this.frmMain_Load );
			this.panel1.ResumeLayout ( false );
			( (System.ComponentModel.ISupportInitialize) ( this.dataGridView1 ) ).EndInit ();
			( (System.ComponentModel.ISupportInitialize) ( this.pictureBox1 ) ).EndInit ();
			this.ResumeLayout ( false );
			this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
     
      

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button button7;
		private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
    }
}