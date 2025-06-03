using Scalar.AspNetCore;

namespace TheSampleApi.Startup;

public static class CorsConfig
{
    private const string AllowAllPolicy = "AllowAll";
    public static void AddOCorsServices(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy(AllowAllPolicy,
                policy =>
                {
                    policy.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
        });
    }



    public static void ApplyCorsConfig(this WebApplication app)
    {
      app.UseCors(AllowAllPolicy);

    }
}
