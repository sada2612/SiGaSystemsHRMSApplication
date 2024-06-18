using Microsoft.AspNetCore.Identity;

namespace SiGaHRMS.ApiService.Helper;

public static class DbInitializer
{
    public static async Task Initialize(IServiceProvider serviceProvider)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

        string[] roleNames = { "Admin", "User" };
        IdentityResult roleResult;

        foreach (var roleName in roleNames)
        {
            var roleExist = await roleManager.RoleExistsAsync(roleName);
            if (!roleExist)
            {
                roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }

        var powerUser = new IdentityUser
        {
            UserName = "admin@admin.com",
            Email = "admin@admin.com",
        };

        string userPassword = "Admin@123";
        var user = await userManager.FindByEmailAsync("admin@admin.com");

        if (user == null)
        {
            var createPowerUser = await userManager.CreateAsync(powerUser, userPassword);
            if (createPowerUser.Succeeded)
            {
                await userManager.AddToRoleAsync(powerUser, "Admin");
            }
        }
    }
}
