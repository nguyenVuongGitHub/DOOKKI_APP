namespace DOOKKI_APP.Views
{
    partial class ManageEployee
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel3 = new Panel();
            dgvEmployee = new DataGridView();
            panel4 = new Panel();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            btnCancel = new Button();
            txtWage = new TextBox();
            txtEmail = new TextBox();
            cmbPosition = new ComboBox();
            txtPhoneNum = new TextBox();
            txtName = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            errorProvider = new ErrorProvider(components);
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            panel4.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(dgvEmployee);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1134, 708);
            panel3.TabIndex = 2;
            // 
            // dgvEmployee
            // 
            dgvEmployee.AllowUserToResizeRows = false;
            dgvEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEmployee.Location = new Point(28, 18);
            dgvEmployee.Margin = new Padding(3, 2, 3, 2);
            dgvEmployee.MultiSelect = false;
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmployee.RowHeadersVisible = false;
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Size = new Size(1080, 387);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.MouseDown += dgvEmployee_MouseDown;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btnCancel);
            panel4.Controls.Add(txtWage);
            panel4.Controls.Add(txtEmail);
            panel4.Controls.Add(cmbPosition);
            panel4.Controls.Add(txtPhoneNum);
            panel4.Controls.Add(txtName);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(28, 409);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1080, 288);
            panel4.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(42, 52, 65);
            btnAdd.CustomizableEdges = customizableEdges1;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.FromArgb(42, 52, 65);
            btnAdd.Font = new Font("Segoe UI", 14F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(317, 191);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAdd.Size = new Size(121, 33);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom;
            btnUpdate.BackColor = Color.FromArgb(42, 52, 65);
            btnUpdate.CustomizableEdges = customizableEdges3;
            btnUpdate.DisabledState.BorderColor = Color.DarkGray;
            btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdate.Enabled = false;
            btnUpdate.FillColor = Color.FromArgb(42, 52, 65);
            btnUpdate.Font = new Font("Segoe UI", 14F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(475, 191);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnUpdate.Size = new Size(121, 33);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "cập nhật";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(30, 53);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 2;
            label2.Text = "Số điện thoại: ";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.BackColor = Color.FromArgb(42, 52, 65);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 14F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(631, 191);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 33);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtWage
            // 
            txtWage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtWage.Font = new Font("Segoe UI", 14F);
            txtWage.Location = new Point(820, 50);
            txtWage.Margin = new Padding(3, 2, 3, 2);
            txtWage.Name = "txtWage";
            txtWage.Size = new Size(216, 32);
            txtWage.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(213, 93);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 32);
            txtEmail.TabIndex = 11;
            // 
            // cmbPosition
            // 
            cmbPosition.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPosition.Font = new Font("Segoe UI", 14F);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "staff", "chef", "cashier" });
            cmbPosition.Location = new Point(820, 5);
            cmbPosition.Margin = new Padding(3, 2, 3, 2);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(216, 33);
            cmbPosition.TabIndex = 10;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Font = new Font("Segoe UI", 14F);
            txtPhoneNum.Location = new Point(213, 50);
            txtPhoneNum.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(210, 32);
            txtPhoneNum.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14F);
            txtName.Location = new Point(213, 5);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(210, 32);
            txtName.TabIndex = 8;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(568, 12);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 6;
            label6.Text = "Chức vụ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(31, 96);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 4;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(568, 53);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 5;
            label5.Text = "Số tiền lương:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(30, 8);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 3;
            label3.Text = "Tên nhân viên:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(150, 48);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(149, 22);
            editToolStripMenuItem.Text = "Sửa nhân viên";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(149, 22);
            deleteToolStripMenuItem.Text = "Xóa nhân viên";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ManageEployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 708);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageEployee";
            Text = "x";
            Load += ManageEployee_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private DataGridView dgvEmployee;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private TextBox txtName;
        private Label label6;
        private Label label4;
        private Label label5;
        private TextBox txtWage;
        private TextBox txtEmail;
        private ComboBox cmbPosition;
        private TextBox txtPhoneNum;
        private Button btnCancel;
        private ContextMenuStrip contextMenuStrip1;
        private ErrorProvider errorProvider;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
    }
}