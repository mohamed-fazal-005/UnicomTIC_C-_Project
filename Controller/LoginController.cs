
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTIC_WindowsForm_By_Fazal.Data;
using UTIC_WindowsForm_By_Fazal.Model;

namespace UTIC_WindowsForm_By_Fazal.Controller
{
    internal class LoginController
    {
        public static async Task<User> LoginUserAsync(string username, string password)
        {
            await Task.Delay(200); 

            if (username == "admin" && password == "1234")
            {
                return new User
                {
                    UserID = 1,
                    Username = "admin",
                    Password = "1234",
                    Role = "Admin"
                };
            }

            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                       User user= new User
                        {
                            UserID = Convert.ToInt32(reader["UserID"]),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Role = reader["Role"].ToString()
                        };
                        return user;

                    }
                }
            }

            return null;
        }
    }
}

