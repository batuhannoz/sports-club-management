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

    public struct Address
    {
        public string City { get; set; }
        public string District { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
    }

    public struct SubscriptionInfo
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime NextPayDate { get; set; }
        public int UserId { get; set; }
        public int PlanId { get; set; }
    }

    public struct PlanInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
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

        public static void UpdateUser(int id, string name, string surname, DateTime dateOfBirth, string phoneNumber, string email, string password, int profileId)
        { 
            using (SqlCommand command = new SqlCommand("UpdateUser", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters to the stored procedure
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
                command.Parameters.AddWithValue("@phone_number", phoneNumber);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@profile_id", profileId);

                command.ExecuteNonQuery(); 
            }
        }

        public static Address GetLatestAddressByUserId(int userId)
        {
            Address latestAddress = new Address();
            using (SqlCommand command = new SqlCommand("GetLatestAddressByUserId", conn))
            {
               command.CommandType = CommandType.StoredProcedure;
               command.Parameters.AddWithValue("@user_id", userId);

               using (SqlDataReader reader = command.ExecuteReader())
               {

                   if (reader.Read())
                   {
                        latestAddress.City = reader["city"].ToString();
                        latestAddress.District = reader["district"].ToString();
                        latestAddress.Neighborhood = reader["neighborhood"].ToString();
                        latestAddress.Street = reader["street"].ToString();
                    }
               }
            }
            return latestAddress;
        }

        public static void InsertNewAddress(int userId, string city, string district, string neighborhood, string street)
        {
            using (SqlCommand command = new SqlCommand("InsertNewAddress", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@user_id", userId);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@district", district);
                command.Parameters.AddWithValue("@neighborhood", neighborhood);
                command.Parameters.AddWithValue("@street", street);

                command.ExecuteNonQuery();
              
            }
        }

        public static void InsertHealthStatus(int userId, int weight, int height)
        {

            using (SqlCommand command = new SqlCommand("InsertHealthStatus", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@user_id", userId);
                command.Parameters.AddWithValue("@weight", weight);
                command.Parameters.AddWithValue("@height", height);
                command.ExecuteNonQuery();
            }
        }

        public static DataTable GetHealthRecords(int userId)
        {
            DataTable healthRecordsTable = new DataTable();
            using (SqlCommand command = new SqlCommand("GetHealthRecordsByUserId", conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@user_id", userId);


                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(healthRecordsTable);
                }
            }
            return healthRecordsTable;
        }

        public static SubscriptionInfo GetSubscriptionInfoByUserId(int userId)
        {
            using (SqlCommand command = new SqlCommand("GetSubscriptionInfoByUserId", conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@user_id", userId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new SubscriptionInfo
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            StartDate = reader.GetDateTime(reader.GetOrdinal("start_date")),
                            ExpireDate = reader.GetDateTime(reader.GetOrdinal("expire_date")),
                            NextPayDate = reader.GetDateTime(reader.GetOrdinal("next_pay_date")),
                            UserId = reader.GetInt32(reader.GetOrdinal("user_id")),
                            PlanId = reader.GetInt32(reader.GetOrdinal("plan_id"))
                        };
                    }
                    else
                    {
                        throw new Exception("No active subscription found for the user.");
                    }
                }
            }
        }

        public static PlanInfo GetPlanById(string connectionString, int planId)
        {


                using (SqlCommand command = new SqlCommand("GetPlanById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@plan_id", planId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new PlanInfo
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                Name = reader.GetString(reader.GetOrdinal("name")),
                                Description = reader.GetString(reader.GetOrdinal("description")),
                                Price = reader.GetDecimal(reader.GetOrdinal("price")),
                                Type = reader.GetString(reader.GetOrdinal("type")),
                                Status = reader.GetString(reader.GetOrdinal("status"))
                            };
                        }
                        else
                        {
                            throw new Exception("No plan found for the specified plan ID.");
                        }
                    }
                }
            
        }
    }
}