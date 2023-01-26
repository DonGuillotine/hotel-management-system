using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
            movingPanel.Left = btnEmployee.Left + 14;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            movingPanel.Left = btnRegister.Left+14;

            uC_Registeration1.Visible = true;
            uC_Registeration1.BringToFront();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            movingPanel.Left = btnAddRoom.Left + 14;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            uC_CustomerCheckOut1.Visible = true;
            uC_CustomerCheckOut1.BringToFront();
            movingPanel.Left = btnCheckOut.Left + 14;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();
            movingPanel.Left = btnDetails.Left + 14;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_AddRoom1_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Employee1.Visible = false;
            uC_AddRoom1.Visible = false;
            uC_Registeration1.Visible = false;
            btnAddRoom.PerformClick();
        }
    }
}
