﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using DisplayService.Extensions;
using OpenWeatherMap.Models;
using WeatherDisplay.Resources;

namespace OpenWeatherMap
{
    public class HighContrastWeatherIconMapping : IWeatherIconMapping
    {
        private readonly IDictionary<int, Func<Stream>> iconMapping;

        public HighContrastWeatherIconMapping()
        {
            this.iconMapping = new Dictionary<int, Func<Stream>>
            {
                // Group 2xx: Thunderstorm
                { 200, /* thunderstorm with light rain*/ () => Icons.ThunderstormWithRain() },
                { 201, /* thunderstorm with rain*/ () => Icons.ThunderstormWithRain() },
                { 202, /* thunderstorm with heavy rain*/ () => Icons.ThunderstormWithRain() },
                { 210, /* light thunderstorm*/ () => Icons.Thunderstorm() },
                { 211, /* thunderstorm*/ () => Icons.Thunderstorm() },
                { 212, /* heavy thunderstorm*/ () => Icons.Thunderstorm() },
                { 221, /* ragged thunderstorm*/ () => Icons.Thunderstorm() },
                { 230, /* thunderstorm with light drizzle*/ () => Icons.ThunderstormWithRain() },
                { 231, /* thunderstorm with drizzle*/ () => Icons.ThunderstormWithRain() },
                { 232, /* thunderstorm with heavy drizzle*/ () => Icons.ThunderstormWithRain() },

                // Group 3xx: Drizzle
                { 300, /* light intensity drizzle*/ () => Icons.RainLight() },
                { 301, /* drizzle*/ () => Icons.Rain() },
                { 302, /* heavy intensity drizzle*/ () => Icons.RainHeavy() },
                { 310, /* light intensity drizzle rain*/ () => Icons.RainLight() },
                { 311, /* drizzle rain*/ () => Icons.Rain() },
                { 312, /* heavy intensity drizzle rain*/ () => Icons.RainHeavy() },
                { 313, /* shower rain and drizzle*/ () => Icons.Rain() },
                { 314, /* heavy shower rain and drizzle*/ () => Icons.RainHeavy() },
                { 321, /* shower drizzle*/ () => Icons.RainLight() },
                    
                // Group 5xx: Rain
                { 500, /* light rain*/ () => Icons.RainLightDay() },
                { 501, /* moderate rain */ () => Icons.Rain() },
                { 502, /* heavy intensity rain  */ () => Icons.RainHeavy() },
                { 503, /* very heavy rain   */ () => Icons.RainHeavy() },
                { 504, /* extreme rain  */ () => Icons.RainHeavy() },
                { 511, /* freezing rain */ () => Icons.RainHeavy() },
                { 520, /* light intensity shower rain*/ () => Icons.RainLight() },
                { 521, /* shower rain*/ () => Icons.RainHeavy() },
                { 522, /* heavy intensity shower rain*/ () => Icons.RainHeavy() },
                { 531, /* ragged shower rain*/ () => Icons.RainHeavy() },
                    
                // Group 6xx: Snow
                { 600, /* light snow*/ () => Icons.SnowLight() },
                { 601, /* Snow  */ () => Icons.Snow() },
                { 602, /* Heavy snow*/ () => Icons.SnowHeavy() },
                { 611, /* Sleet */ () => Icons.SnowRain() },
                { 612, /* Light shower sleet*/ () => Icons.SnowRain() },
                { 613, /* Shower sleet  */ () => Icons.SnowRain() },
                { 615, /* Light rain and snow   */ () => Icons.SnowRain() },
                { 616, /* Rain and snow */ () => Icons.SnowRain() },
                { 620, /* Light shower snow */ () => Icons.SnowLight() },
                { 621, /* Shower snow   */ () => Icons.Snow() },
                { 622, /* Heavy shower snow */ () => Icons.SnowHeavy() },
                   
                // Group 7xx: Atmosphere
                { 701, /* Mist */ () => Icons.Mist() },
                { 711, /* Smoke */ () => Icons.Fog() },
                { 721, /* Haze */ () => Icons.Fog() },
                { 731, /* Dust sand/ dust whirls*/ () => Icons.Fog() },
                { 741, /* Fog */ () => Icons.Fog() },
                { 751, /* Sand */ () => Icons.Fog() },
                { 761, /* Dust */ () => Icons.Fog() },
                { 762, /* Volcanic ash */ () => Icons.Fog() },
                { 771, /* Squall squalls*/ () => Icons.Wind() },
                { 781, /* Tornado */ () => Icons.Tornado() },

                // Group 800: Clear
                { 800, /* clear sky */ () => Icons.Sun() },

                // Group 80x: Clouds
                { 801, /* few clouds: 11-25% */ () => Icons.Clouds1() },
                { 802, /* scattered clouds: 25-50% */ () => Icons.Clouds2() },
                { 803, /* broken clouds: 51-84% */ () => Icons.Clouds3() },
                { 804, /* overcast clouds: 85-100% */ () => Icons.Clouds4() },
            };
        }

        public Task<Stream> GetIconAsync(WeatherCondition weatherCondition)
        {
            Stream selectedImageStream;

            if (this.iconMapping.TryGetValue(weatherCondition.Id, out var imageFactory))
            {
                selectedImageStream = imageFactory();
            }
            else
            {
                selectedImageStream = Icons.Placeholder();
            }

            return Task.FromResult(selectedImageStream.Rewind());
        }
    }
}