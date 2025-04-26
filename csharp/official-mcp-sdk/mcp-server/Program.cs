using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ModelContextProtocol.Server;
using System.ComponentModel;
using mcp_server;

var builder = Host.CreateApplicationBuilder(args);
builder.Logging.AddConsole(consoleLogOptions =>
{
    // This only sort of works. Need to figure out how to keep
    // some initial logging output from being sent to stdout.
    // It is needed because this is an STDIO MCP Server and the
    // logging output is sent to the client and the client tries
    // (and fails) to interpret it as an MCP message.
    consoleLogOptions.LogToStandardErrorThreshold = LogLevel.Trace;
});
builder.Services
    .AddMcpServer()
    .WithStdioServerTransport()
    .WithToolsFromAssembly();
await builder.Build().RunAsync();

[McpServerToolType]
public static class WeatherTool
{
    [McpServerTool, Description("Get the current weather for a given zipcode.")]
    public static Weather GetWeather(string zipcode) => new Weather("Sunny", "75F");
}