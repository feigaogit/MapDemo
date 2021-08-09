using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MapDemo.Configuration;
using MapDemo.Web;

namespace MapDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MapDemoDbContextFactory : IDesignTimeDbContextFactory<MapDemoDbContext>
    {
        public MapDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MapDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MapDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MapDemoConsts.ConnectionStringName));

            return new MapDemoDbContext(builder.Options);
        }
    }
}
