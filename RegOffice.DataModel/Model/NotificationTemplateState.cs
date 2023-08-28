using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Состояния шаблонов уведомлений
    /// </summary>
    public partial class NotificationTemplateState
    {
        public NotificationTemplateState()
        {
            NotificationTemplates = new HashSet<NotificationTemplate>();
        }


        /// <summary>
        /// Идентификатор состояния
        /// </summary>
        public int StateId { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        public virtual ICollection<NotificationTemplate> NotificationTemplates { get; set; }
    }
}
