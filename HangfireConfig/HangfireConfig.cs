public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<SalesDbContext>(options => options.UseSqlServer(ConfigurationManager.ConnectionStrings["ECommerceDatabase"].ConnectionString));
    services.AddHangfire(x => x.UseSqlServerStorage(ConfigurationManager.ConnectionStrings["ECommerceDatabase"].ConnectionString));
    services.AddHangfireServer();

    // Register CsvLoader as a service
    services.AddScoped<CsvLoader>();
}

public void Configure(IApplicationBuilder app, IBackgroundJobClient backgroundJobs)
{
    app.UseHangfireDashboard();
    app.UseHangfireServer();

    // Schedule a recurring job
    RecurringJob.AddOrUpdate<CsvLoader>(loader => loader.LoadDataAsync("D:/lumel_project/sample.csv"), Cron.Daily);
}
