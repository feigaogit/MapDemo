using Abp.Authorization;
using MapDemo.Authorization.Roles;
using MapDemo.Authorization.Users;

namespace MapDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
