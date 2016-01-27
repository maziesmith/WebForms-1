using Data;
using Data.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cars.App_Start
{
    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CarsDbContext, Configuration>());
            CarsDbContext.Create().Database.Initialize(true);
        }
    }
}