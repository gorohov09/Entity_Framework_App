using System;
using System.Data.Entity;

namespace Environmental_monitoring_DateBase_ADO5.Net
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("DbConnectionString")
        {
        }

        public DbSet<Source> Sources { get; set; }

        public DbSet<Emission> Emissions { get; set; }
    }
}
