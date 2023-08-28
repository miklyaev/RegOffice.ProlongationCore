using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица стран мира
    /// </summary>
    public partial class Country
    {
        public Country()
        {
            People = new HashSet<Person>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }


        /// <summary>
        /// Цифровой код
        /// </summary>
        public string CountryId { get; set; }

        /// <summary>
        /// Буквенный код альфа-3
        /// </summary>
        public string Alpha3Id { get; set; }

        /// <summary>
        /// Буквенный код альфа-2
        /// </summary>
        public string Alpha2Id { get; set; }

        /// <summary>
        /// Краткое наименование
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Полное наименование
        /// </summary>
        public string FullName { get; set; }

        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
