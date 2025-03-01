# CSharp_SemanticKernel_Tools

This is an example of using Semantic Kernel in C# to submit a simple prompt
for generation.

Build it using your IDE (VisualStudio, Rider, etc) or at the command line with
the `dotnet` tool:

```
$ dotnet build
```

After building, the binary should be at `./bin/Debug/net9.0/CSharp_SemanticKernel_Basic`
(relative to the project root).

Before running it, make sure that you have the `OPENAI_API_KEY` environment
variable set to a valid OpenAI API key. Then run it like this to generate a joke:

```
$ ./bin/Debug/net9.0/CSharp_SemanticKernel_Basic
```

