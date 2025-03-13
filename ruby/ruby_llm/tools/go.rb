require 'ruby_llm'
require_relative 'WeatherTools'

RubyLLM.configure do |config|
    config.openai_api_key = ENV['OPENAI_API_KEY']
    config.default_model = 'gpt-4o-mini'
end


chat = RubyLLM.chat
chat.with_tool(WeatherTools)
response = chat.ask "What's the weather in Denver?"
puts response.content