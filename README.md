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
The class `MinTemperatureCondition` implements three interfaces: `ICartsCondition`, `ICondition` and `IMappableRuleEntity`. Commerce Engine automatically adds the condition to the UI based on these interfaces.

## WeatherServiceClientPolicy
You need to supply the engine with the correct API key so the `WeatherService` class can access the OpenWeatherMap API. Of course, you don't want to hard-code this key. 

You can use a policy to configure the API Key for each environment. The `WeatherServiceClientPolicy` is a simple class derived from `Policy`. It contains one property `ApplicationId` that contains the API key you get from OpenWeatherMap.

To configure a Commerce environment, add the following JSON to the environment file:

	{
        "$type": "Plugin.Sample.Condition.Policies.WeatherServiceClientPolicy, Plugin.Sample.Condition",
        "ApplicationId": "<your application id>"
   	}


  


