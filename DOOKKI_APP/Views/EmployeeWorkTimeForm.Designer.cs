namespace DOOKKI_APP.Views
{
    partial class EmployeeWorkTimeForm
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
            panel6 = new Panel();
            lblPageInfo = new Label();
            label3 = new Label();
            cmbPageSize = new ComboBox();
            btn_foward = new Button();
            btn_back = new Button();
            panel7 = new Panel();
            label2 = new Label();
            cmbFilterMonth = new ComboBox();
            txtSearch = new TextBox();
            dgvWorkTime = new DataGridView();
            panel3 = new Panel();
            panel8 = new Panel();
            btn_Import = new Button();
            btn_Export = new Button();
            panel5 = new Panel();
            dateTimePicker = new DateTimePicker();
            txtTimeWork = new TextBox();
            lblTimeWork = new Label();
            panel2 = new Panel();
            btnDeleteWorkTime = new Button();
            btnUpdateWorkTime = new Button();
            btnAddWorkTime = new Button();
            panel4 = new Panel();
            txtPhone = new TextBox();
            txtPosition = new TextBox();
            lblEmployeePhone = new Label();
            lblEmplyeeID = new Label();
            lblEmployeePosition = new Label();
            CmbEmployeeID = new ComboBox();
            lblEmployeeName = new Label();
            txtName = new TextBox();
            errorProviderTime = new ErrorProvider(components);
            errorProviderDate = new ErrorProvider(components);
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWorkTime).BeginInit();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(10, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 535);
            panel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblPageInfo);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(cmbPageSize);
            panel6.Controls.Add(btn_foward);
            panel6.Controls.Add(btn_back);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(dgvWorkTime);
            panel6.Location = new Point(17, 17);
            panel6.Name = "panel6";
            panel6.Size = new Size(502, 490);
            panel6.TabIndex = 3;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Location = new Point(293, 462);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(56, 15);
            lblPageInfo.TabIndex = 12;
            lblPageInfo.Text = "Trang 1/1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 460);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 11;
            label3.Text = "số trang:";
            // 
            // cmbPageSize
            // 
            cmbPageSize.FormattingEnabled = true;
            cmbPageSize.Items.AddRange(new object[] { "5", "10", "20", "50" });
            cmbPageSize.Location = new Point(78, 457);
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new Size(76, 23);
            cmbPageSize.TabIndex = 11;
            cmbPageSize.SelectedIndexChanged += cmbPageSize_SelectedIndexChanged;
            // 
            // btn_foward
            // 
            btn_foward.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_foward.BackColor = Color.FromArgb(42, 52, 65);
            btn_foward.FlatStyle = FlatStyle.Flat;
            btn_foward.Font = new Font("Segoe UI", 14F);
            btn_foward.ForeColor = Color.White;
            btn_foward.Location = new Point(367, 450);
            btn_foward.Margin = new Padding(3, 2, 3, 2);
            btn_foward.Name = "btn_foward";
            btn_foward.Size = new Size(118, 38);
            btn_foward.TabIndex = 11;
            btn_foward.Text = "Trang sau";
            btn_foward.UseVisualStyleBackColor = false;
            btn_foward.Click += btn_foward_Click;
            // 
            // btn_back
            // 
            btn_back.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_back.BackColor = Color.FromArgb(42, 52, 65);
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI", 14F);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(160, 450);
            btn_back.Margin = new Padding(3, 2, 3, 2);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(118, 38);
            btn_back.TabIndex = 10;
            btn_back.Text = "Trang trước";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(label2);
            panel7.Controls.Add(cmbFilterMonth);
            panel7.Controls.Add(txtSearch);
            panel7.Location = new Point(16, 10);
            panel7.Name = "panel7";
            panel7.Size = new Size(472, 43);
            panel7.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 10;
            label2.Text = "Tìm kiếm:";
            // 
            // cmbFilterMonth
            // 
            cmbFilterMonth.FormattingEnabled = true;
            cmbFilterMonth.Items.AddRange(new object[] { "Hôm nay", "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" });
            cmbFilterMonth.Location = new Point(224, 3);
            cmbFilterMonth.Name = "cmbFilterMonth";
            cmbFilterMonth.Size = new Size(245, 23);
            cmbFilterMonth.TabIndex = 2;
            cmbFilterMonth.SelectedIndexChanged += cmbFilterMonth_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(59, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(159, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvWorkTime
            // 
            dgvWorkTime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorkTime.Location = new Point(16, 58);
            dgvWorkTime.Margin = new Padding(3, 2, 3, 2);
            dgvWorkTime.Name = "dgvWorkTime";
            dgvWorkTime.RowHeadersWidth = 51;
            dgvWorkTime.Size = new Size(472, 378);
            dgvWorkTime.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(525, 17);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(453, 490);
            panel3.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(btn_Import);
            panel8.Controls.Add(btn_Export);
            panel8.Location = new Point(13, 282);
            panel8.Name = "panel8";
            panel8.Size = new Size(403, 82);
            panel8.TabIndex = 14;
            // 
            // btn_Import
            // 
            btn_Import.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Import.BackColor = Color.FromArgb(42, 52, 65);
            btn_Import.FlatStyle = FlatStyle.Flat;
            btn_Import.Font = new Font("Segoe UI", 14F);
            btn_Import.ForeColor = Color.White;
            btn_Import.Location = new Point(63, 28);
            btn_Import.Margin = new Padding(3, 2, 3, 2);
            btn_Import.Name = "btn_Import";
            btn_Import.Size = new Size(118, 38);
            btn_Import.TabIndex = 12;
            btn_Import.Text = "Nhập File";
            btn_Import.UseVisualStyleBackColor = false;
            btn_Import.Click += btn_Import_Click;
            // 
            // btn_Export
            // 
            btn_Export.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Export.BackColor = Color.FromArgb(42, 52, 65);
            btn_Export.FlatStyle = FlatStyle.Flat;
            btn_Export.Font = new Font("Segoe UI", 14F);
            btn_Export.ForeColor = Color.White;
            btn_Export.Location = new Point(240, 28);
            btn_Export.Margin = new Padding(3, 2, 3, 2);
            btn_Export.Name = "btn_Export";
            btn_Export.Size = new Size(118, 38);
            btn_Export.TabIndex = 13;
            btn_Export.Text = "Xuất File";
            btn_Export.UseVisualStyleBackColor = false;
            btn_Export.Click += btn_Export_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(dateTimePicker);
            panel5.Controls.Add(txtTimeWork);
            panel5.Controls.Add(lblTimeWork);
            panel5.Location = new Point(12, 83);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(425, 79);
            panel5.TabIndex = 9;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker.Location = new Point(16, 39);
            dateTimePicker.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(378, 23);
            dateTimePicker.TabIndex = 2;
            // 
            // txtTimeWork
            // 
            txtTimeWork.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimeWork.Location = new Point(89, 2);
            txtTimeWork.Margin = new Padding(3, 2, 3, 2);
            txtTimeWork.Name = "txtTimeWork";
            txtTimeWork.Size = new Size(305, 23);
            txtTimeWork.TabIndex = 1;
            // 
            // lblTimeWork
            // 
            lblTimeWork.AutoSize = true;
            lblTimeWork.Location = new Point(16, 7);
            lblTimeWork.Name = "lblTimeWork";
            lblTimeWork.Size = new Size(67, 15);
            lblTimeWork.TabIndex = 0;
            lblTimeWork.Text = "Time Work:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(btnDeleteWorkTime);
            panel2.Controls.Add(btnUpdateWorkTime);
            panel2.Controls.Add(btnAddWorkTime);
            panel2.Location = new Point(13, 200);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 50);
            panel2.TabIndex = 1;
            // 
            // btnDeleteWorkTime
            // 
            btnDeleteWorkTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteWorkTime.BackColor = Color.FromArgb(42, 52, 65);
            btnDeleteWorkTime.FlatStyle = FlatStyle.Flat;
            btnDeleteWorkTime.Font = new Font("Segoe UI", 14F);
            btnDeleteWorkTime.ForeColor = Color.White;
            btnDeleteWorkTime.Location = new Point(271, 6);
            btnDeleteWorkTime.Margin = new Padding(3, 2, 3, 2);
            btnDeleteWorkTime.Name = "btnDeleteWorkTime";
            btnDeleteWorkTime.Size = new Size(87, 38);
            btnDeleteWorkTime.TabIndex = 2;
            btnDeleteWorkTime.Text = "Xóa";
            btnDeleteWorkTime.UseVisualStyleBackColor = false;
            btnDeleteWorkTime.Click += btnDeleteWorkTime_Click;
            // 
            // btnUpdateWorkTime
            // 
            btnUpdateWorkTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateWorkTime.BackColor = Color.FromArgb(42, 52, 65);
            btnUpdateWorkTime.FlatStyle = FlatStyle.Flat;
            btnUpdateWorkTime.Font = new Font("Segoe UI", 14F);
            btnUpdateWorkTime.ForeColor = Color.White;
            btnUpdateWorkTime.Location = new Point(167, 6);
            btnUpdateWorkTime.Margin = new Padding(3, 2, 3, 2);
            btnUpdateWorkTime.Name = "btnUpdateWorkTime";
            btnUpdateWorkTime.Size = new Size(87, 38);
            btnUpdateWorkTime.TabIndex = 1;
            btnUpdateWorkTime.Text = "Sửa";
            btnUpdateWorkTime.UseVisualStyleBackColor = false;
            btnUpdateWorkTime.Click += btnUpdateWorkTime_Click;
            // 
            // btnAddWorkTime
            // 
            btnAddWorkTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddWorkTime.BackColor = Color.FromArgb(42, 52, 65);
            btnAddWorkTime.FlatStyle = FlatStyle.Flat;
            btnAddWorkTime.Font = new Font("Segoe UI", 14F);
            btnAddWorkTime.ForeColor = Color.White;
            btnAddWorkTime.Location = new Point(63, 6);
            btnAddWorkTime.Margin = new Padding(3, 2, 3, 2);
            btnAddWorkTime.Name = "btnAddWorkTime";
            btnAddWorkTime.Size = new Size(87, 38);
            btnAddWorkTime.TabIndex = 0;
            btnAddWorkTime.Text = "Thêm";
            btnAddWorkTime.UseVisualStyleBackColor = false;
            btnAddWorkTime.Click += btnAddWorkTime_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtPhone);
            panel4.Controls.Add(txtPosition);
            panel4.Controls.Add(lblEmployeePhone);
            panel4.Controls.Add(lblEmplyeeID);
            panel4.Controls.Add(lblEmployeePosition);
            panel4.Controls.Add(CmbEmployeeID);
            panel4.Controls.Add(lblEmployeeName);
            panel4.Controls.Add(txtName);
            panel4.Location = new Point(13, 10);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(406, 69);
            panel4.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPhone.Location = new Point(238, 40);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(155, 23);
            txtPhone.TabIndex = 5;
            txtPhone.Leave += txtPhone_Leave;
            // 
            // txtPosition
            // 
            txtPosition.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPosition.Location = new Point(79, 40);
            txtPosition.Margin = new Padding(3, 2, 3, 2);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(74, 23);
            txtPosition.TabIndex = 7;
            // 
            // lblEmployeePhone
            // 
            lblEmployeePhone.AutoSize = true;
            lblEmployeePhone.Location = new Point(188, 43);
            lblEmployeePhone.Name = "lblEmployeePhone";
            lblEmployeePhone.Size = new Size(44, 15);
            lblEmployeePhone.TabIndex = 4;
            lblEmployeePhone.Text = "Phone:";
            // 
            // lblEmplyeeID
            // 
            lblEmplyeeID.AutoSize = true;
            lblEmplyeeID.Location = new Point(16, 6);
            lblEmplyeeID.Name = "lblEmplyeeID";
            lblEmplyeeID.Size = new Size(21, 15);
            lblEmplyeeID.TabIndex = 1;
            lblEmplyeeID.Text = "ID:";
            // 
            // lblEmployeePosition
            // 
            lblEmployeePosition.AutoSize = true;
            lblEmployeePosition.Location = new Point(16, 43);
            lblEmployeePosition.Name = "lblEmployeePosition";
            lblEmployeePosition.Size = new Size(53, 15);
            lblEmployeePosition.TabIndex = 6;
            lblEmployeePosition.Text = "Position:";
            lblEmployeePosition.Click += label1_Click;
            // 
            // CmbEmployeeID
            // 
            CmbEmployeeID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CmbEmployeeID.FormattingEnabled = true;
            CmbEmployeeID.Location = new Point(46, 4);
            CmbEmployeeID.Margin = new Padding(3, 2, 3, 2);
            CmbEmployeeID.Name = "CmbEmployeeID";
            CmbEmployeeID.Size = new Size(106, 23);
            CmbEmployeeID.TabIndex = 0;
            CmbEmployeeID.SelectedIndexChanged += cmbEmployeeID_SelectedIndexChanged;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Location = new Point(188, 6);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(42, 15);
            lblEmployeeName.TabIndex = 2;
            lblEmployeeName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtName.Location = new Point(236, 4);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(157, 23);
            txtName.TabIndex = 3;
            txtName.Leave += txtName_Leave;
            // 
            // errorProviderTime
            // 
            errorProviderTime.ContainerControl = this;
            // 
            // errorProviderDate
            // 
            errorProviderDate.ContainerControl = this;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // EmployeeWorkTimeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 566);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmployeeWorkTimeForm";
            Text = "EmployeeWorkTimeForm";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWorkTime).EndInit();
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DataGridView dgvWorkTime;
        private Panel panel2;
        private Button btnUpdateWorkTime;
        private Button btnAddWorkTime;
        private Panel panel3;
        private Label lblEmplyeeID;
        private ComboBox CmbEmployeeID;
        private Button btnDeleteWorkTime;
        private Label lblEmployeeName;
        private Label lblEmployeePosition;
        private TextBox txtPhone;
        private Label lblEmployeePhone;
        private TextBox txtName;
        private TextBox txtPosition;
        private Panel panel4;
        private Panel panel5;
        private DateTimePicker dateTimePicker;
        private TextBox txtTimeWork;
        private Label lblTimeWork;
        private ErrorProvider errorProviderTime;
        private ErrorProvider errorProviderDate;
        private Panel panel6;
        private Panel panel7;
        private TextBox txtSearch;
        private Button btn_back;
        private ComboBox cmbFilterMonth;
        private Button btn_foward;
        private Panel panel8;
        private Button btn_Import;
        private Button btn_Export;
        private Label label2;
        private Label label3;
        private ComboBox cmbPageSize;
        private Label lblPageInfo;
        private ErrorProvider errorProvider;
    }
}