using BusinessLayer.Abstract._1_SiteAreaServices;
using BusinessLayer.Abstract._2_AdminAreaServices;
using BusinessLayer.Concrete._1_SiteAreaManagers;
using BusinessLayer.Concrete._2_AdminManagers;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region Eklenen Servisler

builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<ICourseCategoryService, CourseCategoryManager>();
builder.Services.AddScoped<ICourseCategoryDal, EfCourseCategoryDal>();
builder.Services.AddScoped<ICoursesService, CoursesManager>();
builder.Services.AddScoped<ICoursesDal, EfCoursesDal>();
builder.Services.AddScoped<IInstructorService, InstructorManager>();
builder.Services.AddScoped<IInstructorDal, EfInstructorDal>();
builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDal, EfContactDal>();
#endregion



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
