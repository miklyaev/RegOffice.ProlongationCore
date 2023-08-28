using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица адресов
    /// </summary>
    public partial class Address
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// Регион
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// Район
        /// </summary>
        public int? AreaId { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        public int? CityId { get; set; }

        /// <summary>
        /// Населенный пункт
        /// </summary>
        public int? LocalityId { get; set; }

        /// <summary>
        /// Улица
        /// </summary>
        public int? StreetId { get; set; }

        /// <summary>
        /// Индекс
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Дом
        /// </summary>
        public string Building { get; set; }

        /// <summary>
        /// Корпус
        /// </summary>
        public string Bulk { get; set; }

        /// <summary>
        /// Квартира
        /// </summary>
        public string Flat { get; set; }

        public virtual AddressObject Area { get; set; }
        public virtual AddressObject City { get; set; }
        public virtual AddressObject Locality { get; set; }
        public virtual AddressObject Region { get; set; }
        public virtual AddressObject Street { get; set; }
    }
}
