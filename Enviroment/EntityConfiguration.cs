using GestionTaller.API.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GestionTaller.API.Enviroment;

public static class EntityConfiguration
{
    public static WebApplicationBuilder AddEntitityConfiguration(this WebApplicationBuilder builder)
    {

        builder.Services.AddDbContext<GestionTallerDbContext>(options =>
             options.UseNpgsql(builder.Configuration.GetConnectionString("GestionTallerConnection")));

        return builder; 
    }
}
