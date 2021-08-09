using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MapDemo.Authorization.Roles;
using MapDemo.Authorization.Users;
using MapDemo.MultiTenancy;

namespace MapDemo.EntityFrameworkCore
{
    public class MapDemoDbContext : AbpZeroDbContext<Tenant, Role, User, MapDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MapDemoDbContext(DbContextOptions<MapDemoDbContext> options)
            : base(options)
        {
        }
    }
}
