using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class NotificationTemplate
    {

        /// <summary>
        /// Гуид шаблона
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        /// Абонент
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public int StateId { get; set; }

        /// <summary>
        /// Имя шаблона
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Почта
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Время окончания действия
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Запрос на выборку
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Время исполнения
        /// </summary>
        public int Trigger { get; set; }

        /// <summary>
        /// Время создания
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Ближайшее время срабатывания
        /// </summary>
        public DateTime? TriggerTime { get; set; }

        /// <summary>
        /// Файл результатов выборки
        /// </summary>
        public int? FileId { get; set; }

        /// <summary>
        /// Время обновления результата
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        public virtual Product Product { get; set; }
        public virtual NotificationTemplateState State { get; set; }
    }
}
