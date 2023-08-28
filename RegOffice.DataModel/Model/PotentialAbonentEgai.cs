using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Информация об обособленных подразеделниях для ЕГАИС
    /// </summary>
    public partial class PotentialAbonentEgai
    {

        /// <summary>
        /// Идентификатор обособленного подразеделния
        /// </summary>
        public int PotentialAbonentEgaisId { get; set; }

        /// <summary>
        /// Идентификатор потенциального абонента
        /// </summary>
        public int PotentialAbonentId { get; set; }

        /// <summary>
        /// КПП обособленного подразеделния
        /// </summary>
        public string Kpp { get; set; }

        /// <summary>
        /// Код субъекта РФ обособленного подразеделния
        /// </summary>
        public string RegionCode { get; set; }

        /// <summary>
        /// Адрес обособленного подразеделния
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// Дата выдачи лицензии
        /// </summary>
        public DateOnly? InitialDate { get; set; }

        /// <summary>
        /// Дата окончания действия лицензии
        /// </summary>
        public DateOnly? EndDate { get; set; }

        public virtual PotentialAbonent PotentialAbonent { get; set; }
    }
}
