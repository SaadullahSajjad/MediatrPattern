using demoLibrary;
using demoLibrary.DataAccess;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IDataAccesss, DemoDataAccesss>();

//AS OUR Mediatr stuff was in demolibrary solution that why we have mentioned in here. if it was in Blazor UI then we just have to mention Startup/Program
//builder.Services.AddMediatR(typeof(DemoDataAccesss).Assembly);

//or create a new file in demolibaray solutoin like: DemoLibraryMediatREntryPoint
builder.Services.AddMediatR(typeof(DemoLibraryMediatREntryPoint).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
