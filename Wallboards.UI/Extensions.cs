using System;
using System.Data;
using System.Globalization;

namespace Wallboards.UI
{
    public static class Extensions
    {
        public static T ExstractValue<T>(this IDataReader reader, string column)
        { 
            var ordinal = reader.GetOrdinal(column);
            var value = reader.GetValue(ordinal);

            return  value.ChangeType<T>();
        } 

        public static T ChangeType<T>(this object value)
        {
            return (T)ChangeType(value, typeof(T));
        }

        public static T ChangeType<T>(this object value, T whenNull)
        {
            return value == null || value == DBNull.Value
                ? whenNull
                : (T)ChangeType(value, typeof(T));
        }

        private static object ChangeType(this object value, Type convertToType)
        {
            if (convertToType == null)
            {
                return null;
            }

            if (value == null || value is DBNull)
            {
                return null;
            }
 
            if (convertToType.IsGenericType && convertToType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                convertToType = Nullable.GetUnderlyingType(convertToType);
            }

            if (convertToType.IsEnum && value is string)
            {
                return Enum.Parse(convertToType, (string)value);
            }

            if (convertToType.IsEnum && value.GetType().IsPrimitive && !(value is bool) &&
                !(value is char) && !(value is float) && !(value is double))
            {
                return Enum.ToObject(convertToType, value);
            }

            try
            {
                return Convert.ChangeType(value, convertToType, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                 //TODO:
            }

            return null;
        }

    }
}