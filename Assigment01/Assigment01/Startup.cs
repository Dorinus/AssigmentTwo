using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FileData;
using Microsoft.AspNetCore.Components.Authorization;
using Models;

namespace Assigment01
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<FileContext>();
            services.AddScoped<IUserService, InMemoryUserService>();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

            services.AddAuthorization(options =>
            {
                
                options.AddPolicy("LogedIn", a => a.RequireAuthenticatedUser().RequireClaim("Level", "2","1","3"));
                options.AddPolicy("Moderator", a => a.RequireAuthenticatedUser().RequireClaim("Role", "admin","moderator"));
                options.AddPolicy("Admin", a => a.RequireAuthenticatedUser().RequireClaim("Role", "admin"));
                options.AddPolicy("Test", a => a.RequireAuthenticatedUser().RequireAssertion(context =>
                {
                    Claim levelClaim = context.User.FindFirst(claim => claim.Type.Equals("Level"));
                    if (levelClaim == null) return false;
                    return int.Parse(levelClaim.Value) > 0;
                }));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}