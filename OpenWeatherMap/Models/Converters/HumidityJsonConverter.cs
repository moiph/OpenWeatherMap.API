﻿using System;
using Newtonsoft.Json;

namespace OpenWeatherMap.Models.Converters
{
    internal class HumidityJsonConverter : JsonConverter<Humidity>
    {
        public override void WriteJson(JsonWriter writer, Humidity value, JsonSerializer serializer)
        {
            writer.WriteValue(value.Value);
        }

        public override Humidity ReadJson(JsonReader reader, Type objectType, Humidity existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.Value is long humidity)
            {
                return (Humidity)humidity;
            }

            throw new NotSupportedException($"Cannot convert from {reader.Value} to {nameof(Humidity)}");
        }
    }
}
