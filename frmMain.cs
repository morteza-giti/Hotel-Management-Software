using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementSoftware
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent ();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
			DataClasses1DataContext dc = new DataClasses1DataContext ();
			dataGridView1.DataSource = from c in dc.tblRooms select c;

            dataGridView1.Columns[0].HeaderText = "شماره اتاق";
            dataGridView1.Columns[1].HeaderText = "تعداد تخت";
            dataGridView1.Columns[2].HeaderText = "نرخ اتاق";
            dataGridView1.Columns[3].HeaderText = "وضعیت";
            foreach ( DataGridViewRow item in dataGridView1.Rows )
            {
                switch ( item.Cells[3].Value.ToString () )
                {
                    case "2":
                        item.DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    case "1":
                        item.DefaultCellStyle.BackColor = Color.Green;
                        break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmReservation frm = new frmReservation ();
            frm.ShowDialog ();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEditReservation frm = new frmEditReservation ();
            frm.ShowDialog  ();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddRoom frm = new frmAddRoom ();
            frm.ShowDialog ();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmClean frm = new frmClean ();
            frm.ShowDialog ();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmPay frm = new frmPay ();
            frm.ShowDialog ();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmFinishReservation frm = new frmFinishReservation ();
            frm.ShowDialog ();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            
            lblHint.Text =((Button)sender).Tag.ToString ();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport ();
            frm.ShowDialog ();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit ();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit ();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmMembers frm = new frmMembers ();
            frm.ShowDialog ();
        }

     

      

       
     

     
  
    }
}
