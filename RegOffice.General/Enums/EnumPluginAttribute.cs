using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOffice.General.Enums
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class PluginAttribute : CheckAttribute
    {
        public new PluginInfo Value
        {
            get
            {
                return (PluginInfo)base.Value;
            }
        }

        public PluginAttribute(PluginInfo plugin) : base((int)plugin)
        { }
    }
}
