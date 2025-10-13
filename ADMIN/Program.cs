using ADMIN.Components;
using ADMIN.Service;
using ADMIN.Service.IService;
using API.HeThong;
using System.Security.Policy;

var builder = WebApplication.CreateBuilder(args);
string url = "https://localhost:7268/api/";

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddHttpClient<IService, Service>(client =>
{
    client.BaseAddress = new Uri(url);
});

builder.Services.AddScoped<XulyId>();

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
