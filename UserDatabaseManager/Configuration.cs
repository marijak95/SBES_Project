using System;
using System.Data.Entity.Migrations;

namespace UserDatabaseManager
{
    public class Configuration: DbMigrationsConfiguration<AccessDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Database";

        }
    }
}
