using System;

namespace Exercise3
{
    public static class Ensure
    {
        internal static T Greater<T>(T value, T min, string parameterName) where T : IComparable
        {
            if( value.CompareTo(min) <= 0 )
            {
                throw new ArgumentException(nameof(value), $"Invalid value [{parameterName}] must be greater than [{min}]");
            }
            return value;
        }

        internal static T NotNull<T>(T value, string parameterName)
        {
            if( value == null )
            {
                throw new ArgumentNullException(nameof(value));
            }
            return value;
        }


        internal static string Length(string value, int min, int max, string parameterName)
        {
            if( value.Length < min)
            {
                throw new ArgumentException(nameof(value), $"Invalid value [{parameterName}] is less than [{min}] characters");
            }
            if (value.Length > max)
            {
                throw new ArgumentException(nameof(value), $"Invalid value [{parameterName}] is greater than [{max}] characters");
            }
            return value;
        }

        internal static string NotNullOrWhitespace(string value, string parameterName)
        {
            if( string.IsNullOrWhiteSpace(value) )
            {
                throw new ArgumentException(nameof(value), $"Invalid {parameterName} can't be null or empty string");
            }
            return value;
        }
    }
}