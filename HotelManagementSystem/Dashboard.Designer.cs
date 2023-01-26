namespace HotelManagementSystem
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.movingPanel = new System.Windows.Forms.Panel();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Employee1 = new HotelManagementSystem.All_User_Controls.UC_Employee();
            this.uC_CustomerDetails1 = new HotelManagementSystem.All_User_Controls.UC_CustomerDetails();
            this.uC_CustomerCheckOut1 = new HotelManagementSystem.All_User_Controls.UC_CustomerCheckOut();
            this.uC_Registeration1 = new HotelManagementSystem.All_User_Controls.UC_Registeration();
            this.uC_AddRoom1 = new HotelManagementSystem.All_User_Controls.UC_AddRoom();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.movingPanel);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnDetails);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Location = new System.Drawing.Point(91, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1817, 130);
            this.panel1.TabIndex = 0;
            // 
            // movingPanel
            // 
            this.movingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.movingPanel.Location = new System.Drawing.Point(49, 111);
            this.movingPanel.Name = "movingPanel";
            this.movingPanel.Size = new System.Drawing.Size(199, 5);
            this.movingPanel.TabIndex = 3;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BorderRadius = 26;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnEmployee.CheckedState.Parent = this.btnEmployee;
            this.btnEmployee.CustomImages.Parent = this.btnEmployee;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.Parent = this.btnEmployee;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEmployee.Location = new System.Drawing.Point(1560, 20);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.ShadowDecoration.Parent = this.btnEmployee;
            this.btnEmployee.Size = new System.Drawing.Size(236, 85);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.BorderRadius = 26;
            this.btnDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDetails.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDetails.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnDetails.CheckedState.Parent = this.btnDetails;
            this.btnDetails.CustomImages.Parent = this.btnDetails;
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.White;
            this.btnDetails.HoverState.Parent = this.btnDetails;
            this.btnDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnDetails.Image")));
            this.btnDetails.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDetails.Location = new System.Drawing.Point(1173, 20);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.ShadowDecoration.Parent = this.btnDetails;
            this.btnDetails.Size = new System.Drawing.Size(236, 85);
            this.btnDetails.TabIndex = 3;
            this.btnDetails.Text = "Details";
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BorderRadius = 26;
            this.btnRegister.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRegister.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRegister.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnRegister.CheckedState.Parent = this.btnRegister;
            this.btnRegister.CustomImages.Parent = this.btnRegister;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.HoverState.Parent = this.btnRegister;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.ImageSize = new System.Drawing.Size(35, 35);
            this.btnRegister.Location = new System.Drawing.Point(418, 23);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.ShadowDecoration.Parent = this.btnRegister;
            this.btnRegister.Size = new System.Drawing.Size(236, 85);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Registration";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderRadius = 26;
            this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnCheckOut.CheckedState.Parent = this.btnCheckOut;
            this.btnCheckOut.CustomImages.Parent = this.btnCheckOut;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.HoverState.Parent = this.btnCheckOut;
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCheckOut.Location = new System.Drawing.Point(784, 23);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.ShadowDecoration.Parent = this.btnCheckOut;
            this.btnCheckOut.Size = new System.Drawing.Size(236, 85);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderRadius = 26;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddRoom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddRoom.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnAddRoom.CheckedState.Parent = this.btnAddRoom;
            this.btnAddRoom.CustomImages.Parent = this.btnAddRoom;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.HoverState.Parent = this.btnAddRoom;
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddRoom.Location = new System.Drawing.Point(34, 20);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.ShadowDecoration.Parent = this.btnAddRoom;
            this.btnAddRoom.Size = new System.Drawing.Size(236, 85);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(35, 35);
            this.btnExit.Location = new System.Drawing.Point(4, 55);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(81, 80);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.Empty;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageSize = new System.Drawing.Size(35, 35);
            this.btnMinimize.Location = new System.Drawing.Point(4, 125);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(81, 80);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.uC_Employee1);
            this.panel2.Controls.Add(this.uC_CustomerDetails1);
            this.panel2.Controls.Add(this.uC_CustomerCheckOut1);
            this.panel2.Controls.Add(this.uC_Registeration1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(25, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1900, 794);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.BackColor = System.Drawing.Color.White;
            this.uC_Employee1.Location = new System.Drawing.Point(-13, -7);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(1999, 798);
            this.uC_Employee1.TabIndex = 3;
            // 
            // uC_CustomerDetails1
            // 
            this.uC_CustomerDetails1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerDetails1.Location = new System.Drawing.Point(0, -7);
            this.uC_CustomerDetails1.Name = "uC_CustomerDetails1";
            this.uC_CustomerDetails1.Size = new System.Drawing.Size(1999, 798);
            this.uC_CustomerDetails1.TabIndex = 2;
            // 
            // uC_CustomerCheckOut1
            // 
            this.uC_CustomerCheckOut1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerCheckOut1.Location = new System.Drawing.Point(3, 0);
            this.uC_CustomerCheckOut1.Name = "uC_CustomerCheckOut1";
            this.uC_CustomerCheckOut1.Size = new System.Drawing.Size(1999, 798);
            this.uC_CustomerCheckOut1.TabIndex = 1;
            // 
            // uC_Registeration1
            // 
            this.uC_Registeration1.BackColor = System.Drawing.Color.White;
            this.uC_Registeration1.Location = new System.Drawing.Point(3, 3);
            this.uC_Registeration1.Name = "uC_Registeration1";
            this.uC_Registeration1.Size = new System.Drawing.Size(1920, 798);
            this.uC_Registeration1.TabIndex = 0;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Location = new System.Drawing.Point(3, 3);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1999, 798);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnDetails;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private System.Windows.Forms.Panel movingPanel;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Controls.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Controls.UC_Registeration uC_Registeration1;
        private All_User_Controls.UC_CustomerCheckOut uC_CustomerCheckOut1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Controls.UC_CustomerDetails uC_CustomerDetails1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_Controls.UC_Employee uC_Employee1;
    }
}