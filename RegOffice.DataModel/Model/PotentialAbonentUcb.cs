using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица с данными для ЮКБ
    /// </summary>
    public partial class PotentialAbonentUcb
    {

        /// <summary>
        /// Идентификатор лида
        /// </summary>
        public int PotentialAbonentId { get; set; }

        /// <summary>
        /// Дата передачи в ЮКБ
        /// </summary>
        public DateTime? UcbTransferDate { get; set; }

        /// <summary>
        /// Менеджер ЮКБ
        /// </summary>
        public int? UcbUserId { get; set; }

        /// <summary>
        /// Номер сертификата ЮКБ
        /// </summary>
        public string CertNumber { get; set; }

        public virtual PotentialAbonent PotentialAbonent { get; set; }
        public virtual User UcbUser { get; set; }
    }
}
