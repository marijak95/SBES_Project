using Common;
using System;
using System.Data.Entity;

namespace UserDatabaseManager
{
    public class AccessDB: DbContext
    {
        public AccessDB() : base("dbConnection2015") { }

        public DbSet<User> ListOfUsers { get; set; }
        public DbSet<Request> ListOfRequests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
