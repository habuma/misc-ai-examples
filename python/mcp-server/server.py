from mcp.server.fastmcp import FastMCP

mcp = FastMCP("Weather")

@mcp.tool()
def getWeather(zipcode):
    zipcode = str(zipcode) # coerce to a string
    """Get weather for a given zipcode"""
    return {"conditions":"Frozen mix", "temperature":"12F"}
