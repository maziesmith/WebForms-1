namespace ExamSkeleton.App_Start
{
    using ExamSkeleton.Data;
    using ExamSkeleton.Data.Migrations;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ExamSkeletonDbContext, Configuration>());
            ExamSkeletonDbContext.Create().Database.Initialize(true);
        }
    }
}