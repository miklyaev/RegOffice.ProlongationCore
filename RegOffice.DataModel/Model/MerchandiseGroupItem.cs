using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Членство расширений в группах
    /// </summary>
    public partial class MerchandiseGroupItem
    {

        /// <summary>
        /// Id группы
        /// </summary>
        public int? GroupId { get; set; }

        /// <summary>
        /// Id расширения
        /// </summary>
        public int? MerchandiseId { get; set; }

        /// <summary>
        /// Обязательное расширение
        /// </summary>
        public bool IsRequired { get; set; }

        public virtual MerchandiseGroup Group { get; set; }
        public virtual Merchandise Merchandise { get; set; }
    }
}
