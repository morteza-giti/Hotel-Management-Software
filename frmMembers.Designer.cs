namespace HotelManagementSoftware
{
    partial class frmMembers
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView ();
			this.button1 = new System.Windows.Forms.Button ();
			this.label1 = new System.Windows.Forms.Label ();
			this.textBox1 = new System.Windows.Forms.TextBox ();
			( (System.ComponentModel.ISupportInitialize) ( this.dataGridView1 ) ).BeginInit ();
			this.SuspendLayout ();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point ( 0, 45 );
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size ( 940, 393 );
			this.dataGridView1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point ( 699, 11 );
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size ( 75, 23 );
			this.button1.TabIndex = 1;
			this.button1.Text = "فیلتر";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler ( this.button1_Click );
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point ( 886, 14 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 50, 16 );
			this.label1.TabIndex = 2;
			this.label1.Text = "کد رزرو:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point ( 780, 11 );
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size ( 100, 23 );
			this.textBox1.TabIndex = 0;
			// 
			// frmMembers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 16F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 940, 438 );
			this.Controls.Add ( this.textBox1 );
			this.Controls.Add ( this.label1 );
			this.Controls.Add ( this.button1 );
			this.Controls.Add ( this.dataGridView1 );
			this.Font = new System.Drawing.Font ( "Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 178 ) ) );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding ( 3, 4, 3, 4 );
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMembers";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "نرم افزار مدیریت هتل - همراهان";
			this.Load += new System.EventHandler ( this.frmMembers_Load );
			( (System.ComponentModel.ISupportInitialize) ( this.dataGridView1 ) ).EndInit ();
			this.ResumeLayout ( false );
			this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}