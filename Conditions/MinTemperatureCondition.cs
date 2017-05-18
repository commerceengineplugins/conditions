using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Sitecore.Commerce.Core;
using Sitecore.Framework.Rules;
using Sitecore.Commerce.Plugin.Carts;
using Plugin.Sample.Condition.Services;
using Plugin.Sample.Condition.Policies;

namespace Plugin.Sample.Condition.Conditions
{
    [EntityIdentifier("MinTemperatureCondition")]
    public class MinTemperatureCondition : ICartsCondition, ICondition, IMappableRuleEntity 
    {
        public IRuleValue<Decimal> MinimumTemperature { get; set; }
        public IRuleValue<String> City { get; set; }
        public IRuleValue<String> Country { get; set; }

        public bool Evaluate(IRuleExecutionContext context)
        {
            var minimumTemperature = MinimumTemperature.Yield(context);
            var city = City.Yield(context);
            var country = Country.Yield(context);

            CommerceContext commerceContext = context.Fact<CommerceContext>((string)null);
            var weatherServicePolicy = commerceContext.GetPolicy<WeatherServiceClientPolicy>();

            var currentTemperature = GetCurrentTemperature(city, country, weatherServicePolicy.ApplicationId);

            return currentTemperature > minimumTemperature;
        }

        public decimal GetCurrentTemperature(string city, string country, string applicationId)
        {
            WeatherService weatherService = new WeatherService(applicationId);
            var temperature = weatherService.GetCurrentTemperature(city, country).Result;

            return (decimal) temperature.Max;
        }
    }
}
