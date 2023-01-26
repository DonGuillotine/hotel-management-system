using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.All_User_Controls
{
    public partial class UC_CustomerCheckOut : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_CustomerCheckOut()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UC_CustomerCheckOut_Load(object sender, EventArgs e)
        {
            query = "select customer.cid, customer.cName, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.addres, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where chekout = 'No'";
            //fn.getData(query);->Will Return a data set, needs to be converted to string
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.cid, customer.cName, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.addres, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where cname like '" + txtName.Text + "%' and chekout = 'No'"; //% is added you you can sort names for e.g do% all names with do will appear
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCname.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCname.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to Check Out?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    String cDate = txtCheckOutDate.Text;
                    query = "update customer set chekout = 'YES', checkout='" + cDate + "' where cid = " + id + " update rooms set booked ='No' where roomNo = '" + txtRoom.Text + "'";
                    fn.setData(query, "Checked Out Successfully");
                    UC_CustomerCheckOut_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("No Customer Selected", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            txtCname.Clear();
            txtName.Clear();
            txtRoom.Clear();
            txtCheckOutDate.ResetText();
        }

        private void UC_CustomerCheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
