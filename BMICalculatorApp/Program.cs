var builder = WebApplication.CreateBuilder(args); //Create Web Application Builder
builder.Services.AddControllersWithViews();//Register MVC Service

var app = builder.Build();//Build ASP.NET Core application

app.UseRouting();// Enables routing

// Defines the default route pattern for controller requests
// Sets BMI as the default controller and BMICalculator as the default action.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=BMI}/{action=BMICalculator}/{id?}");

app.Run();
