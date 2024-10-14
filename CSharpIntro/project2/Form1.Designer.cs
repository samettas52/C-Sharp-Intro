namespace project2
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
            lbxStudentList = new ListBox();
            lblStudentList = new Label();
            lblStudentName = new Label();
            tbxStudentName = new TextBox();
            btnAddStudent = new Button();
            btnRemoveStudent = new Button();
            SuspendLayout();
            // 
            // lbxStudentList
            // 
            lbxStudentList.Font = new Font("Segoe UI", 12F);
            lbxStudentList.FormattingEnabled = true;
            lbxStudentList.ItemHeight = 28;
            lbxStudentList.Location = new Point(41, 114);
            lbxStudentList.Name = "lbxStudentList";
            lbxStudentList.Size = new Size(268, 228);
            lbxStudentList.TabIndex = 0;
            // 
            // lblStudentList
            // 
            lblStudentList.AutoSize = true;
            lblStudentList.Font = new Font("Segoe UI", 12F);
            lblStudentList.Location = new Point(41, 73);
            lblStudentList.Name = "lblStudentList";
            lblStudentList.Size = new Size(138, 28);
            lblStudentList.TabIndex = 1;
            lblStudentList.Text = "Öğrenci Listesi";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.BackColor = SystemColors.Control;
            lblStudentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblStudentName.Location = new Point(378, 120);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(116, 28);
            lblStudentName.TabIndex = 2;
            lblStudentName.Text = "Öğrenci Adı";
            // 
            // tbxStudentName
            // 
            tbxStudentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbxStudentName.Location = new Point(532, 114);
            tbxStudentName.Name = "tbxStudentName";
            tbxStudentName.Size = new Size(398, 34);
            tbxStudentName.TabIndex = 3;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = SystemColors.ActiveBorder;
            btnAddStudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAddStudent.Location = new Point(836, 181);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(94, 39);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "Ekle";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.BackColor = SystemColors.ActiveBorder;
            btnRemoveStudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnRemoveStudent.Location = new Point(41, 362);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new Size(268, 44);
            btnRemoveStudent.TabIndex = 5;
            btnRemoveStudent.Text = " Sil";
            btnRemoveStudent.UseVisualStyleBackColor = false;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 450);
            Controls.Add(btnRemoveStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(tbxStudentName);
            Controls.Add(lblStudentName);
            Controls.Add(lblStudentList);
            Controls.Add(lbxStudentList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxStudentList;
        private Label lblStudentList;
        private Label lblStudentName;
        private TextBox tbxStudentName;
        private Button btnAddStudent;
        private Button btnRemoveStudent;
    }
}
