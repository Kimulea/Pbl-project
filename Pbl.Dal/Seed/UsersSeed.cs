using Microsoft.AspNetCore.Identity;
using Pbl.Dal.Constants;
using Pbl.Domain.Auth;
using System.Linq;
using System.Threading.Tasks;

namespace Pbl.Dal.Seed
{
    public class UsersSeed
    {
        public static async Task Seed(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            if (!userManager.Users.Any())
            {
                var user1 = new User()
                {
                    UserName = "admin",
                    Email = "admin@pbl.com",
                };
                await userManager.CreateAsync(user1, "Admin123#");

                if (await roleManager.RoleExistsAsync(UserRoles.Admin))
                {
                    await userManager.AddToRoleAsync(user1, UserRoles.Admin);
                }
            }
        }
    }
}
