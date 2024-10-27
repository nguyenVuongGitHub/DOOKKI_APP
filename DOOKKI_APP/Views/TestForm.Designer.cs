namespace DOOKKI_APP.Views
{
    partial class TestForm
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
            button1 = new Button();
            btnCreateAccount = new Button();
            panel1 = new Panel();
            btnAccept = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            cbEmployee = new ComboBox();
            cbRole = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            panel2 = new Panel();
            btnUpdateAccount = new Button();
            label6 = new Label();
            cbAccount = new ComboBox();
            label5 = new Label();
            cbRoles2 = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(38, 46);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Xuất bill";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(119, 46);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(100, 23);
            btnCreateAccount.TabIndex = 1;
            btnCreateAccount.Text = "Tạo tài khoản";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAccept);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(cbEmployee);
            panel1.Controls.Add(cbRole);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(235, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 241);
            panel1.TabIndex = 2;
            panel1.Visible = false;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(102, 190);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(97, 23);
            btnAccept.TabIndex = 8;
            btnAccept.Text = "Cấp tài khoản";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(98, 142);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(121, 23);
            txtPassword.TabIndex = 7;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(98, 98);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(121, 23);
            txtUserName.TabIndex = 6;
            // 
            // cbEmployee
            // 
            cbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(98, 58);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(121, 23);
            cbEmployee.TabIndex = 5;
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(98, 20);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(121, 23);
            cbRole.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 142);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 101);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 61);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 23);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Quyền truy cập";
            // 
            // button2
            // 
            button2.Location = new Point(119, 91);
            button2.Name = "button2";
            button2.Size = new Size(100, 42);
            button2.TabIndex = 3;
            button2.Text = "Sửa quyền truy cập";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnUpdateAccount);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cbAccount);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cbRoles2);
            panel2.Location = new Point(477, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 239);
            panel2.TabIndex = 4;
            panel2.Visible = false;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.Location = new Point(128, 107);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(97, 48);
            btnUpdateAccount.TabIndex = 9;
            btnUpdateAccount.Text = "Cập nhật tài khoản";
            btnUpdateAccount.UseVisualStyleBackColor = true;
            btnUpdateAccount.Click += btnUpdateAccount_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 21);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Tài khoản";
            // 
            // cbAccount
            // 
            cbAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAccount.FormattingEnabled = true;
            cbAccount.Location = new Point(114, 18);
            cbAccount.Name = "cbAccount";
            cbAccount.Size = new Size(121, 23);
            cbAccount.TabIndex = 9;
            cbAccount.SelectedIndexChanged += cbAccount_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 51);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 9;
            label5.Text = "Quyền truy cập";
            // 
            // cbRoles2
            // 
            cbRoles2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoles2.FormattingEnabled = true;
            cbRoles2.Location = new Point(114, 51);
            cbRoles2.Name = "cbRoles2";
            cbRoles2.Size = new Size(121, 23);
            cbRoles2.TabIndex = 9;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 642);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(btnCreateAccount);
            Controls.Add(button1);
            Name = "TestForm";
            Text = "TestForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnCreateAccount;
        private Panel panel1;
        private Label label1;
        private ComboBox cbEmployee;
        private ComboBox cbRole;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAccept;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button button2;
        private Panel panel2;
        private Label label6;
        private ComboBox cbAccount;
        private Label label5;
        private ComboBox cbRoles2;
        private Button btnUpdateAccount;
    }
}