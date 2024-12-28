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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvProducts = new DataGridView();
            label1 = new Label();
            txtSearch = new TextBox();
            btnPrePage = new Button();
            btnNextPage = new Button();
            lbTotalPages = new Label();
            panel1 = new Panel();
            btnUpdate = new Guna.UI2.WinForms.Guna2Button();
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
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            cbNumberOfPages = new ComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel1.SuspendLayout();
            contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.Location = new Point(10, 48);
            dgvProducts.Margin = new Padding(10);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(977, 275);
            dgvProducts.TabIndex = 0;
            dgvProducts.MouseDown += dgvProducts_MouseDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(691, 6);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(785, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 32);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // btnPrePage
            // 
            btnPrePage.AutoSize = true;
            btnPrePage.BackColor = Color.FromArgb(42, 52, 65);
            btnPrePage.FlatStyle = FlatStyle.Flat;
            btnPrePage.Font = new Font("Segoe UI", 14F);
            btnPrePage.ForeColor = Color.White;
            btnPrePage.Location = new Point(14, 3);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(120, 37);
            btnPrePage.TabIndex = 3;
            btnPrePage.Text = "Trang trước";
            btnPrePage.UseVisualStyleBackColor = false;
            btnPrePage.Click += btnPrePage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.AutoSize = true;
            btnNextPage.BackColor = Color.FromArgb(42, 52, 65);
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Font = new Font("Segoe UI", 14F);
            btnNextPage.ForeColor = Color.White;
            btnNextPage.Location = new Point(152, 3);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(105, 37);
            btnNextPage.TabIndex = 4;
            btnNextPage.Text = "Trang sau";
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // lbTotalPages
            // 
            lbTotalPages.Anchor = AnchorStyles.None;
            lbTotalPages.AutoSize = true;
            lbTotalPages.Font = new Font("Segoe UI", 14F);
            lbTotalPages.Location = new Point(785, 9);
            lbTotalPages.Name = "lbTotalPages";
            lbTotalPages.Size = new Size(59, 25);
            lbTotalPages.TabIndex = 5;
            lbTotalPages.Text = "Trang";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
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
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 222);
            panel1.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(42, 52, 65);
            btnUpdate.CustomizableEdges = customizableEdges1;
            btnUpdate.DisabledState.BorderColor = Color.DarkGray;
            btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdate.Enabled = false;
            btnUpdate.FillColor = Color.FromArgb(42, 52, 65);
            btnUpdate.Font = new Font("Segoe UI", 14F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(655, 174);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnUpdate.Size = new Size(110, 37);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.AutoSize = true;
            btnInsert.BackColor = Color.FromArgb(42, 52, 65);
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Segoe UI", 14F);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(546, 174);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(88, 37);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Thêm";
            btnInsert.UseVisualStyleBackColor = false;
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
            cbCategory.Location = new Point(720, 124);
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
            txtUnitInStock.Location = new Point(720, 73);
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
            label7.Location = new Point(546, 128);
            label7.Name = "label7";
            label7.Size = new Size(47, 25);
            label7.TabIndex = 5;
            label7.Text = "Loại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(546, 73);
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
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(997, 37);
            label2.TabIndex = 0;
            label2.Text = "Kho hàng";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgvProducts);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 222);
            panel2.Name = "panel2";
            panel2.Size = new Size(997, 367);
            panel2.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(997, 41);
            panel4.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(cbNumberOfPages);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(btnNextPage);
            panel3.Controls.Add(btnPrePage);
            panel3.Controls.Add(lbTotalPages);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 325);
            panel3.Name = "panel3";
            panel3.Size = new Size(997, 42);
            panel3.TabIndex = 6;
            // 
            // cbNumberOfPages
            // 
            cbNumberOfPages.Anchor = AnchorStyles.None;
            cbNumberOfPages.BackColor = Color.FromArgb(42, 52, 65);
            cbNumberOfPages.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNumberOfPages.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbNumberOfPages.ForeColor = Color.White;
            cbNumberOfPages.FormattingEnabled = true;
            cbNumberOfPages.Location = new Point(362, 6);
            cbNumberOfPages.Name = "cbNumberOfPages";
            cbNumberOfPages.Size = new Size(121, 33);
            cbNumberOfPages.TabIndex = 6;
            cbNumberOfPages.SelectedIndexChanged += cbNumberOfPages_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(273, 9);
            label8.Name = "label8";
            label8.Size = new Size(83, 25);
            label8.TabIndex = 3;
            label8.Text = "Số trang";
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 589);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManageProducts";
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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
        private Button cn;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private ErrorProvider errorProvider;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Label label8;
        private ComboBox cbNumberOfPages;
    }
}