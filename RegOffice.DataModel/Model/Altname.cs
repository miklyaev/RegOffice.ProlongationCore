using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица соотвествия
    /// </summary>
    public partial class Altname
    {

        /// <summary>
        /// Старый код
        /// </summary>
        public string Oldcode { get; set; }

        /// <summary>
        /// Новый код
        /// </summary>
        public string Newcode { get; set; }

        /// <summary>
        /// Уровень
        /// </summary>
        public int? Level { get; set; }
    }
}
