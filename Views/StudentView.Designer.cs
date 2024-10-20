namespace StudentCRUDDemo1.Views
{
    partial class StudentView
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
            dataGridViewStudents = new DataGridView();
            btnAdd = new Button();
            txtStudentId = new TextBox();
            txtStudentGPA = new TextBox();
            dateTimePickerBday = new DateTimePicker();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(21, 30);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.Size = new Size(370, 268);
            dataGridViewStudents.TabIndex = 0;
            dataGridViewStudents.SelectionChanged += dataGridViewStudents_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(421, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 30);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(421, 93);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.PlaceholderText = "Student Id";
            txtStudentId.Size = new Size(325, 23);
            txtStudentId.TabIndex = 2;
            // 
            // txtStudentGPA
            // 
            txtStudentGPA.Location = new Point(421, 181);
            txtStudentGPA.Name = "txtStudentGPA";
            txtStudentGPA.PlaceholderText = "Student GPA";
            txtStudentGPA.Size = new Size(325, 23);
            txtStudentGPA.TabIndex = 3;
            // 
            // dateTimePickerBday
            // 
            dateTimePickerBday.Location = new Point(421, 141);
            dateTimePickerBday.Name = "dateTimePickerBday";
            dateTimePickerBday.Size = new Size(325, 23);
            dateTimePickerBday.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(533, 30);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(106, 30);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update Student";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(645, 30);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 30);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete Student";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // StudentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 409);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dateTimePickerBday);
            Controls.Add(txtStudentGPA);
            Controls.Add(txtStudentId);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewStudents);
            Name = "StudentView";
            Text = "StudentView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewStudents;
        private Button btnAdd;
        private TextBox txtStudentId;
        private TextBox txtStudentGPA;
        private DateTimePicker dateTimePickerBday;
        private Button btnUpdate;
        private Button btnDelete;
    }
}