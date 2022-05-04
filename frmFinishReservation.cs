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
    public partial class frmFinishReservation : Form
    {
        public frmFinishReservation()
        {
            InitializeComponent ();
        }

        private void txtReCode_Leave(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext ();
            decimal? cost = 0;
            var reserve = from r in dc.tblReservations where r.ReservationCode == int.Parse ( txtReCode.Text ) select r;
            if ( reserve.Count()==0 )
            {
                MessageBox.Show ( "هیچ رزروی با این کد یافت نشد." );
                return;
            }
            foreach ( tblReservation  item in reserve  )
            {
                cost = item.Cost;
                txtCost.Text = item.Cost.ToString ();
                txtReRoom.Text = item.RoomCode.ToString ();
                txtRoomPrice.Text = item.tblRoom.RPrice.ToString ();
                
            }
            var pays = from p in dc.tblPayments  where p.ReservationCode == int.Parse ( txtReCode.Text ) select p;
            decimal? sum = 0;
            foreach ( tblPayment item in pays )
            {
                sum += item.PAmount;
            }
            txtBalance.Text = sum.ToString ();
            txtOwe.Text =(cost- sum).ToString();
            txtReCode.ReadOnly = true;
            if ( decimal.Parse(txtOwe.Text)>0 )
            {
                button1.Enabled = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
DataClasses1DataContext dc = new DataClasses1DataContext ();
            dc.ExecuteCommand ( "insert into tblpayment(reservationcode,pdate,pamount)values({0},{1},{2})",int.Parse( txtReCode.Text), DateTime.Now, decimal.Parse ( txtOwe.Text ) );
            dc.SubmitChanges ();
            dc.ExecuteCommand ( "update tblroom set status=2 where roomcode={0}", int.Parse ( txtReRoom.Text ) );
            dc.SubmitChanges ();
            MessageBox.Show ( "عمل تسویه حساب با موفقیت انجام شد." );
            }
            catch ( Exception ex )
            {

                MessageBox.Show ( "عمل درخواست شده با مشکل مواجه شد." );
                MessageBox.Show ( "Source: " + ex.Source + " " + "Message: " + ex.Message );
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtReCode.Text = txtOwe.Text = txtCost.Text = txtBalance.Text = txtReRoom.Text = txtRoomPrice.Text = string.Empty;
            txtReCode.ReadOnly = false ;
            button1.Enabled = false;
            txtReCode.Focus ();
        }

        private void frmFinishReservation_Load(object sender, EventArgs e)
        {
        }

     
    }
}
