using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTIC_WindowsForm_By_Fazal.Data;
using UTIC_WindowsForm_By_Fazal.Model;

namespace UTIC_WindowsForm_By_Fazal.Controller
{
    internal class ExamController
    {
        public static List<Exam> GetAllExams()
        {
            var exams = new List<Exam>();
            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Exams";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        exams.Add(new Exam
                        {
                            ExamID = Convert.ToInt32(reader["ExamID"]),
                            ExamName = reader["ExamName"].ToString(),
                            SubjectID = Convert.ToInt32(reader["SubjectID"])
                        });
                    }
                }
            }
            return exams;
        }

        public static void AddExam(string name, int subjectId)
        {
            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Exams (ExamName, SubjectID) VALUES (@n, @s)";
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@s", subjectId);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateExam(int id, string name, int subjectId)
        {
            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "UPDATE Exams SET ExamName = @n, SubjectID = @s WHERE ExamID = @id";
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@s", subjectId);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteExam(int id)
        {
            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Exams WHERE ExamID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

