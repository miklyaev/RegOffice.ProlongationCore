using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Типы запросов шаблонов уведомлений
    /// </summary>
    public partial class NotificationTemplateRequestType
    {
        public NotificationTemplateRequestType()
        {
            NotificationTemplateRequests = new HashSet<NotificationTemplateRequest>();
        }


        /// <summary>
        /// Тип запроса шаблона
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        public virtual ICollection<NotificationTemplateRequest> NotificationTemplateRequests { get; set; }
    }
}
