using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов документов для отправки в ПФР
    /// </summary>
    public partial class PfrSchemeType
    {
        public PfrSchemeType()
        {
            PfrLayoutSchemes = new HashSet<PfrLayoutScheme>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PfrSchemeTypeId { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string PfrSchemeTypeName { get; set; }

        /// <summary>
        /// Категория Письма
        /// </summary>
        public string LetterCategory { get; set; }

        public virtual ICollection<PfrLayoutScheme> PfrLayoutSchemes { get; set; }
    }
}
