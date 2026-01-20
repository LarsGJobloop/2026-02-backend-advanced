var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var memories = new List<Memory>();

app.MapPost("/memory", (MemoryCreateRequest createRequest) =>
{
  var newMemory = new Memory
  {
    Id = 0,
    Content = createRequest.Content
  };
  memories.Add(newMemory);
  return newMemory;
});

app.MapGet("/memory/{memoryId}", (int memoryId) =>
{
  return memories.First(memory => memory.Id == memoryId);
});

app.MapGet("/healthz", () => "Ok");

app.Run();


class MemoryCreateRequest
{
  public required string Content { get; init; }
}

class Memory
{
  public required int Id { get; init; }
  public required string Content { get; init; }
}