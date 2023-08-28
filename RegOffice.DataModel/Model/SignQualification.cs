using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица квалификаций подписи
    /// </summary>
    public partial class SignQualification
    {
        public SignQualification()
        {
            ProductPeople = new HashSet<ProductPerson>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int SignQualificationId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string SignQualificationName { get; set; }

        public virtual ICollection<ProductPerson> ProductPeople { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
