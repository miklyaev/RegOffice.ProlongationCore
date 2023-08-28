using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица проверок для продуктов
    /// </summary>
    public partial class ProductChecking
    {
        public ProductChecking()
        {
            ProductCheckingSteps = new HashSet<ProductCheckingStep>();
            ProductPassportCheckings = new HashSet<ProductPassportChecking>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CheckingId { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Тип проверки
        /// </summary>
        public int CheckingTypeId { get; set; }

        /// <summary>
        /// Дата проверки
        /// </summary>
        public DateTime CheckingTime { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Сотрудник
        /// </summary>
        public int? ProductPersonId { get; set; }

        /// <summary>
        /// Идентификатор запроса
        /// </summary>
        public Guid? TaskId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Содержание проверки
        /// </summary>
        public int? ContentId { get; set; }

        public virtual CheckingType CheckingType { get; set; }
        public virtual File Content { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductPerson ProductPerson { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ProductCheckingStep> ProductCheckingSteps { get; set; }
        public virtual ICollection<ProductPassportChecking> ProductPassportCheckings { get; set; }
    }
}
