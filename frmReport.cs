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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent ();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
			using ( DataClasses1DataContext dc=new DataClasses1DataContext() )
			{
				dataGridView1.DataSource = from r in dc.tblReservations
										   select new
										   {
											   ReservationCode=r.ReservationCode,
											   FName=r.FName,
											   LName=r.LName,
											   Popularity=r.Popularity,
											   RDate=r.RDate,
											   Telephone=r.Telephone,
											   Address=r.Address,
											   RoomCode=r.RoomCode,
											   NumsOfDays=r.NumsOfDays,
											   Cost=r.Cost
										   };
			}

            dataGridView1.Columns[0].HeaderText = "کد";
            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[2].HeaderText = "نام خ.";
            dataGridView1.Columns[3].HeaderText = "شهرت";
            dataGridView1.Columns[4].HeaderText = "تاریخ رزور";
            dataGridView1.Columns[5].HeaderText = "تلفن";
            dataGridView1.Columns[6].HeaderText = "آدرس";
            dataGridView1.Columns[7].HeaderText = "شماره اتاق";
            dataGridView1.Columns[8].HeaderText = "تعداد روز";
            dataGridView1.Columns[9].HeaderText = "هزینه اقامت";
        }
    }
}
