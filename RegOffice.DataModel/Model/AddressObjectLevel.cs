using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица уровней адреса
    /// </summary>
    public partial class AddressObjectLevel
    {
        public AddressObjectLevel()
        {
            AddressObjectPrefixes = new HashSet<AddressObjectPrefix>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int LevelId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string LevelName { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string LevelNote { get; set; }

        public virtual ICollection<AddressObjectPrefix> AddressObjectPrefixes { get; set; }
    }
}
