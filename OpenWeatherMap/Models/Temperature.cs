﻿using System;
using System.Globalization;
using System.Linq;

namespace OpenWeatherMap.Models
{
    [Serializable]
    public struct Temperature : IComparable, IComparable<Temperature>, IComparable<double>, IEquatable<Temperature>, IFormattable
    {
        private const double Zero = 0d;
        public const double AbsoluteZeroCelsius = -273.15;
        public const double AbsoluteZeroFahrenheit = -459.67;

        public const double ZeroCelsiusAsKelvin = 273.15;
        public const double ZeroFahrenheitAsKelvin = 459.67 * 5 / 9.0;
        public const double FahrenheitPerKelvin = 9.0 / 5.0;
        public const double KelvinPerFahrenheit = 5.0 / 9.0;

        public static readonly Temperature ZeroKelvin = FromKelvin(0.0);
        public static readonly Temperature ZeroCelsius = FromCelsius(0.0);
        public static readonly Temperature ZeroFahrenheit = FromFahrenheit(0.0);
        public static readonly Temperature MinValue = ZeroKelvin;

        private static readonly char[] NumericalToStringPrefixes =
        {
            'N', 'D', 'F'
        };

        public Temperature(double value, TemperatureUnit unit)
        {
            if (value < 0d && unit == TemperatureUnit.Kelvin)
            {
                throw new ArgumentOutOfRangeException(string.Format($"{0} is less than absolute zero.", value));
            }

            this.Unit = unit;
            this.Value = value;
        }

        public double Value { get; internal set; }

        public TemperatureUnit Unit { get; internal set; }

        public static Temperature FromKelvin(double kelvin)
        {
            return new Temperature(kelvin, TemperatureUnit.Kelvin);
        }

        public static Temperature FromCelsius(double celsius)
        {
            return new Temperature(celsius, TemperatureUnit.Celsius);
        }

        public static Temperature FromFahrenheit(double fahrenheit)
        {
            return new Temperature(fahrenheit, TemperatureUnit.Fahrenheit);
        }

        public static double KelvinToCelsius(double kelvin)
        {
            return kelvin + AbsoluteZeroCelsius;
        }

        public static double CelsiusToKelvin(double celsius)
        {
            return celsius - AbsoluteZeroCelsius;
        }

        public static double KelvinToFahrenheit(double kelvin)
        {
            return kelvin * 1.8 + AbsoluteZeroFahrenheit;
        }

        public static double FahrenheitToKelvin(double fahrenheit)
        {
            return (fahrenheit - AbsoluteZeroFahrenheit) / 1.8;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return celsius * 1.8 + 32.0;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32.0) / 1.8;
        }

        public int CompareTo(object obj)
        {
            if (obj is Temperature)
            {
                return this.ToKelvin().CompareTo((double)obj);
            }

            return this.ToKelvin().CompareTo(obj);
        }

        public int CompareTo(Temperature other)
        {
            return this.ToKelvin().CompareTo(other.ToKelvin());
        }

        public int CompareTo(double other)
        {
            return this.Value.CompareTo(other);
        }

        public bool Equals(Temperature other)
        {
            return this.ToKelvin().Equals(other.ToKelvin());
        }

        public static double ToKelvin(double srcValue, TemperatureUnit srcUnit)
        {
            switch (srcUnit)
            {
                case TemperatureUnit.Celsius:
                    return 273.15 + srcValue;

                case TemperatureUnit.Fahrenheit:
                    return ZeroFahrenheitAsKelvin + srcValue * KelvinPerFahrenheit;

                case TemperatureUnit.Kelvin:
                    return srcValue;

                default:
                    throw new ArgumentOutOfRangeException("TemperatureUnit is unknown: " + srcUnit.ToString());
            }
        }
        public static double FromKelvinTo(double srcValueInKelvin, TemperatureUnit destinationUnit)
        {
            switch (destinationUnit)
            {
                case TemperatureUnit.Celsius:
                    return srcValueInKelvin - ZeroCelsiusAsKelvin;

                case TemperatureUnit.Fahrenheit:
                    return (srcValueInKelvin - ZeroFahrenheitAsKelvin) * FahrenheitPerKelvin;

                case TemperatureUnit.Kelvin:
                    return srcValueInKelvin;

                default:
                    throw new ArgumentOutOfRangeException("TemperatureUnit is unknown: " + destinationUnit.ToString());
            }
        }

        public static Temperature operator +(double v, Temperature t)
        {
            return new Temperature(t.Value + v, t.Unit);
        }

        public static Temperature operator +(Temperature t, double v)
        {
            return v + t;
        }

        public static Temperature operator +(Temperature t1, Temperature t2)
        {
            RequireSameUnit(t1, t2);
            return t1 + t2.Value;
        }

        public static Temperature operator -(Temperature t, double v)
        {
            return new Temperature(t.Value - v, t.Unit);
        }

        public static Temperature operator -(Temperature t1, Temperature t2)
        {
            RequireSameUnit(t1, t2);
            return t1 - t2.Value;
        }

        public static Temperature operator *(Temperature t, double v)
        {
            return new Temperature(t.Value * v, t.Unit);
        }

        public static Temperature operator /(Temperature t1, double v)
        {
            return new Temperature(t1.Value / v, t1.Unit);
        }

        private static void RequireSameUnit(Temperature t1, Temperature t2)
        {
            if (!t1.Unit.Equals(t2.Unit))
            {
                throw new TemperatureUnitMismatchException(t1.Unit, t2.Unit);
            }
        }

        /// <summary>
        /// Returns the string representation of the temperature.
        /// Default format is "0.##" and the respective unit.
        /// </summary>
        public override string ToString()
        {
            return this.ToString(null, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Returns the string representation of the temperature.
        /// Default format is "0.## °C" (where °C is replaced with the respective unit).s
        /// </summary>
        /// <param name="format">
        /// The format.
        /// This can either be a number format (e.g. "0" or "0.##").
        /// Following formats are valid too: "U" = Unit string only (e.g. °C). "N" = Numeric value only.
        /// </param>
        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            if (string.IsNullOrEmpty(format))
            {
                format = "0.##";
            }

            if (provider == null)
            {
                provider = CultureInfo.CurrentCulture;
            }

            var unitString = EnumUtils.GetDescription(this.Unit);

            if (format == "U")
            {
                return unitString;
            }

            // In order to avoid string formatted numbers like "-0" we parse-back to double
            // and check if the double value is exactly "0" or "-0".
            // See also: https://stackoverflow.com/questions/3139538/is-minus-zero-0-equivalent-to-zero-0-in-c-sharp
            var temperatureString = this.Value.ToString(format, provider);
            if (double.TryParse(temperatureString, out var parsed) &&
                Equals(parsed, Zero) &&
                BitConverter.DoubleToInt64Bits(Zero) != BitConverter.DoubleToInt64Bits(parsed))
            {
                temperatureString = Zero.ToString(format, provider);
            }

            if (NumericalToStringPrefixes.Contains(format[0]))
            {
                return temperatureString;
            }

            return $"{temperatureString}{unitString}";
        }
    }
}