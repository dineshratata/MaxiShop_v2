using MaxiShop_Infrastructure.DbContexts;
using MaxiShop_Infrastructure;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MaxiShop_Infrastructure.Repositories;

using MaxiShop;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container

builder.Services.AddInfraStuctureServices();


builder.Services.AddCors(
    options => options.AddPolicy("CustomPolicy", x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));




builder.Services.AddDbContext<ApplicationDbContext>(options => {
    options.UseSqlServer(builder.Configuration.
    GetConnectionString("MaxiShopConnection"))
    
    ;
});



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region DatabaseConnectivity

builder.Services.AddDbContext<ApplicationDbContext>(options => options.
UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
 
app.UseCors("CustomPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
