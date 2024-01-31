using Business.DependcyResolvers;
using Core.CrossCuttingConcerns.Exceptions;

//var builder = WebApplication.CreateBuilder(args);
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
// Add services to the container.

//Add services

builder.Services.AddBusinessServices(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//if (app.Environment.IsProduction())
app.UseGlobalExceptionHandling();


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
