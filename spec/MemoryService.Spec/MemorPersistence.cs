using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Testing;

namespace MemoryService.Spec;

class MemoryCreateRequest
{
  public required string Content { get; init; }
}

class Memory
{
  public required int Id { get; init; }
  public required string Content { get; init; }
}

public class MemorPersistence
    : IClassFixture<WebApplicationFactory<Program>>
{
  private readonly WebApplicationFactory<Program> _factory;

  public MemorPersistence(WebApplicationFactory<Program> factory)
  {
    _factory = factory;
  }

  [Fact]
  public async Task AsIClient_WhenIStoreAMemory_ICanRetriveItLater()
  {
    // As a client
    var client = _factory.CreateClient();
    // with a new memory
    var memory = new MemoryCreateRequest { Content = "My memory" };

    // When I store the memory
    var response = await client.PostAsJsonAsync("/memory", memory);
    // It's a success
    response.EnsureSuccessStatusCode();
    var parsedRespons = await response.Content.ReadFromJsonAsync<Memory>();
    Assert.NotNull(parsedRespons);

    // And I try to retrieve it
    var retrieveResponse = await client.GetFromJsonAsync<Memory>($"/memory/{parsedRespons.Id}");

    // Then the memeroy is not null
    Assert.NotNull(retrieveResponse);
    // And the memory is the same
    Assert.Equal(memory.Content, retrieveResponse.Content);
  }
}