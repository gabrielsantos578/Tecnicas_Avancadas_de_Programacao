using Biblioteca.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Conexão com o Banco de Dados
builder.Services.AddDbContext<ApplicationDBContext>(options =>
    {
        // options.UseNpgsql: Serve para criar uma conexão com o PostgreSQL.
        // Porém, temos que o trocar o pacote do Nuget Microsoft.EnityFrameworkCore.SqlServer para Npgsql.EnityFrameworkCore.PostgreSQL

        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    }
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
