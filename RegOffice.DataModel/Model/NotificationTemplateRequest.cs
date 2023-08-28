using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Запросы шаблонов уведомлений
    /// </summary>
    public partial class NotificationTemplateRequest
    {

        /// <summary>
        /// Идентификатор запроса
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Гуид шаблона
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        /// Тип запроса
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// Время приема запроса
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Имя шаблона
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Почта
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Окончание действия шаблона
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Запрос на выборку
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Временной триггер
        /// </summary>
        public int? Trigger { get; set; }

        /// <summary>
        /// Файл запроса
        /// </summary>
        public int FileId { get; set; }

        public virtual Product Product { get; set; }
        public virtual NotificationTemplateRequestType Type { get; set; }
    }
}
