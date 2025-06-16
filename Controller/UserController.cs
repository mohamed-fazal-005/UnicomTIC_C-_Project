using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTIC_WindowsForm_By_Fazal.Data;
using UTIC_WindowsForm_By_Fazal.Model;

namespace UTIC_WindowsForm_By_Fazal.Controller
{
    internal class UserController
    {
            public static List<User> GetAllUsers()
            {
                List<User> users = new List<User>();

                using (var cmd = DataCon.GetConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Users";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User
                            {
                                UserID = Convert.ToInt32(reader["UserID"]),
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                Role = reader["Role"].ToString()
                            });
                        }
                    }
                }

                return users;
            }

            public static void AddUser(string username, string password, string role)
            {
                using (var cmd = DataCon.GetConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Users (Username, Password, Role) VALUES (@u, @p, @r)";
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);
                    cmd.Parameters.AddWithValue("@r", role);
                    cmd.ExecuteNonQuery();
                }
            }

            public static void UpdateUser(int userId, string username, string password, string role)
            {
                using (var cmd = DataCon.GetConnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Users SET Username = @u, Password = @p, Role = @r WHERE UserID = @id";
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);
                    cmd.Parameters.AddWithValue("@r", role);
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                }
            }

            public static void DeleteUser(int userId)
            {
                using (var cmd = DataCon.GetConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Users WHERE UserID = @id";
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                }
            }
       
    }
}
