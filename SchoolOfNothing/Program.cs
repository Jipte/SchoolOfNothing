using BuildingManager.Repository.IoC;
using SchoolOfNothing.repository.Infrastructure;
using SchoolOfNothing.repository.Repositories.StudentRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IConnectionFactory,ConnectionFactory>();

builder.Services.AddRepository(builder.Configuration);

builder.Services.AddTransient<IStudentRepository,StudentRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
