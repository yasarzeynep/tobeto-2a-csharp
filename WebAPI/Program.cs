using Business.DependcyResolvers;
using Core.CrossCuttingConcerns.Exceptions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

//var builder = WebApplication.CreateBuilder(args);
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
// Add services to the container.

//Add services

builder.Services.AddBusinessServices(builder.Configuration);
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

Core.Utilities.Security.JWT.TokenOptions? tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<Core.Utilities.Security.JWT.TokenOptions>();
builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuer = true, // Issuer'� validate etmeli mi?
            ValidateAudience = true,// Audience'� validate etmeli mi?
            ValidateLifetime = true, // S�reyi validate etmeli mi?
            ValidateIssuerSigningKey = true, // Security key validate etmeli mi?
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOptions.SecurityKey)), // Valid security key de�eri
            ValidIssuer = tokenOptions.Issuer,// Valid Issuer de�eri
            ValidAudience = tokenOptions.Audience,// Valid Audience de�eri
        };
    });

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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
