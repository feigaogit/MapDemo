using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using MapDemo.Authorization.Roles;
using MapDemo.Authorization.Users;
using System.Threading.Tasks;

namespace MapDemo.Users
{
    public class UserAppService : ApplicationService, IUserAppService
    {
        private readonly IRepository<Role> _roleRepository;
        private readonly IRepository<User, long> _userRepository;
        private readonly IObjectMapper _objectMapper;

        public UserAppService(
            IRepository<Role> roleRepository,
            IRepository<User, long> userRepository,
            IObjectMapper objectMapper)
        {
            _roleRepository = roleRepository;
            _userRepository = userRepository;
            _objectMapper = objectMapper;
        }

        public User Map1()
        {
            var user1 = new User { Id = 10, Name = "feifei" };
            var user2 = new User();

            _objectMapper.Map(user1, user2);

            return user2;
        }

        public Role Map2()
        {
            //Role [AutoMapTo(typeof(Role))]
            var role1 = new Role { Id = 11, Name = "role" };
            var role2 = new Role();

            _objectMapper.Map(role1, role2);

            return role2;
        }
    }
}

