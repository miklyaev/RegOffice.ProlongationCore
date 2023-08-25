using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOffice.General.Enums
{
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumGuidAttribute : Attribute
    {
        public readonly Guid GuidValue;

        public EnumGuidAttribute(string guid)
        {
            this.GuidValue = Guid.Parse(guid);
        }
    }
}
