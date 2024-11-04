﻿namespace DOOKKI_APP.Views
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
            pnBody = new Panel();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTableListEmptyText = new Label();
            cbEmptyTable = new ComboBox();
            btnTableChange = new Button();
            btnPay = new Button();
            lblSum = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel6 = new Panel();
            lblPriceSum = new Label();
            lblQuantity = new Label();
            lblNameTicket = new Label();
            panel5 = new Panel();
            lblTable = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            xóaToolStripMenuItem = new ToolStripMenuItem();
            pnBody.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnBody
            // 
            pnBody.BackColor = Color.White;
            pnBody.Controls.Add(panel4);
            pnBody.Controls.Add(flowLayoutPanel1);
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(0, 0);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(800, 450);
            pnBody.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Controls.Add(lblTableListEmptyText);
            panel4.Controls.Add(cbEmptyTable);
            panel4.Controls.Add(btnTableChange);
            panel4.Controls.Add(btnPay);
            panel4.Controls.Add(lblSum);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(514, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(262, 437);
            panel4.TabIndex = 4;
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
            // lblTableListEmptyText
            // 
            lblTableListEmptyText.AutoSize = true;
            lblTableListEmptyText.Location = new Point(113, 408);
            lblTableListEmptyText.Name = "lblTableListEmptyText";
            lblTableListEmptyText.Size = new Size(144, 15);
            lblTableListEmptyText.TabIndex = 11;
            lblTableListEmptyText.Text = "DANH SÁCH BÀN TRỐNG";
            // 
            // cbEmptyTable
            // 
            cbEmptyTable.FormattingEnabled = true;
            cbEmptyTable.Location = new Point(140, 372);
            cbEmptyTable.Name = "cbEmptyTable";
            cbEmptyTable.Size = new Size(102, 23);
            cbEmptyTable.TabIndex = 10;
            // 
            // btnTableChange
            // 
            btnTableChange.BackColor = Color.RoyalBlue;
            btnTableChange.Cursor = Cursors.Hand;
            btnTableChange.FlatStyle = FlatStyle.Popup;
            btnTableChange.ForeColor = Color.White;
            btnTableChange.Location = new Point(11, 404);
            btnTableChange.Name = "btnTableChange";
            btnTableChange.Size = new Size(96, 23);
            btnTableChange.TabIndex = 9;
            btnTableChange.Text = "CHUYỂN BẢN";
            btnTableChange.UseVisualStyleBackColor = false;
            btnTableChange.Click += btnTableChange_Click;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.Red;
            btnPay.Cursor = Cursors.Hand;
            btnPay.FlatStyle = FlatStyle.Popup;
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(11, 375);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(96, 23);
            btnPay.TabIndex = 8;
            btnPay.Text = "THANH TOÁN";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Location = new Point(171, 354);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(40, 15);
            lblSum.TabIndex = 7;
            lblSum.Text = "0 VND";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 354);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 6;
            label4.Text = "Tổng";
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
            // label2
            // 
            label2.BackColor = Color.FromArgb(100, 128, 128, 128);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(11, 124);
            label2.Name = "label2";
            label2.Size = new Size(231, 1);
            label2.TabIndex = 4;
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
            // panel5
            // 
            panel5.Controls.Add(lblTable);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(11, 13);
            panel5.Name = "panel5";
            panel5.Size = new Size(231, 59);
            panel5.TabIndex = 1;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(17, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(491, 437);
            flowLayoutPanel1.TabIndex = 2;
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
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnBody);
            Name = "TableForm";
            Text = "TableForm";
            pnBody.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnBody;
        private Panel panel4;
        private Label lblTableListEmptyText;
        private ComboBox cbEmptyTable;
        private Button btnTableChange;
        private Button btnPay;
        private Label lblSum;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel6;
        private Label lblPriceSum;
        private Label lblQuantity;
        private Label lblNameTicket;
        private Panel panel5;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTable;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private ToolStripMenuItem xóaToolStripMenuItem;
    }
}