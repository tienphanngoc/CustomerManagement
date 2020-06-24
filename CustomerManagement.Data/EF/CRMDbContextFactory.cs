using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CustomerManagement.Data.EF
{
    public class CRMDbContextFactory : IDesignTimeDbContextFactory<CRMDbContext>
    {
        public CRMDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("CRMDatabase");
            var optionsBuilder = new DbContextOptionsBuilder<CRMDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new CRMDbContext(optionsBuilder.Options);
        }
    }
}
