using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOffice.General.Enums
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class EnumProtocolAttribute : CheckAttribute
    {
        public new ProtocolInfo Value
        {
            get
            {
                return (ProtocolInfo)base.Value;
            }
        }
        public EnumProtocolAttribute(ProtocolInfo protocol) : base((int)protocol)
        { }
    }
}
