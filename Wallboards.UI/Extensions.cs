using System;
using System.Data;
using System.Globalization;

namespace Wallboards.UI
{
    public static class Extensions
    {
        public static T ExstractValue<T>(this IDataReader reader, string column)
        {
            T t;

            try
            {
                var ordinal = reader.GetOrdinal(column);
                var value = reader.GetValue(ordinal);

                t = value.ChangeType<T>();
            }
            catch (Exception)
            { 
                t = default(T);
            }

            return t;
        } 

        public static T ChangeType<T>(this object value)
        {
            return (T)ChangeType(value, typeof(T));
        }

        public static T ChangeType<T>(this object value, T whenNull)
        {
            return (value == null || value == DBNull.Value)
                ? whenNull
                : (T)ChangeType(value, typeof(T));
        }

        private static object ChangeType(this object value, Type convertToType)
        {
            if (convertToType == null)
            {
                throw new ArgumentNullException(nameof(convertToType));
            }

            // return null if the value is null or DBNull
            if (value == null || value is DBNull)
            {
                return null;
            }

            // non-nullable types, which are not supported by Convert.ChangeType(), 
            // unwrap the types to determine the underlying time
            if (convertToType.IsGenericType &&
            convertToType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                convertToType = Nullable.GetUnderlyingType(convertToType);
            }

            // deal with conversion to enum types when input is a string 
            if (convertToType.IsEnum && value is string)
            {
                return Enum.Parse(convertToType, (string)value);
            }

            // deal with conversion to enum types when input is a integral primitive 
            if (convertToType.IsEnum && value.GetType().IsPrimitive && !(value is bool) &&
                !(value is char) && !(value is float) && !(value is double))
            {
                return Enum.ToObject(convertToType, value);
            }

            return Convert.ChangeType(value, convertToType, CultureInfo.InvariantCulture);
        }

    }
}