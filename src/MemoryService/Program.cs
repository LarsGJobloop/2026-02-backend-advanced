using Contracts;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MemoriesContext>();

var app = builder.Build();

app.MapPost("/memory", (MemoriesContext context, MemoryCreateRequest createRequest) =>
{
  // Create new memory
  var newMemory = new UserMemory
  {
    Id = Guid.NewGuid(),
    Content = createRequest.Content,
  };
  // Persist memeory
  context.Memories.Add(newMemory);
  context.SaveChanges();
  // Possibly return memory
  return newMemory;
});

app.MapGet("/memory", (MemoriesContext context) =>
{
  return context.Memories.ToList();
});

app.MapGet("/memory/{memoryId}", (MemoriesContext context, Guid memoryId) =>
{
  // Find the memeory
  var result = context.Memories.Find(memoryId);

  // Return
  if (result == null)
  {
    return Results.NotFound();
  }
  else
  {
    return Results.Ok(result);
  }
});

app.MapGet("/healthz", () => "Ok");

app.Run();