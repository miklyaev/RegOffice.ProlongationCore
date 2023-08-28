using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица доверенностей пользователей
    /// </summary>
    public partial class UserTrust
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int UserTrustId { get; set; }
        public int UserId { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Серия паспорта
        /// </summary>
        public string PassportSeries { get; set; }

        /// <summary>
        /// Номер паспорта
        /// </summary>
        public string PassportNumber { get; set; }

        /// <summary>
        /// Кем выдан паспорт
        /// </summary>
        public string PassportAddon { get; set; }

        /// <summary>
        /// Когда выдан паспорт
        /// </summary>
        public DateOnly PassportDate { get; set; }

        /// <summary>
        /// Дата начала доверенности
        /// </summary>
        public DateOnly InitialDate { get; set; }

        /// <summary>
        /// Дата окончания доверенности
        /// </summary>
        public DateOnly EndDate { get; set; }

        /// <summary>
        /// Дата отключения доверенности
        /// </summary>
        public DateTime? OffTime { get; set; }
        public int? FileId { get; set; }

        public virtual File File { get; set; }
        public virtual User User { get; set; }
    }
}
