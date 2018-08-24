using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

public static class Extensions
{
   
    public static T ToEnum<T>(this string value)
    {
        return (T)Enum.Parse(typeof(T), value, true);
    }

    public static T ToEnum<T>(this string value, T defaultValue) where T : struct
    {
        if (string.IsNullOrEmpty(value))
        {
            return defaultValue;
        }

        T result = defaultValue;
        return Enum.TryParse<T>(value, true, out result) ? result : defaultValue;
    }

    public static IWebHost MigrateDatabase<T>(this IWebHost webHost) where T : DbContext
    {
        var serviceScopeFactory = (IServiceScopeFactory)webHost.Services.GetService(typeof(IServiceScopeFactory));

        using (var scope = serviceScopeFactory.CreateScope())
        {
            var services = scope.ServiceProvider;
            var dbContext = services.GetRequiredService<T>();

            try
            {
                dbContext.Database.Migrate();
            }
            catch (Exception ex1)
            {
                try
                {
                    dbContext.Database.EnsureCreated();
                }
                catch (Exception ex2)
                {
                    throw new Exception(ex1.Message, ex2);
                }
            }
        }

        return webHost;
    }
}