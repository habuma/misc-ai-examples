# Langchain Example (Python)

This is a simple example of using LangChain in Python. Additionally, it uses
Flask to expose a simple REST API.

Install the requirements with `pip`:

```
$ pip install -r requirements.txt
```

Make sure that you have set the `OPENAI_API_KEY` environment variable to a valid
OpenAI API key. Then you can run the application:

```
$ python main.py
```

This will start a server listening on port 5000. Note that on MacOS machines,
port 5000 may already be taken by the AirPlay Receiver. You can either display
AirPlay Receiver or change the port by editing `main.py` and changing the final
line to:

```
    app.run(debug=True, port=5001)  
```

This results in the server listening on port 5001.

Once the application starts up, you can make a request to the server to ask
it a question like this (using `curl`):

```
$ curl localhost:5000/ask -H"Content-type: application/json" -d'{"question":"Why is the sky blue?"}'
```

Or if using HTTPie:

```
$ http :5000/ask question="Why is the sky blue?"
```
