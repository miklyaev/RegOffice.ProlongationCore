using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOffice.General.Enums
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class DirectionAttribute : CheckAttribute
    {
        public new TariffDirection Value
        {
            get
            {
                return (TariffDirection)base.Value;
            }
        }
        public DirectionAttribute(TariffDirection direction)
            : base((int)direction)
        { }
    }
}
