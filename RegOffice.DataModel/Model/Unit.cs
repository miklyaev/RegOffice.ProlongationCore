using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица ед. измерения
    /// </summary>
    public partial class Unit
    {
        public Unit()
        {
            CaTemplateAttributes = new HashSet<CaTemplateAttribute>();
            DssUserGroups = new HashSet<DssUserGroup>();
            OfdDevices = new HashSet<OfdDevice>();
            OfdPinTemplates = new HashSet<OfdPinTemplate>();
            OfdPins = new HashSet<OfdPin>();
            TariffAttributes = new HashSet<TariffAttribute>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int UnitId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string UnitName { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int UnitTypeId { get; set; }

        public virtual UnitType UnitType { get; set; }
        public virtual ICollection<CaTemplateAttribute> CaTemplateAttributes { get; set; }
        public virtual ICollection<DssUserGroup> DssUserGroups { get; set; }
        public virtual ICollection<OfdDevice> OfdDevices { get; set; }
        public virtual ICollection<OfdPinTemplate> OfdPinTemplates { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
        public virtual ICollection<TariffAttribute> TariffAttributes { get; set; }
    }
}
