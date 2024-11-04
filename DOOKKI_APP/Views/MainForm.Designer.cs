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
            pnLeft = new Panel();
            btnDashboard = new Button();
            btnWarehouse = new Button();
            btnLogout = new Button();
            btnEmployee = new Button();
            btnTable = new Button();
            lblDookki = new Label();
            ptbLogout = new PictureBox();
            ptbDookkiAvatar = new PictureBox();
            pnTop = new Panel();
            lblUser = new Label();
            lblTitle = new Label();
            ptbLogout2 = new PictureBox();
            ptbUser = new PictureBox();
            ptbNotify = new PictureBox();
            pnBody = new Panel();
            pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbDookkiAvatar).BeginInit();
            pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogout2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbNotify).BeginInit();
            SuspendLayout();
            // 
            // pnLeft
            // 
            pnLeft.BackColor = Color.White;
            pnLeft.Controls.Add(btnDashboard);
            pnLeft.Controls.Add(btnWarehouse);
            pnLeft.Controls.Add(btnLogout);
            pnLeft.Controls.Add(btnEmployee);
            pnLeft.Controls.Add(btnTable);
            pnLeft.Controls.Add(lblDookki);
            pnLeft.Controls.Add(ptbLogout);
            pnLeft.Controls.Add(ptbDookkiAvatar);
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Location = new Point(0, 0);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(200, 589);
            pnLeft.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(0, 357);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 23);
            btnDashboard.TabIndex = 8;
            btnDashboard.Text = "Thống kê";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnWarehouse
            // 
            btnWarehouse.Location = new Point(0, 301);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Size = new Size(200, 23);
            btnWarehouse.TabIndex = 7;
            btnWarehouse.Text = "Kho";
            btnWarehouse.UseVisualStyleBackColor = true;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(87, 542);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(97, 35);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(0, 244);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(200, 23);
            btnEmployee.TabIndex = 5;
            btnEmployee.Text = "Nhân viên";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnTable
            // 
            btnTable.BackColor = Color.White;
            btnTable.ForeColor = Color.Black;
            btnTable.Location = new Point(0, 191);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(200, 23);
            btnTable.TabIndex = 3;
            btnTable.Text = "Menu";
            btnTable.UseVisualStyleBackColor = false;
            btnTable.Click += btnTable_Click;
            // 
            // lblDookki
            // 
            lblDookki.AutoSize = true;
            lblDookki.Location = new Point(73, 97);
            lblDookki.Name = "lblDookki";
            lblDookki.Size = new Size(44, 15);
            lblDookki.TabIndex = 2;
            lblDookki.Text = "Dookki";
            // 
            // ptbLogout
            // 
            ptbLogout.Image = Properties.Resources.icons8_login_50;
            ptbLogout.Location = new Point(41, 542);
            ptbLogout.Name = "ptbLogout";
            ptbLogout.Size = new Size(40, 35);
            ptbLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLogout.TabIndex = 1;
            ptbLogout.TabStop = false;
            // 
            // ptbDookkiAvatar
            // 
            ptbDookkiAvatar.Image = Properties.Resources.icons8_user_60;
            ptbDookkiAvatar.Location = new Point(60, 12);
            ptbDookkiAvatar.Name = "ptbDookkiAvatar";
            ptbDookkiAvatar.Size = new Size(70, 67);
            ptbDookkiAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            ptbDookkiAvatar.TabIndex = 0;
            ptbDookkiAvatar.TabStop = false;
            // 
            // pnTop
            // 
            pnTop.BackColor = Color.White;
            pnTop.Controls.Add(lblUser);
            pnTop.Controls.Add(lblTitle);
            pnTop.Controls.Add(ptbLogout2);
            pnTop.Controls.Add(ptbUser);
            pnTop.Controls.Add(ptbNotify);
            pnTop.Location = new Point(214, 12);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(771, 100);
            pnTop.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(636, 41);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(46, 15);
            lblUser.TabIndex = 5;
            lblUser.Text = "Anh Tai";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(26, 41);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 15);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Menu";
            // 
            // ptbLogout2
            // 
            ptbLogout2.Image = Properties.Resources.icons8_login_50;
            ptbLogout2.Location = new Point(702, 32);
            ptbLogout2.Name = "ptbLogout2";
            ptbLogout2.Size = new Size(40, 35);
            ptbLogout2.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLogout2.TabIndex = 4;
            ptbLogout2.TabStop = false;
            ptbLogout2.Click += ptbLogout2_Click;
            // 
            // ptbUser
            // 
            ptbUser.Image = Properties.Resources.icons8_user_60;
            ptbUser.Location = new Point(590, 32);
            ptbUser.Name = "ptbUser";
            ptbUser.Size = new Size(40, 35);
            ptbUser.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbUser.TabIndex = 3;
            ptbUser.TabStop = false;
            // 
            // ptbNotify
            // 
            ptbNotify.Image = Properties.Resources.icons8_login_50;
            ptbNotify.Location = new Point(544, 32);
            ptbNotify.Name = "ptbNotify";
            ptbNotify.Size = new Size(40, 35);
            ptbNotify.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbNotify.TabIndex = 2;
            ptbNotify.TabStop = false;
            // 
            // pnBody
            // 
            pnBody.BackColor = Color.White;
            pnBody.Location = new Point(214, 139);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(771, 438);
            pnBody.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 589);
            Controls.Add(pnBody);
            Controls.Add(pnTop);
            Controls.Add(pnLeft);
            Name = "MainForm";
            Text = "ManageOrder";
            pnLeft.ResumeLayout(false);
            pnLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbDookkiAvatar).EndInit();
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogout2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbNotify).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnLeft;
        private Button btnLogout;
        private Button btnEmployee;
        private Button btnTable;
        private Label lblDookki;
        private PictureBox ptbLogout;
        private PictureBox ptbDookkiAvatar;
        private Panel pnTop;
        private Label lblUser;
        private Label lblTitle;
        private PictureBox ptbUser;
        private PictureBox ptbNotify;
        private PictureBox ptbLogout2;
        private Panel pnBody;
        private Button btnDashboard;
        private Button btnWarehouse;
    }
}