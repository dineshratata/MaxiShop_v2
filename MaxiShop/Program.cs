using MaxiShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the containe

builder.Services.AddCors(Options => Options.AddPolicy("CustomPolicy", x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod() )

    );


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
app.UseCors();  

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
