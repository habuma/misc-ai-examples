require 'ruby_llm'

Weather = Data.define(:conditions, :temperature)

class WeatherTools < RubyLLM::Tool
    description "Gets the weather for a given zipcode"

    param :zipcode,
        type: :string,
        desc: "The zipcode to get the weather for"

    def execute(zipcode:)
        Weather.new("Partly cloudy", "71F")
    end
end