# Sample Condition (qualification) for Commerce Engine

#### *This sample project was presented at SUGCON 2017. It shows how you can create a new condition (or qualification) you can use in promotions in Sitecore Commerce 8.2.1 and later.* ####

This condition returns true when the current temperature in the city you specify is above the temperature you specify, otherwise it returns false.

The user of the promotion can specify three parameters:

* **Minimum temperature**  
If the current temperature in the city you specify is above this value, the condition returns true.
* **City**  
The city you want to retrieve the temperature for.
* **Country**  
The country code for the specified city.

The project uses two Commerce Engine concepts: Conditions and Policies.

## Where to get weather information?
The sample uses the [OpenWeatherMap API](https://openweathermap.org/api) which supplies current weather information. They have a free plan which is excellent to use for this sample. You need an API key to use their current weather API. Create a free account and generate an API key.

## MinTemperatureCondition
The class _MinTemperatureCondition_ implements three interfaces: _ICartsCondition_, _ICondition_ and _IMappableRuleEntity_. Commerce Engine automatically adds the condition to the UI based on these interfaces.

## WeatherServiceClientPolicy



  


