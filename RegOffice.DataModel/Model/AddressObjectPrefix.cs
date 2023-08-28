using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица префиксов адреса
    /// </summary>
    public partial class AddressObjectPrefix
    {
        public AddressObjectPrefix()
        {
            AddressObjects = new HashSet<AddressObject>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int PrefixId { get; set; }

        /// <summary>
        /// Уровень
        /// </summary>
        public int LevelId { get; set; }

        /// <summary>
        /// Сокращение
        /// </summary>
        public string PrefixName { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string FullName { get; set; }

        public virtual AddressObjectLevel Level { get; set; }
        public virtual ICollection<AddressObject> AddressObjects { get; set; }
    }
}
