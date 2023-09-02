using Microsoft.EntityFrameworkCore;
using PlayGround.API.Data;
using PlayGround.API.Routes;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ApiDatabase");
builder.Services.AddSqlite<PlayGroundDbContext>(connectionString);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();



if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}


app.MapGet("/", ( ) => "API is alive.");
app.MapPosters();

app.UseHttpsRedirection();


app.Run();
