using BlazorIncrementalApp.Components;
using BlazorIncrementalApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddSingleton<Points>();
builder.Services.AddSingleton<Buttons>();
builder.Services.AddSingleton<MoonPoints>();
builder.Services.AddSingleton<VenusPoints>();
builder.Services.AddSingleton<MindoorOres>();
builder.Services.AddSingleton<PersonalDetails>();
builder.Services.AddSingleton<UsePersonalDetails>();

builder.Services.AddDbContextFactory<OrderDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("OrderDb")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
