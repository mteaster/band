using System.Data.Entity.Migrations;
using band.Models;
using WebMatrix.WebData;

namespace band.Config
{
    public class MigrationConfiguration : DbMigrationsConfiguration<DatabaseContext>
    {
        public MigrationConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;  // This is important as it will fail in some environments (like Azure) by default
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DatabaseContext context)
        {
            WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "UserId", "UserName", autoCreateTables: true);

            //context.Database.ExecuteSqlCommand("CREATE CLUSTERED INDEX myIndex ON BandMembership (BandName, MemberId)");
        }
    }
}