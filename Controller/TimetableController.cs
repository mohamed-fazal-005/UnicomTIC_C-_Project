using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTIC_WindowsForm_By_Fazal.Data;
using UTIC_WindowsForm_By_Fazal.Model;

namespace UTIC_WindowsForm_By_Fazal.Controller
{
    internal class TimetableController
    {
           public static List<Timetable> GetAllTimetables()
            {
                List<Timetable> list = new List<Timetable>();

                using (var cmd = DataCon.GetConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Timetables";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Timetable
                            {
                                TimetableID = Convert.ToInt32(reader["TimetableID"]),
                                SubjectID = Convert.ToInt32(reader["SubjectID"]),
                                TimeSlot = reader["TimeSlot"].ToString(),
                                RoomID = Convert.ToInt32(reader["RoomID"])
                            });
                        }
                    }
                }

                return list;
            }

            public static void AddTimetable(int subjectId, string timeSlot, int roomId)
            {
                using (var cmd = DataCon.GetConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Timetables (SubjectID, TimeSlot, RoomID) VALUES (@s, @t, @r)";
                    cmd.Parameters.AddWithValue("@s", subjectId);
                    cmd.Parameters.AddWithValue("@t", timeSlot);
                    cmd.Parameters.AddWithValue("@r", roomId);
                    cmd.ExecuteNonQuery();
                }
            }

            public static void UpdateTimetable(int id, int subjectId, string timeSlot, int roomId)
            {
                using (var cmd = DataCon.GetConnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Timetables SET SubjectID = @s, TimeSlot = @t, RoomID = @r WHERE TimetableID = @id";
                    cmd.Parameters.AddWithValue("@s", subjectId);
                    cmd.Parameters.AddWithValue("@t", timeSlot);
                    cmd.Parameters.AddWithValue("@r", roomId);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            public static void DeleteTimetable(int id)
            {
                using (var cmd = DataCon.GetConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Timetables WHERE TimetableID = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        
    }
}
