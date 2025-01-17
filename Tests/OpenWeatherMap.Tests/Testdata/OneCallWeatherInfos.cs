﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json;
using OpenWeatherMap.Models;
using OpenWeatherMap.Models.Converters;

namespace OpenWeatherMap.Tests.Testdata
{
    internal static class OneCallWeatherInfos
    {
        private static readonly JsonSerializerSettings JsonSerializerSettings = CreateMetricJsonSerializerSettings();

        private static JsonSerializerSettings CreateMetricJsonSerializerSettings()
        {
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new CelsiusTemperatureJsonConverter());
            return settings;
        }

        internal static string GetTestWeatherInfoJson()
        {
            var weatherInfo = GetTestWeatherInfo();
            var weatherInfoJson = JsonConvert.SerializeObject(weatherInfo, JsonSerializerSettings);
            return weatherInfoJson;
        }

        internal static OneCallWeatherInfo GetTestWeatherInfo2()
        {
            return new OneCallWeatherInfo
            {
                Latitude = 47.0907d,
                Longitude = 8.0559d,
                Timezone = "Europe/Zurich",
                TimezoneOffset = 7200,
                CurrentWeather = new CurrentWeatherForecast
                {
                    DateTime = DateTime.ParseExact("2022-06-14T20:05:49.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    Sunrise = DateTime.ParseExact("2022-06-14T03:31:53.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    Sunset = DateTime.ParseExact("2022-06-14T19:24:17.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    Temperature = new Temperature(18.01, TemperatureUnit.Celsius),
                    FeelsLike = new Temperature(17.54, TemperatureUnit.Celsius),
                    Pressure = new Pressure(1017),
                    Humidity = new Humidity(64),
                    DewPoint = new Temperature(11.11, TemperatureUnit.Celsius),
                    UVIndex = new UVIndex(0),
                    Clouds = 73,
                    Visibility = 10000,
                    WindSpeed = 0d,
                    WindDirectionDegrees = 0,
                    WindGust = 0d,
                    Weather = new List<WeatherCondition>
                    {
                      new WeatherCondition
                      {
                        Id = 803,
                        Type = WeatherConditionType.Clouds,
                        Description = "Überwiegend bewölkt",
                        IconId = "04n"
                      }
                    }
                },
                MinutelyForecasts = new List<MinutelyWeatherForecast>
                  {
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:06:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:07:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:08:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:09:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:10:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:11:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:12:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:13:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:14:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:15:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:16:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:17:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:18:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:19:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:20:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:21:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:22:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:23:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:24:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:25:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:26:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:27:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:28:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:29:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:30:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:31:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:32:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:33:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:34:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:35:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:36:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:37:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:38:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:39:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:40:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:41:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:42:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:43:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:44:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:45:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:46:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:47:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:48:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:49:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:50:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:51:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:52:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:53:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:54:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:55:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:56:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:57:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:58:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:59:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T21:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T21:01:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T21:02:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T21:03:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T21:04:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T21:05:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T21:06:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    }
                  },
                HourlyForecasts = new List<HourlyWeatherForecast>
                  {
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T20:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(18.01, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(17.54, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1017),
                      Humidity = new Humidity(64),
                      DewPoint = new Temperature(11.11, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 73,
                      Visibility = 10000,
                      WindSpeed = 1.2d,
                      WindDirectionDegrees = 142,
                      WindGust = 1.33d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 803,
                          Type = WeatherConditionType.Clouds,
                          Description = "Überwiegend bewölkt",
                          IconId = "04n"
                        }
                      },
                      Pop = 0.03d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T21:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(17.32, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(16.88, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1017),
                      Humidity = new Humidity(68),
                      DewPoint = new Temperature(11.36, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 70,
                      Visibility = 10000,
                      WindSpeed = 1.29d,
                      WindDirectionDegrees = 160,
                      WindGust = 1.35d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 803,
                          Type = WeatherConditionType.Clouds,
                          Description = "Überwiegend bewölkt",
                          IconId = "04n"
                        }
                      },
                      Pop = 0.03d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T22:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(16.49, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(16.07, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1017),
                      Humidity = new Humidity(72),
                      DewPoint = new Temperature(11.43, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 61,
                      Visibility = 10000,
                      WindSpeed = 1.38d,
                      WindDirectionDegrees = 167,
                      WindGust = 1.34d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 803,
                          Type = WeatherConditionType.Clouds,
                          Description = "Überwiegend bewölkt",
                          IconId = "04n"
                        }
                      },
                      Pop = 0.01d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T23:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(15.6, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(15.17, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1018),
                      Humidity = new Humidity(75),
                      DewPoint = new Temperature(11.19, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 50,
                      Visibility = 10000,
                      WindSpeed = 1.45d,
                      WindDirectionDegrees = 176,
                      WindGust = 1.34d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 802,
                          Type = WeatherConditionType.Clouds,
                          Description = "Mäßig bewölkt",
                          IconId = "03n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T00:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(14.66, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(14.19, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1018),
                      Humidity = new Humidity(77),
                      DewPoint = new Temperature(10.68, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 38,
                      Visibility = 10000,
                      WindSpeed = 1.52d,
                      WindDirectionDegrees = 198,
                      WindGust = 1.36d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 802,
                          Type = WeatherConditionType.Clouds,
                          Description = "Mäßig bewölkt",
                          IconId = "03n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T01:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(13.71, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(13.23, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1019),
                      Humidity = new Humidity(80),
                      DewPoint = new Temperature(9.43, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 17,
                      Visibility = 10000,
                      WindSpeed = 1.75d,
                      WindDirectionDegrees = 196,
                      WindGust = 1.58d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 801,
                          Type = WeatherConditionType.Clouds,
                          Description = "Ein paar Wolken",
                          IconId = "02n"
                        }
                      },
                      Pop = 0.03d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T02:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(13.7, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(13.19, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1019),
                      Humidity = new Humidity(79),
                      DewPoint = new Temperature(9.18, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 11,
                      Visibility = 10000,
                      WindSpeed = 1.9d,
                      WindDirectionDegrees = 189,
                      WindGust = 1.7d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 801,
                          Type = WeatherConditionType.Clouds,
                          Description = "Ein paar Wolken",
                          IconId = "02n"
                        }
                      },
                      Pop = 0.01d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T03:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(13.77, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(13.21, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1019),
                      Humidity = new Humidity(77),
                      DewPoint = new Temperature(8.99, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 8,
                      Visibility = 10000,
                      WindSpeed = 1.72d,
                      WindDirectionDegrees = 179,
                      WindGust = 1.47d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 800,
                          Type = WeatherConditionType.Clear,
                          Description = "Klarer Himmel",
                          IconId = "01n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T04:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(13.96, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(13.42, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1018),
                      Humidity = new Humidity(77),
                      DewPoint = new Temperature(9.14, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 6,
                      Visibility = 10000,
                      WindSpeed = 1.51d,
                      WindDirectionDegrees = 190,
                      WindGust = 1.4d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 800,
                          Type = WeatherConditionType.Clear,
                          Description = "Klarer Himmel",
                          IconId = "01d"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T05:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(15.86, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(15.51, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1018),
                      Humidity = new Humidity(77),
                      DewPoint = new Temperature(10.83, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.34),
                      Clouds = 6,
                      Visibility = 10000,
                      WindSpeed = 1.27d,
                      WindDirectionDegrees = 199,
                      WindGust = 1.29d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 800,
                          Type = WeatherConditionType.Clear,
                          Description = "Klarer Himmel",
                          IconId = "01d"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T06:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(19.04, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(18.75, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1018),
                      Humidity = new Humidity(67),
                      DewPoint = new Temperature(11.93, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(1.01),
                      Clouds = 6,
                      Visibility = 10000,
                      WindSpeed = 0.73d,
                      WindDirectionDegrees = 216,
                      WindGust = 1.17d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 800,
                          Type = WeatherConditionType.Clear,
                          Description = "Klarer Himmel",
                          IconId = "01d"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T07:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(21.42, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(21.18, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1018),
                      Humidity = new Humidity(60),
                      DewPoint = new Temperature(12.48, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(2.18),
                      Clouds = 19,
                      Visibility = 10000,
                      WindSpeed = 0.88d,
                      WindDirectionDegrees = 286,
                      WindGust = 1.46d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 801,
                          Type = WeatherConditionType.Clouds,
                          Description = "Ein paar Wolken",
                          IconId = "02d"
                        }
                      },
                      Pop = 0.14d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T08:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(23.33, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(23.13, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1018),
                      Humidity = new Humidity(54),
                      DewPoint = new Temperature(12.54, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(3.82),
                      Clouds = 26,
                      Visibility = 10000,
                      WindSpeed = 0.98d,
                      WindDirectionDegrees = 289,
                      WindGust = 3.1d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 500,
                          Type = WeatherConditionType.Rain,
                          Description = "Leichter Regen",
                          IconId = "10d"
                        }
                      },
                      Pop = 0.3d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T09:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(25.57, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(25.36, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1018),
                      Humidity = new Humidity(45),
                      DewPoint = new Temperature(12.1, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(5.63),
                      Clouds = 29,
                      Visibility = 10000,
                      WindSpeed = 1.07d,
                      WindDirectionDegrees = 299,
                      WindGust = 3.32d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 802,
                          Type = WeatherConditionType.Clouds,
                          Description = "Mäßig bewölkt",
                          IconId = "03d"
                        }
                      },
                      Pop = 0.27d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T10:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(27.13, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(26.96, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1017),
                      Humidity = new Humidity(40),
                      DewPoint = new Temperature(11.68, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(7.22),
                      Clouds = 22,
                      Visibility = 10000,
                      WindSpeed = 1.6d,
                      WindDirectionDegrees = 292,
                      WindGust = 4.76d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 801,
                          Type = WeatherConditionType.Clouds,
                          Description = "Ein paar Wolken",
                          IconId = "02d"
                        }
                      },
                      Pop = 0.19d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(28.26, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(27.69, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1017),
                      Humidity = new Humidity(37),
                      DewPoint = new Temperature(11.53, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(8.11),
                      Clouds = 20,
                      Visibility = 10000,
                      WindSpeed = 2.36d,
                      WindDirectionDegrees = 284,
                      WindGust = 5.7d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 801,
                          Type = WeatherConditionType.Clouds,
                          Description = "Ein paar Wolken",
                          IconId = "02d"
                        }
                      },
                      Pop = 0.15d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T12:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(29, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(28.27, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1016),
                      Humidity = new Humidity(36),
                      DewPoint = new Temperature(11.68, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(8.08),
                      Clouds = 25,
                      Visibility = 10000,
                      WindSpeed = 3.2d,
                      WindDirectionDegrees = 280,
                      WindGust = 6.55d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 802,
                          Type = WeatherConditionType.Clouds,
                          Description = "Mäßig bewölkt",
                          IconId = "03d"
                        }
                      },
                      Pop = 0.07d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T13:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(29.44, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(28.61, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1016),
                      Humidity = new Humidity(35),
                      DewPoint = new Temperature(11.82, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(7.08),
                      Clouds = 44,
                      Visibility = 10000,
                      WindSpeed = 3.76d,
                      WindDirectionDegrees = 272,
                      WindGust = 6.65d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 802,
                          Type = WeatherConditionType.Clouds,
                          Description = "Mäßig bewölkt",
                          IconId = "03d"
                        }
                      },
                      Pop = 0.06d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T14:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(29.64, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(28.72, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1016),
                      Humidity = new Humidity(34),
                      DewPoint = new Temperature(11.63, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(5.49),
                      Clouds = 51,
                      Visibility = 10000,
                      WindSpeed = 3.74d,
                      WindDirectionDegrees = 268,
                      WindGust = 6.72d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 803,
                          Type = WeatherConditionType.Clouds,
                          Description = "Überwiegend bewölkt",
                          IconId = "04d"
                        }
                      },
                      Pop = 0.06d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T15:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(29.38, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(28.64, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1016),
                      Humidity = new Humidity(36),
                      DewPoint = new Temperature(12.37, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(3.68),
                      Clouds = 37,
                      Visibility = 10000,
                      WindSpeed = 3.24d,
                      WindDirectionDegrees = 285,
                      WindGust = 5.8d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 802,
                          Type = WeatherConditionType.Clouds,
                          Description = "Mäßig bewölkt",
                          IconId = "03d"
                        }
                      },
                      Pop = 0.08d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T16:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(28.28, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(28.23, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1016),
                      Humidity = new Humidity(44),
                      DewPoint = new Temperature(14.37, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(2.09),
                      Clouds = 30,
                      Visibility = 10000,
                      WindSpeed = 2.98d,
                      WindDirectionDegrees = 315,
                      WindGust = 4.65d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 802,
                          Type = WeatherConditionType.Clouds,
                          Description = "Mäßig bewölkt",
                          IconId = "03d"
                        }
                      },
                      Pop = 0.08d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T17:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(26.64, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(26.64, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1016),
                      Humidity = new Humidity(57),
                      DewPoint = new Temperature(16.83, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.94),
                      Clouds = 25,
                      Visibility = 10000,
                      WindSpeed = 2.3d,
                      WindDirectionDegrees = 342,
                      WindGust = 4.49d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 802,
                          Type = WeatherConditionType.Clouds,
                          Description = "Mäßig bewölkt",
                          IconId = "03d"
                        }
                      },
                      Pop = 0.12d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T18:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(23.48, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(23.82, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1016),
                      Humidity = new Humidity(74),
                      DewPoint = new Temperature(17.73, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.31),
                      Clouds = 28,
                      Visibility = 10000,
                      WindSpeed = 1.24d,
                      WindDirectionDegrees = 17,
                      WindGust = 1.6d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 500,
                          Type = WeatherConditionType.Rain,
                          Description = "Leichter Regen",
                          IconId = "10d"
                        }
                      },
                      Pop = 0.28d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T19:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(20.36, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(20.62, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1017),
                      Humidity = new Humidity(83),
                      DewPoint = new Temperature(16.48, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 10,
                      Visibility = 10000,
                      WindSpeed = 1.42d,
                      WindDirectionDegrees = 176,
                      WindGust = 1.46d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 500,
                          Type = WeatherConditionType.Rain,
                          Description = "Leichter Regen",
                          IconId = "10d"
                        }
                      },
                      Pop = 0.53d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T20:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(18.12, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(18.29, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1019),
                      Humidity = new Humidity(88),
                      DewPoint = new Temperature(15.35, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 18,
                      Visibility = 10000,
                      WindSpeed = 2.88d,
                      WindDirectionDegrees = 194,
                      WindGust = 4.2d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 500,
                          Type = WeatherConditionType.Rain,
                          Description = "Leichter Regen",
                          IconId = "10n"
                        }
                      },
                      Pop = 0.75d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T21:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(16.64, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(16.76, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1019),
                      Humidity = new Humidity(92),
                      DewPoint = new Temperature(14.54, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 39,
                      Visibility = 10000,
                      WindSpeed = 2.94d,
                      WindDirectionDegrees = 201,
                      WindGust = 4.93d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 501,
                          Type = WeatherConditionType.Rain,
                          Description = "Mäßiger Regen",
                          IconId = "10n"
                        }
                      },
                      Pop = 0.74d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T22:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(14.59, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(14.59, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(95),
                      DewPoint = new Temperature(12.89, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 31,
                      Visibility = 7351,
                      WindSpeed = 2.94d,
                      WindDirectionDegrees = 161,
                      WindGust = 4.55d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 501,
                          Type = WeatherConditionType.Rain,
                          Description = "Mäßiger Regen",
                          IconId = "10n"
                        }
                      },
                      Pop = 0.9d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T23:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(14, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(13.88, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(93),
                      DewPoint = new Temperature(12.09, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 26,
                      Visibility = 10000,
                      WindSpeed = 2.7d,
                      WindDirectionDegrees = 179,
                      WindGust = 2.96d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 500,
                          Type = WeatherConditionType.Rain,
                          Description = "Leichter Regen",
                          IconId = "10n"
                        }
                      },
                      Pop = 0.96d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T00:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(13.87, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(13.69, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1020),
                      Humidity = new Humidity(91),
                      DewPoint = new Temperature(11.63, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 23,
                      Visibility = 10000,
                      WindSpeed = 2.63d,
                      WindDirectionDegrees = 197,
                      WindGust = 2.87d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 500,
                          Type = WeatherConditionType.Rain,
                          Description = "Leichter Regen",
                          IconId = "10n"
                        }
                      },
                      Pop = 0.96d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T01:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(13.99, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(13.79, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1020),
                      Humidity = new Humidity(90),
                      DewPoint = new Temperature(11.63, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 9,
                      Visibility = 10000,
                      WindSpeed = 2.52d,
                      WindDirectionDegrees = 202,
                      WindGust = 2.25d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 800,
                          Type = WeatherConditionType.Clear,
                          Description = "Klarer Himmel",
                          IconId = "01n"
                        }
                      },
                      Pop = 0.11d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T02:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(14.15, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(14, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1020),
                      Humidity = new Humidity(91),
                      DewPoint = new Temperature(11.91, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 18,
                      Visibility = 10000,
                      WindSpeed = 2.44d,
                      WindDirectionDegrees = 201,
                      WindGust = 2.5d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 801,
                          Type = WeatherConditionType.Clouds,
                          Description = "Ein paar Wolken",
                          IconId = "02n"
                        }
                      },
                      Pop = 0.07d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T03:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(14.29, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(14.15, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1020),
                      Humidity = new Humidity(91),
                      DewPoint = new Temperature(11.98, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 14,
                      Visibility = 10000,
                      WindSpeed = 1.99d,
                      WindDirectionDegrees = 203,
                      WindGust = 1.89d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 801,
                          Type = WeatherConditionType.Clouds,
                          Description = "Ein paar Wolken",
                          IconId = "02n"
                        }
                      },
                      Pop = 0.04d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T04:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(14.45, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(14.3, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1020),
                      Humidity = new Humidity(90),
                      DewPoint = new Temperature(12.08, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 13,
                      Visibility = 10000,
                      WindSpeed = 1.8d,
                      WindDirectionDegrees = 203,
                      WindGust = 1.62d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 801,
                          Type = WeatherConditionType.Clouds,
                          Description = "Ein paar Wolken",
                          IconId = "02d"
                        }
                      },
                      Pop = 0.01d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T05:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(16.1, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(16.09, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1020),
                      Humidity = new Humidity(89),
                      DewPoint = new Temperature(13.5, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.34),
                      Clouds = 14,
                      Visibility = 10000,
                      WindSpeed = 1.74d,
                      WindDirectionDegrees = 213,
                      WindGust = 1.82d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 801,
                          Type = WeatherConditionType.Clouds,
                          Description = "Ein paar Wolken",
                          IconId = "02d"
                        }
                      },
                      Pop = 0.08d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T06:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(18.79, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(18.89, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1020),
                      Humidity = new Humidity(83),
                      DewPoint = new Temperature(14.93, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(1.01),
                      Clouds = 13,
                      Visibility = 10000,
                      WindSpeed = 1.2d,
                      WindDirectionDegrees = 218,
                      WindGust = 2.03d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 500,
                          Type = WeatherConditionType.Rain,
                          Description = "Leichter Regen",
                          IconId = "10d"
                        }
                      },
                      Pop = 0.36d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T07:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(20.93, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(20.98, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1020),
                      Humidity = new Humidity(73),
                      DewPoint = new Temperature(15.05, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(2.21),
                      Clouds = 2,
                      Visibility = 10000,
                      WindSpeed = 1.26d,
                      WindDirectionDegrees = 274,
                      WindGust = 3.46d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 800,
                          Type = WeatherConditionType.Clear,
                          Description = "Klarer Himmel",
                          IconId = "01d"
                        }
                      },
                      Pop = 0.38d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T08:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(21.6, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(21.8, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1020),
                      Humidity = new Humidity(76),
                      DewPoint = new Temperature(16.42, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(3.87),
                      Clouds = 7,
                      Visibility = 10000,
                      WindSpeed = 1.71d,
                      WindDirectionDegrees = 286,
                      WindGust = 3.79d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 500,
                          Type = WeatherConditionType.Rain,
                          Description = "Leichter Regen",
                          IconId = "10d"
                        }
                      },
                      Pop = 0.7d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T09:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(23.13, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(23.3, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(69),
                      DewPoint = new Temperature(16.45, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(5.7),
                      Clouds = 7,
                      Visibility = 10000,
                      WindSpeed = 1.76d,
                      WindDirectionDegrees = 286,
                      WindGust = 4.1d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 500,
                          Type = WeatherConditionType.Rain,
                          Description = "Leichter Regen",
                          IconId = "10d"
                        }
                      },
                      Pop = 0.74d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T10:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(25.26, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(25.2, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1020),
                      Humidity = new Humidity(52),
                      DewPoint = new Temperature(13.95, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(6.88),
                      Clouds = 8,
                      Visibility = 10000,
                      WindSpeed = 2.12d,
                      WindDirectionDegrees = 286,
                      WindGust = 4.34d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 500,
                          Type = WeatherConditionType.Rain,
                          Description = "Leichter Regen",
                          IconId = "10d"
                        }
                      },
                      Pop = 0.74d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(26.27, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(26.27, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1020),
                      Humidity = new Humidity(46),
                      DewPoint = new Temperature(12.92, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(7.72),
                      Clouds = 24,
                      Visibility = 10000,
                      WindSpeed = 2.4d,
                      WindDirectionDegrees = 294,
                      WindGust = 4.9d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 801,
                          Type = WeatherConditionType.Clouds,
                          Description = "Ein paar Wolken",
                          IconId = "02d"
                        }
                      },
                      Pop = 0.69d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T12:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(26.88, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(26.92, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1020),
                      Humidity = new Humidity(43),
                      DewPoint = new Temperature(12.45, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(7.7),
                      Clouds = 37,
                      Visibility = 10000,
                      WindSpeed = 2.81d,
                      WindDirectionDegrees = 302,
                      WindGust = 5.14d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 802,
                          Type = WeatherConditionType.Clouds,
                          Description = "Mäßig bewölkt",
                          IconId = "03d"
                        }
                      },
                      Pop = 0.64d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T13:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(27.28, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(27.07, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1020),
                      Humidity = new Humidity(40),
                      DewPoint = new Temperature(12.05, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(6.96),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 3.25d,
                      WindDirectionDegrees = 313,
                      WindGust = 4.88d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "Bedeckt",
                          IconId = "04d"
                        }
                      },
                      Pop = 0.2d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T14:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(26.53, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(26.53, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(44),
                      DewPoint = new Temperature(12.64, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(5.4),
                      Clouds = 97,
                      Visibility = 10000,
                      WindSpeed = 3.58d,
                      WindDirectionDegrees = 328,
                      WindGust = 4.29d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "Bedeckt",
                          IconId = "04d"
                        }
                      },
                      Pop = 0.2d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T15:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(24.58, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(24.53, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(55),
                      DewPoint = new Temperature(13.71, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(3.62),
                      Clouds = 87,
                      Visibility = 10000,
                      WindSpeed = 1.98d,
                      WindDirectionDegrees = 338,
                      WindGust = 3.32d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "Bedeckt",
                          IconId = "04d"
                        }
                      },
                      Pop = 0.18d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T16:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(25.67, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(25.49, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(46),
                      DewPoint = new Temperature(12.28, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(2.15),
                      Clouds = 74,
                      Visibility = 10000,
                      WindSpeed = 2.2d,
                      WindDirectionDegrees = 340,
                      WindGust = 2.63d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 803,
                          Type = WeatherConditionType.Clouds,
                          Description = "Überwiegend bewölkt",
                          IconId = "04d"
                        }
                      },
                      Pop = 0.14d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T17:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(24.81, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(24.76, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(54),
                      DewPoint = new Temperature(14.28, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.97),
                      Clouds = 65,
                      Visibility = 10000,
                      WindSpeed = 1.84d,
                      WindDirectionDegrees = 338,
                      WindGust = 3.38d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 803,
                          Type = WeatherConditionType.Clouds,
                          Description = "Überwiegend bewölkt",
                          IconId = "04d"
                        }
                      },
                      Pop = 0.1d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T18:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(22.4, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(22.5, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(69),
                      DewPoint = new Temperature(15.58, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.32),
                      Clouds = 62,
                      Visibility = 10000,
                      WindSpeed = 1.29d,
                      WindDirectionDegrees = 335,
                      WindGust = 1.56d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 803,
                          Type = WeatherConditionType.Clouds,
                          Description = "Überwiegend bewölkt",
                          IconId = "04d"
                        }
                      },
                      Pop = 0.1d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T19:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(20.11, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(20.06, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1022),
                      Humidity = new Humidity(72),
                      DewPoint = new Temperature(14.21, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 97,
                      Visibility = 10000,
                      WindSpeed = 0.39d,
                      WindDirectionDegrees = 327,
                      WindGust = 0.66d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "Bedeckt",
                          IconId = "04d"
                        }
                      },
                      Pop = 0.05d
                    }
                  },
                DailyForecasts = new List<DailyWeatherForecast>
                  {
                    new DailyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-14T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunrise = DateTime.ParseExact("2022-06-14T03:31:53.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunset = DateTime.ParseExact("2022-06-14T19:24:17.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonrise = DateTime.ParseExact("2022-06-14T20:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonset = DateTime.ParseExact("2022-06-14T03:02:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      MoonPhase = 0.5d,
                      Temperature = new DailyTemperatureForecast
                      {
                        Day = new Temperature(23.42, TemperatureUnit.Celsius),
                        Min = new Temperature(9.96, TemperatureUnit.Celsius),
                        Max = new Temperature(25.01, TemperatureUnit.Celsius),
                        Night = new Temperature(17.32, TemperatureUnit.Celsius),
                        Evening = new Temperature(20.7, TemperatureUnit.Celsius),
                        Morning = new Temperature(12.16, TemperatureUnit.Celsius)
                      },
                      FeelsLike = new DailyFeelsLikeForecast
                      {
                        Day = new Temperature(22.94, TemperatureUnit.Celsius),
                        Night = new Temperature(16.88, TemperatureUnit.Celsius),
                        Evening = new Temperature(20.34, TemperatureUnit.Celsius),
                        Morning = new Temperature(11.55, TemperatureUnit.Celsius)
                      },
                      Pressure = new Pressure(1019),
                      Humidity = new Humidity(43),
                      DewPoint = new Temperature(9.49, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(7.88),
                      Clouds = 0,
                      Visibility = 0,
                      WindSpeed = 2.95d,
                      WindDirectionDegrees = 48,
                      WindGust = 3.51d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 800,
                          Type = WeatherConditionType.Clear,
                          Description = "Klarer Himmel",
                          IconId = "01d"
                        }
                      },
                      Pop = 0.06d,
                      Rain = 0d,
                      Snow = 0d
                    },
                    new DailyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-15T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunrise = DateTime.ParseExact("2022-06-15T03:31:48.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunset = DateTime.ParseExact("2022-06-15T19:24:45.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonrise = DateTime.ParseExact("2022-06-15T21:09:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonset = DateTime.ParseExact("2022-06-15T03:57:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      MoonPhase = 0.54d,
                      Temperature = new DailyTemperatureForecast
                      {
                        Day = new Temperature(28.26, TemperatureUnit.Celsius),
                        Min = new Temperature(13.7, TemperatureUnit.Celsius),
                        Max = new Temperature(29.64, TemperatureUnit.Celsius),
                        Night = new Temperature(16.64, TemperatureUnit.Celsius),
                        Evening = new Temperature(26.64, TemperatureUnit.Celsius),
                        Morning = new Temperature(15.86, TemperatureUnit.Celsius)
                      },
                      FeelsLike = new DailyFeelsLikeForecast
                      {
                        Day = new Temperature(27.69, TemperatureUnit.Celsius),
                        Night = new Temperature(16.76, TemperatureUnit.Celsius),
                        Evening = new Temperature(26.64, TemperatureUnit.Celsius),
                        Morning = new Temperature(15.51, TemperatureUnit.Celsius)
                      },
                      Pressure = new Pressure(1017),
                      Humidity = new Humidity(37),
                      DewPoint = new Temperature(11.53, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(8.11),
                      Clouds = 20,
                      Visibility = 0,
                      WindSpeed = 3.76d,
                      WindDirectionDegrees = 272,
                      WindGust = 6.72d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 501,
                          Type = WeatherConditionType.Rain,
                          Description = "Mäßiger Regen",
                          IconId = "10d"
                        }
                      },
                      Pop = 0.75d,
                      Rain = 2.77d,
                      Snow = 0d
                    },
                    new DailyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-16T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunrise = DateTime.ParseExact("2022-06-16T03:31:46.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunset = DateTime.ParseExact("2022-06-16T19:25:11.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonrise = DateTime.ParseExact("1970-01-01T00:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonset = DateTime.ParseExact("2022-06-16T05:08:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      MoonPhase = 0.58d,
                      Temperature = new DailyTemperatureForecast
                      {
                        Day = new Temperature(26.27, TemperatureUnit.Celsius),
                        Min = new Temperature(13.87, TemperatureUnit.Celsius),
                        Max = new Temperature(27.28, TemperatureUnit.Celsius),
                        Night = new Temperature(17.66, TemperatureUnit.Celsius),
                        Evening = new Temperature(24.81, TemperatureUnit.Celsius),
                        Morning = new Temperature(16.1, TemperatureUnit.Celsius)
                      },
                      FeelsLike = new DailyFeelsLikeForecast
                      {
                        Day = new Temperature(26.27, TemperatureUnit.Celsius),
                        Night = new Temperature(17.49, TemperatureUnit.Celsius),
                        Evening = new Temperature(24.76, TemperatureUnit.Celsius),
                        Morning = new Temperature(16.09, TemperatureUnit.Celsius)
                      },
                      Pressure = new Pressure(1020),
                      Humidity = new Humidity(46),
                      DewPoint = new Temperature(12.92, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(7.72),
                      Clouds = 24,
                      Visibility = 0,
                      WindSpeed = 3.58d,
                      WindDirectionDegrees = 328,
                      WindGust = 5.14d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 501,
                          Type = WeatherConditionType.Rain,
                          Description = "Mäßiger Regen",
                          IconId = "10d"
                        }
                      },
                      Pop = 0.96d,
                      Rain = 3.39d,
                      Snow = 0d
                    },
                    new DailyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-17T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunrise = DateTime.ParseExact("2022-06-17T03:31:47.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunset = DateTime.ParseExact("2022-06-17T19:25:35.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonrise = DateTime.ParseExact("2022-06-16T22:01:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonset = DateTime.ParseExact("2022-06-17T06:28:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      MoonPhase = 0.62d,
                      Temperature = new DailyTemperatureForecast
                      {
                        Day = new Temperature(27.47, TemperatureUnit.Celsius),
                        Min = new Temperature(14.53, TemperatureUnit.Celsius),
                        Max = new Temperature(28.3, TemperatureUnit.Celsius),
                        Night = new Temperature(18.61, TemperatureUnit.Celsius),
                        Evening = new Temperature(23.73, TemperatureUnit.Celsius),
                        Morning = new Temperature(16.47, TemperatureUnit.Celsius)
                      },
                      FeelsLike = new DailyFeelsLikeForecast
                      {
                        Day = new Temperature(27.17, TemperatureUnit.Celsius),
                        Night = new Temperature(18.43, TemperatureUnit.Celsius),
                        Evening = new Temperature(23.91, TemperatureUnit.Celsius),
                        Morning = new Temperature(16.31, TemperatureUnit.Celsius)
                      },
                      Pressure = new Pressure(1022),
                      Humidity = new Humidity(39),
                      DewPoint = new Temperature(11.72, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(8.52),
                      Clouds = 74,
                      Visibility = 0,
                      WindSpeed = 2.43d,
                      WindDirectionDegrees = 8,
                      WindGust = 2.34d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 803,
                          Type = WeatherConditionType.Clouds,
                          Description = "Überwiegend bewölkt",
                          IconId = "04d"
                        }
                      },
                      Pop = 0d,
                      Rain = 0d,
                      Snow = 0d
                    },
                    new DailyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-18T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunrise = DateTime.ParseExact("2022-06-18T03:31:50.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunset = DateTime.ParseExact("2022-06-18T19:25:56.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonrise = DateTime.ParseExact("2022-06-17T22:40:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonset = DateTime.ParseExact("2022-06-18T07:52:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      MoonPhase = 0.65d,
                      Temperature = new DailyTemperatureForecast
                      {
                        Day = new Temperature(30.82, TemperatureUnit.Celsius),
                        Min = new Temperature(16.34, TemperatureUnit.Celsius),
                        Max = new Temperature(31.58, TemperatureUnit.Celsius),
                        Night = new Temperature(21.31, TemperatureUnit.Celsius),
                        Evening = new Temperature(25.86, TemperatureUnit.Celsius),
                        Morning = new Temperature(20.74, TemperatureUnit.Celsius)
                      },
                      FeelsLike = new DailyFeelsLikeForecast
                      {
                        Day = new Temperature(29.84, TemperatureUnit.Celsius),
                        Night = new Temperature(21.3, TemperatureUnit.Celsius),
                        Evening = new Temperature(26.17, TemperatureUnit.Celsius),
                        Morning = new Temperature(20.57, TemperatureUnit.Celsius)
                      },
                      Pressure = new Pressure(1017),
                      Humidity = new Humidity(33),
                      DewPoint = new Temperature(12.28, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(8.56),
                      Clouds = 1,
                      Visibility = 0,
                      WindSpeed = 3.19d,
                      WindDirectionDegrees = 51,
                      WindGust = 4.24d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 800,
                          Type = WeatherConditionType.Clear,
                          Description = "Klarer Himmel",
                          IconId = "01d"
                        }
                      },
                      Pop = 0.03d,
                      Rain = 0d,
                      Snow = 0d
                    },
                    new DailyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-19T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunrise = DateTime.ParseExact("2022-06-19T03:31:56.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunset = DateTime.ParseExact("2022-06-19T19:26:15.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonrise = DateTime.ParseExact("2022-06-18T23:09:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonset = DateTime.ParseExact("2022-06-19T09:13:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      MoonPhase = 0.69d,
                      Temperature = new DailyTemperatureForecast
                      {
                        Day = new Temperature(31.74, TemperatureUnit.Celsius),
                        Min = new Temperature(17.84, TemperatureUnit.Celsius),
                        Max = new Temperature(31.74, TemperatureUnit.Celsius),
                        Night = new Temperature(17.84, TemperatureUnit.Celsius),
                        Evening = new Temperature(20.36, TemperatureUnit.Celsius),
                        Morning = new Temperature(21.82, TemperatureUnit.Celsius)
                      },
                      FeelsLike = new DailyFeelsLikeForecast
                      {
                        Day = new Temperature(31.01, TemperatureUnit.Celsius),
                        Night = new Temperature(17.9, TemperatureUnit.Celsius),
                        Evening = new Temperature(20.8, TemperatureUnit.Celsius),
                        Morning = new Temperature(21.75, TemperatureUnit.Celsius)
                      },
                      Pressure = new Pressure(1010),
                      Humidity = new Humidity(34),
                      DewPoint = new Temperature(13.19, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(8.57),
                      Clouds = 0,
                      Visibility = 0,
                      WindSpeed = 3.47d,
                      WindDirectionDegrees = 149,
                      WindGust = 7.32d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 500,
                          Type = WeatherConditionType.Rain,
                          Description = "Leichter Regen",
                          IconId = "10d"
                        }
                      },
                      Pop = 0.85d,
                      Rain = 4.93d,
                      Snow = 0d
                    },
                    new DailyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-20T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunrise = DateTime.ParseExact("2022-06-20T03:32:03.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunset = DateTime.ParseExact("2022-06-20T19:26:31.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonrise = DateTime.ParseExact("2022-06-19T23:32:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonset = DateTime.ParseExact("2022-06-20T10:30:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      MoonPhase = 0.72d,
                      Temperature = new DailyTemperatureForecast
                      {
                        Day = new Temperature(23.92, TemperatureUnit.Celsius),
                        Min = new Temperature(14.68, TemperatureUnit.Celsius),
                        Max = new Temperature(24.37, TemperatureUnit.Celsius),
                        Night = new Temperature(14.68, TemperatureUnit.Celsius),
                        Evening = new Temperature(18.14, TemperatureUnit.Celsius),
                        Morning = new Temperature(20.58, TemperatureUnit.Celsius)
                      },
                      FeelsLike = new DailyFeelsLikeForecast
                      {
                        Day = new Temperature(23.88, TemperatureUnit.Celsius),
                        Night = new Temperature(14.76, TemperatureUnit.Celsius),
                        Evening = new Temperature(18.52, TemperatureUnit.Celsius),
                        Morning = new Temperature(20.5, TemperatureUnit.Celsius)
                      },
                      Pressure = new Pressure(1012),
                      Humidity = new Humidity(58),
                      DewPoint = new Temperature(14.37, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(9),
                      Clouds = 76,
                      Visibility = 0,
                      WindSpeed = 3.32d,
                      WindDirectionDegrees = 359,
                      WindGust = 7.06d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 501,
                          Type = WeatherConditionType.Rain,
                          Description = "Mäßiger Regen",
                          IconId = "10d"
                        }
                      },
                      Pop = 1d,
                      Rain = 9.69d,
                      Snow = 0d
                    },
                    new DailyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-06-21T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunrise = DateTime.ParseExact("2022-06-21T03:32:14.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunset = DateTime.ParseExact("2022-06-21T19:26:45.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonrise = DateTime.ParseExact("2022-06-20T23:51:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonset = DateTime.ParseExact("2022-06-21T11:43:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      MoonPhase = 0.75d,
                      Temperature = new DailyTemperatureForecast
                      {
                        Day = new Temperature(7.46, TemperatureUnit.Celsius),
                        Min = new Temperature(7.46, TemperatureUnit.Celsius),
                        Max = new Temperature(14.02, TemperatureUnit.Celsius),
                        Night = new Temperature(8.01, TemperatureUnit.Celsius),
                        Evening = new Temperature(12.57, TemperatureUnit.Celsius),
                        Morning = new Temperature(10.98, TemperatureUnit.Celsius)
                      },
                      FeelsLike = new DailyFeelsLikeForecast
                      {
                        Day = new Temperature(5.04, TemperatureUnit.Celsius),
                        Night = new Temperature(6.87, TemperatureUnit.Celsius),
                        Evening = new Temperature(11.68, TemperatureUnit.Celsius),
                        Morning = new Temperature(10.69, TemperatureUnit.Celsius)
                      },
                      Pressure = new Pressure(1015),
                      Humidity = new Humidity(96),
                      DewPoint = new Temperature(6.06, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(9),
                      Clouds = 100,
                      Visibility = 0,
                      WindSpeed = 3.7d,
                      WindDirectionDegrees = 211,
                      WindGust = 8.22d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 502,
                          Type = WeatherConditionType.Rain,
                          Description = "Starker Regen",
                          IconId = "10d"
                        }
                      },
                      Pop = 1d,
                      Rain = 50.16d,
                      Snow = 0d
                    }
                },
                Alerts = new List<AlertInfo>
                {
                }
            };
        }

        internal static OneCallWeatherInfo GetTestWeatherInfo() => new OneCallWeatherInfo
        {
            Latitude = 47.0907d,
            Longitude = 8.0559d,
            Timezone = "Europe/Zurich",
            TimezoneOffset = 3600,
            CurrentWeather = new CurrentWeatherForecast
            {
                DateTime = DateTime.ParseExact("2022-12-27T12:06:29.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                Sunrise = DateTime.ParseExact("2022-12-27T07:13:16.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                Sunset = DateTime.ParseExact("2022-12-27T15:44:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                Temperature = new Temperature(6.42, TemperatureUnit.Celsius),
                FeelsLike = new Temperature(6.42, TemperatureUnit.Celsius),
                Pressure = new Pressure(1030),
                Humidity = new Humidity(89),
                DewPoint = new Temperature(4.74, TemperatureUnit.Celsius),
                UVIndex = new UVIndex(0.69),
                Clouds = 75,
                Visibility = 10000,
                WindSpeed = 0d,
                WindDirectionDegrees = 0,
                WindGust = 0d,
                Weather = new List<WeatherCondition>
                    {
                      new WeatherCondition
                      {
                        Id = 803,
                        Type = WeatherConditionType.Clouds,
                        Description = "broken clouds",
                        IconId = "04d"
                      }
                    }
            },
            MinutelyForecasts = new List<MinutelyWeatherForecast>
                  {
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:07:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:08:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:09:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:10:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:11:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:12:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:13:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:14:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:15:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:16:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:17:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:18:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:19:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:20:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:21:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:22:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:23:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:24:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:25:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:26:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:27:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:28:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:29:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:30:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:31:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:32:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:33:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:34:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:35:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:36:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:37:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:38:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:39:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:40:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:41:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:42:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:43:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:44:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:45:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:46:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:47:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:48:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:49:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:50:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:51:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:52:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:53:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:54:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:55:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:56:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:57:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:58:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:59:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T13:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T13:01:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T13:02:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T13:03:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T13:04:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T13:05:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T13:06:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    },
                    new MinutelyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T13:07:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Precipitation = 0d
                    }
                  },
            HourlyForecasts = new List<HourlyWeatherForecast>
                  {
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T12:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(6.42, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(6.42, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1030),
                      Humidity = new Humidity(89),
                      DewPoint = new Temperature(4.74, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.69),
                      Clouds = 75,
                      Visibility = 10000,
                      WindSpeed = 0.67d,
                      WindDirectionDegrees = 294,
                      WindGust = 1.82d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 803,
                          Type = WeatherConditionType.Clouds,
                          Description = "broken clouds",
                          IconId = "04d"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T13:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(6.57, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(6.57, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1030),
                      Humidity = new Humidity(87),
                      DewPoint = new Temperature(4.56, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.42),
                      Clouds = 80,
                      Visibility = 10000,
                      WindSpeed = 0.73d,
                      WindDirectionDegrees = 334,
                      WindGust = 1.19d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 803,
                          Type = WeatherConditionType.Clouds,
                          Description = "broken clouds",
                          IconId = "04d"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T14:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(6.57, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(6.57, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1030),
                      Humidity = new Humidity(87),
                      DewPoint = new Temperature(4.56, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.22),
                      Clouds = 85,
                      Visibility = 10000,
                      WindSpeed = 1.03d,
                      WindDirectionDegrees = 357,
                      WindGust = 0.98d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04d"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T15:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(6.14, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(6.14, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1029),
                      Humidity = new Humidity(91),
                      DewPoint = new Temperature(4.78, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 90,
                      Visibility = 10000,
                      WindSpeed = 0.85d,
                      WindDirectionDegrees = 14,
                      WindGust = 0.94d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04d"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T16:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(5.24, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(5.24, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1029),
                      Humidity = new Humidity(95),
                      DewPoint = new Temperature(4.51, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 95,
                      Visibility = 10000,
                      WindSpeed = 0.51d,
                      WindDirectionDegrees = 13,
                      WindGust = 0.55d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T17:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(4.75, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(4.75, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1029),
                      Humidity = new Humidity(96),
                      DewPoint = new Temperature(3.32, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 0.58d,
                      WindDirectionDegrees = 139,
                      WindGust = 0.57d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T18:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(4.28, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(4.28, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1029),
                      Humidity = new Humidity(95),
                      DewPoint = new Temperature(2.75, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 98,
                      Visibility = 10000,
                      WindSpeed = 0.8d,
                      WindDirectionDegrees = 170,
                      WindGust = 0.76d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T19:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(3.82, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(3.82, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1029),
                      Humidity = new Humidity(94),
                      DewPoint = new Temperature(2.19, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 62,
                      Visibility = 10000,
                      WindSpeed = 1.04d,
                      WindDirectionDegrees = 184,
                      WindGust = 0.97d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 803,
                          Type = WeatherConditionType.Clouds,
                          Description = "broken clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T20:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(3.45, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(3.45, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1029),
                      Humidity = new Humidity(93),
                      DewPoint = new Temperature(1.64, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 40,
                      Visibility = 10000,
                      WindSpeed = 1.33d,
                      WindDirectionDegrees = 198,
                      WindGust = 1.27d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 802,
                          Type = WeatherConditionType.Clouds,
                          Description = "scattered clouds",
                          IconId = "03n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T21:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(3.14, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(1.99, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1029),
                      Humidity = new Humidity(93),
                      DewPoint = new Temperature(1.26, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 31,
                      Visibility = 10000,
                      WindSpeed = 1.39d,
                      WindDirectionDegrees = 210,
                      WindGust = 1.27d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 802,
                          Type = WeatherConditionType.Clouds,
                          Description = "scattered clouds",
                          IconId = "03n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T22:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(2.89, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(1.4, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1029),
                      Humidity = new Humidity(93),
                      DewPoint = new Temperature(0.98, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 25,
                      Visibility = 10000,
                      WindSpeed = 1.6d,
                      WindDirectionDegrees = 214,
                      WindGust = 1.42d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 802,
                          Type = WeatherConditionType.Clouds,
                          Description = "scattered clouds",
                          IconId = "03n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T23:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(2.77, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(1.13, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1029),
                      Humidity = new Humidity(92),
                      DewPoint = new Temperature(0.79, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 22,
                      Visibility = 10000,
                      WindSpeed = 1.7d,
                      WindDirectionDegrees = 208,
                      WindGust = 1.63d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 801,
                          Type = WeatherConditionType.Clouds,
                          Description = "few clouds",
                          IconId = "02n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T00:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(2.6, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(0.8, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1029),
                      Humidity = new Humidity(91),
                      DewPoint = new Temperature(0.46, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 34,
                      Visibility = 10000,
                      WindSpeed = 1.81d,
                      WindDirectionDegrees = 200,
                      WindGust = 1.82d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 802,
                          Type = WeatherConditionType.Clouds,
                          Description = "scattered clouds",
                          IconId = "03n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T01:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(2.53, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(0.75, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1028),
                      Humidity = new Humidity(90),
                      DewPoint = new Temperature(0.19, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 1.78d,
                      WindDirectionDegrees = 201,
                      WindGust = 1.64d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T02:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(2.55, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(0.65, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1028),
                      Humidity = new Humidity(89),
                      DewPoint = new Temperature(0.02, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 1.88d,
                      WindDirectionDegrees = 190,
                      WindGust = 1.69d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T03:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(3.2, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(1.65, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1027),
                      Humidity = new Humidity(86),
                      DewPoint = new Temperature(0.33, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 1.68d,
                      WindDirectionDegrees = 189,
                      WindGust = 1.53d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T04:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(3.39, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(1.94, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1026),
                      Humidity = new Humidity(85),
                      DewPoint = new Temperature(0.34, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 1.63d,
                      WindDirectionDegrees = 196,
                      WindGust = 1.49d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T05:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(3.34, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(2.11, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1026),
                      Humidity = new Humidity(84),
                      DewPoint = new Temperature(0.15, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 1.46d,
                      WindDirectionDegrees = 206,
                      WindGust = 1.34d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T06:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(2.87, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(1.58, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1026),
                      Humidity = new Humidity(85),
                      DewPoint = new Temperature(-0.29, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 1.46d,
                      WindDirectionDegrees = 221,
                      WindGust = 1.35d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T07:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(2.7, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(1.06, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1026),
                      Humidity = new Humidity(84),
                      DewPoint = new Temperature(-0.5, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 1.69d,
                      WindDirectionDegrees = 202,
                      WindGust = 1.64d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T08:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(3.09, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(1.14, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1026),
                      Humidity = new Humidity(82),
                      DewPoint = new Temperature(-0.54, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.09),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 2d,
                      WindDirectionDegrees = 181,
                      WindGust = 2.13d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04d"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T09:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(4.48, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(4.48, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1025),
                      Humidity = new Humidity(78),
                      DewPoint = new Temperature(0.1, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.28),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 1.3d,
                      WindDirectionDegrees = 192,
                      WindGust = 1.85d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04d"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T10:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(6.07, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(6.07, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1025),
                      Humidity = new Humidity(71),
                      DewPoint = new Temperature(0.4, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.63),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 1.02d,
                      WindDirectionDegrees = 194,
                      WindGust = 2.53d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04d"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(7.05, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(7.05, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1023),
                      Humidity = new Humidity(66),
                      DewPoint = new Temperature(0.21, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.81),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 0.86d,
                      WindDirectionDegrees = 224,
                      WindGust = 3d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04d"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T12:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(7.69, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(7.69, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1022),
                      Humidity = new Humidity(62),
                      DewPoint = new Temperature(0.14, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.71),
                      Clouds = 96,
                      Visibility = 10000,
                      WindSpeed = 1.06d,
                      WindDirectionDegrees = 240,
                      WindGust = 3.45d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04d"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T13:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(7.67, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(7.67, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(65),
                      DewPoint = new Temperature(0.82, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.6),
                      Clouds = 99,
                      Visibility = 10000,
                      WindSpeed = 0.78d,
                      WindDirectionDegrees = 247,
                      WindGust = 3.07d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04d"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T14:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(7.1, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(7.1, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(73),
                      DewPoint = new Temperature(1.79, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.33),
                      Clouds = 98,
                      Visibility = 10000,
                      WindSpeed = 0.59d,
                      WindDirectionDegrees = 241,
                      WindGust = 1.76d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04d"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T15:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(5.45, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(5.45, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(76),
                      DewPoint = new Temperature(0.67, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 98,
                      Visibility = 10000,
                      WindSpeed = 1.06d,
                      WindDirectionDegrees = 195,
                      WindGust = 1.04d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04d"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T16:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(3.93, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(2.78, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(76),
                      DewPoint = new Temperature(-0.74, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 96,
                      Visibility = 10000,
                      WindSpeed = 1.46d,
                      WindDirectionDegrees = 186,
                      WindGust = 1.34d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T17:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(3.34, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(1.7, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(75),
                      DewPoint = new Temperature(-1.53, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 96,
                      Visibility = 10000,
                      WindSpeed = 1.77d,
                      WindDirectionDegrees = 190,
                      WindGust = 1.57d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T18:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(3.09, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(1.25, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(73),
                      DewPoint = new Temperature(-2.04, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 96,
                      Visibility = 10000,
                      WindSpeed = 1.91d,
                      WindDirectionDegrees = 194,
                      WindGust = 1.67d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T19:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(2.91, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(1.04, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(72),
                      DewPoint = new Temperature(-2.39, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 1.91d,
                      WindDirectionDegrees = 194,
                      WindGust = 1.68d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T20:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(2.77, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(0.69, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(72),
                      DewPoint = new Temperature(-2.67, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 2.07d,
                      WindDirectionDegrees = 199,
                      WindGust = 1.81d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T21:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(2.58, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(0.23, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(71),
                      DewPoint = new Temperature(-3.05, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 2.3d,
                      WindDirectionDegrees = 186,
                      WindGust = 1.96d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T22:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(2.72, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(0.43, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(69),
                      DewPoint = new Temperature(-3.27, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 2.26d,
                      WindDirectionDegrees = 186,
                      WindGust = 1.95d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T23:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(2.63, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(0.39, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(67),
                      DewPoint = new Temperature(-3.68, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 2.2d,
                      WindDirectionDegrees = 188,
                      WindGust = 1.88d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-29T00:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(2.38, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(-0.05, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1020),
                      Humidity = new Humidity(66),
                      DewPoint = new Temperature(-4.1, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 99,
                      Visibility = 10000,
                      WindSpeed = 2.34d,
                      WindDirectionDegrees = 187,
                      WindGust = 2d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-29T01:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(2.33, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(-0.23, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1020),
                      Humidity = new Humidity(65),
                      DewPoint = new Temperature(-4.4, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 23,
                      Visibility = 10000,
                      WindSpeed = 2.47d,
                      WindDirectionDegrees = 185,
                      WindGust = 2.12d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 801,
                          Type = WeatherConditionType.Clouds,
                          Description = "few clouds",
                          IconId = "02n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-29T02:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(2.41, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(-0.18, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1020),
                      Humidity = new Humidity(63),
                      DewPoint = new Temperature(-4.68, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 28,
                      Visibility = 10000,
                      WindSpeed = 2.51d,
                      WindDirectionDegrees = 182,
                      WindGust = 2.16d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 802,
                          Type = WeatherConditionType.Clouds,
                          Description = "scattered clouds",
                          IconId = "03n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-29T03:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(2.7, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(0.42, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1019),
                      Humidity = new Humidity(61),
                      DewPoint = new Temperature(-4.88, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 31,
                      Visibility = 10000,
                      WindSpeed = 2.25d,
                      WindDirectionDegrees = 183,
                      WindGust = 1.92d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 802,
                          Type = WeatherConditionType.Clouds,
                          Description = "scattered clouds",
                          IconId = "03n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-29T04:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(3.45, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(1.54, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1019),
                      Humidity = new Humidity(59),
                      DewPoint = new Temperature(-4.66, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 48,
                      Visibility = 10000,
                      WindSpeed = 2.02d,
                      WindDirectionDegrees = 183,
                      WindGust = 1.79d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 802,
                          Type = WeatherConditionType.Clouds,
                          Description = "scattered clouds",
                          IconId = "03n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-29T05:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(3.79, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(2.1, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1019),
                      Humidity = new Humidity(58),
                      DewPoint = new Temperature(-4.53, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 58,
                      Visibility = 10000,
                      WindSpeed = 1.87d,
                      WindDirectionDegrees = 185,
                      WindGust = 1.66d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 803,
                          Type = WeatherConditionType.Clouds,
                          Description = "broken clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-29T06:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(3.55, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(1.65, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1019),
                      Humidity = new Humidity(59),
                      DewPoint = new Temperature(-4.61, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 65,
                      Visibility = 10000,
                      WindSpeed = 2.03d,
                      WindDirectionDegrees = 184,
                      WindGust = 1.79d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 803,
                          Type = WeatherConditionType.Clouds,
                          Description = "broken clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-29T07:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(3.25, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(1.18, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1019),
                      Humidity = new Humidity(61),
                      DewPoint = new Temperature(-4.46, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0),
                      Clouds = 100,
                      Visibility = 10000,
                      WindSpeed = 2.14d,
                      WindDirectionDegrees = 194,
                      WindGust = 1.91d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04n"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-29T08:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(3.41, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(1.83, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1020),
                      Humidity = new Humidity(62),
                      DewPoint = new Temperature(-4.09, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.1),
                      Clouds = 88,
                      Visibility = 10000,
                      WindSpeed = 1.73d,
                      WindDirectionDegrees = 203,
                      WindGust = 1.76d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04d"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-29T09:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(5.39, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(4, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1019),
                      Humidity = new Humidity(60),
                      DewPoint = new Temperature(-2.59, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.31),
                      Clouds = 77,
                      Visibility = 10000,
                      WindSpeed = 1.83d,
                      WindDirectionDegrees = 195,
                      WindGust = 3.89d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 803,
                          Type = WeatherConditionType.Clouds,
                          Description = "broken clouds",
                          IconId = "04d"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-29T10:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(7.61, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(6.87, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1019),
                      Humidity = new Humidity(59),
                      DewPoint = new Temperature(-0.62, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.59),
                      Clouds = 82,
                      Visibility = 10000,
                      WindSpeed = 1.55d,
                      WindDirectionDegrees = 207,
                      WindGust = 5.87d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 803,
                          Type = WeatherConditionType.Clouds,
                          Description = "broken clouds",
                          IconId = "04d"
                        }
                      },
                      Pop = 0d
                    },
                    new HourlyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-29T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Temperature = new Temperature(8.89, TemperatureUnit.Celsius),
                      FeelsLike = new Temperature(8.42, TemperatureUnit.Celsius),
                      Pressure = new Pressure(1018),
                      Humidity = new Humidity(55),
                      DewPoint = new Temperature(-0.41, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.72),
                      Clouds = 81,
                      Visibility = 10000,
                      WindSpeed = 1.47d,
                      WindDirectionDegrees = 220,
                      WindGust = 5.78d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 803,
                          Type = WeatherConditionType.Clouds,
                          Description = "broken clouds",
                          IconId = "04d"
                        }
                      },
                      Pop = 0d
                    }
                  },
            DailyForecasts = new List<DailyWeatherForecast>
                  {
                    new DailyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-27T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunrise = DateTime.ParseExact("2022-12-27T07:13:16.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunset = DateTime.ParseExact("2022-12-27T15:44:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonrise = DateTime.ParseExact("2022-12-27T10:36:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonset = DateTime.ParseExact("2022-12-27T20:51:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      MoonPhase = 0.16d,
                      Temperature = new DailyTemperatureForecast
                      {
                        Day = new Temperature(6.51, TemperatureUnit.Celsius),
                        Min = new Temperature(2.89, TemperatureUnit.Celsius),
                        Max = new Temperature(7.25, TemperatureUnit.Celsius),
                        Night = new Temperature(2.89, TemperatureUnit.Celsius),
                        Evening = new Temperature(4.75, TemperatureUnit.Celsius),
                        Morning = new Temperature(5.09, TemperatureUnit.Celsius)
                      },
                      FeelsLike = new DailyFeelsLikeForecast
                      {
                        Day = new Temperature(6.51, TemperatureUnit.Celsius),
                        Night = new Temperature(1.4, TemperatureUnit.Celsius),
                        Evening = new Temperature(4.75, TemperatureUnit.Celsius),
                        Morning = new Temperature(5.09, TemperatureUnit.Celsius)
                      },
                      Pressure = new Pressure(1030),
                      Humidity = new Humidity(88),
                      DewPoint = new Temperature(4.67, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.69),
                      Clouds = 80,
                      Visibility = 0,
                      WindSpeed = 2.92d,
                      WindDirectionDegrees = 263,
                      WindGust = 7.38d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 501,
                          Type = WeatherConditionType.Rain,
                          Description = "moderate rain",
                          IconId = "10d"
                        }
                      },
                      Pop = 1d,
                      Rain = 4.4d,
                      Snow = 0d
                    },
                    new DailyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-28T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunrise = DateTime.ParseExact("2022-12-28T07:13:29.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunset = DateTime.ParseExact("2022-12-28T15:44:44.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonrise = DateTime.ParseExact("2022-12-28T10:58:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonset = DateTime.ParseExact("2022-12-28T22:10:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      MoonPhase = 0.19d,
                      Temperature = new DailyTemperatureForecast
                      {
                        Day = new Temperature(7.05, TemperatureUnit.Celsius),
                        Min = new Temperature(2.53, TemperatureUnit.Celsius),
                        Max = new Temperature(7.69, TemperatureUnit.Celsius),
                        Night = new Temperature(2.72, TemperatureUnit.Celsius),
                        Evening = new Temperature(3.34, TemperatureUnit.Celsius),
                        Morning = new Temperature(3.34, TemperatureUnit.Celsius)
                      },
                      FeelsLike = new DailyFeelsLikeForecast
                      {
                        Day = new Temperature(7.05, TemperatureUnit.Celsius),
                        Night = new Temperature(0.43, TemperatureUnit.Celsius),
                        Evening = new Temperature(1.7, TemperatureUnit.Celsius),
                        Morning = new Temperature(2.11, TemperatureUnit.Celsius)
                      },
                      Pressure = new Pressure(1023),
                      Humidity = new Humidity(66),
                      DewPoint = new Temperature(0.21, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.81),
                      Clouds = 100,
                      Visibility = 0,
                      WindSpeed = 2.3d,
                      WindDirectionDegrees = 186,
                      WindGust = 3.45d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 804,
                          Type = WeatherConditionType.Clouds,
                          Description = "overcast clouds",
                          IconId = "04d"
                        }
                      },
                      Pop = 0d,
                      Rain = 0d,
                      Snow = 0d
                    },
                    new DailyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-29T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunrise = DateTime.ParseExact("2022-12-29T07:13:40.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunset = DateTime.ParseExact("2022-12-29T15:45:31.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonrise = DateTime.ParseExact("2022-12-29T11:16:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonset = DateTime.ParseExact("1970-01-01T00:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      MoonPhase = 0.23d,
                      Temperature = new DailyTemperatureForecast
                      {
                        Day = new Temperature(8.89, TemperatureUnit.Celsius),
                        Min = new Temperature(2.33, TemperatureUnit.Celsius),
                        Max = new Temperature(9.62, TemperatureUnit.Celsius),
                        Night = new Temperature(4.37, TemperatureUnit.Celsius),
                        Evening = new Temperature(5, TemperatureUnit.Celsius),
                        Morning = new Temperature(3.79, TemperatureUnit.Celsius)
                      },
                      FeelsLike = new DailyFeelsLikeForecast
                      {
                        Day = new Temperature(8.42, TemperatureUnit.Celsius),
                        Night = new Temperature(2.88, TemperatureUnit.Celsius),
                        Evening = new Temperature(3.4, TemperatureUnit.Celsius),
                        Morning = new Temperature(2.1, TemperatureUnit.Celsius)
                      },
                      Pressure = new Pressure(1018),
                      Humidity = new Humidity(55),
                      DewPoint = new Temperature(-0.41, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.72),
                      Clouds = 81,
                      Visibility = 0,
                      WindSpeed = 2.51d,
                      WindDirectionDegrees = 182,
                      WindGust = 5.87d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 803,
                          Type = WeatherConditionType.Clouds,
                          Description = "broken clouds",
                          IconId = "04d"
                        }
                      },
                      Pop = 0.29d,
                      Rain = 0d,
                      Snow = 0d
                    },
                    new DailyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-30T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunrise = DateTime.ParseExact("2022-12-30T07:13:47.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunset = DateTime.ParseExact("2022-12-30T15:46:19.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonrise = DateTime.ParseExact("2022-12-30T11:34:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonset = DateTime.ParseExact("2022-12-29T23:25:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      MoonPhase = 0.25d,
                      Temperature = new DailyTemperatureForecast
                      {
                        Day = new Temperature(9.37, TemperatureUnit.Celsius),
                        Min = new Temperature(3.83, TemperatureUnit.Celsius),
                        Max = new Temperature(9.37, TemperatureUnit.Celsius),
                        Night = new Temperature(6.54, TemperatureUnit.Celsius),
                        Evening = new Temperature(5.74, TemperatureUnit.Celsius),
                        Morning = new Temperature(3.83, TemperatureUnit.Celsius)
                      },
                      FeelsLike = new DailyFeelsLikeForecast
                      {
                        Day = new Temperature(9.37, TemperatureUnit.Celsius),
                        Night = new Temperature(4.98, TemperatureUnit.Celsius),
                        Evening = new Temperature(4.28, TemperatureUnit.Celsius),
                        Morning = new Temperature(2.53, TemperatureUnit.Celsius)
                      },
                      Pressure = new Pressure(1016),
                      Humidity = new Humidity(55),
                      DewPoint = new Temperature(0.02, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(0.64),
                      Clouds = 42,
                      Visibility = 0,
                      WindSpeed = 2.2d,
                      WindDirectionDegrees = 194,
                      WindGust = 3.1d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 500,
                          Type = WeatherConditionType.Rain,
                          Description = "light rain",
                          IconId = "10d"
                        }
                      },
                      Pop = 0.43d,
                      Rain = 0.15d,
                      Snow = 0d
                    },
                    new DailyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2022-12-31T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunrise = DateTime.ParseExact("2022-12-31T07:13:52.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunset = DateTime.ParseExact("2022-12-31T15:47:10.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonrise = DateTime.ParseExact("2022-12-31T11:51:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonset = DateTime.ParseExact("2022-12-31T00:39:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      MoonPhase = 0.3d,
                      Temperature = new DailyTemperatureForecast
                      {
                        Day = new Temperature(13.56, TemperatureUnit.Celsius),
                        Min = new Temperature(6.88, TemperatureUnit.Celsius),
                        Max = new Temperature(13.56, TemperatureUnit.Celsius),
                        Night = new Temperature(8.93, TemperatureUnit.Celsius),
                        Evening = new Temperature(9.22, TemperatureUnit.Celsius),
                        Morning = new Temperature(7.1, TemperatureUnit.Celsius)
                      },
                      FeelsLike = new DailyFeelsLikeForecast
                      {
                        Day = new Temperature(12.9, TemperatureUnit.Celsius),
                        Night = new Temperature(7.7, TemperatureUnit.Celsius),
                        Evening = new Temperature(8.13, TemperatureUnit.Celsius),
                        Morning = new Temperature(5.81, TemperatureUnit.Celsius)
                      },
                      Pressure = new Pressure(1021),
                      Humidity = new Humidity(74),
                      DewPoint = new Temperature(8.19, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(1),
                      Clouds = 100,
                      Visibility = 0,
                      WindSpeed = 2.32d,
                      WindDirectionDegrees = 189,
                      WindGust = 5.16d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 500,
                          Type = WeatherConditionType.Rain,
                          Description = "light rain",
                          IconId = "10d"
                        }
                      },
                      Pop = 0.56d,
                      Rain = 0.68d,
                      Snow = 0d
                    },
                    new DailyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2023-01-01T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunrise = DateTime.ParseExact("2023-01-01T07:13:55.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunset = DateTime.ParseExact("2023-01-01T15:48:04.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonrise = DateTime.ParseExact("2023-01-01T12:10:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonset = DateTime.ParseExact("2023-01-01T01:50:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      MoonPhase = 0.33d,
                      Temperature = new DailyTemperatureForecast
                      {
                        Day = new Temperature(13.61, TemperatureUnit.Celsius),
                        Min = new Temperature(7.42, TemperatureUnit.Celsius),
                        Max = new Temperature(13.61, TemperatureUnit.Celsius),
                        Night = new Temperature(7.42, TemperatureUnit.Celsius),
                        Evening = new Temperature(8.25, TemperatureUnit.Celsius),
                        Morning = new Temperature(7.66, TemperatureUnit.Celsius)
                      },
                      FeelsLike = new DailyFeelsLikeForecast
                      {
                        Day = new Temperature(12.67, TemperatureUnit.Celsius),
                        Night = new Temperature(6.38, TemperatureUnit.Celsius),
                        Evening = new Temperature(7.47, TemperatureUnit.Celsius),
                        Morning = new Temperature(7.66, TemperatureUnit.Celsius)
                      },
                      Pressure = new Pressure(1024),
                      Humidity = new Humidity(63),
                      DewPoint = new Temperature(6.08, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(1),
                      Clouds = 34,
                      Visibility = 0,
                      WindSpeed = 1.98d,
                      WindDirectionDegrees = 193,
                      WindGust = 1.8d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 802,
                          Type = WeatherConditionType.Clouds,
                          Description = "scattered clouds",
                          IconId = "03d"
                        }
                      },
                      Pop = 0d,
                      Rain = 0d,
                      Snow = 0d
                    },
                    new DailyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2023-01-02T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunrise = DateTime.ParseExact("2023-01-02T07:13:54.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunset = DateTime.ParseExact("2023-01-02T15:48:59.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonrise = DateTime.ParseExact("2023-01-02T12:33:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonset = DateTime.ParseExact("2023-01-02T03:02:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      MoonPhase = 0.36d,
                      Temperature = new DailyTemperatureForecast
                      {
                        Day = new Temperature(12.03, TemperatureUnit.Celsius),
                        Min = new Temperature(5.89, TemperatureUnit.Celsius),
                        Max = new Temperature(12.03, TemperatureUnit.Celsius),
                        Night = new Temperature(5.89, TemperatureUnit.Celsius),
                        Evening = new Temperature(6.56, TemperatureUnit.Celsius),
                        Morning = new Temperature(5.89, TemperatureUnit.Celsius)
                      },
                      FeelsLike = new DailyFeelsLikeForecast
                      {
                        Day = new Temperature(10.88, TemperatureUnit.Celsius),
                        Night = new Temperature(4.72, TemperatureUnit.Celsius),
                        Evening = new Temperature(5.61, TemperatureUnit.Celsius),
                        Morning = new Temperature(4.61, TemperatureUnit.Celsius)
                      },
                      Pressure = new Pressure(1022),
                      Humidity = new Humidity(61),
                      DewPoint = new Temperature(3.91, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(1),
                      Clouds = 21,
                      Visibility = 0,
                      WindSpeed = 1.8d,
                      WindDirectionDegrees = 175,
                      WindGust = 1.59d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 801,
                          Type = WeatherConditionType.Clouds,
                          Description = "few clouds",
                          IconId = "02d"
                        }
                      },
                      Pop = 0d,
                      Rain = 0d,
                      Snow = 0d
                    },
                    new DailyWeatherForecast
                    {
                      DateTime = DateTime.ParseExact("2023-01-03T11:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunrise = DateTime.ParseExact("2023-01-03T07:13:51.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Sunset = DateTime.ParseExact("2023-01-03T15:49:57.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonrise = DateTime.ParseExact("2023-01-03T12:59:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      Moonset = DateTime.ParseExact("2023-01-03T04:12:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                      MoonPhase = 0.39d,
                      Temperature = new DailyTemperatureForecast
                      {
                        Day = new Temperature(7.22, TemperatureUnit.Celsius),
                        Min = new Temperature(2.27, TemperatureUnit.Celsius),
                        Max = new Temperature(7.72, TemperatureUnit.Celsius),
                        Night = new Temperature(2.27, TemperatureUnit.Celsius),
                        Evening = new Temperature(3.54, TemperatureUnit.Celsius),
                        Morning = new Temperature(6.86, TemperatureUnit.Celsius)
                      },
                      FeelsLike = new DailyFeelsLikeForecast
                      {
                        Day = new Temperature(6.23, TemperatureUnit.Celsius),
                        Night = new Temperature(2.27, TemperatureUnit.Celsius),
                        Evening = new Temperature(1.61, TemperatureUnit.Celsius),
                        Morning = new Temperature(6.86, TemperatureUnit.Celsius)
                      },
                      Pressure = new Pressure(1027),
                      Humidity = new Humidity(93),
                      DewPoint = new Temperature(5.37, TemperatureUnit.Celsius),
                      UVIndex = new UVIndex(1),
                      Clouds = 97,
                      Visibility = 0,
                      WindSpeed = 3.41d,
                      WindDirectionDegrees = 234,
                      WindGust = 8.34d,
                      Weather = new List<WeatherCondition>
                      {
                        new WeatherCondition
                        {
                          Id = 500,
                          Type = WeatherConditionType.Rain,
                          Description = "light rain",
                          IconId = "10d"
                        }
                      },
                      Pop = 0.63d,
                      Rain = 2.35d,
                      Snow = 0d
                    }
                  },
            Alerts = new List<AlertInfo>
            {
            }
        };
    }
}
