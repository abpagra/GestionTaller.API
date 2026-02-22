using GestionTaller.API.Persistence;
using Microsoft.AspNetCore.Identity;

namespace GestionTaller.API.Enviroment;

public static class IdentityConfiguration
{
    public static IServiceCollection AddIdentity(this IServiceCollection services)
    {
        //configuracion de identity en la aplicacion
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = IdentityConstants.BearerScheme;
            options.DefaultChallengeScheme = IdentityConstants.BearerScheme;
        })
            .AddBearerToken(IdentityConstants.BearerScheme);
        services.AddAuthorization();

        services
            .AddIdentityCore<IdentityUser>(
            options =>
            {
                //Password
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 8;

                //Require Email confirmed
                options.SignIn.RequireConfirmedEmail = false;

                //Lockout
                options.Lockout.AllowedForNewUsers = true;
                options.Lockout.MaxFailedAccessAttempts = 5;
            }

            )
            .AddEntityFrameworkStores<GestionTallerDbContext>()
            .AddApiEndpoints();

        return services;
    }
}
