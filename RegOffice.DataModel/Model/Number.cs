using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица номеров счетов
    /// </summary>
    public partial class Number
    {

        /// <summary>
        /// Номер
        /// </summary>
        public long NumberValue { get; set; }
        public string Prefix { get; set; }
        public int NumberId { get; set; }
    }
}
