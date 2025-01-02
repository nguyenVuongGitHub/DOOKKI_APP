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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel6 = new Panel();
            panel8 = new Panel();
            btn_Import = new Button();
            btn_Export = new Button();
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            xóaToolStripMenuItem = new ToolStripMenuItem();
            sửaToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            panel2 = new Panel();
            btnUpdateWorkTime = new Guna.UI2.WinForms.Guna2Button();
            btnAddWorkTime = new Button();
            panel4 = new Panel();
            label1 = new Label();
            dateTimePicker = new DateTimePicker();
            txtTimeWork = new TextBox();
            txtPhone = new TextBox();
            lblTimeWork = new Label();
            lblEmployeePhone = new Label();
            lblEmplyeeID = new Label();
            CmbEmployeeID = new ComboBox();
            lblEmployeeName = new Label();
            txtName = new TextBox();
            errorProviderTime = new ErrorProvider(components);
            errorProviderDate = new ErrorProvider(components);
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWorkTime).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 566);
            panel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.WhiteSmoke;
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(lblPageInfo);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(cmbPageSize);
            panel6.Controls.Add(btn_foward);
            panel6.Controls.Add(btn_back);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(dgvWorkTime);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(614, 566);
            panel6.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.Controls.Add(btn_Import);
            panel8.Controls.Add(btn_Export);
            panel8.Location = new Point(351, 12);
            panel8.Name = "panel8";
            panel8.Size = new Size(251, 49);
            panel8.TabIndex = 14;
            // 
            // btn_Import
            // 
            btn_Import.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Import.BackColor = Color.FromArgb(42, 52, 65);
            btn_Import.FlatStyle = FlatStyle.Flat;
            btn_Import.Font = new Font("Segoe UI", 14.25F);
            btn_Import.ForeColor = Color.White;
            btn_Import.Location = new Point(6, 3);
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
            btn_Export.Font = new Font("Segoe UI", 14.25F);
            btn_Export.ForeColor = Color.White;
            btn_Export.Location = new Point(130, 3);
            btn_Export.Margin = new Padding(3, 2, 3, 2);
            btn_Export.Name = "btn_Export";
            btn_Export.Size = new Size(118, 38);
            btn_Export.TabIndex = 13;
            btn_Export.Text = "Xuất File";
            btn_Export.UseVisualStyleBackColor = false;
            btn_Export.Click += btn_Export_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Segoe UI", 14.25F);
            lblPageInfo.Location = new Point(263, 525);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(91, 25);
            lblPageInfo.TabIndex = 12;
            lblPageInfo.Text = "Trang 1/1";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(17, 526);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 11;
            label3.Text = "số trang:";
            // 
            // cmbPageSize
            // 
            cmbPageSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbPageSize.Font = new Font("Segoe UI", 14.25F);
            cmbPageSize.FormattingEnabled = true;
            cmbPageSize.Items.AddRange(new object[] { "5", "10", "20", "50" });
            cmbPageSize.Location = new Point(102, 523);
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new Size(76, 33);
            cmbPageSize.TabIndex = 11;
            cmbPageSize.SelectedIndexChanged += cmbPageSize_SelectedIndexChanged;
            // 
            // btn_foward
            // 
            btn_foward.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_foward.BackColor = Color.FromArgb(42, 52, 65);
            btn_foward.FlatStyle = FlatStyle.Flat;
            btn_foward.Font = new Font("Segoe UI", 14.25F);
            btn_foward.ForeColor = Color.White;
            btn_foward.Location = new Point(484, 518);
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
            btn_back.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_back.BackColor = Color.FromArgb(42, 52, 65);
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI", 14.25F);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(360, 518);
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
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.Controls.Add(label2);
            panel7.Controls.Add(cmbFilterMonth);
            panel7.Controls.Add(txtSearch);
            panel7.Location = new Point(21, 78);
            panel7.Name = "panel7";
            panel7.Size = new Size(581, 43);
            panel7.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 10;
            label2.Text = "Tìm kiếm:";
            // 
            // cmbFilterMonth
            // 
            cmbFilterMonth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFilterMonth.Font = new Font("Segoe UI", 14.25F);
            cmbFilterMonth.FormattingEnabled = true;
            cmbFilterMonth.Items.AddRange(new object[] { "Hôm nay", "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" });
            cmbFilterMonth.Location = new Point(407, 4);
            cmbFilterMonth.Name = "cmbFilterMonth";
            cmbFilterMonth.Size = new Size(171, 33);
            cmbFilterMonth.TabIndex = 2;
            cmbFilterMonth.SelectedIndexChanged += cmbFilterMonth_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14.25F);
            txtSearch.Location = new Point(101, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(178, 33);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvWorkTime
            // 
            dgvWorkTime.AllowUserToResizeRows = false;
            dgvWorkTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvWorkTime.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWorkTime.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvWorkTime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvWorkTime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorkTime.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvWorkTime.DefaultCellStyle = dataGridViewCellStyle2;
            dgvWorkTime.Location = new Point(21, 126);
            dgvWorkTime.Margin = new Padding(3, 2, 3, 2);
            dgvWorkTime.Name = "dgvWorkTime";
            dgvWorkTime.RowHeadersVisible = false;
            dgvWorkTime.RowHeadersWidth = 51;
            dgvWorkTime.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWorkTime.Size = new Size(581, 378);
            dgvWorkTime.TabIndex = 0;
            dgvWorkTime.MouseDown += dgvWorkTime_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { xóaToolStripMenuItem, sửaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(95, 48);
            // 
            // xóaToolStripMenuItem
            // 
            xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            xóaToolStripMenuItem.Size = new Size(94, 22);
            xóaToolStripMenuItem.Text = "Xóa";
            xóaToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // sửaToolStripMenuItem
            // 
            sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            sửaToolStripMenuItem.Size = new Size(94, 22);
            sửaToolStripMenuItem.Text = "Sửa";
            sửaToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(620, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(466, 566);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnUpdateWorkTime);
            panel2.Controls.Add(btnAddWorkTime);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 518);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(466, 48);
            panel2.TabIndex = 1;
            // 
            // btnUpdateWorkTime
            // 
            btnUpdateWorkTime.BackColor = Color.FromArgb(42, 52, 65);
            btnUpdateWorkTime.CustomizableEdges = customizableEdges1;
            btnUpdateWorkTime.DisabledState.BorderColor = Color.DarkGray;
            btnUpdateWorkTime.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdateWorkTime.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdateWorkTime.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdateWorkTime.Enabled = false;
            btnUpdateWorkTime.FillColor = Color.FromArgb(42, 52, 65);
            btnUpdateWorkTime.Font = new Font("Segoe UI", 14.25F);
            btnUpdateWorkTime.ForeColor = Color.White;
            btnUpdateWorkTime.Location = new Point(263, 7);
            btnUpdateWorkTime.Name = "btnUpdateWorkTime";
            btnUpdateWorkTime.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnUpdateWorkTime.Size = new Size(87, 38);
            btnUpdateWorkTime.TabIndex = 2;
            btnUpdateWorkTime.Text = "Sửa";
            btnUpdateWorkTime.Click += btnUpdateWorkTime_Click;
            // 
            // btnAddWorkTime
            // 
            btnAddWorkTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddWorkTime.BackColor = Color.FromArgb(42, 52, 65);
            btnAddWorkTime.FlatStyle = FlatStyle.Flat;
            btnAddWorkTime.Font = new Font("Segoe UI", 14.25F);
            btnAddWorkTime.ForeColor = Color.White;
            btnAddWorkTime.Location = new Point(367, 7);
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
            panel4.Controls.Add(label1);
            panel4.Controls.Add(dateTimePicker);
            panel4.Controls.Add(txtTimeWork);
            panel4.Controls.Add(txtPhone);
            panel4.Controls.Add(lblTimeWork);
            panel4.Controls.Add(lblEmployeePhone);
            panel4.Controls.Add(lblEmplyeeID);
            panel4.Controls.Add(CmbEmployeeID);
            panel4.Controls.Add(lblEmployeeName);
            panel4.Controls.Add(txtName);
            panel4.Dock = DockStyle.Top;
            panel4.Font = new Font("Segoe UI", 14.25F);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(466, 375);
            panel4.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(16, 215);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 8;
            label1.Text = "Ngày:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker.Enabled = false;
            dateTimePicker.Font = new Font("Segoe UI", 14.25F);
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(157, 215);
            dateTimePicker.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(297, 33);
            dateTimePicker.TabIndex = 2;
            // 
            // txtTimeWork
            // 
            txtTimeWork.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimeWork.Font = new Font("Segoe UI", 14.25F);
            txtTimeWork.Location = new Point(157, 162);
            txtTimeWork.Margin = new Padding(3, 2, 3, 2);
            txtTimeWork.Name = "txtTimeWork";
            txtTimeWork.Size = new Size(297, 33);
            txtTimeWork.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Font = new Font("Segoe UI", 14.25F);
            txtPhone.Location = new Point(157, 109);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(297, 33);
            txtPhone.TabIndex = 5;
            txtPhone.Leave += txtPhone_Leave;
            // 
            // lblTimeWork
            // 
            lblTimeWork.AutoSize = true;
            lblTimeWork.Font = new Font("Segoe UI", 14.25F);
            lblTimeWork.Location = new Point(17, 167);
            lblTimeWork.Name = "lblTimeWork";
            lblTimeWork.Size = new Size(69, 25);
            lblTimeWork.TabIndex = 0;
            lblTimeWork.Text = "Số giờ:";
            // 
            // lblEmployeePhone
            // 
            lblEmployeePhone.AutoSize = true;
            lblEmployeePhone.Font = new Font("Segoe UI", 14.25F);
            lblEmployeePhone.Location = new Point(16, 112);
            lblEmployeePhone.Name = "lblEmployeePhone";
            lblEmployeePhone.Size = new Size(127, 25);
            lblEmployeePhone.TabIndex = 4;
            lblEmployeePhone.Text = "Số điện thoại:";
            // 
            // lblEmplyeeID
            // 
            lblEmplyeeID.AutoSize = true;
            lblEmplyeeID.Location = new Point(16, 6);
            lblEmplyeeID.Name = "lblEmplyeeID";
            lblEmplyeeID.Size = new Size(122, 25);
            lblEmplyeeID.TabIndex = 1;
            lblEmplyeeID.Text = "ID nhân viên:";
            // 
            // CmbEmployeeID
            // 
            CmbEmployeeID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbEmployeeID.Font = new Font("Segoe UI", 14.25F);
            CmbEmployeeID.FormattingEnabled = true;
            CmbEmployeeID.Location = new Point(157, 6);
            CmbEmployeeID.Margin = new Padding(3, 2, 3, 2);
            CmbEmployeeID.Name = "CmbEmployeeID";
            CmbEmployeeID.Size = new Size(297, 33);
            CmbEmployeeID.TabIndex = 0;
            CmbEmployeeID.SelectedIndexChanged += cmbEmployeeID_SelectedIndexChanged;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Segoe UI", 14.25F);
            lblEmployeeName.Location = new Point(16, 59);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(96, 25);
            lblEmployeeName.TabIndex = 2;
            lblEmployeeName.Text = "Họ và tên:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 14.25F);
            txtName.Location = new Point(157, 56);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(297, 33);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
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
            BackColor = Color.White;
            ClientSize = new Size(1086, 566);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmployeeWorkTimeForm";
            Text = "EmployeeWorkTimeForm";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWorkTime).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel3.ResumeLayout(false);
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
        private Button btnAddWorkTime;
        private Panel panel3;
        private Label lblEmplyeeID;
        private ComboBox CmbEmployeeID;
        private Label lblEmployeeName;
        private TextBox txtPhone;
        private Label lblEmployeePhone;
        private TextBox txtName;
        private Panel panel4;
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
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem xóaToolStripMenuItem;
        private ToolStripMenuItem sửaToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnUpdateWorkTime;
    }
}