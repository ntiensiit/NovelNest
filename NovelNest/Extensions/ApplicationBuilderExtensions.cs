namespace Microsoft.AspNetCore.Builder
{
    using Microsoft.AspNetCore.Identity;
    using NovelNest.Infrastructure.Data.Models.Roles;
    using static NovelNest.Core.Constants.AdminConstants;

    public static class ApplicationBuilderExtensions
    {
        public static async Task CreateAdminRoleAsync(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            var logger = scope.ServiceProvider.GetRequiredService<ILoggerFactory>().CreateLogger("ApplicationSeed");
            try
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (userManager != null && roleManager != null && await roleManager.RoleExistsAsync(AdminRole) == false)
                {
                    var role = new IdentityRole(AdminRole);
                    await roleManager.CreateAsync(role);

                    var admin = await userManager.FindByEmailAsync("admin@gmail.com");

                    if (admin != null)
                    {
                        await userManager.AddToRoleAsync(admin, role.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Seeding admin role failed. Check ConnectionStrings:DefaultConnection - app will continue without seeding.");
            }
        }
    }
}