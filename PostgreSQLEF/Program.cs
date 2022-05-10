using PostgreSQLEF.Models.DB;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

//configuracion de la cadena de conexion a postgres
//builder.Services.AddDbContext<pruebaEFContext>(opciones => 
//    opciones.UsePostgreSQL(builder.Configuration.GetConnectionString("ConexionPostresql"))
//);
//************************
//builder.Services.AddEntityFrameworkNpgsql()
//    .AddDbContext<pruebaEFContext>(options => options.UseNpgsql("ConexionPostresql"));

//builder.Services.AddDbContext<pruebaEFContext>(optionsBuilder =>
//    optionsBuilder.UseNpgsql(connectionString: _config.GetConnectionString("ConexionPostresql"));
//);


//---------------configuracion de la cadena de conexion postgress
builder.Services.AddDbContext<pruebaEFContext>(opciones => 
    opciones.UseNpgsql(builder.Configuration.GetConnectionString("ConexionPostresql"))
);



// Add services to the container.
builder.Services.AddControllersWithViews();

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
