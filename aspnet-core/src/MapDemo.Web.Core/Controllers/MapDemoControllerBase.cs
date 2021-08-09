using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MapDemo.Controllers
{
    public abstract class MapDemoControllerBase: AbpController
    {
        protected MapDemoControllerBase()
        {
            LocalizationSourceName = MapDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
