using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MapDemo.EntityFrameworkCore
{
    public static class MapDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MapDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MapDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
