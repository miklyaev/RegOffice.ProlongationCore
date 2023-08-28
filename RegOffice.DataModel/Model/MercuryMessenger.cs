using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица курьеров АстралОтчет
    /// </summary>
    public partial class MercuryMessenger
    {
        public MercuryMessenger()
        {
            MercuryMessengerSteps = new HashSet<MercuryMessengerStep>();
            MercuryRecipients = new HashSet<MercuryRecipient>();
        }


        /// <summary>
        /// АстралОтчет
        /// </summary>
        public int MercuryId { get; set; }

        /// <summary>
        /// Курьер
        /// </summary>
        public int MessengerId { get; set; }

        /// <summary>
        /// Логин входящий
        /// </summary>
        public string AccountIn { get; set; }

        /// <summary>
        /// Логин исходящий
        /// </summary>
        public string AccountOut { get; set; }

        /// <summary>
        /// Пароль входящий
        /// </summary>
        public string PasswordIn { get; set; }

        /// <summary>
        /// Пароль исходящий
        /// </summary>
        public string PasswordOut { get; set; }

        /// <summary>
        /// Идентификатор пакета
        /// </summary>
        public string PackId { get; set; }

        /// <summary>
        /// Состояния
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Логин в ИРУЦ
        /// </summary>
        public string IrucAccount { get; set; }

        /// <summary>
        /// Пароль в ИРУЦ
        /// </summary>
        public string IrucPassword { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Дата оключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        /// <summary>
        /// Оператор ИРУЦ
        /// </summary>
        public int? OperatorIrucId { get; set; }

        public virtual Product Mercury { get; set; }
        public virtual Messenger Messenger { get; set; }
        public virtual OperatorIruc OperatorIruc { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<MercuryMessengerStep> MercuryMessengerSteps { get; set; }
        public virtual ICollection<MercuryRecipient> MercuryRecipients { get; set; }
    }
}
