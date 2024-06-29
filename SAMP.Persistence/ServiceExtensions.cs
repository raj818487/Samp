using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SAMP.Application;
using Serilog;
using System.Reflection;

namespace SAMP.Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistence(this IServiceCollection services, WebApplicationBuilder builder)
        {
            //var connectionString = builder.Configuration.GetConnectionString("postgres");
            // services.AddEntityFrameworkNpgsql().AddDbContext<DataContext>(options =>
            //     options.UseNpgsql(connectionString)
            // );
            builder.Services.AddDbContext<DataContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("Sqlite")));
            builder.Services.AddAuthentication();
            builder.Services.AddIdentityApiEndpoints<IdentityUser>().AddEntityFrameworkStores<DataContext>();        /*Audit.Core.Configuration.Setup()
            .UseEntityFramework(ef => ef
                .AuditTypeMapper(type => typeof(AuditLog))  // AuditLog should be your custom AuditLog entity
                .AuditEntityAction<AuditLog>((auditEvent, entry, entity) =>
                {
                    // Customize audit log entity
                    entity.AuditData = auditEvent.GetEntityFrameworkEvent().ToJson();
                })
                .IgnoreMatchedProperties(true));*/

            services.ConfigureApplication();
            builder.Host.UseSerilog(CreateSerilogLogger(builder.Configuration));
            builder.Services.AddControllers(options =>
            {
                options.Filters.Add<HttpGlobalExceptionFilter>();
            });

            services.AddServices();

            //Serilog Configurations
            ILogger CreateSerilogLogger(IConfiguration configuration)
            {
                return new LoggerConfiguration()
                    .Enrich.FromLogContext()
                    .ReadFrom.Configuration(configuration)
                    .CreateLogger();
            }
        }

        /// <summary>
        /// Find and map all IServices with respective services
        /// </summary>
        /// <param name="services"></param>
        public static void AddServices(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(t => t.IsClass && !t.IsAbstract && t.IsPublic && t.Name.EndsWith("Service"));

            foreach (var type in types)
            {
                var interfaces = type.GetInterfaces();
                foreach (var @interface in interfaces)
                {
                    if (@interface.Name == $"I{type.Name}")
                    {
                        services.AddScoped(@interface, type);
                    }
                }
            }
        }
    }
}
