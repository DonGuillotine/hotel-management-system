using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagementSystem.All_User_Controls
{
    public partial class UC_Registeration : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_Registeration()
        {
            InitializeComponent();
        }
        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close(); 
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UC_Registeration_Load(object sender, EventArgs e)
        {

        }

        private void txtRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomno.Items.Clear();
            txtPrice.Clear();
            query = "select roomNo from rooms where bed = '" + txtbed.Text + "' and roomType = '" + txtRoom.Text + "' and booked = 'No'";
            setComboBox(query, txtRoomno);
        }

        private void txtbed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoom.SelectedIndex = -1;
            txtRoomno.Items.Clear();
            txtPrice.Clear();
        }

        int rid;
        private void txtRoomno_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price,roomid from rooms where roomNo = '" + txtRoomno.Text + "'";
            DataSet ds = fn.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtContact.Text != "" && txtNation.Text != "" && txtGender.Text != "" && txtDob.Text !="" && txtId.Text != "" && txtAddress.Text != "" && txtCheckIn.Text != "" && txtPrice.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                String nation = txtNation.Text;
                String gender = txtGender.Text;
                String dob = txtDob.Text;
                String idproof = txtId.Text;
                String address = txtAddress.Text;
                String checkin = txtCheckIn.Text;

                query = "insert into customer (cName, mobile, nationality, gender, dob, idproof, addres, checkin, roomid) values ('" + name + "', " + mobile + ", '" + nation + "', '" + gender + "', '" + dob + "', '" + idproof + "', '" + address + "', '" + checkin + "', " + rid + " ) update rooms set booked = 'YES' where roomNo = '" + txtRoomno.Text + "'";
                fn.setData(query, "Room No. " + txtRoomno.Text + " Allocated Sucessfully");
                clearAll();
            }
            else
            {
                MessageBox.Show("All Fields are mandatory!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNation.Clear();
            txtGender.SelectedIndex = -1;
            txtDob.ResetText();
            txtId.Clear();
            txtAddress.Clear();
            txtCheckIn.ResetText();
            txtbed.SelectedIndex = -1;
            txtRoom.SelectedIndex = -1;
            txtRoomno.Items.Clear();
            txtPrice.Clear();
        }

        private void UC_Registeration_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
