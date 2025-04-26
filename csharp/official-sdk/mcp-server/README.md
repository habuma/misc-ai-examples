# MCP Server (Official C# SDK)

This is an example of how to create an MCP Server that implements the STDIO transport
in C# using the [official C# SDK](https://github.com/modelcontextprotocol/csharp-sdk).

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
      "command": "/path/to/project/mcp-server/bin/Debug/net9.0/mcp-server",
      "args": [
        ">",
        "/dev/null"
      ]
    }
  }
}
```

(Adjust the path in the "command" property accordingly for your project's location.)

Once you've added the configuration and have restarted Claude Desktop, you can
ask it questions such as "What is the weather in Jal, New Mexico?". Because the
MCP Server is hard-coded to always return the same weather conditions, Claude
should tell you that it's cloudy and drizzly with a temperature of 72F.

## About logging and STDIO

Note that the above configuration is for Unix-like systems. The "args" provide
a way to redirect the standard output of the server to `/dev/null`, to avoid sending
some initial logging to the client. Even though, it's sending that to `/dev/null`,
it still seems to work for MCP messages over STDIO (although, TBH, I don't know why).

There is some code in `Program.cs` that attempts to send all logging to STDERR, so
that the client won't interpret it as MCP messages. But for some reason there are
still a few items emitted to STDIO as the server starts, which confuses Claude
Desktop. If you know how to stop those messages from being sent to STDIO, please
let me know.

