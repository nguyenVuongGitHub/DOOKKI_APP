namespace DOOKKI_APP.Views
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnLeft = new Panel();
            pbSidebar = new PictureBox();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            ptbDookkiAvatar = new PictureBox();
            lblDookki = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnTable = new Guna.UI2.WinForms.Guna2Button();
            pnEmployeeContainer = new FlowLayoutPanel();
            btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            btnManageEmployee = new Guna.UI2.WinForms.Guna2Button();
            btnTimeTracking = new Guna.UI2.WinForms.Guna2Button();
            btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            btnWarehouse = new Guna.UI2.WinForms.Guna2Button();
            btnAdmin = new Guna.UI2.WinForms.Guna2Button();
            pnBody = new Panel();
            employeeTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSidebar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbDookkiAvatar).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            pnEmployeeContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnLeft
            // 
            pnLeft.BackColor = Color.FromArgb(42, 52, 65);
            pnLeft.Controls.Add(pbSidebar);
            pnLeft.Controls.Add(btnLogout);
            pnLeft.Controls.Add(ptbDookkiAvatar);
            pnLeft.Controls.Add(lblDookki);
            pnLeft.Controls.Add(flowLayoutPanel1);
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Location = new Point(0, 0);
            pnLeft.Margin = new Padding(3, 2, 3, 2);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(200, 747);
            pnLeft.TabIndex = 0;
            // 
            // pbSidebar
            // 
            pbSidebar.Image = Properties.Resources.menu_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            pbSidebar.Location = new Point(3, 3);
            pbSidebar.Name = "pbSidebar";
            pbSidebar.Size = new Size(40, 40);
            pbSidebar.SizeMode = PictureBoxSizeMode.Zoom;
            pbSidebar.TabIndex = 10;
            pbSidebar.TabStop = false;
            pbSidebar.Click += pbSidebar_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.CustomizableEdges = customizableEdges1;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.FillColor = Color.FromArgb(42, 52, 65);
            btnLogout.Font = new Font("Segoe UI", 14F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.logout_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            btnLogout.ImageOffset = new Point(-15, 0);
            btnLogout.ImageSize = new Size(40, 40);
            btnLogout.Location = new Point(2, 697);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogout.Size = new Size(195, 40);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Đăng xuất";
            btnLogout.Click += btnLogout_Click;
            // 
            // ptbDookkiAvatar
            // 
            ptbDookkiAvatar.Image = Properties.Resources.dookki_removebg_preview;
            ptbDookkiAvatar.Location = new Point(65, 29);
            ptbDookkiAvatar.Margin = new Padding(3, 2, 3, 2);
            ptbDookkiAvatar.Name = "ptbDookkiAvatar";
            ptbDookkiAvatar.Size = new Size(61, 50);
            ptbDookkiAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            ptbDookkiAvatar.TabIndex = 0;
            ptbDookkiAvatar.TabStop = false;
            // 
            // lblDookki
            // 
            lblDookki.AutoSize = true;
            lblDookki.Font = new Font("MV Boli", 20F);
            lblDookki.ForeColor = Color.White;
            lblDookki.Location = new Point(48, 85);
            lblDookki.Name = "lblDookki";
            lblDookki.Size = new Size(95, 34);
            lblDookki.TabIndex = 2;
            lblDookki.Text = "Dookki";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btnTable);
            flowLayoutPanel1.Controls.Add(pnEmployeeContainer);
            flowLayoutPanel1.Controls.Add(btnDashboard);
            flowLayoutPanel1.Controls.Add(btnWarehouse);
            flowLayoutPanel1.Controls.Add(btnAdmin);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(-4, 150);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(206, 336);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnTable
            // 
            btnTable.CustomizableEdges = customizableEdges3;
            btnTable.DisabledState.BorderColor = Color.DarkGray;
            btnTable.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTable.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTable.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTable.FillColor = Color.FromArgb(42, 52, 65);
            btnTable.Font = new Font("Segoe UI", 14F);
            btnTable.ForeColor = Color.White;
            btnTable.Image = Properties.Resources.grid_view_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            btnTable.ImageAlign = HorizontalAlignment.Left;
            btnTable.ImageOffset = new Point(-5, 0);
            btnTable.ImageSize = new Size(40, 40);
            btnTable.Location = new Point(3, 3);
            btnTable.Name = "btnTable";
            btnTable.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnTable.Size = new Size(195, 40);
            btnTable.TabIndex = 10;
            btnTable.Text = "Menu";
            btnTable.TextAlign = HorizontalAlignment.Left;
            btnTable.TextOffset = new Point(-5, 0);
            btnTable.Click += btnTable_Click;
            // 
            // pnEmployeeContainer
            // 
            pnEmployeeContainer.BackColor = Color.FromArgb(42, 52, 65);
            pnEmployeeContainer.Controls.Add(btnEmployee);
            pnEmployeeContainer.Controls.Add(btnManageEmployee);
            pnEmployeeContainer.Controls.Add(btnTimeTracking);
            pnEmployeeContainer.FlowDirection = FlowDirection.TopDown;
            pnEmployeeContainer.Location = new Point(3, 49);
            pnEmployeeContainer.Name = "pnEmployeeContainer";
            pnEmployeeContainer.Size = new Size(200, 50);
            pnEmployeeContainer.TabIndex = 13;
            // 
            // btnEmployee
            // 
            btnEmployee.CustomizableEdges = customizableEdges5;
            btnEmployee.DisabledState.BorderColor = Color.DarkGray;
            btnEmployee.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEmployee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEmployee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEmployee.FillColor = Color.FromArgb(42, 52, 65);
            btnEmployee.Font = new Font("Segoe UI", 14F);
            btnEmployee.ForeColor = Color.White;
            btnEmployee.Image = Properties.Resources.groups_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            btnEmployee.ImageAlign = HorizontalAlignment.Left;
            btnEmployee.ImageOffset = new Point(-5, 0);
            btnEmployee.ImageSize = new Size(35, 40);
            btnEmployee.Location = new Point(3, 3);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEmployee.Size = new Size(195, 40);
            btnEmployee.TabIndex = 11;
            btnEmployee.Text = "Nhân viên";
            btnEmployee.TextAlign = HorizontalAlignment.Left;
            btnEmployee.TextOffset = new Point(-5, 0);
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnManageEmployee
            // 
            btnManageEmployee.BackColor = Color.FromArgb(46, 58, 77);
            btnManageEmployee.CustomizableEdges = customizableEdges7;
            btnManageEmployee.DisabledState.BorderColor = Color.DarkGray;
            btnManageEmployee.DisabledState.CustomBorderColor = Color.DarkGray;
            btnManageEmployee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnManageEmployee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnManageEmployee.FillColor = Color.FromArgb(46, 58, 77);
            btnManageEmployee.Font = new Font("Segoe UI", 14F);
            btnManageEmployee.ForeColor = Color.White;
            btnManageEmployee.Image = (Image)resources.GetObject("btnManageEmployee.Image");
            btnManageEmployee.ImageAlign = HorizontalAlignment.Left;
            btnManageEmployee.ImageOffset = new Point(-5, 0);
            btnManageEmployee.ImageSize = new Size(35, 40);
            btnManageEmployee.Location = new Point(204, 3);
            btnManageEmployee.Name = "btnManageEmployee";
            btnManageEmployee.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnManageEmployee.Size = new Size(195, 40);
            btnManageEmployee.TabIndex = 12;
            btnManageEmployee.Text = "Quản lý";
            btnManageEmployee.TextAlign = HorizontalAlignment.Left;
            btnManageEmployee.TextOffset = new Point(5, 0);
            btnManageEmployee.Click += btnManageEmployee_Click;
            // 
            // btnTimeTracking
            // 
            btnTimeTracking.BackColor = Color.FromArgb(46, 58, 77);
            btnTimeTracking.CustomizableEdges = customizableEdges9;
            btnTimeTracking.DisabledState.BorderColor = Color.DarkGray;
            btnTimeTracking.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTimeTracking.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTimeTracking.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTimeTracking.FillColor = Color.FromArgb(46, 58, 77);
            btnTimeTracking.Font = new Font("Segoe UI", 14F);
            btnTimeTracking.ForeColor = Color.White;
            btnTimeTracking.Image = (Image)resources.GetObject("btnTimeTracking.Image");
            btnTimeTracking.ImageAlign = HorizontalAlignment.Left;
            btnTimeTracking.ImageOffset = new Point(-5, 0);
            btnTimeTracking.ImageSize = new Size(35, 40);
            btnTimeTracking.Location = new Point(405, 3);
            btnTimeTracking.Name = "btnTimeTracking";
            btnTimeTracking.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnTimeTracking.Size = new Size(195, 40);
            btnTimeTracking.TabIndex = 13;
            btnTimeTracking.Text = "Chấm công";
            btnTimeTracking.TextAlign = HorizontalAlignment.Left;
            btnTimeTracking.TextOffset = new Point(5, 0);
            btnTimeTracking.Click += btnTimeTracking_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.CustomizableEdges = customizableEdges11;
            btnDashboard.DisabledState.BorderColor = Color.DarkGray;
            btnDashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDashboard.FillColor = Color.FromArgb(42, 52, 65);
            btnDashboard.Font = new Font("Segoe UI", 14F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.bar_chart_4_bars_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            btnDashboard.ImageAlign = HorizontalAlignment.Left;
            btnDashboard.ImageSize = new Size(35, 40);
            btnDashboard.Location = new Point(3, 105);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnDashboard.Size = new Size(195, 40);
            btnDashboard.TabIndex = 12;
            btnDashboard.Text = "Thống kê";
            btnDashboard.TextAlign = HorizontalAlignment.Left;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnWarehouse
            // 
            btnWarehouse.CustomizableEdges = customizableEdges13;
            btnWarehouse.DisabledState.BorderColor = Color.DarkGray;
            btnWarehouse.DisabledState.CustomBorderColor = Color.DarkGray;
            btnWarehouse.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnWarehouse.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnWarehouse.FillColor = Color.FromArgb(42, 52, 65);
            btnWarehouse.Font = new Font("Segoe UI", 14F);
            btnWarehouse.ForeColor = Color.White;
            btnWarehouse.Image = Properties.Resources.warehouse_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            btnWarehouse.ImageAlign = HorizontalAlignment.Left;
            btnWarehouse.ImageSize = new Size(35, 40);
            btnWarehouse.Location = new Point(3, 151);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnWarehouse.Size = new Size(195, 40);
            btnWarehouse.TabIndex = 13;
            btnWarehouse.Text = "Kho";
            btnWarehouse.TextAlign = HorizontalAlignment.Left;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.CustomizableEdges = customizableEdges15;
            btnAdmin.DisabledState.BorderColor = Color.DarkGray;
            btnAdmin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdmin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdmin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdmin.FillColor = Color.FromArgb(42, 52, 65);
            btnAdmin.Font = new Font("Segoe UI", 14F);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Image = Properties.Resources.settings_account_box_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            btnAdmin.ImageAlign = HorizontalAlignment.Left;
            btnAdmin.ImageSize = new Size(40, 40);
            btnAdmin.Location = new Point(3, 197);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnAdmin.Size = new Size(195, 40);
            btnAdmin.TabIndex = 14;
            btnAdmin.Text = "Tài khoản";
            btnAdmin.TextAlign = HorizontalAlignment.Left;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // pnBody
            // 
            pnBody.AutoSize = true;
            pnBody.BackColor = Color.White;
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(200, 0);
            pnBody.Margin = new Padding(3, 2, 3, 2);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(1150, 747);
            pnBody.TabIndex = 2;
            // 
            // employeeTransition
            // 
            employeeTransition.Interval = 10;
            employeeTransition.Tick += employeeTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 747);
            Controls.Add(pnBody);
            Controls.Add(pnLeft);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "ManageOrder";
            pnLeft.ResumeLayout(false);
            pnLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSidebar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbDookkiAvatar).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            pnEmployeeContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnLeft;
        private Label lblDookki;
        private PictureBox ptbLogout;
        private PictureBox ptbDookkiAvatar;
        private Panel pnBody;
        private FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnTable;
        private PictureBox pbSidebar;
        private System.Windows.Forms.Timer employeeTransition;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnWarehouse;
        private Guna.UI2.WinForms.Guna2Button btnAdmin;
        private System.Windows.Forms.Timer sidebarTransition;
        private FlowLayoutPanel pnEmployeeContainer;
        private Guna.UI2.WinForms.Guna2Button btnManageEmployee;
        private Guna.UI2.WinForms.Guna2Button btnTimeTracking;
    }
}