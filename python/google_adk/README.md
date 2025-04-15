# Google Agent Development Kit

This directory contains (currently only one) example of using the Google
Development Kit.

The one agent defined is a looping agent that loops over two other agents to
create Java code to the specification of the user. The code agent writes the
code while the review agent suggests improvements. It will loop between these
two agents for up to 5 iterations.

## Setting up the project

First, create a virtual Python environment using the venv module:

```
$ python -m venv .venv
```

Next enable the virtual environment:

```
$ source .venv/bin/activate
```

Finally, install the required dependencies:

```
$ pip install -r requirements.txt
```

You are now ready to run the agent using the ADK's web interface.

## Running the agent

Fire up the web interface with the `adk` command line:

```
$ adk web
```

Then open your web browser to http://localhost:8000 and select "looping_agent"
from the dropdown at the top left of the screen.

Now ask it to write some Java code for you. For example: "Write a method that
translates English to Pig Latin".

Then sit back and watch.
