using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using SampleMVC.Models.SampleDO;

namespace SampleMVC.Dal
{
    public class MenuRepository
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;

        public List<MenuItem> GetMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT Id, Name, Url, ParentId, IsActive FROM Menu WHERE IsActive = 1";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MenuItem item = new MenuItem
                        {
                            Id = (int)reader["Id"],
                            Name = (string)reader["Name"],
                            Url = (string)reader["Url"],
                            ParentId = reader["ParentId"] as int?,
                            IsActive = (bool)reader["IsActive"]
                        };
                        menuItems.Add(item);
                    }
                }
            }
            return menuItems;
        }
    }

}