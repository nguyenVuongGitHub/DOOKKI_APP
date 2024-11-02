namespace DOOKKI_APP.Views
{
    partial class ManageProducts
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
            dgvProducts = new DataGridView();
            label1 = new Label();
            txtSearch = new TextBox();
            btnPrePage = new Button();
            btnNextPage = new Button();
            lbTotalPages = new Label();
            panel1 = new Panel();
            btnUpdate = new Button();
            btnInsert = new Button();
            dtpk_Exp = new DateTimePicker();
            cbCategory = new ComboBox();
            dtpk_Mfg = new DateTimePicker();
            txtUnitInStock = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            contextMenuStrip = new ContextMenuStrip(components);
            EditToolStripMenuItem = new ToolStripMenuItem();
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel1.SuspendLayout();
            contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(65, 312);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.Size = new Size(894, 212);
            dgvProducts.TabIndex = 0;
            dgvProducts.MouseDown += dgvProducts_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(633, 255);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(759, 252);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 32);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnPrePage
            // 
            btnPrePage.AutoSize = true;
            btnPrePage.Font = new Font("Segoe UI", 14F);
            btnPrePage.Location = new Point(65, 542);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(118, 35);
            btnPrePage.TabIndex = 3;
            btnPrePage.Text = "Trang trước";
            btnPrePage.UseVisualStyleBackColor = true;
            btnPrePage.Click += btnPrePage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.AutoSize = true;
            btnNextPage.Font = new Font("Segoe UI", 14F);
            btnNextPage.Location = new Point(203, 542);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(103, 35);
            btnNextPage.TabIndex = 4;
            btnNextPage.Text = "Trang sau";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // lbTotalPages
            // 
            lbTotalPages.AutoSize = true;
            lbTotalPages.Font = new Font("Segoe UI", 14F);
            lbTotalPages.Location = new Point(358, 547);
            lbTotalPages.Name = "lbTotalPages";
            lbTotalPages.Size = new Size(59, 25);
            lbTotalPages.TabIndex = 5;
            lbTotalPages.Text = "Trang";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnInsert);
            panel1.Controls.Add(dtpk_Exp);
            panel1.Controls.Add(cbCategory);
            panel1.Controls.Add(dtpk_Mfg);
            panel1.Controls.Add(txtUnitInStock);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(65, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 222);
            panel1.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Segoe UI", 14F);
            btnUpdate.Location = new Point(626, 174);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 35);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.AutoSize = true;
            btnInsert.Font = new Font("Segoe UI", 14F);
            btnInsert.Location = new Point(497, 174);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(88, 35);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Thêm";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // dtpk_Exp
            // 
            dtpk_Exp.Font = new Font("Segoe UI", 14F);
            dtpk_Exp.Format = DateTimePickerFormat.Custom;
            dtpk_Exp.Location = new Point(190, 174);
            dtpk_Exp.Name = "dtpk_Exp";
            dtpk_Exp.Size = new Size(220, 32);
            dtpk_Exp.TabIndex = 10;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Font = new Font("Segoe UI", 14F);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(671, 124);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(220, 33);
            cbCategory.TabIndex = 9;
            // 
            // dtpk_Mfg
            // 
            dtpk_Mfg.Font = new Font("Segoe UI", 14F);
            dtpk_Mfg.Format = DateTimePickerFormat.Custom;
            dtpk_Mfg.Location = new Point(190, 121);
            dtpk_Mfg.Name = "dtpk_Mfg";
            dtpk_Mfg.Size = new Size(220, 32);
            dtpk_Mfg.TabIndex = 8;
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Font = new Font("Segoe UI", 14F);
            txtUnitInStock.Location = new Point(671, 73);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new Size(220, 32);
            txtUnitInStock.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14F);
            txtName.Location = new Point(190, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 32);
            txtName.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(497, 128);
            label7.Name = "label7";
            label7.Size = new Size(47, 25);
            label7.TabIndex = 5;
            label7.Text = "Loại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(497, 73);
            label6.Name = "label6";
            label6.Size = new Size(174, 25);
            label6.TabIndex = 4;
            label6.Text = "Số lượng trong kho";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(38, 180);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 3;
            label5.Text = "Hạn sử dụng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(38, 127);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 2;
            label4.Text = "Ngày sản xuất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(38, 73);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 1;
            label3.Text = "Tên";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(368, 13);
            label2.Name = "label2";
            label2.Size = new Size(131, 37);
            label2.TabIndex = 0;
            label2.Text = "Kho hàng";
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { EditToolStripMenuItem, DeleteToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(123, 48);
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(122, 22);
            EditToolStripMenuItem.Text = "Cập nhật";
            EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.Size = new Size(122, 22);
            DeleteToolStripMenuItem.Text = "Xóa";
            DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 589);
            Controls.Add(panel1);
            Controls.Add(lbTotalPages);
            Controls.Add(btnNextPage);
            Controls.Add(btnPrePage);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dgvProducts);
            Name = "ManageProducts";
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Label label1;
        private TextBox txtSearch;
        private Button btnPrePage;
        private Button btnNextPage;
        private Label lbTotalPages;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label6;
        private TextBox txtName;
        private Label label7;
        private DateTimePicker dtpk_Mfg;
        private TextBox txtUnitInStock;
        private ComboBox cbCategory;
        private DateTimePicker dtpk_Exp;
        private Button btnInsert;
        private Button btnUpdate;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private ErrorProvider errorProvider;
    }
}