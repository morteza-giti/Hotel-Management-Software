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
    public partial class frmVacantRooms : Form
    {
        public frmVacantRooms()
        {
            InitializeComponent ();
        }

       

        private void frmVacantRooms_Load(object sender, EventArgs e)
        {
           

			using ( DataClasses1DataContext dc = new DataClasses1DataContext () )
			{
				dataGridView1.DataSource = from c in dc.tblRooms where c.Status == 0 select new { RoomCode = c.RoomCode, NumOfBeds = c.NumsOfBed, Price = c.RPrice };
			}
			


            dataGridView1.Columns[0].HeaderText = "شماره اتاق";
            dataGridView1.Columns[1].HeaderText = "تعداد تخت";
            dataGridView1.Columns[2].HeaderText = "نرخ اتاق";
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow r = dataGridView1.SelectedRows[0];
            frmReservation.roomId = frmEditReservation.roomId = (int) r.Cells[0].Value;
            frmReservation.roomPrice = frmEditReservation.roomPrice = (decimal) r.Cells[2].Value;
            this.Close ();
        }

     

      

    

    

      
    }
}
