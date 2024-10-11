using CINE_ACT2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor, incluyendo el DbContext
builder.Services.AddDbContext<CineDbAct2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") + ";TrustServerCertificate=True", sqlOptions =>
    {
        sqlOptions.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(30),
            errorNumbersToAdd: null);
    }));

// Agregar soporte para Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// Configurar el pipeline de la aplicación
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();