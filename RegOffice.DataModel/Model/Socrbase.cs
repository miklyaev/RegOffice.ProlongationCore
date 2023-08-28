using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица сокращений типов объектов адреса
    /// </summary>
    public partial class Socrbase
    {

        /// <summary>
        /// Уровень
        /// </summary>
        public int? Level { get; set; }

        /// <summary>
        /// Сокращение
        /// </summary>
        public string Scname { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Socrname { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        public int? KodTSt { get; set; }
    }
}
