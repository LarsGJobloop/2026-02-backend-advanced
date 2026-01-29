using Microsoft.EntityFrameworkCore;
using Contracts;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MemoriesContext>();

var app = builder.Build();

app.MapPost("/memory", (MemoriesContext context, MemoryCreateRequest createRequest) =>
{
  // Create new memory 
  // Persist memeory
  // Possibly return memory
});

app.MapGet("/memory/{memoryId}", (MemoriesContext context, int memoryId) =>
{
  // Find the memeory
  // Return
});

app.MapGet("/healthz", () => "Ok");

app.Run();