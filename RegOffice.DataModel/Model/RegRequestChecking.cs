using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица проверок для заявлений
    /// </summary>
    public partial class RegRequestChecking
    {
        public RegRequestChecking()
        {
            RegRequestCheckingSteps = new HashSet<RegRequestCheckingStep>();
            RegRequestPassportCheckings = new HashSet<RegRequestPassportChecking>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CheckingId { get; set; }

        /// <summary>
        /// Заявление
        /// </summary>
        public int RegRequestId { get; set; }

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
        public int? MemberId { get; set; }

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
        public virtual RegRequestMember Member { get; set; }
        public virtual RegRequest RegRequest { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<RegRequestCheckingStep> RegRequestCheckingSteps { get; set; }
        public virtual ICollection<RegRequestPassportChecking> RegRequestPassportCheckings { get; set; }
    }
}
