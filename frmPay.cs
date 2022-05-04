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
    public partial class frmPay : Form
    {
        public frmPay()
        {
            InitializeComponent ();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBalance.Text = txtOwe.Text = txtPay.Text = txtReCode.Text = string.Empty;
            txtReCode.Enabled = true;
            txtReCode.Focus ();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( txtPay.Text==string.Empty  || decimal.Parse(txtPay.Text )==0)
            {
                MessageBox.Show ( "مبلغ پرداختی را وارد کنید." );
                return;
            }
            if ( decimal.Parse ( txtPay.Text ) <= decimal.Parse ( txtOwe.Text ) )
            {
                try
                {
   DataClasses1DataContext dc = new DataClasses1DataContext ();
                tblPayment pay = new tblPayment ();
                pay.ReservationCode = int.Parse ( txtReCode.Text );
                pay.PDate = DateTime.Now;
                pay.PAmount = decimal.Parse ( txtPay.Text );
                dc.tblPayments.InsertOnSubmit ( pay );
                dc.SubmitChanges ();
                MessageBox.Show ( "اطلاعات پرداخت با موفقیت ثبت شد." );
                }
                catch ( Exception ex )
                {

                    MessageBox.Show ( "عمل درخواست شده با مشکل مواجه شد." );
                    MessageBox.Show ( "Source: " + ex.Source + " " + "Message: " + ex.Message );
                }
            }
            else
            {
                MessageBox.Show ( "مبلغ وارد شده از بدهی بیشتر است." );
            }
        }

        private void txtReCode_Leave(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext ();
            var reserve = from r in dc.tblReservations where r.ReservationCode == int.Parse ( txtReCode.Text ) select r;
            if ( reserve.Count () == 0 )
            {
                MessageBox.Show ( "هیچ رزروی با این کد یافت نشد." );
                return;
            }
            txtReCode.Enabled = false;
            
            var payments = from r in dc.tblPayments where r.ReservationCode == int.Parse ( txtReCode.Text ) select r;
           
            decimal? sum = 0;
            foreach ( tblPayment item in payments  )
            {
                sum +=item.PAmount;
            }
            txtBalance.Text = sum.ToString ();

            
            decimal? owe = 0;
            foreach ( tblReservation item in reserve  )
            {
                owe =  item.Cost - sum;
            }
            txtOwe.Text  = owe.ToString ();
            button2.Enabled = true;
            txtReCode.Enabled = false;
        }

      
    }
}
