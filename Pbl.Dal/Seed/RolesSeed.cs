using Microsoft.AspNetCore.Identity;
using Pbl.Dal.Constants;
using Pbl.Domain.Auth;
using System.Threading.Tasks;

namespace Pbl.Dal.Seed
{
    public class RolesSeed
    {
        public static async Task Seed(RoleManager<Role> roleManager)
        {
            await roleManager.CreateAsync(new Role() { Name = UserRoles.Admin });
            await roleManager.CreateAsync(new Role() { Name = UserRoles.User });
        }
    }
}
