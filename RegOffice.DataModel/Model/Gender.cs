using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица полов
    /// </summary>
    public partial class Gender
    {
        public Gender()
        {
            People = new HashSet<Person>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int GenderId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string GenderName { get; set; }

        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
