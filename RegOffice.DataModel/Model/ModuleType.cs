using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Тип модуля
    /// </summary>
    public partial class ModuleType
    {
        public ModuleType()
        {
            Modules = new HashSet<Module>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int ModuleTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string ModuleTypeName { get; set; }

        public virtual ICollection<Module> Modules { get; set; }
    }
}
