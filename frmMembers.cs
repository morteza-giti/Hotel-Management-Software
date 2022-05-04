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
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent ();
        }
        BindingSource bs;
        DataClasses1DataContext dc;
        private void frmMembers_Load(object sender, EventArgs e)
        {
            dc = new DataClasses1DataContext ();
            Table<tblMember > query = dc.tblMembers ;
            bs = new BindingSource ();
            bs.DataSource = query;
        
            dataGridView1.DataSource = bs;
            dataGridView1.Columns[0].HeaderText = "کد همراه";
            dataGridView1.Columns[1].HeaderText = "کد رزرو";
            dataGridView1.Columns[2].HeaderText = "نام";
            dataGridView1.Columns[3].HeaderText = "نام خانوداگی";
            dataGridView1.Columns[3].Width =103 ;
            dataGridView1.Columns[4].HeaderText = "شهرت";
            dataGridView1.Columns[5].HeaderText = "نام پدر";
            dataGridView1.Columns[6].HeaderText = "تاریخ تولد";
            dataGridView1.Columns[7].HeaderText = "تابعیت";
            dataGridView1.Columns[8].HeaderText = "کد ملی";
            dataGridView1.Columns[9].HeaderText = "محل تولد";

            dataGridView1.Columns[10].Visible = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ( textBox1.Text == string.Empty )
            {
                bs.Filter = "";
                
            }
            else
            {
              
                IQueryable <tblMember> query =from m in dc.tblMembers where m.ReservationCode == int.Parse(textBox1.Text) select m;
                BindingSource b = new BindingSource ();
                b.DataSource = query;
                dataGridView1.DataSource = b;
               
            }
        }
    }
}
