
using Microsoft.EntityFrameworkCore;
using PlanningProject.Data;
using PlanningProject.Hubs;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddHttpClient(); // Add HttpClient service
builder.Services.AddControllers();
builder.Services.AddSignalR();
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllersWithViews();
// Add Controllers service

builder.Services.AddHttpClient(); // Add HttpClient service
builder.Services.AddControllers();
builder.Services.AddSignalR();
builder.Services.AddHttpContextAccessor();
// Add Controllers service


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.MapGet("/", context =>
{
    context.Response.Redirect("/Login");
    return Task.CompletedTask;
});


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.UseAuthorization();
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);
app.MapHub<PlanningHub>("/planningHub");
app.MapHub<PokerHub>("/pokerHub");

app.Run();
