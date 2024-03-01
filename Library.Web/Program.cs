//api den önce appsettings.json doyasýna istek atacaðýmýz url yi þu þekil ekledik :"BaseUrl": "https://localhost:7223/api",
using FluentValidation;
using FluentValidation.AspNetCore;
using Library.Web.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<Program>();

builder.Services.AddHttpClient<BookApiService>(opt => opt.BaseAddress = new Uri(builder.Configuration["BaseUrl"]));
builder.Services.AddHttpClient<CategoryApiService>(opt => opt.BaseAddress = new Uri(builder.Configuration["BaseUrl"]));
builder.Services.AddHttpClient<AuthorApiService>(opt => opt.BaseAddress = new Uri(builder.Configuration["BaseUrl"]));
builder.Services.AddHttpClient<ShelfApiService>(opt => opt.BaseAddress = new Uri(builder.Configuration["BaseUrl"]));
builder.Services.AddHttpClient<CountryApiService>(opt => opt.BaseAddress = new Uri(builder.Configuration["BaseUrl"]));
builder.Services.AddHttpClient<LanguageApiService>(opt => opt.BaseAddress = new Uri(builder.Configuration["BaseUrl"]));
builder.Services.AddHttpClient<TransactionApiService>(opt => opt.BaseAddress = new Uri(builder.Configuration["BaseUrl"]));
builder.Services.AddHttpClient<PublisherApiService>(opt => opt.BaseAddress = new Uri(builder.Configuration["BaseUrl"]));
builder.Services.AddHttpClient<UserApiService>(opt => opt.BaseAddress = new Uri(builder.Configuration["BaseUrl"]));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapAreaControllerRoute(name: "Admin", areaName: "Admin", pattern: "Admin/{controller=Book}/{action=Dashboard}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
