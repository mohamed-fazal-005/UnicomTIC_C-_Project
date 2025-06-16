using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTIC_WindowsForm_By_Fazal.Data;
using UTIC_WindowsForm_By_Fazal.Model;

namespace UTIC_WindowsForm_By_Fazal.Controller
{
    internal class StudentController
    {
        public static List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Students";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            StudentID = Convert.ToInt32(reader["StudentID"]),
                            Name = reader["Name"].ToString(),
                            Age = Convert.ToInt32(reader["Age"]),
                            Address = reader["Address"].ToString(),
                            CourseID = Convert.ToInt32(reader["CourseID"])
                        });
                    }
                }
            }

            return students;
        }

        public static void AddStudent(string name, int age, string address, int courseId)
        {
            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Students (Name, Age, Address, CourseID) VALUES (@n, @a, @ad, @c)";
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@a", age);
                cmd.Parameters.AddWithValue("@ad", address);
                cmd.Parameters.AddWithValue("@c", courseId);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateStudent(int id, string name, int age, string address, int courseId)
        {
            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "UPDATE Students SET Name = @n, Age = @a, Address = @ad, CourseID = @c WHERE StudentID = @id";
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@a", age);
                cmd.Parameters.AddWithValue("@ad", address);
                cmd.Parameters.AddWithValue("@c", courseId);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteStudent(int id)
        {
            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Students WHERE StudentID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

