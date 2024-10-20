using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using StudentCRUDDemo1.Models;

namespace StudentCRUDDemo1.ModelViews
{
    internal class StudentMV
    {

        private string connectionString;
        public List<StudentModel> Students { get; set; } = new List<StudentModel>();

        public StudentMV()
        {
            // Assuming the connection string is stored in App.config
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LoadStudents();
        }

        // Add methods for Create, Read, Update, Delete
        public void AddStudent(StudentModel student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Student (Student_id, Student_bday, Student_gpa) VALUES (@Student_id, @Student_bday, @Student_gpa);";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Student_id", student.Student_id);
                command.Parameters.AddWithValue("@Student_bday", student.Student_bday);
                command.Parameters.AddWithValue("@Student_gpa", student.Student_gpa);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                LoadStudents(); // Refresh the list after adding
            }
        }
        public void UpdateStudent(StudentModel student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Student SET Student_id = @Student_id, Student_bday = @Student_bday, Student_gpa = @Student_gpa WHERE Student_pk = @Student_pk;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Student_id", student.Student_id);
                command.Parameters.AddWithValue("@Student_bday", student.Student_bday);
                command.Parameters.AddWithValue("@Student_gpa", student.Student_gpa);
                command.Parameters.AddWithValue("@Student_pk", student.Student_pk);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                LoadStudents(); // Refresh the list after updating
            }
        }
        public void DeleteStudent(int studentPk)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Student WHERE Student_pk = @Student_pk;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Student_pk", studentPk);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                LoadStudents(); // Refresh the list after deleting
            }
        }
        public void LoadStudents()
        {
            Students.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Student_pk, Student_id, Student_bday, Student_gpa FROM Student;";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    StudentModel student = new StudentModel
                    {
                        Student_pk = reader.GetInt32(0),
                        Student_id = reader.GetString(1),
                        Student_bday = reader.GetDateTime(2),
                        Student_gpa = (float)reader.GetDouble(3),
                    };
                    Students.Add(student);
                }
                connection.Close();
            }
        }
    }
}
