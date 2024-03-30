using infnetMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// banco de dados configuração 
builder.Services.AddDbContext<InfnetDbContexto>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("defaultDb"));
});

// Aqui estou adicionando o controle de ususarios de identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<InfnetDbContexto>();


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

app.UseAuthentication(); // estou dizendo que vou utilizar autentificação
app.UseAuthorization();

// Configurar a rota padrão 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Funcionarios}/{action=Index}/{id?}");

app.Run();
