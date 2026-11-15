var builder = WebApplication.CreateBuilder(args); //Create Web Application Builder
builder.Services.AddControllersWithViews();//Register MVC Service
var app = builder.Build();//Build ASP.NET Core application
app.UseRouting();// Enables routing
app.MapControllerRoute( //Defines the default route pattern for controller requests

name: "default",
    pattern: "{controller=Grade}/{action=Index}/{id?}");// •  Sets Home as the default controller and BMICalculator as the default action.
app.Run();