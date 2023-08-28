using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица адрес (временная)
    /// </summary>
    public partial class Addr
    {
        public Addr()
        {
            AbonentLocationAddresses = new HashSet<Abonent>();
            AbonentPostalAddresses = new HashSet<Abonent>();
            Orders = new HashSet<Order>();
            Points = new HashSet<Point>();
            ProductAbonentLocationAddresses = new HashSet<Product>();
            ProductAbonentPostalAddresses = new HashSet<Product>();
            RegBankRequests = new HashSet<RegBankRequest>();
            RegRequestLocationAddresses = new HashSet<RegRequest>();
            RegRequestPostalAddresses = new HashSet<RegRequest>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AddrId { get; set; }

        /// <summary>
        /// Индекс
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Регион
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// Район
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Населенный пункт
        /// </summary>
        public string Locality { get; set; }

        /// <summary>
        /// Улица
        /// </summary>
        public string Street { get; set; }

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

        /// <summary>
        /// ФИАС адрес в формате XML
        /// </summary>
        public string FiasXml { get; set; }

        /// <summary>
        /// Строковое представление ФИАС адреса
        /// </summary>
        public string FiasStringView { get; set; }

        /// <summary>
        /// Идентификатор ФИАС адреса
        /// </summary>
        public Guid? FiasGuid { get; set; }

        /// <summary>
        /// Адрес, начиная с улицы
        /// </summary>
        public string StreetAddress { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<Abonent> AbonentLocationAddresses { get; set; }
        public virtual ICollection<Abonent> AbonentPostalAddresses { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Point> Points { get; set; }
        public virtual ICollection<Product> ProductAbonentLocationAddresses { get; set; }
        public virtual ICollection<Product> ProductAbonentPostalAddresses { get; set; }
        public virtual ICollection<RegBankRequest> RegBankRequests { get; set; }
        public virtual ICollection<RegRequest> RegRequestLocationAddresses { get; set; }
        public virtual ICollection<RegRequest> RegRequestPostalAddresses { get; set; }
    }
}
