using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTIC_WindowsForm_By_Fazal.Data;
using UTIC_WindowsForm_By_Fazal.Model;

namespace UTIC_WindowsForm_By_Fazal.Controller
{
    internal class StaffController
    {
        public static List<Staff> GetAllStaff()
        {
            var list = new List<Staff>();
            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Staff";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Staff
                        {
                            StaffID = Convert.ToInt32(reader["StaffID"]),
                            Name = reader["Name"].ToString(),
                            Position = reader["Position"].ToString(),
                            Email = reader["Email"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public static void AddStaff(string name, string position, string email)
        {
            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Staff (Name, Position, Email) VALUES (@n, @p, @e)";
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@p", position);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateStaff(int id, string name, string position, string email)
        {
            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "UPDATE Staff SET Name = @n, Position = @p, Email = @e WHERE StaffID = @id";
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@p", position);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteStaff(int id)
        {
            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Staff WHERE StaffID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
