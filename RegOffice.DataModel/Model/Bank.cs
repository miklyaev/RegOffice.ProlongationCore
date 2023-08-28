using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Справочник банков
    /// </summary>
    public partial class Bank
    {

        /// <summary>
        /// БИК
        /// </summary>
        public string Bic { get; set; }

        /// <summary>
        /// Наименование банка
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// Корреспондентский счёт
        /// </summary>
        public string CorrespondentAccount { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateOnly? OffDate { get; set; }
    }
}
