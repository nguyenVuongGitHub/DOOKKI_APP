namespace DOOKKI_APP.Views
{
    partial class TableFoodForm
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
            panel2 = new Panel();
            panel3 = new Panel();
            txtTotalPrice = new TextBox();
            btnSwitchTable = new Button();
            btnCharge = new Button();
            cbEmptyTable = new ComboBox();
            lsvOrder = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            xóaToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            nmProductQuantity = new NumericUpDown();
            btnAddOrder = new Button();
            cbTicket = new ComboBox();
            cbCategory = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmProductQuantity).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lsvOrder);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(626, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 702);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTotalPrice);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(btnCharge);
            panel3.Controls.Add(cbEmptyTable);
            panel3.Dock = DockStyle.Bottom;
            panel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel3.Location = new Point(0, 572);
            panel3.Name = "panel3";
            panel3.Size = new Size(340, 130);
            panel3.TabIndex = 2;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.BackColor = Color.WhiteSmoke;
            txtTotalPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalPrice.Location = new Point(122, 44);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(110, 23);
            txtTotalPrice.TabIndex = 16;
            txtTotalPrice.Text = "0";
            txtTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.Anchor = AnchorStyles.Bottom;
            btnSwitchTable.BackColor = Color.FromArgb(42, 52, 65);
            btnSwitchTable.FlatStyle = FlatStyle.Flat;
            btnSwitchTable.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSwitchTable.ForeColor = Color.White;
            btnSwitchTable.Location = new Point(16, 20);
            btnSwitchTable.Margin = new Padding(3, 2, 3, 2);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(87, 27);
            btnSwitchTable.TabIndex = 15;
            btnSwitchTable.Text = "Chuyển bàn";
            btnSwitchTable.UseVisualStyleBackColor = false;
            btnSwitchTable.Click += btnSwitchTable_Click;
            // 
            // btnCharge
            // 
            btnCharge.Anchor = AnchorStyles.Bottom;
            btnCharge.BackColor = Color.FromArgb(42, 52, 65);
            btnCharge.FlatStyle = FlatStyle.Flat;
            btnCharge.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCharge.ForeColor = Color.White;
            btnCharge.Location = new Point(248, 29);
            btnCharge.Margin = new Padding(3, 2, 3, 2);
            btnCharge.Name = "btnCharge";
            btnCharge.Size = new Size(80, 51);
            btnCharge.TabIndex = 14;
            btnCharge.Text = "Thanh toán";
            btnCharge.UseVisualStyleBackColor = false;
            btnCharge.Click += btnCharge_Click;
            // 
            // cbEmptyTable
            // 
            cbEmptyTable.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbEmptyTable.FormattingEnabled = true;
            cbEmptyTable.Location = new Point(16, 72);
            cbEmptyTable.Name = "cbEmptyTable";
            cbEmptyTable.Size = new Size(87, 25);
            cbEmptyTable.TabIndex = 10;
            // 
            // lsvOrder
            // 
            lsvOrder.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvOrder.ContextMenuStrip = contextMenuStrip1;
            lsvOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lsvOrder.FullRowSelect = true;
            lsvOrder.GridLines = true;
            lsvOrder.Location = new Point(6, 112);
            lsvOrder.MultiSelect = false;
            lsvOrder.Name = "lsvOrder";
            lsvOrder.Size = new Size(331, 454);
            lsvOrder.TabIndex = 1;
            lsvOrder.UseCompatibleStateImageBehavior = false;
            lsvOrder.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 90;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { xóaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(95, 26);
            contextMenuStrip1.ItemClicked += contextMenuStrip1_ItemClicked;
            // 
            // xóaToolStripMenuItem
            // 
            xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            xóaToolStripMenuItem.Size = new Size(94, 22);
            xóaToolStripMenuItem.Text = "Xóa";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(nmProductQuantity);
            panel1.Controls.Add(btnAddOrder);
            panel1.Controls.Add(cbTicket);
            panel1.Controls.Add(cbCategory);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 100);
            panel1.TabIndex = 0;
            // 
            // nmProductQuantity
            // 
            nmProductQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nmProductQuantity.Location = new Point(146, 22);
            nmProductQuantity.Name = "nmProductQuantity";
            nmProductQuantity.Size = new Size(44, 25);
            nmProductQuantity.TabIndex = 18;
            nmProductQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddOrder
            // 
            btnAddOrder.Anchor = AnchorStyles.Bottom;
            btnAddOrder.BackColor = Color.FromArgb(42, 52, 65);
            btnAddOrder.FlatStyle = FlatStyle.Flat;
            btnAddOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddOrder.ForeColor = Color.White;
            btnAddOrder.Location = new Point(227, 21);
            btnAddOrder.Margin = new Padding(3, 2, 3, 2);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(80, 51);
            btnAddOrder.TabIndex = 17;
            btnAddOrder.Text = "Thêm món";
            btnAddOrder.UseVisualStyleBackColor = false;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // cbTicket
            // 
            cbTicket.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTicket.FormattingEnabled = true;
            cbTicket.Location = new Point(13, 61);
            cbTicket.Name = "cbTicket";
            cbTicket.Size = new Size(177, 25);
            cbTicket.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(13, 21);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(121, 25);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.WhiteSmoke;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(626, 702);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // TableFoodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 702);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Name = "TableFoodForm";
            Text = "TableFoodForm";
            Load += TableFoodForm_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmProductQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private ListView lsvOrder;
        private Panel panel3;
        private ComboBox cbEmptyTable;
        private Button btnCharge;
        private Button btnSwitchTable;
        private TextBox txtTotalPrice;
        private NumericUpDown nmProductQuantity;
        private Button btnAddOrder;
        private ComboBox cbTicket;
        private ComboBox cbCategory;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem xóaToolStripMenuItem;
    }
}