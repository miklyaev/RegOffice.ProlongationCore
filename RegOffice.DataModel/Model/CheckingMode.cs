using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица с режимами проверки
    /// </summary>
    public partial class CheckingMode
    {
        public CheckingMode()
        {
            CheckingSchemes = new HashSet<CheckingScheme>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int CheckingModeId { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание режима
        /// </summary>
        public string Description { get; set; }

        public virtual ICollection<CheckingScheme> CheckingSchemes { get; set; }
    }
}
