using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class PotentialAbonentContactCatalog
    {

        /// <summary>
        /// Наименование абонента
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// инн
        /// </summary>
        public string Inn { get; set; }

        /// <summary>
        /// кпп
        /// </summary>
        public string Kpp { get; set; }

        /// <summary>
        /// телефон
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// дополнительный e-mail
        /// </summary>
        public string Email2 { get; set; }

        /// <summary>
        /// Контактное лицо
        /// </summary>
        public string ContactPerson { get; set; }
    }
}
