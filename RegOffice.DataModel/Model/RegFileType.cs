using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов рег-файлов
    /// </summary>
    public partial class RegFileType
    {
        public RegFileType()
        {
            ProductPeople = new HashSet<ProductPerson>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int RegFileTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string RegFileTypeName { get; set; }

        public virtual ICollection<ProductPerson> ProductPeople { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
