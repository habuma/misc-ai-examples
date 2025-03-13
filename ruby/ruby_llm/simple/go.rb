require 'ruby_llm'

RubyLLM.configure do |config|
    config.openai_api_key = ENV['OPENAI_API_KEY']
    config.default_model = 'gpt-4o-mini'
end


chat = RubyLLM.chat
response = chat.ask "Tell me a joke"
puts response.content
