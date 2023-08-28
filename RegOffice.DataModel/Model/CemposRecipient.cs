using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class CemposRecipient
    {

        /// <summary>
        /// Ид
        /// </summary>
        public Guid CemposRecipientId { get; set; }

        /// <summary>
        /// Код региона
        /// </summary>
        public string RegionCode { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        public string RecipientCode { get; set; }

        /// <summary>
        /// Старый код
        /// </summary>
        public string RecipientCodeOld { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string RecipientName { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Завершение перехода
        /// </summary>
        public DateTime? EndDate { get; set; }
    }
}
