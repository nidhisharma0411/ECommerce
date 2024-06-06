using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers(); 
        services.AddMvc(options =>
        {
            // Configure options if necessary
        }).SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Latest);
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage(); // Enables the developer exception page in development environment
        }
        else
        {
            app.UseExceptionHandler("/Home/Error"); // Configures exception handling middleware in production environment
            app.UseHsts();
        }

        app.UseHttpsRedirection(); // Redirects HTTP requests to HTTPS
        app.UseStaticFiles(); // Enables static file serving

        app.UseRouting(); // Adds routing middleware to the pipeline

        app.UseAuthentication(); // Enables authentication
        app.UseAuthorization(); // Enables authorization

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
