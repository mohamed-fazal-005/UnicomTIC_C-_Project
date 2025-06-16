using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTIC_WindowsForm_By_Fazal.Data;
using UTIC_WindowsForm_By_Fazal.Model;

namespace UTIC_WindowsForm_By_Fazal.Controller
{
    internal class MarkController
    {
        public static List<Marks> GetAllMarks()
        {
            List<Marks> marks = new List<Marks>();

            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Marks";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        marks.Add(new Marks
                        {
                            MarkID = Convert.ToInt32(reader["MarkID"]),
                            StudentID = Convert.ToInt32(reader["StudentID"]),
                            ExamID = Convert.ToInt32(reader["ExamID"]),
                            Score = Convert.ToInt32(reader["Score"])
                        });
                    }
                }
            }

            return marks;
        }

        public static void AddMark(int studentId, int examId, int score)
        {
            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Marks (StudentID, ExamID, Score) VALUES (@s, @e, @sc)";
                cmd.Parameters.AddWithValue("@s", studentId);
                cmd.Parameters.AddWithValue("@e", examId);
                cmd.Parameters.AddWithValue("@sc", score);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateMark(int markId, int studentId, int examId, int score)
        {
            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "UPDATE Marks SET StudentID = @s, ExamID = @e, Score = @sc WHERE MarkID = @id";
                cmd.Parameters.AddWithValue("@s", studentId);
                cmd.Parameters.AddWithValue("@e", examId);
                cmd.Parameters.AddWithValue("@sc", score);
                cmd.Parameters.AddWithValue("@id", markId);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteMark(int markId)
        {
            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Marks WHERE MarkID = @id";
                cmd.Parameters.AddWithValue("@id", markId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

