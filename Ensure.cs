using System;

namespace Exercise3
{
    public static class Ensure
    {
        internal static uint Greater(uint value, int limit)
        {
            if( value < limit )
            {
                throw new ArgumentException(nameof(value), $"Invalid value [{value}] is less than [{limit}]");
            }
            return value;
        }

        internal static float Greater(float value, float limit)
        {
            if (value < limit)
            {
                throw new ArgumentException(nameof(value), $"Invalid value [{value}] is less than [{limit}]");
            }
            return value;
        }

        internal static T NotNull<T>(T value)
        {
            if( value == null )
            {
                throw new ArgumentNullException(nameof(value));
            }
            return value;
        }


        internal static string Length(string value, int min, int max)
        {
            if( value.Length < min)
            {
                throw new ArgumentException(nameof(value), $"Invalid value [{value}] is less than [{min}] characters");
            }
            if (value.Length > max)
            {
                throw new ArgumentException(nameof(value), $"Invalid value [{value}] is greater than [{max}] characters");
            }
            return value;
        }

        internal static string NotNullOrWhitespace(string value)
        {
            if( string.IsNullOrWhiteSpace(value) )
            {
                throw new ArgumentException(nameof(value), $"Invalid value can't be null or empty string");
            }
            return value;
        }
    }
}