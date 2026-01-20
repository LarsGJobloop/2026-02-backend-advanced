using Microsoft.AspNetCore.Mvc.Testing;

namespace MemoryService.Spec;

public class HealthProbe
    : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public HealthProbe(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task What_To_Test_First()
    {
        // As a client
        var client = _factory.CreateClient();

        // When I try to probe the health endpoint
        var response = await client.GetAsync("/healthz");

        // The server responds with a success status code
        response.EnsureSuccessStatusCode();
    }
}