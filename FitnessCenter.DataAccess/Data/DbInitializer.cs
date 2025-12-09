using FitnessCenter.Models;
using FitnessCenter.Utility;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.DataAccess.Data
{
    public static class DbInitializer
    {
        public static async Task SeedAdminUser(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Admin").GetAwaiter().GetResult())
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            var adminUser = await userManager.FindByEmailAsync(StaticDetails.Admin_Email);

            if (adminUser == null)
            {
                adminUser = new IdentityUser
                {
                    UserName = StaticDetails.Admin_Email,
                    Email = StaticDetails.Admin_Email,
                    EmailConfirmed = true 
                };
                var result = userManager.CreateAsync(adminUser, StaticDetails.Admin_Password).GetAwaiter().GetResult();

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, StaticDetails.Role_Admin);
                }
            }
        }
    }
}
