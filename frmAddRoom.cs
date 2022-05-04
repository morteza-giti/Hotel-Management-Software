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
    public partial class frmAddRoom : Form
    {
        public frmAddRoom()
        {
            InitializeComponent ();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( txtPrice.Text=="" || decimal.Parse(txtPrice.Text)==0)
            {
                MessageBox.Show ( "لطفآ تمامی اطلاعات را وارد کنید." );
                txtNumsOfBeds.Value = 1;
                return;
            }
            try
            {
 DataClasses1DataContext dc = new DataClasses1DataContext ();
            tblRoom room=new tblRoom();          
            room.NumsOfBed=int.Parse(txtNumsOfBeds.Value.ToString() );
            room.RPrice=decimal.Parse(txtPrice .Text );
            room.Status = 0;
            dc.tblRooms.InsertOnSubmit ( room );
           
            dc.SubmitChanges ();
            MessageBox.Show ( "اتاق جدید با موفقیت ثبت شد." );
            IEnumerable<tblRoom> result = dc.ExecuteQuery<tblRoom> ( "SELECT TOP (1) RoomCode FROM tblRoom WHERE (RoomCode NOT IN (SELECT TOP (SELECT COUNT(RoomCode) - 1 AS Expr1 FROM tblRoom AS tblRoom_2) RoomCode FROM tblRoom AS tblRoom_1))" );
  
            foreach ( tblRoom item in result )
            {
                lblCode.Text = "کد اتاق جدید: " + item.RoomCode;
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
            txtNumsOfBeds.Text = txtPrice.Text =string.Empty;
            
        }

     
    }
}
