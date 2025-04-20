# Pydantic AI Example (Python)

This is a simple example of using Pydantic AI in Python.

Initialize the project using the venv module:

```
$ python -m venv .venv
$ source .venv/bin/activate
```

Then install the requirements with `pip`:

```
$ pip install 'pydantic_ai[openai]'
```

Make sure that you have set the `OPENAI_API_KEY` environment 
variable to a valid OpenAI API key. Then you can run the 
application:

```
$ python main.py
```

This will create a simple agent instructed to talk like a pirate.
Then it will invoke the agent, asking it to tell a joke about the
Kraken. (No guarantees that it will be a funny joke.)