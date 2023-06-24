using LogicServices.Data;
using LogicServices.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<DataService>();
try
{
    builder.Services.AddDbContext<DataContext>(db=>
    {
        db.UseMySql(builder.Configuration.GetConnectionString("Default") ,new MySqlServerVersion(new Version(10, 1, 40)));
        // .EnableSensitiveDataLogging()
        //         .EnableDetailedErrors();
    }); 
}
catch (System.Exception)
{
    throw;
}
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.MapControllers();

app.Run();
