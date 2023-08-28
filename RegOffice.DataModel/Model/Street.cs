using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица улиц (5 уровень)
    /// </summary>
    public partial class Street
    {

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Сокращение
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
    }
}
