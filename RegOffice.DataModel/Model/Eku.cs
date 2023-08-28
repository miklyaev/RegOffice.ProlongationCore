using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица расширений сертификата
    /// </summary>
    public partial class Eku
    {
        public Eku()
        {
            AttributeEkus = new HashSet<AttributeEku>();
            CertTemplateEkus = new HashSet<CertTemplateEku>();
            ProductPeople = new HashSet<ProductPerson>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int EkuId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string EkuName { get; set; }

        /// <summary>
        /// Объектный идентификатор
        /// </summary>
        public string EkuOid { get; set; }

        /// <summary>
        /// Обязательный
        /// </summary>
        public bool Required { get; set; }

        public virtual ICollection<AttributeEku> AttributeEkus { get; set; }
        public virtual ICollection<CertTemplateEku> CertTemplateEkus { get; set; }
        public virtual ICollection<ProductPerson> ProductPeople { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
