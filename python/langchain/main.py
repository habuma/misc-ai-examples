from flask import Flask, request, jsonify
from langchain_openai import ChatOpenAI

app = Flask(__name__)

@app.route("/")
def hello():
    return "hiya!"

@app.route("/ask", methods=['POST'])
def ask():
    content = request.get_json()
    print(content["question"])

    llm = ChatOpenAI()
    answer = llm.invoke(content["question"])
    response = {}
    response["answer"] = answer.content
    return response


if __name__ == "__main__":
    app.run(debug=True)