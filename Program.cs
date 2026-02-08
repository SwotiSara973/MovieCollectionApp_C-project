using Microsoft.EntityFrameworkCore;
using Movie_Collection_App.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. DATABASE REGISTRATION
// This tells the app to use our ApplicationDbContext and connects it to SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// This adds the "brain" of the app (Controllers) and the "face" (Views) to the project
builder.Services.AddControllersWithViews();

var app = builder.Build();

// This part handles errors. If the app crashes, it shows a friendly error page
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// These lines are like the "traffic police" for the website
app.UseHttpsRedirection(); // Makes the site secure
app.UseStaticFiles();      // Allows the app to show images and CSS files
app.UseRouting();          // Helps the app find the right page when you click a link

app.UseAuthorization();    // Checks if the user has permission to see things

// This defines the "Default" page. 
// It tells the app to start with the Home Controller and the Index page first.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// This officially starts the application
app.Run();