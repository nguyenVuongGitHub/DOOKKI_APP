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
            menuStrip.Size = new Size(874, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem });
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(48, 24);
            tệpToolStripMenuItem.Text = "Tệp";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(224, 26);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(224, 26);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvWorkTime);
            panel1.Location = new Point(12, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 537);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(15, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(824, 114);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(dateTimePicker);
            panel5.Controls.Add(txtTimeWork);
            panel5.Controls.Add(lblTimeWork);
            panel5.Location = new Point(509, 13);
            panel5.Name = "panel5";
            panel5.Size = new Size(304, 85);
            panel5.TabIndex = 9;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(14, 52);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 2;
            // 
            // txtTimeWork
            // 
            txtTimeWork.Location = new Point(103, 5);
            txtTimeWork.Name = "txtTimeWork";
            txtTimeWork.Size = new Size(161, 27);
            txtTimeWork.TabIndex = 1;
            // 
            // lblTimeWork
            // 
            lblTimeWork.AutoSize = true;
            lblTimeWork.Location = new Point(14, 8);
            lblTimeWork.Name = "lblTimeWork";
            lblTimeWork.Size = new Size(83, 20);
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
            panel4.Location = new Point(22, 13);
            panel4.Name = "panel4";
            panel4.Size = new Size(459, 85);
            panel4.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(274, 54);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(174, 27);
            txtPhone.TabIndex = 5;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(88, 50);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(100, 27);
            txtPosition.TabIndex = 7;
            // 
            // lblEmployeePhone
            // 
            lblEmployeePhone.AutoSize = true;
            lblEmployeePhone.Location = new Point(215, 57);
            lblEmployeePhone.Name = "lblEmployeePhone";
            lblEmployeePhone.Size = new Size(53, 20);
            lblEmployeePhone.TabIndex = 4;
            lblEmployeePhone.Text = "Phone:";
            // 
            // lblEmplyeeID
            // 
            lblEmplyeeID.AutoSize = true;
            lblEmplyeeID.Location = new Point(18, 8);
            lblEmplyeeID.Name = "lblEmplyeeID";
            lblEmplyeeID.Size = new Size(27, 20);
            lblEmplyeeID.TabIndex = 1;
            lblEmplyeeID.Text = "ID:";
            // 
            // lblEmployeePosition
            // 
            lblEmployeePosition.AutoSize = true;
            lblEmployeePosition.Location = new Point(18, 57);
            lblEmployeePosition.Name = "lblEmployeePosition";
            lblEmployeePosition.Size = new Size(64, 20);
            lblEmployeePosition.TabIndex = 6;
            lblEmployeePosition.Text = "Position:";
            lblEmployeePosition.Click += label1_Click;
            // 
            // cmbEmployeeID
            // 
            cmbEmployeeID.FormattingEnabled = true;
            cmbEmployeeID.Location = new Point(51, 5);
            cmbEmployeeID.Name = "cmbEmployeeID";
            cmbEmployeeID.Size = new Size(137, 28);
            cmbEmployeeID.TabIndex = 0;
            cmbEmployeeID.SelectedIndexChanged += cmbEmployeeID_SelectedIndexChanged;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Location = new Point(215, 8);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(52, 20);
            lblEmployeeName.TabIndex = 2;
            lblEmployeeName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(273, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(174, 27);
            txtName.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDeleteWorkTime);
            panel2.Controls.Add(btnUpdateWorkTime);
            panel2.Controls.Add(btnAddWorkTime);
            panel2.Location = new Point(15, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(824, 67);
            panel2.TabIndex = 1;
            // 
            // btnDeleteWorkTime
            // 
            btnDeleteWorkTime.Location = new Point(674, 13);
            btnDeleteWorkTime.Name = "btnDeleteWorkTime";
            btnDeleteWorkTime.Size = new Size(99, 40);
            btnDeleteWorkTime.TabIndex = 2;
            btnDeleteWorkTime.Text = "Xóa";
            btnDeleteWorkTime.UseVisualStyleBackColor = true;
            btnDeleteWorkTime.Click += btnDeleteWorkTime_Click;
            // 
            // btnUpdateWorkTime
            // 
            btnUpdateWorkTime.Location = new Point(557, 13);
            btnUpdateWorkTime.Name = "btnUpdateWorkTime";
            btnUpdateWorkTime.Size = new Size(99, 40);
            btnUpdateWorkTime.TabIndex = 1;
            btnUpdateWorkTime.Text = "Sữa";
            btnUpdateWorkTime.UseVisualStyleBackColor = true;
            btnUpdateWorkTime.Click += btnUpdateWorkTime_Click;
            // 
            // btnAddWorkTime
            // 
            btnAddWorkTime.Location = new Point(426, 13);
            btnAddWorkTime.Name = "btnAddWorkTime";
            btnAddWorkTime.Size = new Size(99, 40);
            btnAddWorkTime.TabIndex = 0;
            btnAddWorkTime.Text = "Thêm";
            btnAddWorkTime.UseVisualStyleBackColor = true;
            btnAddWorkTime.Click += btnAddWorkTime_Click;
            // 
            // dgvWorkTime
            // 
            dgvWorkTime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorkTime.Location = new Point(15, 229);
            dgvWorkTime.Name = "dgvWorkTime";
            dgvWorkTime.RowHeadersWidth = 51;
            dgvWorkTime.Size = new Size(804, 293);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 595);
            Controls.Add(panel1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
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