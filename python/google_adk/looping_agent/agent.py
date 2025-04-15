from google.adk.agents import Agent, LoopAgent

code_agent = Agent(
    name="code_agent",
    model="gemini-2.0-flash",
    description=(
        "Agent that writes Java code."
    ),
    instruction=(
        "You are a helpful agent who can write Java code to a user's specification."
    ),
)

review_agent = Agent(
    name="review_agent",
    model="gemini-2.0-flash",
    description=(
        "Agent that review Java code and provides improvement suggestions"
    ),
    instruction=(
        "You are a helpful agent who reviews Java code and provides suggestions for how to improve it."
    )
)

root_agent = LoopAgent(
    name="code_review_agent",
    description=(
        "Agent to create and review Java code."
    ),
    max_iterations=5,
    sub_agents=[code_agent, review_agent],
)

