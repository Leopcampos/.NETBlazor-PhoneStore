using Microsoft.EntityFrameworkCore;
using PhoneShop.Api.Data;
using PhoneShop.Api.Repositories;
using PhoneShop.ShareLibrary.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Adicionando o Blazor

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

#endregion

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") 
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));

builder.Services.AddScoped<IProduct, ProductRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseWebAssemblyDebugging(); //Adicionado
}

app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles(); //Adicionadov
app.UseStaticFiles();//Adicionado
app.UseAuthorization();

app.MapRazorPages();//Adicionado
app.MapControllers();
app.MapControllers();
app.MapFallbackToFile("index.html");//Adicionado

app.Run();