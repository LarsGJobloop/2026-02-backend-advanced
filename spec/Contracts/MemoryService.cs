namespace Contracts;

public class MemoryCreateRequest
{
  public required string Content { get; init; }
}

public class Memory
{
  public required int Id { get; init; }
  public required string Content { get; init; }
}