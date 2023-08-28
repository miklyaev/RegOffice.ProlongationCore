using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица КЛАДР (4 уровня)
    /// </summary>
    public partial class Kladr
    {

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Сокращение типа
        /// </summary>
        public string Socr { get; set; }
        public string Code { get; set; }

        /// <summary>
        /// Индекс
        /// </summary>
        public string Index { get; set; }

        /// <summary>
        /// Код ИФНС
        /// </summary>
        public string Gninmb { get; set; }

        /// <summary>
        /// Код тер. уч. ИФНС
        /// </summary>
        public string Uno { get; set; }

        /// <summary>
        /// ОКАТО
        /// </summary>
        public string Ocatd { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public int? Status { get; set; }
    }
}
