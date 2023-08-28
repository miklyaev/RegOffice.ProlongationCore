using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов видимости
    /// </summary>
    public partial class VisibilityType
    {
        public VisibilityType()
        {
            News = new HashSet<News>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int VisibilityTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string VisibilityTypeName { get; set; }

        public virtual ICollection<News> News { get; set; }
    }
}
