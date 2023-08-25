using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOffice.General.Enums
{
    public class CheckAttribute : Attribute
    {
        public readonly int Value;
        public CheckAttribute(int value)
        {
            Value = value;
        }
        public CheckAttribute()
        { }
    }
}
