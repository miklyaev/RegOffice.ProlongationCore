using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов хранилищ
    /// </summary>
    public partial class StorageType
    {
        public StorageType()
        {
            ProductPeople = new HashSet<ProductPerson>();
            ProductPersonKeys = new HashSet<ProductPersonKey>();
            Products = new HashSet<Product>();
            ReflexRules = new HashSet<ReflexRule>();
            RegRequestMembers = new HashSet<RegRequestMember>();
            RegRequests = new HashSet<RegRequest>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int StorageTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string StorageTypeName { get; set; }

        public virtual ICollection<ProductPerson> ProductPeople { get; set; }
        public virtual ICollection<ProductPersonKey> ProductPersonKeys { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ReflexRule> ReflexRules { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
    }
}
