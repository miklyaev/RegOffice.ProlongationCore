using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOffice.General.Enums
{
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumAliasAttribute : Attribute
    {
        public readonly string Description;

        public EnumAliasAttribute(string description)
        {
            this.Description = description;
        }
    }
}
