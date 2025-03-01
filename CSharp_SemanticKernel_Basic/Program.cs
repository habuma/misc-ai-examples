using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;

var modelId = "gpt-4o-mini";
var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");

var builder = Kernel.CreateBuilder().AddOpenAIChatCompletion(modelId, apiKey);
Kernel kernel = builder.Build();

var chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();

ChatMessageContent result = await chatCompletionService.GetChatMessageContentAsync(
    "Tell me a joke.", 
    kernel: kernel);

Console.WriteLine("Joke : " + result);
