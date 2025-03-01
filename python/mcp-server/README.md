# MCP Server (Python)

This is an example of a Python-based MCP Server.

Install the requirements with `pip`:

```
$ pip install -r requirements.txt
```

Add the "mcp[cli]" tool to your environment with:

```
$ pip install "mcp[cli]"
```

Then you can test the MCP Server in the MCP Inspector by issuing this command:

```
$ mcp dev server.py
```

This will start the MCP Inspector listening on port 5173. Open "http://localhost:5173"
in your web browser. The command and arguments fields should already be filled
with the details for the MCP Server. Click "Connect" and then "List Tools" to
see the available tools. Click on the "getWeather" tool, then enter a zipcode in
the zipcode field and click "Run Tool" to see the results.

You can also install the MCP Server into Claude Desktop using the `mcp` command line:

```
$ mcp install server.py
```

Then start Claude Desktop and ask about the weather with a question such as
"What is the weather in Denver?"
