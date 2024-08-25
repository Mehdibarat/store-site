using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace web;

public static class ConfigureService
{
    public static IServiceCollection AddServiceCollection(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<ApplicationDbContext>(option =>
        {
            option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        });
        return builder.Services;
    }
}

 