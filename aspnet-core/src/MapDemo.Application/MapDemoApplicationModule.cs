using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MapDemo.Authorization;

namespace MapDemo
{
    [DependsOn(
        typeof(MapDemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MapDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MapDemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MapDemoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
