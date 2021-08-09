using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MapDemo.Configuration.Dto;

namespace MapDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MapDemoAppServiceBase, IConfigurationAppService
    {
        //public async Task ChangeUiTheme(ChangeUiThemeInput input)
        //{
        //    await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        //}
    }
}
