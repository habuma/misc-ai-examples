using MCPSharp;

namespace WeatherMcp;

[McpTool("weather_tools", "Tools for getting weather information")]
public class WeatherTools
{
    [McpFunction("getWeather", "Gets the weather for a given zipcode")]
    public static Weather getWeather(string zipcode)
    {
        return new Weather("Cloudy and drizzly", "72.123F");
    }
}