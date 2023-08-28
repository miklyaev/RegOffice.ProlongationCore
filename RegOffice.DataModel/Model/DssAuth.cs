using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний аутентификации пользователей DSS
    /// </summary>
    public partial class DssAuth
    {
        public DssAuth()
        {
            DssAuthSteps = new HashSet<DssAuthStep>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AuthId { get; set; }

        /// <summary>
        /// Пользователь DSS
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Шаг аутентификации
        /// </summary>
        public int StepId { get; set; }
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Время проверки
        /// </summary>
        public DateTime? CheckTime { get; set; }

        /// <summary>
        /// QR-код
        /// </summary>
        public int? QrCodeId { get; set; }

        /// <summary>
        /// Серийный номер
        /// </summary>
        public string Serial { get; set; }

        /// <summary>
        /// Владелец ЭП
        /// </summary>
        public int? ProductPersonId { get; set; }

        /// <summary>
        /// Система аутентификации
        /// </summary>
        public int AuthSystemId { get; set; }

        public virtual DssAuthSystem AuthSystem { get; set; }
        public virtual ProductPerson ProductPerson { get; set; }
        public virtual File QrCode { get; set; }
        public virtual Step Step { get; set; }
        public virtual DssUser User { get; set; }
        public virtual ICollection<DssAuthStep> DssAuthSteps { get; set; }
    }
}
