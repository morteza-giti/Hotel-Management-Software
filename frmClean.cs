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
    public partial class frmClean : Form
    {
        public frmClean()
        {
            InitializeComponent ();
        }

        private void frmClean_Load(object sender, EventArgs e)
        {

        }

        private void txtReCode_Leave(object sender, EventArgs e)
        {
            try
            {
 txtRoomCode.Enabled = false;
            DataClasses1DataContext dc = new DataClasses1DataContext ();
            var room = from r in dc.tblRooms where r.RoomCode == int.Parse ( txtRoomCode.Text ) select r;
           // tblRoom selRoom=(tblRoom )room;
            if ( room.Count()==0 )
            {
                MessageBox.Show ( "اتاقی با این کد وجود ندارد." );
                button1.Enabled = false;
                return;
            }
            foreach ( var item in room )
            {
                switch ( item.Status )
                {
                    case 0:
                        txtStatus.Text = "عدم نیاز به نظافت";
                        break;
                    case 1:
                        txtStatus.Text = "این اتاق پر است.";
                        break;
                    case 2:
                        txtStatus.Text = "نیاز به نظافت";
                        button1.Enabled = true;
                        break;
                    default:
                        txtStatus.Text = "نا شناخته";
                        break;
                }
            }
            }
            catch ( Exception ex )
            {

                MessageBox.Show ( "عمل درخواست شده با مشکل مواجه شد." );
                MessageBox.Show ( "Source: " + ex.Source + " " + "Message: " + ex.Message );
            }
           
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtRoomCode.Clear ();
            txtStatus.Clear ();
            txtRoomCode.Enabled = true;
            txtRoomCode.Focus ();
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext ();
            dc.ExecuteCommand ( "update tblRoom set status=0 where RoomCode={0}", int.Parse ( txtRoomCode.Text ) );
            dc.SubmitChanges ();
            MessageBox.Show ("نظافت انجام شد.");
            button2_Click ( sender, e );
        }
    }
}
