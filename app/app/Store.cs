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
        public int ProfileID { get; set; }
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

        public static bool UserLogin(string Email, string Password)
        {
            SqlCommand cmd = new SqlCommand($"SELECT * FROM [user] WHERE email = '{Email}' AND password = '{Password}'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            int a = 0;
            while (dr.Read())
            {
                user.Id = Convert.ToInt32(dr["id"]);
                user.Name = Convert.ToString(dr["name"]);
                user.Surname  = Convert.ToString(dr["surname"]);
                user.DateOfBirth = Convert.ToDateTime(dr["date_of_birth"]);
                user.PhoneNumber = Convert.ToString(dr["phone_number"]);
                user.Email = Convert.ToString(dr["email"]);
                user.Password = Convert.ToString(dr["password"]);
                user.ProfileID = Convert.ToInt32(dr["profile_id"]);
                Debug.WriteLine(user);
                a++;
            }
            return a == 1;
        }
    }
}