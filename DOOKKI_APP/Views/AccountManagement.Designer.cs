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
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            cbRoles = new ComboBox();
            btnEditAccount = new Button();
            btnAddNewAccount = new Button();
            pnAddNewAccount = new Panel();
            txtPhone = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnAddnew = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
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
            panel2.Size = new Size(800, 450);
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
            groupBox1.Size = new Size(381, 267);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý tài khoản";
            // 
            // cbRoles
            // 
            cbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoles.FormattingEnabled = true;
            cbRoles.Location = new Point(235, 63);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new Size(121, 33);
            cbRoles.TabIndex = 2;
            cbRoles.SelectedIndexChanged += cbRoles_SelectedIndexChanged;
            // 
            // btnEditAccount
            // 
            btnEditAccount.AutoSize = true;
            btnEditAccount.Location = new Point(6, 141);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(204, 35);
            btnEditAccount.TabIndex = 1;
            btnEditAccount.Text = "Sửa tài khoản hiện tại";
            btnEditAccount.UseVisualStyleBackColor = true;
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // btnAddNewAccount
            // 
            btnAddNewAccount.AutoSize = true;
            btnAddNewAccount.Location = new Point(6, 63);
            btnAddNewAccount.Name = "btnAddNewAccount";
            btnAddNewAccount.Size = new Size(204, 35);
            btnAddNewAccount.TabIndex = 0;
            btnAddNewAccount.Text = "Cấp tài khoản mới";
            btnAddNewAccount.UseVisualStyleBackColor = true;
            btnAddNewAccount.Click += btnAddNewAccount_Click;
            // 
            // pnAddNewAccount
            // 
            pnAddNewAccount.Controls.Add(txtPhone);
            pnAddNewAccount.Controls.Add(txtName);
            pnAddNewAccount.Controls.Add(label3);
            pnAddNewAccount.Controls.Add(label4);
            pnAddNewAccount.Controls.Add(btnCancel);
            pnAddNewAccount.Controls.Add(btnUpdate);
            pnAddNewAccount.Controls.Add(btnAddnew);
            pnAddNewAccount.Controls.Add(txtPassword);
            pnAddNewAccount.Controls.Add(txtUserName);
            pnAddNewAccount.Controls.Add(label2);
            pnAddNewAccount.Controls.Add(label1);
            pnAddNewAccount.Location = new Point(417, 3);
            pnAddNewAccount.Name = "pnAddNewAccount";
            pnAddNewAccount.Size = new Size(313, 276);
            pnAddNewAccount.TabIndex = 0;
            pnAddNewAccount.Visible = false;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 14F);
            txtPhone.Location = new Point(156, 146);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(148, 32);
            txtPhone.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14F);
            txtName.Location = new Point(156, 104);
            txtName.Name = "txtName";
            txtName.Size = new Size(148, 32);
            txtName.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(16, 149);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 13;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(16, 111);
            label4.Name = "label4";
            label4.Size = new Size(41, 25);
            label4.TabIndex = 12;
            label4.Text = "Tên";
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.Font = new Font("Segoe UI", 14F);
            btnCancel.Location = new Point(205, 197);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(99, 35);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.Font = new Font("Segoe UI", 14F);
            btnUpdate.Location = new Point(26, 197);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 35);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Visible = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAddnew
            // 
            btnAddnew.AutoSize = true;
            btnAddnew.Font = new Font("Segoe UI", 14F);
            btnAddnew.Location = new Point(26, 197);
            btnAddnew.Name = "btnAddnew";
            btnAddnew.Size = new Size(152, 35);
            btnAddnew.TabIndex = 9;
            btnAddnew.Text = "Thêm tài khoản";
            btnAddnew.UseVisualStyleBackColor = true;
            btnAddnew.Visible = false;
            btnAddnew.Click += btnAddnew_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F);
            txtPassword.Location = new Point(156, 61);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(148, 32);
            txtPassword.TabIndex = 5;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 14F);
            txtUserName.Location = new Point(156, 19);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(148, 32);
            txtUserName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(16, 68);
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
            dgvAdmin.AllowUserToResizeColumns = false;
            dgvAdmin.AllowUserToResizeRows = false;
            dgvAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdmin.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvAdmin.Dock = DockStyle.Bottom;
            dgvAdmin.Location = new Point(0, 285);
            dgvAdmin.MultiSelect = false;
            dgvAdmin.Name = "dgvAdmin";
            dgvAdmin.ReadOnly = true;
            dgvAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdmin.Size = new Size(800, 165);
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
            ClientSize = new Size(800, 450);
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
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnAddnew;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnUpdate;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private Button btnCancel;
        private GroupBox groupBox1;
        private Button btnAddNewAccount;
        private Button btnEditAccount;
        private TextBox txtPhone;
        private TextBox txtName;
        private Label label3;
        private Label label4;
        private ComboBox cbRoles;
        private ErrorProvider errorProvider1;
    }
}