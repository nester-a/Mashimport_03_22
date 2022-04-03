using Mashimport_03_22.Infrastucture.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddControllersWithViews();
builder.Services.AddContactsInfo();
builder.Services.AddMenuButtonsData();
builder.Services.AddLanguageChangerControllerComponent();

var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute("default", "{controller=Russian}/{action=About}/{id?}");

app.Run();
