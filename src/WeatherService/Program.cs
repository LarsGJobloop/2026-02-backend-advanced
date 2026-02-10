using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Configure Authorization
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false, // Validate the server that issues the token
            ValidateIssuerSigningKey = false, // Validate the signing key
            ValidIssuer = "zitadel.localhost", // Is this Norge/USA/China

            ValidateAudience = false, // Validate the recipient of the token
            ValidAudience = "api.localhost", // This is us
            ValidateLifetime = false, // Check if the token is expired
        };
    });
// Add Authorization to the App
builder.Services.AddAuthorization();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// We dont hava a TLS certificate
// app.UseHttpsRedirection();

// Actually use Authorization
app.UseAuthorization();

app.MapControllers();

app.Run();
