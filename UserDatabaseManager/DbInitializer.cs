using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDatabaseManager
{
    public class DbInitializer
    {
        public DbInitializer()
        {
            string path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.LastIndexOf("bin")) + "Database";
            AppDomain.CurrentDomain.SetData("DataDirectory", path);

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AccessDB, Configuration>());



        }

        
    }
}
