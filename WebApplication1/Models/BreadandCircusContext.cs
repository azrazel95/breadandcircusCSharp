using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
namespace WebApplication1.Models
{
    public class BreadandCircusContext : DbContext
    {
        public string ConnectionString { get; set; }
        public BreadandCircusContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Comment> GetAllComments()
        {
            List<Comment> list = new List<Comment>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Comment", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Comment()
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            description = reader["description"].ToString(),
                            date_created = Convert.ToDateTime(reader["date_created"])
                            // I must figure out how to add the relation between user and post
                        });
                    }
                }

            }
            return BreadandCircusContext.Comment;
        }
    }
}
