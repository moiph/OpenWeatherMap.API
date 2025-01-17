﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using OpenWeatherMap.Models.Converters;

namespace OpenWeatherMap.Models
{
    public class DailyWeatherForecast
    {
        public DailyWeatherForecast()
        {
            this.Weather = new List<WeatherCondition>();
        }

        [JsonProperty("dt")]
        [JsonConverter(typeof(EpochDateTimeConverter))]
        public DateTime DateTime { get; set; }

        [JsonProperty("sunrise")]
        [JsonConverter(typeof(EpochDateTimeConverter))]
        public DateTime Sunrise { get; set; }

        [JsonProperty("sunset")]
        [JsonConverter(typeof(EpochDateTimeConverter))]
        public DateTime Sunset { get; set; }

        [JsonProperty("moonrise")]
        [JsonConverter(typeof(EpochDateTimeConverter))]
        public DateTime Moonrise { get; set; }

        [JsonProperty("moonset")]
        [JsonConverter(typeof(EpochDateTimeConverter))]
        public DateTime Moonset { get; set; }

        [JsonProperty("moon_phase")]
        public double MoonPhase { get; set; }

        [JsonProperty("temp")]
        public DailyTemperatureForecast Temperature { get; set; }

        [JsonProperty("feels_like")]
        public DailyFeelsLikeForecast FeelsLike { get; set; }

        /// <summary>
        ///  Atmospheric pressure on the sea level, hPa.
        /// </summary>
        [JsonProperty("pressure")]
        [JsonConverter(typeof(PressureJsonConverter))]
        public Pressure Pressure { get; set; }

        [JsonProperty("humidity")]
        [JsonConverter(typeof(HumidityJsonConverter))]
        public Humidity Humidity { get; set; }

        [JsonProperty("dew_point")]
        public Temperature DewPoint { get; set; }

        /// <summary>
        /// The maximum value of UV index for the day.
        /// </summary>
        [JsonProperty("uvi")]
        [JsonConverter(typeof(UVIndexJsonConverter))]
        public UVIndex UVIndex { get; set; }

        [JsonProperty("clouds")]
        public int Clouds { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonProperty("wind_deg")]
        public int WindDirectionDegrees { get; set; }

        [JsonIgnore]
        public CardinalWindDirection WindDirection => WindHelper.GetCardinalWindDirection(this.WindDirectionDegrees);

        /// <summary>
        /// Wind gust is a brief increase in the speed of the wind, usually less than 20 seconds. (German: Windböe).
        /// </summary>
        [JsonProperty("wind_gust")]
        public double WindGust { get; set; }

        [JsonProperty("weather")]
        public List<WeatherCondition> Weather { get; set; }

        /// <summary>
        /// Probability of precipitation.
        /// The values of the parameter vary between 0 and 1, where 0 is equal to 0%, 1 is equal to 100%.
        /// </summary>
        [JsonProperty("pop")]
        public double Pop { get; set; }

        /// <summary>
        /// Daily amount of rain, precipitation volume, mm.
        /// </summary>
        [JsonProperty("rain")]
        public double Rain { get; set; }

        /// <summary>
        /// Daily amount of snow, precipitation volume, mm.
        /// </summary>
        [JsonProperty("snow")]
        public double Snow { get; set; }

        public override string ToString()
        {
            return $"DateTime: {this.DateTime}, Temperature: {this.Temperature.Min}/{this.Temperature.Max}";
        }
    }
}