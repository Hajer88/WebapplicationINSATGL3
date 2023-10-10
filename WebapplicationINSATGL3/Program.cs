using Microsoft.EntityFrameworkCore;
using WebapplicationINSATGL3.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationdbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
//Map Customized Route
/*app.MapControllerRoute(name: "Movie",
                pattern: "Movie/{Release}/{year}/{month}",
                defaults: new { controller = "Movie", action = "ByReleaseDate" });*/
//Add a route without specifying any endpoint for annotations use
//app.MapControllers();
//Affecter MapController à un endpoint pour traiter le dispatch d'une manière
//précoce au niveau du middleware
//On peut facilement y accèder via HTTP Context ou IendpointFeature

//app.UseEndpoints(routes =>
//routes.MapControllers());

//Default Can be replaced by app.MapDefaultControllerroute()
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//un point de terminaison unique à l’aide de la méthode MapGet
//Le délégué de requête s’exécute.
//Hello World! est écrit dans la réponse HTTP.
//Si la méthode de requête n’est pas GET ou si l’URL racine n’est pas /,
//aucun routage ne correspond et un HTTP 404 est retourné.
//app.MapGet("/", () => "Hello World!");

app.Run();
