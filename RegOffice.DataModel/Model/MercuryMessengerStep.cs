using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний курьеров АстралОтчет
    /// </summary>
    public partial class MercuryMessengerStep
    {

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// АстралОтчет
        /// </summary>
        public int MercuryId { get; set; }

        /// <summary>
        /// Курьер
        /// </summary>
        public int MessengerId { get; set; }

        /// <summary>
        /// Следующее состояние
        /// </summary>
        public int? NextStepId { get; set; }

        /// <summary>
        /// Ошибка
        /// </summary>
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Предыдущие состояние
        /// </summary>
        public int? PreviousStepId { get; set; }

        /// <summary>
        /// Файл
        /// </summary>
        public int? FileId { get; set; }

        public virtual File File { get; set; }
        public virtual MercuryMessenger Me { get; set; }
        public virtual Product Mercury { get; set; }
        public virtual Messenger Messenger { get; set; }
        public virtual Step NextStep { get; set; }
        public virtual Step PreviousStep { get; set; }
        public virtual Step Step { get; set; }
    }
}
