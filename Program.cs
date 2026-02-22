using Microsoft.EntityFrameworkCore;
using Movie_Collection_App.Data;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Database Connection
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Step 3a: Add Controllers for both Views and Web API
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();

// 1. Enable Session and HttpContext Utilities
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

WebApplication app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

// 2. Activate Session (Must be before Authorization)
app.UseSession();
app.UseAuthorization();

// Step 3b: Map the API Controllers so routes like /api/MovieApi work
app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();