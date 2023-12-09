using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int ProfileId { get; set; }
    }
    public static class Store
    {
        public static SqlConnection conn;

        public static User user = new User();

        public static void Connect(string Username, string Password)
        {
            conn = new SqlConnection($@"
                Server=127.0.0.1,1433;
                Database=sports_club;
                User Id={ Username };
                Password={ Password };
                TrustServerCertificate=True"
            );
            conn.Open();
        }

        public static bool UserLogin(string email, string password)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM [user] WHERE [email] = @email AND [password] = @password", conn))
                {
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        user.Name = reader.GetString(reader.GetOrdinal("name"));
                        user.Surname = reader.GetString(reader.GetOrdinal("surname"));
                        user.DateOfBirth = reader.GetDateTime(reader.GetOrdinal("date_of_birth"));
                        user.PhoneNumber = reader.GetString(reader.GetOrdinal("phone_number"));
                        user.Email = reader.GetString(reader.GetOrdinal("email"));
                        user.Password = reader.GetString(reader.GetOrdinal("password"));
                        user.ProfileId = reader.GetInt32(reader.GetOrdinal("profile_id"));

                        return true;
                    }
                }
            }
            return false; 
        }

        public static void InsertUser(string name, string surname, DateTime dateOfBirth, string phoneNumber, string email, string password)
        {
            using (SqlCommand command = new SqlCommand("InsertUser", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
                command.Parameters.AddWithValue("@phone_number", phoneNumber);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);

                command.ExecuteNonQuery();
            }
        }
    }
}