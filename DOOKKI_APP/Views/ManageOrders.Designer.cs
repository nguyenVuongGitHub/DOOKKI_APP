namespace DOOKKI_APP.Views
{
    partial class ManageOrders
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
            btnLogout = new Button();
            button3 = new Button();
            btnMenu = new Button();
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
            pnLeft.Controls.Add(btnLogout);
            pnLeft.Controls.Add(button3);
            pnLeft.Controls.Add(btnMenu);
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
            // btnLogout
            // 
            btnLogout.Location = new Point(98, 554);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(88, 23);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "button4";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(0, 316);
            button3.Name = "button3";
            button3.Size = new Size(200, 23);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(0, 207);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(200, 23);
            btnMenu.TabIndex = 4;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnTable
            // 
            btnTable.BackColor = Color.White;
            btnTable.ForeColor = Color.Black;
            btnTable.Location = new Point(0, 261);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(200, 23);
            btnTable.TabIndex = 3;
            btnTable.Text = "Tình trạng bàn";
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
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 589);
            Controls.Add(pnBody);
            Controls.Add(pnTop);
            Controls.Add(pnLeft);
            Name = "ManageOrders";
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
        private Button button3;
        private Button btnMenu;
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
    }
}