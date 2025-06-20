using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTIC_WindowsForm_By_Fazal.Data;
using UTIC_WindowsForm_By_Fazal.Model;

namespace UTIC_WindowsForm_By_Fazal.Controller
{
    internal class LectureController
    {
        public static List<Lecture> GetAllLectures()
        {
            List<Lecture> lectures = new List<Lecture>();

            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT l.LectureID, l.Name, l.SubjectID, l.Qualification, l.Email
                    FROM Lectures l";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lectures.Add(new Lecture
                        {
                            LectureID = Convert.ToInt32(reader["LectureID"]),
                            Name = reader["Name"].ToString(),
                            SubjectID = Convert.ToInt32(reader["SubjectID"]),
                            Qualification = reader["Qualification"].ToString(),
                            Email = reader["Email"].ToString()
                        });
                    }
                }
            }


            return lectures;
        }

        public static void AddLecture(string name, int subjectId, string qualification, string email)
        {
            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Lectures (Name, SubjectID, Qualification, Email) VALUES (@n, @s, @q, @e)";
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@s", subjectId);
                cmd.Parameters.AddWithValue("@q", qualification);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateLecture(int id, string name, int subjectId, string qualification, string email)
        {
            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "UPDATE Lectures SET Name = @n, SubjectID = @s, Qualification = @q, Email = @e WHERE LectureID = @id";
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@s", subjectId);
                cmd.Parameters.AddWithValue("@q", qualification);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteLecture(int id)
        {
            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Lectures WHERE LectureID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

