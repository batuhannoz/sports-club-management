﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
    public struct Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PermissionId { get; set; }
    }
        public struct TimetableInfo
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public byte WeekDay { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }

    public struct Permissions
    {
        public int Id { get; set; }
        public bool ViewPlans { get; set; }
        public bool SubscribePlan { get; set; }
        public bool UnsubscribePlan { get; set; }
        public bool Pay { get; set; }
        public bool ViewTimetable { get; set; }
        public bool UpdateHealthStatus { get; set; }
        public bool UpdateProfile { get; set; }
        public bool UpdateAddress { get; set; }
    }

    public static class Store
    {
        public static SqlConnection conn;

        public static User user = new User();

        public static Permissions permissions = new Permissions();

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

        public static PlanInfo GetPlanById(int planId)
        {
            using (SqlCommand command = new SqlCommand("GetPlanById", conn))
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

        public static List<TimetableInfo> GetWeeklyTimetableByPlanId(int planId)
        {
            List<TimetableInfo> timetable = new List<TimetableInfo>();

            using (SqlCommand command = new SqlCommand("GetWeeklyTimetableByPlanId", conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@plan_id", planId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        timetable.Add(new TimetableInfo
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            PlanId = reader.GetInt32(reader.GetOrdinal("plan_id")),
                            WeekDay = reader.GetByte(reader.GetOrdinal("week_day")),
                            StartTime = reader.GetTimeSpan(reader.GetOrdinal("start_time")),
                            EndTime = reader.GetTimeSpan(reader.GetOrdinal("end_time"))
                        });
                    }
                }
            }
            return timetable;
        }
        public static void DelayNextPayDateByOneMonth(int userId)
        {
            using (SqlCommand command = new SqlCommand("DelayNextPayDateByOneMonth", conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@user_id", userId);

                command.ExecuteNonQuery();
            }
        }
        public static void UnsubscribeUser(int userId)
        {
            using (SqlCommand command = new SqlCommand("UnsubscribeUser", conn))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@user_id", userId);

                command.ExecuteNonQuery();
            }
        }

        public static DataTable GetActivePlans()
        {
            DataTable activePlans = new DataTable();

            using (SqlCommand command = new SqlCommand("GetActivePlans", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(activePlans);
                }
            }
            return activePlans;
        }
        public static void StartNewSubscription(int userId, int planId)
        {
            using (SqlCommand command = new SqlCommand("StartNewSubscription", conn))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@user_id", userId);
                command.Parameters.AddWithValue("@plan_id", planId);

                command.ExecuteNonQuery();
            }
        }

        public static void RestoreDatabase()
        {
            SqlConnection restoreConn = new SqlConnection($@"
                Server=127.0.0.1,1433;
                Database=sports_club;
                User Id=sa;
                Password=Password1!;
                TrustServerCertificate=True"
            );
            restoreConn.Open();

            string restoreQuery = @"USE master; 
                ALTER DATABASE sports_club SET Single_User WITH Rollback Immediate; 
                RESTORE DATABASE sports_club FROM DISK = '/var/opt/mssql/backups/backup.bak' WITH REPLACE; 
                ALTER DATABASE sports_club SET Multi_User;
                USE sports_club;
                ALTER USER [admin] WITH LOGIN = [admin];";

            using (SqlCommand command = new SqlCommand(restoreQuery, restoreConn))
            {
                command.ExecuteNonQuery();
            }

            restoreConn.Close();
        }

        public static void BackupDatabase()
        {

            SqlConnection backupConn = new SqlConnection($@"
                Server=127.0.0.1,1433;
                Database=sports_club;
                User Id=sa;
                Password=Password1!;
                TrustServerCertificate=True"
            );
            backupConn.Open();

            string backupQuery = $"BACKUP DATABASE sports_club TO DISK = '/var/opt/mssql/backups/backup.bak';";

            using (SqlCommand command = new SqlCommand(backupQuery, backupConn))
            {
                command.ExecuteNonQuery();
            }
            backupConn.Close(); 
            
        }

        public static Permissions GetPermissionsByProfileId(int profileId)
        {
            Permissions permissions = new Permissions();

            using (SqlCommand command = new SqlCommand("GetPermissionDetailsByProfileId", conn))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@profile_id", profileId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        permissions.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        permissions.ViewPlans = reader.GetBoolean(reader.GetOrdinal("view_plans"));
                        permissions.SubscribePlan = reader.GetBoolean(reader.GetOrdinal("subscribe_plan"));
                        permissions.UnsubscribePlan = reader.GetBoolean(reader.GetOrdinal("unsubscribe_plan"));
                        permissions.Pay = reader.GetBoolean(reader.GetOrdinal("pay"));
                        permissions.ViewTimetable = reader.GetBoolean(reader.GetOrdinal("view_timetable"));
                        permissions.UpdateHealthStatus = reader.GetBoolean(reader.GetOrdinal("update_health_status"));
                        permissions.UpdateProfile = reader.GetBoolean(reader.GetOrdinal("update_profile"));
                        permissions.UpdateAddress = reader.GetBoolean(reader.GetOrdinal("update_address"));
                    }
                }
            }
            return permissions;
        }

        public static DataTable GetPlanData()
        {
            DataTable activePlans = new DataTable();

            using (SqlCommand command = new SqlCommand("GetPlanData", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(activePlans);
                }
            }
            return activePlans;
        }

        public static void UpdatePlanById(PlanInfo updatedPlan)
        {
            using (SqlCommand command = new SqlCommand("UpdatePlanById", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters
                command.Parameters.AddWithValue("@planId", updatedPlan.Id);
                command.Parameters.AddWithValue("@name", updatedPlan.Name);
                command.Parameters.AddWithValue("@description", updatedPlan.Description);
                command.Parameters.AddWithValue("@price", updatedPlan.Price);
                command.Parameters.AddWithValue("@type", updatedPlan.Type);
                command.Parameters.AddWithValue("@status", updatedPlan.Status);

                // Execute the update stored procedure
                command.ExecuteNonQuery();       
            }
        }

        public static void UpdateTimetableById(TimetableInfo updatedTimetable)
        {
            using (SqlCommand command = new SqlCommand("UpdateTimetableById", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters
                command.Parameters.AddWithValue("@timetableId", updatedTimetable.Id);
                command.Parameters.AddWithValue("@weekDay", updatedTimetable.WeekDay);
                command.Parameters.AddWithValue("@startTime", updatedTimetable.StartTime);
                command.Parameters.AddWithValue("@endTime", updatedTimetable.EndTime);

                // Execute the update stored procedure
                command.ExecuteNonQuery();
            }
        }

        public static int CreateNewPlan(PlanInfo newPlan)
        {
            using (SqlCommand command = new SqlCommand("CreateNewPlan", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add input parameters
                command.Parameters.AddWithValue("@name", newPlan.Name);
                command.Parameters.AddWithValue("@description", newPlan.Description);
                command.Parameters.AddWithValue("@price", newPlan.Price);
                command.Parameters.AddWithValue("@type", newPlan.Type);
                command.Parameters.AddWithValue("@status", newPlan.Status);

                // Add output parameter for the new plan ID
                SqlParameter newPlanIdParameter = new SqlParameter("@newPlanId", SqlDbType.Int);
                newPlanIdParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(newPlanIdParameter);

                // Execute the stored procedure
                command.ExecuteNonQuery();

                // Retrieve the generated plan ID
                int newPlanId = Convert.ToInt32(newPlanIdParameter.Value);
                return newPlanId;
            }          
        }

        public static int CreateNewTimetable(TimetableInfo newTimetable)
        {
            using (SqlCommand command = new SqlCommand("CreateNewTimetable", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add input parameters
                command.Parameters.AddWithValue("@planId", newTimetable.PlanId);
                command.Parameters.AddWithValue("@weekDay", newTimetable.WeekDay);
                command.Parameters.AddWithValue("@startTime", newTimetable.StartTime);
                command.Parameters.AddWithValue("@endTime", newTimetable.EndTime);

                // Add output parameter for the new timetable ID
                SqlParameter newTimetableIdParameter = new SqlParameter("@newTimetableId", SqlDbType.Int);
                newTimetableIdParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(newTimetableIdParameter);

                // Execute the stored procedure
                command.ExecuteNonQuery();

                // Retrieve the generated timetable ID
                int newTimetableId = Convert.ToInt32(newTimetableIdParameter.Value);
                return newTimetableId;
            }            
        }

        public static DataTable SearchUsers(string keyword)
        {
            using (SqlCommand command = new SqlCommand("SearchUsers", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add parameter for the keyword
                command.Parameters.AddWithValue("@keyword", keyword);

                // Execute the stored procedure and fill the DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable searchResults = new DataTable();
                    adapter.Fill(searchResults);
                    return searchResults;
                }
            }
        }

        public static DataTable GetProfilesWithID()
        {
            using (SqlCommand command = new SqlCommand("GetProfileNamesAndIds", conn))
            {
                DataTable profilesTable = new DataTable();

                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(profilesTable);

                    return profilesTable;
                }
            }            
        }
        public static int InsertNewUser(string name, string surname, DateTime dateOfBirth, string phone, string email, string password, int profileId)
        {
            using (SqlCommand command = new SqlCommand("InsertNewUser", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add input parameters
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@profileId", profileId);

                // Add output parameter for the new user ID
                SqlParameter newUserIdParameter = new SqlParameter("@newUserId", SqlDbType.Int);
                newUserIdParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(newUserIdParameter);

                // Execute the stored procedure
                command.ExecuteNonQuery();

                // Retrieve the generated user ID
                int newUserId = Convert.ToInt32(newUserIdParameter.Value);
                return newUserId;
            }
        }

        public static User GetUserById(int userId)
        {
            User user = new User(); // Initialize a new User struct

            using (SqlCommand command = new SqlCommand("GetUserById", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add parameter for the user ID
                command.Parameters.AddWithValue("@userId", userId);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable userData = new DataTable();
                    adapter.Fill(userData);

                    // If user is found, populate the User struct
                    if (userData.Rows.Count > 0)
                    {
                        DataRow userRow = userData.Rows[0];
                        user.Id = Convert.ToInt32(userRow["id"]);
                        user.Name = Convert.ToString(userRow["name"]);
                        user.Surname = Convert.ToString(userRow["surname"]);
                        user.DateOfBirth = Convert.ToDateTime(userRow["date_of_birth"]);
                        user.PhoneNumber = Convert.ToString(userRow["phone_number"]);
                        user.Email = Convert.ToString(userRow["email"]);
                        user.Password = Convert.ToString(userRow["password"]);
                        user.ProfileId = Convert.ToInt32(userRow["profile_id"]);
                    }
                }
            }
            return user;
        }

        public static DataTable GetAllProfiles()
        {
            using (SqlCommand command = new SqlCommand("GetAllProfiles", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable profilesData = new DataTable();
                    adapter.Fill(profilesData);

                    return profilesData;
                }
            }
        }

        public static void UpdateProfileAndPermissions(int profileId,
        string name, bool viewPlans, bool subscribePlan, bool unsubscribePlan, bool pay,
        bool viewTimetable, bool updateHealthStatus, bool updateProfile, bool updateAddress)
        {
            using (SqlCommand command = new SqlCommand("UpdateProfileAndPermissions", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters for the update
                command.Parameters.AddWithValue("@profileId", profileId);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@viewPlans", viewPlans);
                command.Parameters.AddWithValue("@subscribePlan", subscribePlan);
                command.Parameters.AddWithValue("@unsubscribePlan", unsubscribePlan);
                command.Parameters.AddWithValue("@pay", pay);
                command.Parameters.AddWithValue("@viewTimetable", viewTimetable);
                command.Parameters.AddWithValue("@updateHealthStatus", updateHealthStatus);
                command.Parameters.AddWithValue("@updateProfile", updateProfile);
                command.Parameters.AddWithValue("@updateAddress", updateAddress);

                // Execute the stored procedure
                command.ExecuteNonQuery();
            }            
        }

        public static Permissions GetPermissionsById(int permissionsId)
        {
            Permissions permissions = new Permissions();

            using (SqlCommand command = new SqlCommand("GetPermissionsById", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@permissionsId", permissionsId);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable permissionsData = new DataTable();
                    adapter.Fill(permissionsData);

                    if (permissionsData.Rows.Count > 0)
                    {
                        DataRow permissionsRow = permissionsData.Rows[0];
                        permissions.ViewPlans = Convert.ToBoolean(permissionsRow["view_plans"]);
                        permissions.SubscribePlan = Convert.ToBoolean(permissionsRow["subscribe_plan"]);
                        permissions.UnsubscribePlan = Convert.ToBoolean(permissionsRow["unsubscribe_plan"]);
                        permissions.Pay = Convert.ToBoolean(permissionsRow["pay"]);
                        permissions.ViewTimetable = Convert.ToBoolean(permissionsRow["view_timetable"]);
                        permissions.UpdateHealthStatus = Convert.ToBoolean(permissionsRow["update_health_status"]);
                        permissions.UpdateProfile = Convert.ToBoolean(permissionsRow["update_profile"]);
                        permissions.UpdateAddress = Convert.ToBoolean(permissionsRow["update_address"]);
                    }
                }
            }
            return permissions;
        }

        public static void DeleteProfileAndPermissions(int profileId)
        {
            using (SqlCommand command = new SqlCommand("DeleteProfileAndPermissions", conn))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@profileId", profileId);

                command.ExecuteNonQuery();                
            }
        }

        public static void InsertProfileAndPermissions(Permissions permissions, Profile profile)
        {
            using (SqlCommand command = new SqlCommand("InsertProfileAndPermissions", conn))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@name", profile.Name);
                command.Parameters.AddWithValue("@viewPlans", permissions.ViewPlans);
                command.Parameters.AddWithValue("@subscribePlan", permissions.SubscribePlan);
                command.Parameters.AddWithValue("@unsubscribePlan", permissions.UnsubscribePlan);
                command.Parameters.AddWithValue("@pay", permissions.Pay);
                command.Parameters.AddWithValue("@viewTimetable", permissions.ViewTimetable);
                command.Parameters.AddWithValue("@updateHealthStatus", permissions.UpdateHealthStatus);
                command.Parameters.AddWithValue("@updateProfile", permissions.UpdateProfile);
                command.Parameters.AddWithValue("@updateAddress", permissions.UpdateAddress);

                command.ExecuteNonQuery();                
            }
        }
    }
}