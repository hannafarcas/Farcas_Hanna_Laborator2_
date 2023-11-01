using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Farcas_Hanna_Laborator2.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Farcas_Hanna_Laborator2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Farcas_Hanna_Laborator2Context") ?? throw new InvalidOperationException("Connection string 'Farcas_Hanna_Laborator2Context' not found.")));

var app = builder.Build();

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
