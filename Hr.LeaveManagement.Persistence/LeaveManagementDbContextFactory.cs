using Hr.LeaveManagement.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace HR.LeaveManagement.Persistence
{
    public static partial class PersistenceServicesRegistration
    {
        public class LeaveManagementDbContextFactory:
            IDesignTimeDbContextFactory<LeaveManagementDbContext>
        {
            public LeaveManagementDbContext CreateDbContext(string[] args)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.Json")
                    .Build();
                var builder = new DbContextOptionsBuilder<LeaveManagementDbContext>();
                var connectionString = configuration.GetConnectionString
                    ("LeaveManagementConnectionString");
                builder.UseSqlServer(connectionString);

                return new LeaveManagementDbContext(builder.Options);
            }
        }
        

        
    }
}