using BlazorUI.Data;
using demoLibrary;
using demoLibrary.DataAccess;
using MediatR;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<IDataAccesss, DemoDataAccesss>();

//AS OUR Mediatr stuff was in demolibrary solution that why we have mentioned in here. if it was in Blazor UI then we just have to mention Startup/Program
//builder.Services.AddMediatR(typeof(DemoDataAccesss).Assembly);

//or create a new file in demolibaray solutoin like: DemoLibraryMediatREntryPoint
builder.Services.AddMediatR(typeof(DemoLibraryMediatREntryPoint).Assembly);

var app = builder.Build(); 

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
