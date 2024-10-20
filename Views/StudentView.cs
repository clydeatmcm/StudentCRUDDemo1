using StudentCRUDDemo1.Models;
using StudentCRUDDemo1.ModelViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCRUDDemo1.Views
{
    public partial class StudentView : Form
    {
        private StudentMV studentMV;

        public StudentView()
        {
            InitializeComponent();
            studentMV = new StudentMV();
            LoadData();
        }

        private void LoadData()
        {
            dataGridViewStudents.DataSource = null;
            dataGridViewStudents.DataSource = studentMV.Students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var student = new StudentModel
            {
                Student_id = txtStudentId.Text,
                Student_bday = dateTimePickerBday.Value,
                Student_gpa = float.Parse(txtStudentGPA.Text)
            };

            studentMV.AddStudent(student);
            LoadData();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewStudents.SelectedRows[0];
                var student = new StudentModel
                {
                    Student_pk = (int)selectedRow.Cells["Student_pk"].Value,
                    Student_id = txtStudentId.Text,
                    Student_bday = dateTimePickerBday.Value,
                    Student_gpa = float.Parse(txtStudentGPA.Text)
                };

                studentMV.UpdateStudent(student);
                LoadData();
                ClearFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewStudents.SelectedRows[0];
                int studentPk = (int)selectedRow.Cells["Student_pk"].Value;

                studentMV.DeleteStudent(studentPk);
                LoadData();
                ClearFields();
            }
        }

        private void dataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewStudents.SelectedRows[0];
                txtStudentId.Text = selectedRow.Cells["Student_id"].Value.ToString();
                dateTimePickerBday.Value = (DateTime)selectedRow.Cells["Student_bday"].Value;
                txtStudentGPA.Text = selectedRow.Cells["Student_gpa"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtStudentId.Clear();
            txtStudentGPA.Clear();
            dateTimePickerBday.Value = DateTime.Today;
        }
    }
}
