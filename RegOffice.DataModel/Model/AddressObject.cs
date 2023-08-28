using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица объектов адреса
    /// </summary>
    public partial class AddressObject
    {
        public AddressObject()
        {
            InverseParent = new HashSet<AddressObject>();
            AddressAreas = new HashSet<Address>();
            AddressCities = new HashSet<Address>();
            AddressLocalities = new HashSet<Address>();
            AddressRegions = new HashSet<Address>();
            AddressStreets = new HashSet<Address>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AddressObjectId { get; set; }

        /// <summary>
        /// Родитель
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// Префикс
        /// </summary>
        public int PrefixId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string AddressObjectName { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        public string AddressObjectCode { get; set; }
        public string PostalCode { get; set; }

        /// <summary>
        /// Код ИФНС
        /// </summary>
        public string TaxCode { get; set; }

        /// <summary>
        /// Код тер. уч. ИФНС
        /// </summary>
        public string AreaTaxCode { get; set; }

        /// <summary>
        /// ОКАТО
        /// </summary>
        public string Okato { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public int? Status { get; set; }

        public virtual AddressObject Parent { get; set; }
        public virtual AddressObjectPrefix Prefix { get; set; }
        public virtual ICollection<AddressObject> InverseParent { get; set; }
        public virtual ICollection<Address> AddressAreas { get; set; }
        public virtual ICollection<Address> AddressCities { get; set; }
        public virtual ICollection<Address> AddressLocalities { get; set; }
        public virtual ICollection<Address> AddressRegions { get; set; }
        public virtual ICollection<Address> AddressStreets { get; set; }
    }
}
