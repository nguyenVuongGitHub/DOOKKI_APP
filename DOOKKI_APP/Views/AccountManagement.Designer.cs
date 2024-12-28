namespace DOOKKI_APP.Views
{
    partial class AccountManagement
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            cbRoles = new Guna.UI2.WinForms.Guna2ComboBox();
            btnEditAccount = new Button();
            btnAddNewAccount = new Button();
            pnAddNewAccount = new Panel();
            txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            label4 = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnAddnew = new Button();
            label2 = new Label();
            label1 = new Label();
            dgvAdmin = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            errorProvider1 = new ErrorProvider(components);
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            pnAddNewAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(pnAddNewAccount);
            panel2.Controls.Add(dgvAdmin);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(852, 538);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbRoles);
            groupBox1.Controls.Add(btnEditAccount);
            groupBox1.Controls.Add(btnAddNewAccount);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.Location = new Point(30, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 317);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý tài khoản";
            // 
            // cbRoles
            // 
            cbRoles.BackColor = Color.Transparent;
            cbRoles.CustomizableEdges = customizableEdges1;
            cbRoles.DrawMode = DrawMode.OwnerDrawFixed;
            cbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoles.FocusedColor = Color.FromArgb(94, 148, 255);
            cbRoles.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbRoles.Font = new Font("Segoe UI", 10F);
            cbRoles.ForeColor = Color.FromArgb(68, 88, 112);
            cbRoles.ItemHeight = 30;
            cbRoles.Location = new Point(235, 62);
            cbRoles.Name = "cbRoles";
            cbRoles.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbRoles.Size = new Size(140, 36);
            cbRoles.TabIndex = 3;
            cbRoles.SelectedIndexChanged += cbRoles_SelectedIndexChanged;
            // 
            // btnEditAccount
            // 
            btnEditAccount.AutoSize = true;
            btnEditAccount.BackColor = Color.FromArgb(42, 52, 65);
            btnEditAccount.FlatStyle = FlatStyle.Flat;
            btnEditAccount.ForeColor = Color.White;
            btnEditAccount.Location = new Point(6, 141);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(206, 37);
            btnEditAccount.TabIndex = 1;
            btnEditAccount.Text = "Sửa tài khoản hiện tại";
            btnEditAccount.UseVisualStyleBackColor = false;
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // btnAddNewAccount
            // 
            btnAddNewAccount.AutoSize = true;
            btnAddNewAccount.BackColor = Color.FromArgb(42, 52, 65);
            btnAddNewAccount.FlatStyle = FlatStyle.Flat;
            btnAddNewAccount.ForeColor = Color.White;
            btnAddNewAccount.Location = new Point(6, 63);
            btnAddNewAccount.Name = "btnAddNewAccount";
            btnAddNewAccount.Size = new Size(204, 37);
            btnAddNewAccount.TabIndex = 0;
            btnAddNewAccount.Text = "Cấp tài khoản mới";
            btnAddNewAccount.UseVisualStyleBackColor = false;
            btnAddNewAccount.Click += btnAddNewAccount_Click;
            // 
            // pnAddNewAccount
            // 
            pnAddNewAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnAddNewAccount.Controls.Add(txtPhone);
            pnAddNewAccount.Controls.Add(txtName);
            pnAddNewAccount.Controls.Add(txtPassword);
            pnAddNewAccount.Controls.Add(txtUserName);
            pnAddNewAccount.Controls.Add(label3);
            pnAddNewAccount.Controls.Add(label4);
            pnAddNewAccount.Controls.Add(btnCancel);
            pnAddNewAccount.Controls.Add(btnUpdate);
            pnAddNewAccount.Controls.Add(btnAddnew);
            pnAddNewAccount.Controls.Add(label2);
            pnAddNewAccount.Controls.Add(label1);
            pnAddNewAccount.Location = new Point(448, 3);
            pnAddNewAccount.Name = "pnAddNewAccount";
            pnAddNewAccount.Size = new Size(401, 326);
            pnAddNewAccount.TabIndex = 0;
            pnAddNewAccount.Visible = false;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.CustomizableEdges = customizableEdges3;
            txtPhone.DefaultText = "";
            txtPhone.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPhone.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPhone.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPhone.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPhone.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPhone.Location = new Point(149, 192);
            txtPhone.Margin = new Padding(0);
            txtPhone.Name = "txtPhone";
            txtPhone.PasswordChar = '\0';
            txtPhone.PlaceholderText = "";
            txtPhone.SelectedText = "";
            txtPhone.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPhone.Size = new Size(244, 50);
            txtPhone.TabIndex = 18;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.CustomizableEdges = customizableEdges5;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(149, 131);
            txtName.Margin = new Padding(0);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtName.Size = new Size(244, 50);
            txtName.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.CustomizableEdges = customizableEdges7;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(149, 72);
            txtPassword.Margin = new Padding(0);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.PlaceholderText = "";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtPassword.Size = new Size(244, 50);
            txtPassword.TabIndex = 16;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.CustomizableEdges = customizableEdges9;
            txtUserName.DefaultText = "";
            txtUserName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUserName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUserName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUserName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUserName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserName.Font = new Font("Segoe UI", 12F);
            txtUserName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserName.Location = new Point(149, 13);
            txtUserName.Margin = new Padding(0);
            txtUserName.Name = "txtUserName";
            txtUserName.PasswordChar = '\0';
            txtUserName.PlaceholderText = "";
            txtUserName.SelectedText = "";
            txtUserName.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtUserName.Size = new Size(244, 50);
            txtUserName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(16, 204);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 13;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(16, 146);
            label4.Name = "label4";
            label4.Size = new Size(41, 25);
            label4.TabIndex = 12;
            label4.Text = "Tên";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.AutoSize = true;
            btnCancel.BackColor = Color.FromArgb(42, 52, 65);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 14F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(294, 275);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(99, 37);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = Color.FromArgb(42, 52, 65);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 14F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(114, 275);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 37);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Visible = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAddnew
            // 
            btnAddnew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddnew.AutoSize = true;
            btnAddnew.BackColor = Color.FromArgb(42, 52, 65);
            btnAddnew.FlatStyle = FlatStyle.Flat;
            btnAddnew.Font = new Font("Segoe UI", 14F);
            btnAddnew.ForeColor = Color.White;
            btnAddnew.Location = new Point(113, 275);
            btnAddnew.Name = "btnAddnew";
            btnAddnew.Size = new Size(154, 37);
            btnAddnew.TabIndex = 9;
            btnAddnew.Text = "Thêm tài khoản";
            btnAddnew.UseVisualStyleBackColor = false;
            btnAddnew.Visible = false;
            btnAddnew.Click += btnAddnew_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(16, 88);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoản";
            // 
            // dgvAdmin
            // 
            dgvAdmin.AllowUserToAddRows = false;
            dgvAdmin.AllowUserToDeleteRows = false;
            dgvAdmin.AllowUserToResizeRows = false;
            dgvAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAdmin.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAdmin.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAdmin.EnableHeadersVisualStyles = false;
            dgvAdmin.Location = new Point(0, 335);
            dgvAdmin.MultiSelect = false;
            dgvAdmin.Name = "dgvAdmin";
            dgvAdmin.ReadOnly = true;
            dgvAdmin.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvAdmin.RowHeadersVisible = false;
            dgvAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdmin.Size = new Size(852, 162);
            dgvAdmin.TabIndex = 0;
            dgvAdmin.MouseDown += dgvAdmin_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { DeleteToolStripMenuItem, EditToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(95, 48);
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.Size = new Size(94, 22);
            DeleteToolStripMenuItem.Text = "Xóa";
            DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(94, 22);
            EditToolStripMenuItem.Text = "Sửa";
            EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AccountManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 538);
            Controls.Add(panel2);
            Name = "AccountManagement";
            Text = "AdminManagement";
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnAddNewAccount.ResumeLayout(false);
            pnAddNewAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel pnAddNewAccount;
        private Label label2;
        private Label label1;
        private DataGridView dgvAdmin;
        private Button btnAddnew;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnUpdate;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private Button btnCancel;
        private GroupBox groupBox1;
        private Button btnAddNewAccount;
        private Button btnEditAccount;
        private Label label3;
        private Label label4;
        private ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2ComboBox cbRoles;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
    }
}