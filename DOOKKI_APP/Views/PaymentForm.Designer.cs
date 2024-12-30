namespace DOOKKI_APP.Views
{
    partial class PaymentForm
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
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            ckbTotal = new CheckBox();
            cbMarks = new ComboBox();
            label6 = new Label();
            btnSearch = new Button();
            label1 = new Label();
            label5 = new Label();
            txtCustomerPhone = new TextBox();
            label4 = new Label();
            btnCreateAccount = new Button();
            ckbHadAccount = new CheckBox();
            label3 = new Label();
            btnCancel = new Button();
            btnAccept = new Button();
            rdCash = new RadioButton();
            rdCredit = new RadioButton();
            txtAmount = new TextBox();
            label2 = new Label();
            lblTotal = new Label();
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 466);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Controls.Add(ckbTotal);
            groupBox1.Controls.Add(cbMarks);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCustomerPhone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCreateAccount);
            groupBox1.Controls.Add(ckbHadAccount);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnAccept);
            groupBox1.Controls.Add(rdCash);
            groupBox1.Controls.Add(rdCredit);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.Location = new Point(38, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 427);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thanh toán";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(42, 52, 65);
            pictureBox1.Location = new Point(562, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 293);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(134, 398);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(275, 23);
            progressBar1.TabIndex = 18;
            progressBar1.Visible = false;
            // 
            // ckbTotal
            // 
            ckbTotal.AutoSize = true;
            ckbTotal.Location = new Point(406, 85);
            ckbTotal.Name = "ckbTotal";
            ckbTotal.Size = new Size(111, 29);
            ckbTotal.TabIndex = 17;
            ckbTotal.Text = "Tổng tiền";
            ckbTotal.UseVisualStyleBackColor = true;
            ckbTotal.CheckedChanged += ckbTotal_CheckedChanged;
            // 
            // cbMarks
            // 
            cbMarks.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMarks.FormattingEnabled = true;
            cbMarks.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5" });
            cbMarks.Location = new Point(317, 302);
            cbMarks.Name = "cbMarks";
            cbMarks.Size = new Size(55, 33);
            cbMarks.TabIndex = 16;
            cbMarks.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 269);
            label6.Name = "label6";
            label6.Size = new Size(188, 25);
            label6.TabIndex = 15;
            label6.Text = "Khách hàng có: điểm";
            label6.Visible = false;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.FromArgb(42, 52, 65);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(406, 218);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 37);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Visible = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 305);
            label1.Name = "label1";
            label1.Size = new Size(277, 25);
            label1.TabIndex = 13;
            label1.Text = "Khách có dùng discount không:";
            label1.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(13, 85);
            label5.Name = "label5";
            label5.Size = new Size(144, 25);
            label5.TabIndex = 12;
            label5.Text = "Tiền khách đưa:";
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new Point(212, 218);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(160, 32);
            txtCustomerPhone.TabIndex = 11;
            txtCustomerPhone.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 221);
            label4.Name = "label4";
            label4.Size = new Size(151, 25);
            label4.TabIndex = 10;
            label4.Text = "SDT khách hàng:";
            label4.Visible = false;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.AutoSize = true;
            btnCreateAccount.BackColor = Color.FromArgb(42, 52, 65);
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(336, 347);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(175, 37);
            btnCreateAccount.TabIndex = 9;
            btnCreateAccount.Text = "Tạo tài khoản mới";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // ckbHadAccount
            // 
            ckbHadAccount.AutoSize = true;
            ckbHadAccount.Location = new Point(212, 177);
            ckbHadAccount.Name = "ckbHadAccount";
            ckbHadAccount.Size = new Size(79, 29);
            ckbHadAccount.TabIndex = 8;
            ckbHadAccount.Text = "Đã có";
            ckbHadAccount.UseVisualStyleBackColor = true;
            ckbHadAccount.CheckedChanged += cbHadAccount_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 177);
            label3.Name = "label3";
            label3.Size = new Size(176, 25);
            label3.TabIndex = 7;
            label3.Text = "Khách có tài khoản:";
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.BackColor = Color.FromArgb(42, 52, 65);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(134, 347);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(91, 37);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAccept
            // 
            btnAccept.AutoSize = true;
            btnAccept.BackColor = Color.FromArgb(42, 52, 65);
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(18, 347);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(93, 37);
            btnAccept.TabIndex = 5;
            btnAccept.Text = "Xuất bill";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // rdCash
            // 
            rdCash.AutoSize = true;
            rdCash.Location = new Point(406, 133);
            rdCash.Name = "rdCash";
            rdCash.Size = new Size(103, 29);
            rdCash.TabIndex = 4;
            rdCash.TabStop = true;
            rdCash.Text = "Tiền mặt";
            rdCash.UseVisualStyleBackColor = true;
            // 
            // rdCredit
            // 
            rdCredit.AutoSize = true;
            rdCredit.Location = new Point(212, 133);
            rdCredit.Name = "rdCredit";
            rdCredit.Size = new Size(151, 29);
            rdCredit.TabIndex = 3;
            rdCredit.TabStop = true;
            rdCredit.Text = "Chuyển khoản";
            rdCredit.UseVisualStyleBackColor = true;
            rdCredit.CheckedChanged += rdCredit_CheckedChanged;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(212, 85);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(160, 32);
            txtAmount.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(13, 133);
            label2.Name = "label2";
            label2.Size = new Size(191, 25);
            label2.TabIndex = 1;
            label2.Text = "Loại hình thanh toán:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F);
            lblTotal.Location = new Point(13, 40);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(96, 25);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Tổng tiền:";
            // 
            // backgroundWorker
            // 
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 466);
            Controls.Add(panel1);
            Name = "PaymentForm";
            Text = "Payment";
            FormClosed += PaymentForm_FormClosed;
            Load += PaymentForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label2;
        private Label lblTotal;
        private RadioButton rdCash;
        private RadioButton rdCredit;
        private TextBox txtAmount;
        private Button btnCancel;
        private Button btnAccept;
        private CheckBox ckbHadAccount;
        private Label label3;
        private Button btnCreateAccount;
        private Label label4;
        private TextBox txtCustomerPhone;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private Button btnSearch;
        private Label label1;
        private ComboBox cbMarks;
        private Label label6;
        private CheckBox ckbTotal;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
    }
}