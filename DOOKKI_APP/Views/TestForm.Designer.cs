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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            button1 = new Button();
            btnExportSalary = new Guna.UI2.WinForms.Guna2Button();
            DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnRevenueByMonth = new Guna.UI2.WinForms.Guna2Button();
            DTPRevenue = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
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
            // btnExportSalary
            // 
            btnExportSalary.Animated = true;
            btnExportSalary.BorderRadius = 5;
            btnExportSalary.CustomizableEdges = customizableEdges1;
            btnExportSalary.DisabledState.BorderColor = Color.DarkGray;
            btnExportSalary.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExportSalary.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExportSalary.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExportSalary.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnExportSalary.ForeColor = Color.White;
            btnExportSalary.Location = new Point(38, 157);
            btnExportSalary.Name = "btnExportSalary";
            btnExportSalary.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExportSalary.Size = new Size(344, 45);
            btnExportSalary.TabIndex = 1;
            btnExportSalary.Text = "Export Salary By Month";
            btnExportSalary.Click += btnExportSalary_Click;
            // 
            // DateTimePicker
            // 
            DateTimePicker.BorderRadius = 10;
            DateTimePicker.Checked = true;
            DateTimePicker.CustomizableEdges = customizableEdges3;
            DateTimePicker.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            DateTimePicker.Format = DateTimePickerFormat.Long;
            DateTimePicker.Location = new Point(38, 89);
            DateTimePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DateTimePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.ShadowDecoration.CustomizableEdges = customizableEdges4;
            DateTimePicker.Size = new Size(344, 36);
            DateTimePicker.TabIndex = 2;
            DateTimePicker.Value = new DateTime(2024, 10, 27, 10, 42, 22, 613);
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 20;
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.Controls.Add(btnExportSalary);
            guna2Panel1.Controls.Add(DateTimePicker);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.FillColor = Color.FromArgb(255, 224, 192);
            guna2Panel1.Location = new Point(383, 90);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.ShadowDecoration.Depth = 50;
            guna2Panel1.Size = new Size(442, 239);
            guna2Panel1.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.AutoSize = false;
            guna2HtmlLabel1.AutoSizeHeightOnly = true;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 16F);
            guna2HtmlLabel1.Location = new Point(142, 23);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(155, 31);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "Salary by month";
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.BorderRadius = 20;
            guna2Panel2.Controls.Add(guna2HtmlLabel2);
            guna2Panel2.Controls.Add(btnRevenueByMonth);
            guna2Panel2.Controls.Add(DTPRevenue);
            guna2Panel2.CustomizableEdges = customizableEdges11;
            guna2Panel2.FillColor = Color.FromArgb(255, 224, 192);
            guna2Panel2.Location = new Point(76, 409);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel2.ShadowDecoration.Depth = 50;
            guna2Panel2.Size = new Size(442, 239);
            guna2Panel2.TabIndex = 4;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.AutoSize = false;
            guna2HtmlLabel2.AutoSizeHeightOnly = true;
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 16F);
            guna2HtmlLabel2.Location = new Point(130, 29);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(183, 31);
            guna2HtmlLabel2.TabIndex = 3;
            guna2HtmlLabel2.Text = "Revenue by year";
            // 
            // btnRevenueByMonth
            // 
            btnRevenueByMonth.Animated = true;
            btnRevenueByMonth.BorderRadius = 5;
            btnRevenueByMonth.CustomizableEdges = customizableEdges7;
            btnRevenueByMonth.DisabledState.BorderColor = Color.DarkGray;
            btnRevenueByMonth.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRevenueByMonth.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRevenueByMonth.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRevenueByMonth.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnRevenueByMonth.ForeColor = Color.White;
            btnRevenueByMonth.Location = new Point(56, 157);
            btnRevenueByMonth.Name = "btnRevenueByMonth";
            btnRevenueByMonth.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnRevenueByMonth.Size = new Size(326, 45);
            btnRevenueByMonth.TabIndex = 1;
            btnRevenueByMonth.Text = "Export Revenue By Year";
            btnRevenueByMonth.Click += btnRevenueByMonth_Click;
            // 
            // DTPRevenue
            // 
            DTPRevenue.BorderRadius = 10;
            DTPRevenue.Checked = true;
            DTPRevenue.CustomizableEdges = customizableEdges9;
            DTPRevenue.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            DTPRevenue.Format = DateTimePickerFormat.Long;
            DTPRevenue.Location = new Point(56, 89);
            DTPRevenue.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DTPRevenue.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DTPRevenue.Name = "DTPRevenue";
            DTPRevenue.ShadowDecoration.CustomizableEdges = customizableEdges10;
            DTPRevenue.Size = new Size(326, 36);
            DTPRevenue.TabIndex = 2;
            DTPRevenue.Value = new DateTime(2024, 10, 27, 10, 42, 22, 613);
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 743);
            Controls.Add(guna2Panel2);
            Controls.Add(guna2Panel1);
            Controls.Add(button1);
            Name = "TestForm";
            Text = "TestForm";
            guna2Panel1.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Guna.UI2.WinForms.Guna2Button btnExportSalary;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btnRevenueByMonth;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTPRevenue;
    }
}