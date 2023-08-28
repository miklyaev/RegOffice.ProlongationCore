using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица подразделений
    /// </summary>
    public partial class OrgUnit
    {
        public OrgUnit()
        {
            AbonentPeople = new HashSet<AbonentPerson>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int OrgUnitId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string OrgUnitName { get; set; }

        /// <summary>
        /// Флаг отображения
        /// </summary>
        public bool Display { get; set; }

        public virtual ICollection<AbonentPerson> AbonentPeople { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
