using System.ComponentModel;
using Microsoft.SemanticKernel;

namespace dotnet_fun;

public class WeatherPlugin
{
    [KernelFunction("getWeather")]
    [Description("Gets the weather for a given zipcode")]
    public Weather getWeather(string zipcode)
    {
        return new Weather("Sunny with rain later in the day", "77.3F");
    }
}