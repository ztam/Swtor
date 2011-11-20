using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Providers;
using System.Data.SqlClient;
using Swtor.Common;

namespace Swtor.Business.Entities.Migrations
{
    public class Settings : DbMigrationContext<SwtorContext>
    {
        public Settings()
        {
            AutomaticMigrationsEnabled = true;
            SetCodeGenerator<CSharpMigrationCodeGenerator>();
            AddSqlGenerator<SqlConnection, SqlServerMigrationSqlGenerator>();

            // Uncomment the following line if you are using SQL Server Compact 
            // SQL Server Compact is available as the SqlServerCompact NuGet package
            // AddSqlGenerator<System.Data.SqlServerCe.SqlCeConnection, SqlCeMigrationSqlGenerator>();

            // Seed data: 
            //   Override the Seed method in this class to add seed data.
            //    - The Seed method will be called after migrating to the latest version.
            //    - The method should be written defensively in order that duplicate data is not created. E.g:
            //
            //        if (!context.Countries.Any())
            //        {
            //            context.Countries.Add(new Country { Name = "Australia" });
            //            context.Countries.Add(new Country { Name = "New Zealand" });
            //        }
            //

        }

        protected override void Seed(SwtorContext context)
        {
            var testText = new Text
            {
                Name = Constants.TestTextName,
                Content = "This is a test text"
            };

            var testUser = new User
            {
                Firstname = "Test",
                Lastname = "User",
                UserRole = (int)UserRoles.User
            };

            context.Texts.Add(testText);
            context.Users.Add(testUser);

            base.Seed(context);
        }
    }
}
