using AutoMapper;
using BugTracker.Domain.Settings;
using BugTracker.Persistence;
using BugTracker.Service.Contract;
using BugTracker.Service.Implementation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace BugTracker.Infrastructure.Extension
{
    public static class ConfigureServiceContainer
    {
        public static void AddDbContext(this IServiceCollection serviceCollection,
             IConfiguration configuration, IConfigurationRoot configRoot)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
                   options.UseSqlServer(configuration.GetConnectionString("BugTrackerConn") ?? configRoot["ConnectionStrings:BugTrackerConn"]
                , b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));


        }

        public static void AddAutoMapper(this IServiceCollection serviceCollection)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                //mc.AddProfile(new CustomerProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            serviceCollection.AddSingleton(mapper);
        }

        public static void AddScopedServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());


        }
        public static void AddTransientServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IDateTimeService, DateTimeService>();
            serviceCollection.AddTransient<IAccountService, AccountService>();
        }



        public static void AddSwaggerOpenAPI(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSwaggerGen(setupAction =>
            {

                setupAction.SwaggerDoc(
                    "OpenAPISpecification",
                    new OpenApiInfo()
                    {
                        Title = "Bug-Tracker Architecture WebAPI",
                        Version = "1",
                        Description = "Through this API you can access customer details",
                        Contact = new OpenApiContact()
                        {
                            Email = "zuluchs@gmail.com",
                            Name = "Musa Zulu",
                            Url = new Uri("https://musa-zulu.github.io/mypage/")
                        },
                        License = new OpenApiLicense()
                        {
                            Name = "MIT License",
                            Url = new Uri("https://opensource.org/licenses/MIT")
                        }
                    });

                setupAction.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    Description = $"Input your Bearer token in this format - Bearer token to access this API",
                });
                setupAction.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer",
                            },
                        }, new List<string>()
                    },
                });

                var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);
                setupAction.IncludeXmlComments(xmlCommentsFullPath);

            });

        }

        public static void AddMailSetting(this IServiceCollection serviceCollection,
            IConfiguration configuration)
        {
            serviceCollection.Configure<MailSettings>(configuration.GetSection("MailSettings"));
        }

        public static void AddController(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddControllers().AddNewtonsoftJson();
        }

        //public static void AddMediatorCQRS(this IServiceCollection services)
        //{
        //    //var assembly = AppDomain.CurrentDomain.Lbugtrackerd("BugTracker.Service");
        //    services.AddMediatR(Assembly.GetExecutingAssembly());
        //}
        public static void AddVersion(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            });
        }
        //public static void AddHealthCheck(this IServiceCollection serviceCollection, IConfiguration configuration)
        //{
        //    serviceCollection.AddHealthChecks()
        //         //.AddDbContextCheck<ApplicationDbContext>(name: "Application DB Context", failureStatus: HealthStatus.Degraded)
        //         .AddUrlGroup(new Uri("https://musa-zulu.github.io/mypage/"), name: "My personal website", failureStatus: HealthStatus.Degraded)
        //         .AddSqlServer(configuration.GetConnectionString("BugTrackerConn"));
        //    //.AddSqlServer(configuration.GetConnectionString("IdentityConnection"));

        //    serviceCollection.AddHealthChecksUI(setupSettings: setup =>
        //    {
        //        setup.AddHealthCheckEndpoint("Basic Health Check", $"http://localhost:44356/healthz");
        //    });
        //}

    }
}
