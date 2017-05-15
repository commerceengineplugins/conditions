using Sitecore.Commerce.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plugin.Sample.Condition.Policies
{
    public class WeatherServiceClientPolicy : Policy
    {
        public WeatherServiceClientPolicy()
        {
            this.ApplicationId = string.Empty;
        }

        public string ApplicationId { get; set; }
    }
}
