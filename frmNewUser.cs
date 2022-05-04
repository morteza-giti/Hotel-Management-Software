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
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent ();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ( txtPassword.Text==string.Empty || txtUsername.Text==string.Empty || txtConfirmation.Text==string.Empty )
            {
                return;
            }
            if ( txtPassword.Text != txtConfirmation.Text )
            {
                return;
            }
           
            DataClasses1DataContext dc = new DataClasses1DataContext ();
            var exists = from u in dc.tblUsers where u.UserName == txtUsername.Text select u;
            if ( exists.Count()>0 )
            {
                MessageBox.Show ("این نام کاربری از قبل انتخاب شده است. لطفآ آن را تغییر دهید.");
                return;
            }

            tblUser user=new tblUser();
            user.UserName=txtUsername.Text;
            user.Password=txtPassword.Text;

            dc.tblUsers.InsertOnSubmit ( user );
            dc.SubmitChanges ();
            MessageBox.Show ( "کاربر جدید با موفقیت ثبت شد." );

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        
    }
}
