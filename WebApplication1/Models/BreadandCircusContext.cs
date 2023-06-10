using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Models
{
    public class BreadandCircusContext : DbContext
    {
        public string ConnectionString { get; set; }
        public BreadandCircusContext(string connectionString ) {
            this.ConnectionString = connectionString;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
