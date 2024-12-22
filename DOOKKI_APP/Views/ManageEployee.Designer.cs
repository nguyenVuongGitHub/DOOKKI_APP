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
            panel1 = new Panel();
            btnManageEployee = new Button();
            panel2 = new Panel();
            mnuManageEmployeeFunction = new MenuStrip();
            quảnLýNhgToolStripMenuItem = new ToolStripMenuItem();
            quảnLýChấmCôngToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            dgvEmployee = new DataGridView();
            panel4 = new Panel();
            label2 = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtWage = new TextBox();
            txtEmail = new TextBox();
            cmbPosition = new ComboBox();
            txtPhoneNum = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            mnuManageEmployeeFunction.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnManageEployee);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 511);
            panel1.TabIndex = 0;
            // 
            // btnManageEployee
            // 
            btnManageEployee.Font = new Font("Segoe UI", 14F);
            btnManageEployee.Location = new Point(3, 202);
            btnManageEployee.Margin = new Padding(3, 2, 3, 2);
            btnManageEployee.Name = "btnManageEployee";
            btnManageEployee.Size = new Size(199, 41);
            btnManageEployee.TabIndex = 0;
            btnManageEployee.Text = "Quản lý nhân sự";
            btnManageEployee.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(mnuManageEmployeeFunction);
            panel2.Location = new Point(220, 9);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(835, 45);
            panel2.TabIndex = 1;
            // 
            // mnuManageEmployeeFunction
            // 
            mnuManageEmployeeFunction.BackColor = SystemColors.ControlLight;
            mnuManageEmployeeFunction.ImageScalingSize = new Size(20, 20);
            mnuManageEmployeeFunction.Items.AddRange(new ToolStripItem[] { quảnLýNhgToolStripMenuItem, quảnLýChấmCôngToolStripMenuItem });
            mnuManageEmployeeFunction.Location = new Point(0, 0);
            mnuManageEmployeeFunction.Name = "mnuManageEmployeeFunction";
            mnuManageEmployeeFunction.Padding = new Padding(5, 2, 0, 2);
            mnuManageEmployeeFunction.Size = new Size(835, 33);
            mnuManageEmployeeFunction.TabIndex = 0;
            mnuManageEmployeeFunction.Text = "menuStrip1";
            // 
            // quảnLýNhgToolStripMenuItem
            // 
            quảnLýNhgToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            quảnLýNhgToolStripMenuItem.Name = "quảnLýNhgToolStripMenuItem";
            quảnLýNhgToolStripMenuItem.Size = new Size(177, 29);
            quảnLýNhgToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // quảnLýChấmCôngToolStripMenuItem
            // 
            quảnLýChấmCôngToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            quảnLýChấmCôngToolStripMenuItem.Name = "quảnLýChấmCôngToolStripMenuItem";
            quảnLýChấmCôngToolStripMenuItem.Size = new Size(187, 29);
            quảnLýChấmCôngToolStripMenuItem.Text = "Quản lý chấm công";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(dgvEmployee);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(220, 58);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(835, 461);
            panel3.TabIndex = 2;
            // 
            // dgvEmployee
            // 
            dgvEmployee.AllowUserToResizeRows = false;
            dgvEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            dgvEmployee.Size = new Size(781, 206);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btnCancel);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(btnEdit);
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(txtWage);
            panel4.Controls.Add(txtEmail);
            panel4.Controls.Add(cmbPosition);
            panel4.Controls.Add(txtPhoneNum);
            panel4.Controls.Add(txtName);
            panel4.Controls.Add(txtID);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(28, 242);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(781, 208);
            panel4.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(18, 53);
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
            btnCancel.Location = new Point(574, 162);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 35);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom;
            btnUpdate.BackColor = Color.FromArgb(42, 52, 65);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 14F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(469, 162);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 33);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Ghi dữ liệu";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom;
            btnDelete.BackColor = Color.FromArgb(42, 52, 65);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 14F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(358, 162);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 33);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom;
            btnEdit.BackColor = Color.FromArgb(42, 52, 65);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 14F);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(250, 162);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 33);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Sữa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom;
            btnAdd.BackColor = Color.FromArgb(42, 52, 65);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 14F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(148, 162);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 33);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtWage
            // 
            txtWage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtWage.Font = new Font("Segoe UI", 14F);
            txtWage.Location = new Point(574, 93);
            txtWage.Margin = new Padding(3, 2, 3, 2);
            txtWage.Name = "txtWage";
            txtWage.Size = new Size(200, 32);
            txtWage.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(190, 93);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 32);
            txtEmail.TabIndex = 11;
            // 
            // cmbPosition
            // 
            cmbPosition.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbPosition.Font = new Font("Segoe UI", 14F);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "staff", "chef", "cashier" });
            cmbPosition.Location = new Point(574, 50);
            cmbPosition.Margin = new Padding(3, 2, 3, 2);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(200, 33);
            cmbPosition.TabIndex = 10;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Font = new Font("Segoe UI", 14F);
            txtPhoneNum.Location = new Point(190, 50);
            txtPhoneNum.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(210, 32);
            txtPhoneNum.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 14F);
            txtName.Location = new Point(574, 5);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 32);
            txtName.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 14F);
            txtID.Location = new Point(190, 5);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(210, 32);
            txtID.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(418, 50);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 6;
            label6.Text = "Chức vụ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(18, 8);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 1;
            label1.Text = "Mã nhân viên(ID): ";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(18, 96);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 4;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(418, 95);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 5;
            label5.Text = "Số tiền lương:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(418, 11);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 3;
            label3.Text = "Tên nhân viên:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ManageEployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 529);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MainMenuStrip = mnuManageEmployeeFunction;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageEployee";
            Text = "x";
            Load += ManageEployee_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            mnuManageEmployeeFunction.ResumeLayout(false);
            mnuManageEmployeeFunction.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private MenuStrip mnuManageEmployeeFunction;
        private ToolStripMenuItem quảnLýNhgToolStripMenuItem;
        private ToolStripMenuItem quảnLýChấmCôngToolStripMenuItem;
        private Button btnManageEployee;
        private DataGridView dgvEmployee;
        private Label label1;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private TextBox txtName;
        private TextBox txtID;
        private Label label6;
        private Label label4;
        private Label label5;
        private TextBox txtWage;
        private TextBox txtEmail;
        private ComboBox cmbPosition;
        private TextBox txtPhoneNum;
        private Button btnCancel;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private ContextMenuStrip contextMenuStrip1;
    }
}