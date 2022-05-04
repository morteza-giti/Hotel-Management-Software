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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent ();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext ();
            var user = from u in dc.tblUsers where u.UserName == txtUsername.Text && u.Password == txtPassword.Text select u;
            if ( user.Count() != 0 )
            {
                frmMain frm = new frmMain ();
                frm.Show ();
                this.Hide();

            }
            else
            {
                MessageBox.Show ( "نام کاربری یا رمز عبور اشتباه است." );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNewUser frm = new frmNewUser ();
            frm.ShowDialog ();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit ();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        
    }
}
