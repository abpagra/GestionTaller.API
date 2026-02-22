using Scalar.AspNetCore;

namespace GestionTaller.API.Enviroment;

public static class ScalarConfiguration
{
    public static void UseScalar(this WebApplication app)
    {
        app.MapOpenApi();
        app.MapScalarApiReference();
    }
}
