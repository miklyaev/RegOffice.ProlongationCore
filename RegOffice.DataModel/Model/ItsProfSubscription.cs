using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица подписок ИТС-Проф
    /// </summary>
    public partial class ItsProfSubscription
    {

        /// <summary>
        /// Идентификатор ИТС подписки
        /// </summary>
        public int ItsSubscriptionId { get; set; }

        /// <summary>
        /// Наименование ИТС подписки
        /// </summary>
        public string ItsPublishName { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }
    }
}
