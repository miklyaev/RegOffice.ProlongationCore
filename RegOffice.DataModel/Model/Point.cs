using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица точек
    /// </summary>
    public partial class Point
    {
        public Point()
        {
            AgentSchemes = new HashSet<AgentScheme>();
            PointSteps = new HashSet<PointStep>();
            PointUses = new HashSet<PointUse>();
            PointZones = new HashSet<PointZone>();
            Products = new HashSet<Product>();
            RegRequestIdentPoints = new HashSet<RegRequest>();
            RegRequestTransferPoints = new HashSet<RegRequest>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PointId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string PointName { get; set; }

        /// <summary>
        /// Гуид
        /// </summary>
        public Guid PointGuid { get; set; }

        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public int? AddressId { get; set; }

        /// <summary>
        /// График работы
        /// </summary>
        public string Schedule { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Электронный адрес
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Широта
        /// </summary>
        public decimal? Latitude { get; set; }

        /// <summary>
        /// Долгота
        /// </summary>
        public decimal? Longitude { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        public virtual Addr Address { get; set; }
        public virtual Agent Agent { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<AgentScheme> AgentSchemes { get; set; }
        public virtual ICollection<PointStep> PointSteps { get; set; }
        public virtual ICollection<PointUse> PointUses { get; set; }
        public virtual ICollection<PointZone> PointZones { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<RegRequest> RegRequestIdentPoints { get; set; }
        public virtual ICollection<RegRequest> RegRequestTransferPoints { get; set; }
    }
}
