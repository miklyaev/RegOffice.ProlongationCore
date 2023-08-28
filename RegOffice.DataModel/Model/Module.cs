using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица модулей
    /// </summary>
    public partial class Module
    {
        public Module()
        {
            ModuleTariffs = new HashSet<ModuleTariff>();
            RoleModules = new HashSet<RoleModule>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int ModuleId { get; set; }

        /// <summary>
        /// Тип продукта
        /// </summary>
        public int? ProductTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string MuduleName { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int TypeId { get; set; }

        public virtual ProductType ProductType { get; set; }
        public virtual ModuleType Type { get; set; }
        public virtual ICollection<ModuleTariff> ModuleTariffs { get; set; }
        public virtual ICollection<RoleModule> RoleModules { get; set; }
    }
}
