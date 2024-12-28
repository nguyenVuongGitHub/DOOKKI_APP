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
            menuStrip = new MenuStrip();
            tệpToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            dateTimePicker = new DateTimePicker();
            txtTimeWork = new TextBox();
            lblTimeWork = new Label();
            panel4 = new Panel();
            txtPhone = new TextBox();
            txtPosition = new TextBox();
            lblEmployeePhone = new Label();
            lblEmplyeeID = new Label();
            lblEmployeePosition = new Label();
            cmbEmployeeID = new ComboBox();
            lblEmployeeName = new Label();
            txtName = new TextBox();
            panel2 = new Panel();
            btnDeleteWorkTime = new Button();
            btnUpdateWorkTime = new Button();
            btnAddWorkTime = new Button();
            dgvWorkTime = new DataGridView();
            errorProviderTime = new ErrorProvider(components);
            errorProviderDate = new ErrorProvider(components);
            menuStrip.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWorkTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { tệpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.Size = new Size(765, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem });
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(38, 20);
            tệpToolStripMenuItem.Text = "Tệp";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(180, 22);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(180, 22);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvWorkTime);
            panel1.Location = new Point(10, 23);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 403);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(13, 11);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(721, 86);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(dateTimePicker);
            panel5.Controls.Add(txtTimeWork);
            panel5.Controls.Add(lblTimeWork);
            panel5.Location = new Point(445, 10);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(266, 64);
            panel5.TabIndex = 9;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker.Location = new Point(12, 39);
            dateTimePicker.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(219, 23);
            dateTimePicker.TabIndex = 2;
            // 
            // txtTimeWork
            // 
            txtTimeWork.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimeWork.Location = new Point(90, 4);
            txtTimeWork.Margin = new Padding(3, 2, 3, 2);
            txtTimeWork.Name = "txtTimeWork";
            txtTimeWork.Size = new Size(141, 23);
            txtTimeWork.TabIndex = 1;
            // 
            // lblTimeWork
            // 
            lblTimeWork.AutoSize = true;
            lblTimeWork.Location = new Point(12, 6);
            lblTimeWork.Name = "lblTimeWork";
            lblTimeWork.Size = new Size(67, 15);
            lblTimeWork.TabIndex = 0;
            lblTimeWork.Text = "Time Work:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtPhone);
            panel4.Controls.Add(txtPosition);
            panel4.Controls.Add(lblEmployeePhone);
            panel4.Controls.Add(lblEmplyeeID);
            panel4.Controls.Add(lblEmployeePosition);
            panel4.Controls.Add(cmbEmployeeID);
            panel4.Controls.Add(lblEmployeeName);
            panel4.Controls.Add(txtName);
            panel4.Location = new Point(19, 10);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(402, 64);
            panel4.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPhone.Location = new Point(240, 40);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(153, 23);
            txtPhone.TabIndex = 5;
            // 
            // txtPosition
            // 
            txtPosition.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPosition.Location = new Point(77, 38);
            txtPosition.Margin = new Padding(3, 2, 3, 2);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(88, 23);
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
            // cmbEmployeeID
            // 
            cmbEmployeeID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbEmployeeID.FormattingEnabled = true;
            cmbEmployeeID.Location = new Point(45, 4);
            cmbEmployeeID.Margin = new Padding(3, 2, 3, 2);
            cmbEmployeeID.Name = "cmbEmployeeID";
            cmbEmployeeID.Size = new Size(120, 23);
            cmbEmployeeID.TabIndex = 0;
            cmbEmployeeID.SelectedIndexChanged += cmbEmployeeID_SelectedIndexChanged;
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
            txtName.Location = new Point(239, 4);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(153, 23);
            txtName.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(btnDeleteWorkTime);
            panel2.Controls.Add(btnUpdateWorkTime);
            panel2.Controls.Add(btnAddWorkTime);
            panel2.Location = new Point(13, 109);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(721, 50);
            panel2.TabIndex = 1;
            // 
            // btnDeleteWorkTime
            // 
            btnDeleteWorkTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteWorkTime.BackColor = Color.FromArgb(42, 52, 65);
            btnDeleteWorkTime.FlatStyle = FlatStyle.Flat;
            btnDeleteWorkTime.Font = new Font("Segoe UI", 14F);
            btnDeleteWorkTime.ForeColor = Color.White;
            btnDeleteWorkTime.Location = new Point(589, 6);
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
            btnUpdateWorkTime.Location = new Point(486, 6);
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
            btnAddWorkTime.Location = new Point(381, 6);
            btnAddWorkTime.Margin = new Padding(3, 2, 3, 2);
            btnAddWorkTime.Name = "btnAddWorkTime";
            btnAddWorkTime.Size = new Size(87, 38);
            btnAddWorkTime.TabIndex = 0;
            btnAddWorkTime.Text = "Thêm";
            btnAddWorkTime.UseVisualStyleBackColor = false;
            btnAddWorkTime.Click += btnAddWorkTime_Click;
            // 
            // dgvWorkTime
            // 
            dgvWorkTime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorkTime.Location = new Point(13, 172);
            dgvWorkTime.Margin = new Padding(3, 2, 3, 2);
            dgvWorkTime.Name = "dgvWorkTime";
            dgvWorkTime.RowHeadersWidth = 51;
            dgvWorkTime.Size = new Size(704, 220);
            dgvWorkTime.TabIndex = 0;
            // 
            // errorProviderTime
            // 
            errorProviderTime.ContainerControl = this;
            // 
            // errorProviderDate
            // 
            errorProviderDate.ContainerControl = this;
            // 
            // EmployeeWorkTimeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 446);
            Controls.Add(panel1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmployeeWorkTimeForm";
            Text = "EmployeeWorkTimeForm";
            Load += EmployeeWorkTimeForm_Load_1;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvWorkTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem tệpToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private Panel panel1;
        private DataGridView dgvWorkTime;
        private Panel panel2;
        private Button btnUpdateWorkTime;
        private Button btnAddWorkTime;
        private Panel panel3;
        private Label lblEmplyeeID;
        private ComboBox cmbEmployeeID;
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
    }
}