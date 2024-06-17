using Microsoft.EntityFrameworkCore;
using Siga_Hrms.Data.DataContext;
using Siga_Systems.HRMS.ApiService;

var builder = WebApplication.CreateBuilder(args);


var Sqlversion = new MySqlServerVersion(ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), Sqlversion);
});

ServiceCollectionExtenstion.AddService(builder.Services);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        options.AddPolicy("AllowOrigin",
         builder => builder.WithOrigins("http://localhost:5013")
             .AllowAnyHeader()
             .AllowAnyMethod()
             .AllowCredentials());
    });
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Cors Implemention
app.UseHttpsRedirection();
app.UseCors("AllowOrigin");
app.UseAuthorization();

app.MapControllers();

app.Run();