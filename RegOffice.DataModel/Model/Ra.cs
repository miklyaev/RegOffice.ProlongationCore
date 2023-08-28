using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица центров регистрации
    /// </summary>
    public partial class Ra
    {
        public Ra()
        {
            RaSteps = new HashSet<RaStep>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RaId { get; set; }

        /// <summary>
        /// Центр сертификации
        /// </summary>
        public int CaId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string RaName { get; set; }

        /// <summary>
        /// Маска имени файла c {id}
        /// </summary>
        public string FileMask { get; set; }

        /// <summary>
        /// Время последней отправки
        /// </summary>
        public DateTime? LastSending { get; set; }

        /// <summary>
        /// Флаг деловой почты
        /// </summary>
        public bool? Wmail { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Порт
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<RaStep> RaSteps { get; set; }
    }
}
