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
    public partial class UC_Employee : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaximiumID();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtUser.Text != "" && txtPassword.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String userName = txtUser.Text;
                String password = txtPassword.Text;

                query = "insert into employee(ename, mobile, gender, emailid, username, pass) values('" + name + "', "+ mobile +", '" + gender + "', '" + email + "', '" + userName + "', '" + password + "')";
                fn.setData(query, "Employee Registered Successfully");
                clearAll();
                getMaximiumID();
            }
            else
            {
                MessageBox.Show("All Fields are Mandatory", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabEmployeeDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployeeDetails.SelectedIndex == 1)
            {
                getEmployeeDetails(guna2DataGridView1);
            }
            else if (tabEmployeeDetails.SelectedIndex == 2)
            {
                getEmployeeDetails(guna2DataGridView2);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to Fire this Employee?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    query = "delete from employee where eid =" + txtID.Text + "";
                    fn.setData(query, "Fired Sucessfully");
                    tabEmployeeDetails_SelectedIndexChanged(this, null);
                }
            }
            else
            {
                MessageBox.Show("Select an Employee ID to Fire", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
        //To get the next ID from the database then add one, for eg if The ID in the database is 4 it will add one to make it 5. Boom! Brand New ID!!!!!!
        public void getMaximiumID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSET.Text = (num + 1).ToString();
            }
        }
        //To clear all text and combo boxes after submission
        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtUser.Clear();
            txtPassword.Clear();
        }
        //This method contains the query to view all emoloyee details. It contains an argument of type Datagridview which is passed as the datagrid view name
        public void getEmployeeDetails(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

      

      
    

       
    }
}
