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
    public static class Store
    {
        public static SqlConnection conn;

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
            SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM [user] WHERE email = '{Email}' AND password = '{Password}'", conn);
            int count;
            count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
    }
}
