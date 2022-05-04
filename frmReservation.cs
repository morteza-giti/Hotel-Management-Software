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
    public partial class frmReservation : Form
    {
        public static  int roomId = 0;
        public static decimal roomPrice = 0;
        public frmReservation()
        {
            InitializeComponent ();
        }
        DataClasses1DataContext dc = new DataClasses1DataContext ();
        tblReservation reserve;
        private void button1_Click(object sender, EventArgs e)
        {
            if ( txtPrePay.Enabled == true && decimal.Parse ( txtPrePay.Text ) > 0 && decimal.Parse ( txtPrePay.Text ) < decimal.Parse ( txtCost.Text ) )
            {
                tblPayment pay = new tblPayment ();
                pay.PDate = DateTime.Now;
                pay.tblReservation = reserve;
                pay.PAmount = decimal.Parse ( txtPrePay.Text );
                dc.tblPayments.InsertOnSubmit ( pay );
                dc.SubmitChanges ();

            }
            else if ( decimal.Parse ( txtPrePay.Text ) > 0 && decimal.Parse ( txtPrePay.Text ) > decimal.Parse ( txtCost.Text ) )
            {
                MessageBox.Show ( "مبلغ وارد شده از هزینه اقامت بیشتر است." );
                return;
            }
            reserve.Address = txtAddress.Text;
            reserve.FName = txtFName.Text;
            reserve.LName = txtLName.Text;
            reserve.Popularity = txtPopularity.Text;
            reserve.Telephone = txtPhone.Text;
            reserve.RDate = DpickerEntryDate.Value;
            reserve.RoomCode = int.Parse ( txtRoomCode.Text );
            reserve.NumsOfDays = int.Parse ( txtDaysOfStay.Text );
            reserve.Cost = decimal.Parse ( txtCost.Text );

            dc.tblReservations.InsertOnSubmit ( reserve );

            dc.SubmitChanges ();
            
            try
            {
                dc.ExecuteCommand ( "update tblroom set status=1 where roomcode={0}", int.Parse ( txtRoomCode.Text ) );
                dc.SubmitChanges ();
                MessageBox.Show ( "رزرو جدید با موفقیت ثبت شد." );
                IEnumerable<tblReservation> result = dc.ExecuteQuery<tblReservation> ( "SELECT TOP (1) ReservationCode FROM tblReservation WHERE (ReservationCode NOT IN (SELECT TOP (SELECT COUNT(ReservationCode) - 1 AS Expr1 FROM tblReservation AS tblReservation_2) ReservationCode FROM tblReservation AS tblReservation_1))" );

                foreach ( tblReservation item in result )
                {
                    lblCode.Text = "کد رزرو جدید: " + item.RoomCode;
                }
            }
            catch ( Exception ex )
            {

                MessageBox.Show ( "عمل درخواست شده با مشکل مواجه شد." );
                MessageBox.Show ( "Source: " + ex.Source + " " + "Message: " + ex.Message );

            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            tblMember member=new tblMember();
            member.FatherName=txtMemFatherName.Text;
            member.FName=txtMemFName.Text;
            member.LName=txtMemLName.Text;
            member.Popularity=txtMemPopularity.Text;
            member.BirthDate =  dPickerMemBDate.Value  ;
            member.BirthPlace=txtMemBPlace.Text;
            member.Nationality=txtMemNationality.Text;
            member.NationId=txtMemNationanId.Text;
            reserve.tblMembers.Add ( member );
            txtMemBPlace.Text = txtMemFatherName.Text = txtMemFName.Text = txtMemLName.Text = txtMemNationality.Text = txtMemNationanId.Text = txtMemPopularity.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( groupBox1.Enabled  )
            {
                groupBox1.Enabled = false;
                button2.Text = "افزودن همراهان";
            }
            else
            {
                groupBox1.Enabled = true ;
                button2.Text = "اتمام افزودن همراهان";
                
            }
           
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            reserve = new tblReservation ();
            roomId =0;
            roomPrice = 0;
        }

        private void frmReservation_Activated(object sender, EventArgs e)
        {
            txtRoomCode.Text = roomId.ToString ();
            txtRoomPrice.Text = roomPrice.ToString ();
            txtCost.Text = ( decimal.Parse ( txtRoomPrice.Text ) * int.Parse ( txtDaysOfStay.Value.ToString() ) ).ToString ();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmVacantRooms frm = new frmVacantRooms ();
            frm.ShowDialog ();
        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPrePay.Enabled=label19.Enabled  = checkBox1.Checked;
            if ( txtPrePay.Enabled==false  )
            {
                txtPrePay.Text = "0";
            }
        }

        private void txtDaysOfStay_ValueChanged(object sender, EventArgs e)
        {
          
            txtCost.Text = ( decimal.Parse ( txtRoomPrice.Text ) * int.Parse ( txtDaysOfStay.Value.ToString()) ).ToString ();
        }

        
   
    }
}
