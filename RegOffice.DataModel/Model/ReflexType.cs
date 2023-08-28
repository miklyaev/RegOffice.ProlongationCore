using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов отражений
    /// </summary>
    public partial class ReflexType
    {
        public ReflexType()
        {
            ReflexMessengers = new HashSet<ReflexMessenger>();
            ReflexProductTypes = new HashSet<ReflexProductType>();
            ReflexProducts = new HashSet<ReflexProduct>();
            ReflexRules = new HashSet<ReflexRule>();
            ReflexTypeSystems = new HashSet<ReflexTypeSystem>();
            ReflexUseTypes = new HashSet<ReflexUseType>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int ReflexTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string ReflexTypeName { get; set; }

        public virtual ICollection<ReflexMessenger> ReflexMessengers { get; set; }
        public virtual ICollection<ReflexProductType> ReflexProductTypes { get; set; }
        public virtual ICollection<ReflexProduct> ReflexProducts { get; set; }
        public virtual ICollection<ReflexRule> ReflexRules { get; set; }
        public virtual ICollection<ReflexTypeSystem> ReflexTypeSystems { get; set; }
        public virtual ICollection<ReflexUseType> ReflexUseTypes { get; set; }
    }
}
