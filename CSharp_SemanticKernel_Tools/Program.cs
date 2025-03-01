using dotnet_fun;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;

var modelId = "gpt-4o-mini";
var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");

var builder = Kernel.CreateBuilder().AddOpenAIChatCompletion(modelId, apiKey);
Kernel kernel = builder.Build();

kernel.Plugins.AddFromType<WeatherPlugin>("Weather");

OpenAIPromptExecutionSettings openAiPromptExecutionSettings = new() 
{
    FunctionChoiceBehavior = FunctionChoiceBehavior.Auto()
};

var chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();

ChatMessageContent result = await chatCompletionService.GetChatMessageContentAsync(
    "Is it a good day for a picnic in Jal, New Mexico?",
    executionSettings: openAiPromptExecutionSettings,
    kernel: kernel);

Console.WriteLine("Weather : " + result);
