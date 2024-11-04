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
            panel1 = new Panel();
            btnManageEployee = new Button();
            panel2 = new Panel();
            mnuManageEmployeeFunction = new MenuStrip();
            quảnLýNhgToolStripMenuItem = new ToolStripMenuItem();
            quảnLýChấmCôngToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            label2 = new Label();
            dgvEmployee = new DataGridView();
            panel4 = new Panel();
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
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnManageEployee);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 681);
            panel1.TabIndex = 0;
            // 
            // btnManageEployee
            // 
            btnManageEployee.Location = new Point(32, 269);
            btnManageEployee.Name = "btnManageEployee";
            btnManageEployee.Size = new Size(164, 29);
            btnManageEployee.TabIndex = 0;
            btnManageEployee.Text = "Quản lý nhân sự";
            btnManageEployee.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(mnuManageEmployeeFunction);
            panel2.Location = new Point(252, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(954, 60);
            panel2.TabIndex = 1;
            // 
            // mnuManageEmployeeFunction
            // 
            mnuManageEmployeeFunction.BackColor = SystemColors.ControlLight;
            mnuManageEmployeeFunction.ImageScalingSize = new Size(20, 20);
            mnuManageEmployeeFunction.Items.AddRange(new ToolStripItem[] { quảnLýNhgToolStripMenuItem, quảnLýChấmCôngToolStripMenuItem });
            mnuManageEmployeeFunction.Location = new Point(0, 0);
            mnuManageEmployeeFunction.Name = "mnuManageEmployeeFunction";
            mnuManageEmployeeFunction.Size = new Size(954, 28);
            mnuManageEmployeeFunction.TabIndex = 0;
            mnuManageEmployeeFunction.Text = "menuStrip1";
            // 
            // quảnLýNhgToolStripMenuItem
            // 
            quảnLýNhgToolStripMenuItem.Name = "quảnLýNhgToolStripMenuItem";
            quảnLýNhgToolStripMenuItem.Size = new Size(140, 24);
            quảnLýNhgToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // quảnLýChấmCôngToolStripMenuItem
            // 
            quảnLýChấmCôngToolStripMenuItem.Name = "quảnLýChấmCôngToolStripMenuItem";
            quảnLýChấmCôngToolStripMenuItem.Size = new Size(150, 24);
            quảnLýChấmCôngToolStripMenuItem.Text = "Quản lý chấm công";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dgvEmployee);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(252, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(954, 615);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 372);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Số điện thoại: ";
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(32, 24);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(893, 274);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // panel4
            // 
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
            panel4.Location = new Point(32, 322);
            panel4.Name = "panel4";
            panel4.Size = new Size(893, 250);
            panel4.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Salmon;
            btnCancel.Location = new Point(656, 204);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkOrange;
            btnUpdate.Location = new Point(536, 204);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Ghi dữ liệu";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(409, 204);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Yellow;
            btnEdit.Location = new Point(286, 204);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Sữa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LawnGreen;
            btnAdd.Location = new Point(169, 204);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtWage
            // 
            txtWage.Location = new Point(169, 154);
            txtWage.Name = "txtWage";
            txtWage.Size = new Size(239, 27);
            txtWage.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(169, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(595, 27);
            txtEmail.TabIndex = 11;
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "staff", "chef", "cashier" });
            cmbPosition.Location = new Point(536, 47);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(228, 28);
            cmbPosition.TabIndex = 10;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(169, 50);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(239, 27);
            txtPhoneNum.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(536, 10);
            txtName.Name = "txtName";
            txtName.Size = new Size(228, 27);
            txtName.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Location = new Point(169, 10);
            txtID.Name = "txtID";
            txtID.Size = new Size(239, 27);
            txtID.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(428, 50);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 6;
            label6.Text = "Chức vụ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 10);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã nhân viên(ID): ";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 104);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 4;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 154);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 5;
            label5.Text = "Số tiền lương:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 10);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 705);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MainMenuStrip = mnuManageEmployeeFunction;
            Name = "ManageEployee";
            Text = "x";
            Load += ManageEployee_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            mnuManageEmployeeFunction.ResumeLayout(false);
            mnuManageEmployeeFunction.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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