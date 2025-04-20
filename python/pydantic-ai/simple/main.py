from flask import Flask, request, jsonify
from pydantic_ai import Agent

app = Flask(__name__)

agent = Agent(
    "gpt-4o-mini",
    system_prompt="""
        You are a helpful info-providing assistant who answers all questions 
        briefly in no more than one sentence.""",
)


@app.route('/ask', methods=['POST'])
def ask():
    content = request.get_json()
    response = agent.run_sync(content["question"])
    return response.output

if __name__ == '__main__':
    app.run(debug=True)