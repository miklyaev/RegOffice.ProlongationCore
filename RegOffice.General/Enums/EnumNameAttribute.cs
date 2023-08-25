using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RegOffice.General.Enums
{
    public class EnumNameAttribute : Attribute
    {
        public readonly string Description;

        public EnumNameAttribute(string description)
        {
            this.Description = description;
        }
    }

    public static class EnumNameHelper
    {
        public static string GetName(this Enum value, bool throwException = true)
        {
            object[] attribs = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(EnumNameAttribute), false);
            if (attribs.Length > 0)
                return ((EnumNameAttribute)attribs[attribs.Length - 1]).Description;
            if (!throwException)
                return null;
            throw new NotImplementedException("Конвертация для данного формата не реализована");
        }

        public static string GetAlias(this Enum value)
        {
            object[] attribs = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(EnumAliasAttribute), false);
            if (attribs.Length > 0)
                return ((EnumAliasAttribute)attribs[attribs.Length - 1]).Description;
            throw new NotImplementedException("Конвертация для данного формата не реализована");
        }

        public static string GetNames(this Enum value)
        {
            return string.Join(",", value.GetType().GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly).
                Where(f => ((int)f.GetValue(null) & (int)(object)value) != 0).
                Select(f => f.GetCustomAttributes(typeof(EnumNameAttribute), false).Cast<EnumNameAttribute>().
                FirstOrDefault()?.Description).Where(a => a != null).Distinct());
        }
    }
}
