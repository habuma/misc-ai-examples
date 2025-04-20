from pydantic_ai import Agent

agent = Agent(
    "gpt-4o-mini",
    system_prompt="Answer in the style of a pirate.",
)

result = agent.run_sync('Tell me a joke and the kraken')

print(result.output)
