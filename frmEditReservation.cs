using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.Linq;
namespace HotelManagementSoftware
{
    public partial class frmEditReservation : Form
    {
        string PreRoom = string.Empty;
        int numsOfStay = 0;
        public static int roomId = 0;
        public static decimal roomPrice = 0;
        public frmEditReservation()
        {
            InitializeComponent ();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
           
            DataClasses1DataContext dc = new DataClasses1DataContext ();
            int rCode = int.Parse ( txtReCode.Text );
            var reserve = from r in dc.tblReservations where r.ReservationCode == rCode select r;
            if ( reserve.Count () != 0 )
            {
                foreach ( tblReservation item in reserve )
                {
                    txtReRoom.Text = item.RoomCode.ToString ();
                    PreRoom = txtReRoom.Text;
                    txtRoomPrice.Text = item.tblRoom.RPrice.ToString ();
                    txtCost.Text = ( decimal.Parse ( txtRoomPrice.Text ) * item.NumsOfDays ).ToString ();
                    numsOfStay = (int)item.NumsOfDays;
                }
                txtRoomPrice.Enabled = txtReRoom .Enabled = txtReCode.Enabled =txtReCode.Enabled = false;
                button1.Enabled = true;
                button4.Enabled = true;
                
                
            }
            else
            {
                MessageBox.Show ( "هیچ رزروی با این کد یافت نشد." );
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmVacantRooms frm = new frmVacantRooms ();
            frm.ShowDialog ();
        }

        private void frmEditReservation_Load(object sender, EventArgs e)
        {
            roomId = 0;
            roomPrice = 0;
        }

       

     

        private void frmEditReservation_Activated(object sender, EventArgs e)
        {
            txtRoomPrice.Text = roomPrice.ToString ();
            txtReRoom.Text = roomId.ToString ();
            txtCost.Text = ( numsOfStay * decimal.Parse ( txtRoomPrice.Text ) ).ToString ();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCost.Text = txtReCode.Text = txtReRoom.Text = txtRoomPrice.Text = string.Empty;
            txtRoomPrice.Enabled = txtReRoom.Enabled = txtReCode.Enabled = txtReCode.Enabled = true;
            txtReCode.Focus();
            button1.Enabled = false;
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            dc.ExecuteCommand("update tblroom set status=1 where roomcode={0}",int.Parse(txtReRoom.Text) );
            dc.SubmitChanges();
            dc.ExecuteCommand  ( "update tblroom set status=0 where roomcode={0}", int.Parse ( PreRoom ) );
            dc.SubmitChanges ();
            dc.ExecuteCommand("update tblReservation set RoomCode={0} where ReservationCode={1}", int.Parse(txtReRoom.Text), int.Parse(txtReCode.Text));
            dc.SubmitChanges();
               
            MessageBox.Show("ویرایش با موفقیت انجام شد.");
            }
         
                
                 catch ( Exception ex)
                {

                    MessageBox.Show ( "عمل درخواست شده با مشکل مواجه شد." );
                    MessageBox.Show ( "Source: " + ex.Source + " " + "Message: " + ex.Message );
                }
          
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show ( "آیا به ابطال رزرو اطمینان دارید؟","ابطال ",MessageBoxButtons.OKCancel) == DialogResult.OK )
            {
                try
                {
                 DataClasses1DataContext dc = new DataClasses1DataContext ();
                 dc.ExecuteCommand ( "delete from tblpayment where reservationcode={0}", int.Parse ( txtReCode.Text ) );
                 dc.ExecuteCommand ( "delete from tblmembers where reservationcode={0}", int.Parse ( txtReCode.Text ) );
                dc.ExecuteCommand ( "delete from tblreservation where reservationcode={0}", int.Parse ( txtReCode.Text ) );
                dc.ExecuteCommand ( "update tblroom set status=1 where roomcode={0}", int.Parse ( txtReRoom.Text ) );
                dc.SubmitChanges ();
                MessageBox.Show ( "ابطال رزرو با موفقیت انجام شد." );
                button3_Click ( sender, e );
                }
                catch ( Exception ex)
                {

                    MessageBox.Show ( "عمل درخواست شده با مشکل مواجه شد." );
                    MessageBox.Show ( "Source: " + ex.Source + " " + "Message: " + ex.Message );
                }
               
            }
        }

       
   
    }
}
