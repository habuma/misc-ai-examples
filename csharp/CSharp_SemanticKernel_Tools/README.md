# CSharp_SemanticKernel_Tools

This is an example of using tools with Semantic Kernel in C#.

Build it using your IDE (VisualStudio, Rider, etc) or at the command line with
the `dotnet` tool:

```
$ dotnet build
```

After building, the binary should be at `./bin/Debug/net9.0/CSharp_SemanticKernel_Tools`
(relative to the project root).

Before running it, make sure that you have the `OPENAI_API_KEY` environment
variable set to a valid OpenAI API key. Then run it like this to get the weather
conditions for Jal, New Mexico:

```
$ ./bin/Debug/net9.0/CSharp_SemanticKernel_Tools
```

The weather plugin is hardcoded to always return "Sunny with rain later in the day"
and "77.3F".
