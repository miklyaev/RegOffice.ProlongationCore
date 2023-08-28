using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class PotentialAbonentPerson
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PotentialAbonentId { get; set; }

        /// <summary>
        /// Идентификатор конкретного индивида
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Имя контактного лица
        /// </summary>
        public string PersonName { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string PersonPhone { get; set; }
        public string PersonEmail { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string PersonPost { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string PersonAddress { get; set; }
    }
}
