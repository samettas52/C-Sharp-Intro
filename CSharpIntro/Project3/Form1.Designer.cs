namespace Project3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgrwCustomers = new DataGridView();
            tbxId = new TextBox();
            tbxFirstName = new TextBox();
            tbxLastName = new TextBox();
            tbxEmail = new TextBox();
            tbxCity = new TextBox();
            lblId = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            lblCity = new Label();
            btnAdd = new Button();
            gbxAdd = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgrwCustomers).BeginInit();
            gbxAdd.SuspendLayout();
            SuspendLayout();
            // 
            // dgrwCustomers
            // 
            dgrwCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrwCustomers.Dock = DockStyle.Top;
            dgrwCustomers.Location = new Point(0, 0);
            dgrwCustomers.Name = "dgrwCustomers";
            dgrwCustomers.RowHeadersWidth = 51;
            dgrwCustomers.Size = new Size(971, 255);
            dgrwCustomers.TabIndex = 0;
            // 
            // tbxId
            // 
            tbxId.Font = new Font("Segoe UI", 12F);
            tbxId.Location = new Point(117, 35);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(223, 34);
            tbxId.TabIndex = 1;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Font = new Font("Segoe UI", 12F);
            tbxFirstName.Location = new Point(117, 75);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(223, 34);
            tbxFirstName.TabIndex = 2;
            // 
            // tbxLastName
            // 
            tbxLastName.Font = new Font("Segoe UI", 12F);
            tbxLastName.Location = new Point(117, 113);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(223, 34);
            tbxLastName.TabIndex = 3;
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Segoe UI", 12F);
            tbxEmail.Location = new Point(117, 153);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(223, 34);
            tbxEmail.TabIndex = 4;
            // 
            // tbxCity
            // 
            tbxCity.Font = new Font("Segoe UI", 12F);
            tbxCity.Location = new Point(117, 193);
            tbxCity.Name = "tbxCity";
            tbxCity.Size = new Size(223, 34);
            tbxCity.TabIndex = 5;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F);
            lblId.Location = new Point(12, 41);
            lblId.Name = "lblId";
            lblId.Size = new Size(29, 28);
            lblId.TabIndex = 6;
            lblId.Text = "Id";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F);
            lblFirstName.Location = new Point(12, 81);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 28);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F);
            lblLastName.Location = new Point(12, 119);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(89, 28);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "Surname";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(12, 159);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 28);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 12F);
            lblCity.Location = new Point(12, 199);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(46, 28);
            lblCity.TabIndex = 10;
            lblCity.Text = "City";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlDark;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(244, 243);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 47);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbxAdd
            // 
            gbxAdd.Controls.Add(tbxFirstName);
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(tbxId);
            gbxAdd.Controls.Add(lblCity);
            gbxAdd.Controls.Add(tbxLastName);
            gbxAdd.Controls.Add(lblEmail);
            gbxAdd.Controls.Add(tbxEmail);
            gbxAdd.Controls.Add(lblLastName);
            gbxAdd.Controls.Add(tbxCity);
            gbxAdd.Controls.Add(lblFirstName);
            gbxAdd.Controls.Add(lblId);
            gbxAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            gbxAdd.Location = new Point(0, 261);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(396, 328);
            gbxAdd.TabIndex = 12;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "Add";
            gbxAdd.Enter += gbxAdd_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 642);
            Controls.Add(gbxAdd);
            Controls.Add(dgrwCustomers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgrwCustomers).EndInit();
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgrwCustomers;
        private TextBox tbxId;
        private TextBox tbxFirstName;
        private TextBox tbxLastName;
        private TextBox tbxEmail;
        private TextBox tbxCity;
        private Label lblId;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblCity;
        private Button btnAdd;
        private GroupBox gbxAdd;
    }
}
