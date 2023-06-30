using BlazorAppWithDatabase.Data;
using BlazorAppWithDatabase.Data.Database;
using BlazorAppWithDatabase.Data.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddTransient<IPubService, PubService>();
builder.Services.AddDbContext<PubContext>(options => options.UseSqlServer(builder.Configuration["conn"]),ServiceLifetime.Transient);

var app = builder.Build();

//Seed Db
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    Seed.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
