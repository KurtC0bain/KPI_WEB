using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AudioContext _audioContext;

        public UserRepository(AudioContext audioContext)
        {
            _audioContext = audioContext;
        }

        public async Task<User> CreateUserAsync(User user)
        {
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);

            IdentityResult result = await manager.CreateAsync(new IdentityUser()
            {
                UserName = "TestUserName"
            }, "TestPassword");

            _audioContext.Users.Add(user);
            await _audioContext.SaveChangesAsync();

            return user;
        }

        public async Task CreateUserRolesAsync()
        { 
            var roleStore = new RoleStore<IdentityRole>();
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            var identityResult = await roleManager.CreateAsync(new IdentityRole()
            {
                Name = "Admin"
            });
            var identityResult2 = await roleManager.CreateAsync(new IdentityRole()
            {
                Name = "User"
            });
            var adminRole = await roleManager.FindByNameAsync("Admin");

            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            var user = await userManager.FindAsync("TestUserName", "TestPassword");

            await userManager.AddToRoleAsync(user.Id, "Admin");

        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            
            return await _audioContext.Users.ToListAsync();
        }

        public async Task<User> GetUserByUserId(int userId)
        {
            return await _audioContext.Users.FindAsync(userId);
        }
    }
}
