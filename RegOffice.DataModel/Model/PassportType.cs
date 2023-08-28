using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов документов удостоверяющих личность
    /// </summary>
    public partial class PassportType
    {
        public PassportType()
        {
            Docs = new HashSet<Doc>();
            People = new HashSet<Person>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PassportTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string PassportTypeName { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        public string PassportTypeCode { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string PassportTypeNote { get; set; }

        public virtual ICollection<Doc> Docs { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
