# CSharp-MCP-Server

This is an example of how to create an MCP Server that implements the STDIO transport
in C# using the MCPSharp library.

You can build it using your IDE (e.g., VisualStudio, Rider, etc) or using the
`dotnet` command line:

```
$ dotnet build
```

After building it, the binary should be in `./bin/Debug/net9.0` (relative to the
project root). You can then try it out using the [MCP Inspector](https://modelcontextprotocol.io/docs/tools/inspector)
or by installing it into a client such as Claude Desktop.

For example, the configuration for enabling it in Claude Desktop looks a little
something like this:

```
{
  "mcpServers": {
    "weather": {
      "command": "/path/to/project/CSharp-MCP-Server/bin/Debug/net9.0/CSharp-MCP-Server",
      "args": []
    }
  }
}
```

(Adjust the path in the "command" property accordingly for your project's location.)

Once you've added the configuration and have restarted Claude Desktop, you can
ask it questions such as "What is the weather in Jal, New Mexico?". Because the
MCP Server is hard-coded to always return the same weather conditions, Claude
should tell you that it's cloudy and drizzly with a temperature of 72F.
