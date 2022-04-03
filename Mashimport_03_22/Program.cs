using Mashimport_03_22.Infrastucture.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddControllersWithViews();
builder.Services.AddContacts();
builder.Services.AddMenuData();
builder.Services.AddLanguageChanger();

var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute("default", "{controller=Russian}/{action=About}/{id?}");

app.Run();
