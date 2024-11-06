namespace DOOKKI_APP.Views
{
    partial class TableForm
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            xóaToolStripMenuItem = new ToolStripMenuItem();
            panel4 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            lblTable = new Label();
            panel6 = new Panel();
            lblNameTicket = new Label();
            lblQuantity = new Label();
            lblPriceSum = new Label();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            cbEmptyTable = new ComboBox();
            btnPay = new Button();
            lblTableListEmptyText = new Label();
            btnTableChange = new Button();
            lblSum = new Label();
            label4 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            contextMenuStrip1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { cậpNhậtToolStripMenuItem, xóaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(123, 48);
            // 
            // cậpNhậtToolStripMenuItem
            // 
            cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            cậpNhậtToolStripMenuItem.Size = new Size(122, 22);
            cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            cậpNhậtToolStripMenuItem.Click += cậpNhậtToolStripMenuItem_Click;
            // 
            // xóaToolStripMenuItem
            // 
            xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            xóaToolStripMenuItem.Size = new Size(122, 22);
            xóaToolStripMenuItem.Text = "Xóa";
            xóaToolStripMenuItem.Click += xóaToolStripMenuItem_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(704, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(262, 702);
            panel4.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblTable);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(11, 13);
            panel5.Name = "panel5";
            panel5.Size = new Size(231, 59);
            panel5.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.Red;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(231, 59);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTable
            // 
            lblTable.BackColor = Color.Red;
            lblTable.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTable.ForeColor = Color.White;
            lblTable.Location = new Point(54, 8);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(136, 36);
            lblTable.TabIndex = 1;
            lblTable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblPriceSum);
            panel6.Controls.Add(lblQuantity);
            panel6.Controls.Add(lblNameTicket);
            panel6.Location = new Point(11, 80);
            panel6.Name = "panel6";
            panel6.Size = new Size(231, 40);
            panel6.TabIndex = 3;
            // 
            // lblNameTicket
            // 
            lblNameTicket.AutoSize = true;
            lblNameTicket.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameTicket.Location = new Point(19, 13);
            lblNameTicket.Name = "lblNameTicket";
            lblNameTicket.Size = new Size(39, 12);
            lblNameTicket.TabIndex = 0;
            lblNameTicket.Text = "Tên món";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(111, 13);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(39, 12);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Số lượng";
            // 
            // lblPriceSum
            // 
            lblPriceSum.AutoSize = true;
            lblPriceSum.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPriceSum.Location = new Point(170, 13);
            lblPriceSum.Name = "lblPriceSum";
            lblPriceSum.Size = new Size(47, 12);
            lblPriceSum.TabIndex = 2;
            lblPriceSum.Text = "Thành tiền";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(100, 128, 128, 128);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(11, 124);
            label2.Name = "label2";
            label2.Size = new Size(231, 1);
            label2.TabIndex = 4;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(100, 128, 128, 128);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(11, 341);
            label3.Name = "label3";
            label3.Size = new Size(231, 1);
            label3.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AllowDrop = true;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.5625F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.4375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.Location = new Point(11, 128);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(246, 210);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblSum);
            panel1.Controls.Add(btnTableChange);
            panel1.Controls.Add(lblTableListEmptyText);
            panel1.Controls.Add(btnPay);
            panel1.Controls.Add(cbEmptyTable);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 609);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 93);
            panel1.TabIndex = 0;
            // 
            // cbEmptyTable
            // 
            cbEmptyTable.FormattingEnabled = true;
            cbEmptyTable.Location = new Point(129, 38);
            cbEmptyTable.Name = "cbEmptyTable";
            cbEmptyTable.Size = new Size(102, 23);
            cbEmptyTable.TabIndex = 10;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.Red;
            btnPay.Cursor = Cursors.Hand;
            btnPay.FlatStyle = FlatStyle.Popup;
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(3, 38);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(96, 23);
            btnPay.TabIndex = 8;
            btnPay.Text = "THANH TOÁN";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // lblTableListEmptyText
            // 
            lblTableListEmptyText.AutoSize = true;
            lblTableListEmptyText.Location = new Point(113, 71);
            lblTableListEmptyText.Name = "lblTableListEmptyText";
            lblTableListEmptyText.Size = new Size(144, 15);
            lblTableListEmptyText.TabIndex = 11;
            lblTableListEmptyText.Text = "DANH SÁCH BÀN TRỐNG";
            // 
            // btnTableChange
            // 
            btnTableChange.BackColor = Color.RoyalBlue;
            btnTableChange.Cursor = Cursors.Hand;
            btnTableChange.FlatStyle = FlatStyle.Popup;
            btnTableChange.ForeColor = Color.White;
            btnTableChange.Location = new Point(3, 67);
            btnTableChange.Name = "btnTableChange";
            btnTableChange.Size = new Size(96, 23);
            btnTableChange.TabIndex = 9;
            btnTableChange.Text = "CHUYỂN BẢN";
            btnTableChange.UseVisualStyleBackColor = false;
            btnTableChange.Click += btnTableChange_Click;
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Location = new Point(191, 9);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(40, 15);
            lblSum.TabIndex = 7;
            lblSum.Text = "0 VND";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 9);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 6;
            label4.Text = "Tổng";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(704, 702);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 702);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel4);
            Name = "TableForm";
            Text = "TableForm";
            contextMenuStrip1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private ToolStripMenuItem xóaToolStripMenuItem;
        private Panel panel4;
        private Panel panel1;
        private Label label4;
        private Label lblSum;
        private Button btnTableChange;
        private Label lblTableListEmptyText;
        private Button btnPay;
        private ComboBox cbEmptyTable;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label2;
        private Panel panel6;
        private Label lblPriceSum;
        private Label lblQuantity;
        private Label lblNameTicket;
        private Panel panel5;
        private Label lblTable;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}