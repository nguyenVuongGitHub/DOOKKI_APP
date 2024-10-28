namespace DOOKKI_APP.Views
{
    partial class MenuForm
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
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnBooking = new Button();
            btnDeleteAll = new Button();
            lblSum = new Label();
            label1 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            txtDate = new TextBox();
            lblTitleText = new Label();
            dgvTicket = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTicket).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvTicket);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 450);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.icons8_login_50;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(36, 40);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(btnBooking);
            panel2.Controls.Add(btnDeleteAll);
            panel2.Controls.Add(lblSum);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(476, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 435);
            panel2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(4, 107);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(277, 262);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // btnBooking
            // 
            btnBooking.BackColor = Color.RoyalBlue;
            btnBooking.Cursor = Cursors.Hand;
            btnBooking.FlatStyle = FlatStyle.Popup;
            btnBooking.ForeColor = Color.White;
            btnBooking.Location = new Point(158, 403);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(89, 23);
            btnBooking.TabIndex = 10;
            btnBooking.Text = "Đặt";
            btnBooking.UseVisualStyleBackColor = false;
            btnBooking.Click += btnBooking_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.RoyalBlue;
            btnDeleteAll.Cursor = Cursors.Hand;
            btnDeleteAll.FlatStyle = FlatStyle.Popup;
            btnDeleteAll.ForeColor = Color.White;
            btnDeleteAll.Location = new Point(20, 403);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(103, 23);
            btnDeleteAll.TabIndex = 9;
            btnDeleteAll.Text = "Xóa chọn tất cả";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Location = new Point(206, 379);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(40, 15);
            lblSum.TabIndex = 8;
            lblSum.Text = "0 VND";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 379);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 7;
            label1.Text = "Tổng";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(100, 128, 128, 128);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(4, 372);
            label3.Name = "label3";
            label3.Size = new Size(270, 1);
            label3.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RoyalBlue;
            panel3.Controls.Add(txtDate);
            panel3.Controls.Add(lblTitleText);
            panel3.Location = new Point(3, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 81);
            panel3.TabIndex = 0;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.RoyalBlue;
            txtDate.BorderStyle = BorderStyle.None;
            txtDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDate.ForeColor = Color.White;
            txtDate.Location = new Point(132, 26);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(139, 16);
            txtDate.TabIndex = 1;
            // 
            // lblTitleText
            // 
            lblTitleText.AutoSize = true;
            lblTitleText.ForeColor = Color.White;
            lblTitleText.Location = new Point(17, 26);
            lblTitleText.Name = "lblTitleText";
            lblTitleText.Size = new Size(64, 15);
            lblTitleText.TabIndex = 0;
            lblTitleText.Text = "New Order";
            // 
            // dgvTicket
            // 
            dgvTicket.AllowUserToAddRows = false;
            dgvTicket.AllowUserToDeleteRows = false;
            dgvTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTicket.BackgroundColor = Color.White;
            dgvTicket.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTicket.Location = new Point(12, 58);
            dgvTicket.Name = "dgvTicket";
            dgvTicket.RowHeadersWidth = 51;
            dgvTicket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTicket.Size = new Size(427, 341);
            dgvTicket.TabIndex = 0;
            dgvTicket.CellClick += dgvTicket_CellClick;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuForm";
            Text = "MenuForm";
            Load += MenuForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTicket).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvTicket;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnBooking;
        private Button btnDeleteAll;
        private Label lblSum;
        private Label label1;
        private Label label3;
        private Panel panel3;
        private TextBox txtDate;
        private Label lblTitleText;
        private Button button1;
    }
}