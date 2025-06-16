using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTIC_WindowsForm_By_Fazal.Data;
using UTIC_WindowsForm_By_Fazal.Model;

namespace UTIC_WindowsForm_By_Fazal.Controller
{
    internal class SubjectController
    {
            public static List<Subject> GetAllSubjects()
            {
                List<Subject> subjects = new List<Subject>();

                using (var cmd = DataCon.GetConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Subjects";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subjects.Add(new Subject
                            {
                                SubjectID = Convert.ToInt32(reader["SubjectID"]),
                                SubjectName = reader["SubjectName"].ToString(),
                                CourseID = Convert.ToInt32(reader["CourseID"])
                            });
                        }
                    }
                }

                return subjects;
            }

            public static void AddSubject(string name, int courseId)
            {
                using (var cmd = DataCon.GetConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Subjects (SubjectName, CourseID) VALUES (@name, @courseId)";
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@courseId", courseId);
                    cmd.ExecuteNonQuery();
                }
            }

            public static void UpdateSubject(int id, string name, int courseId)
            {
                using (var cmd = DataCon.GetConnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Subjects SET SubjectName = @name, CourseID = @courseId WHERE SubjectID = @id";
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@courseId", courseId);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            public static void DeleteSubject(int id)
            {
                using (var cmd = DataCon.GetConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Subjects WHERE SubjectID = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        
    }
}
