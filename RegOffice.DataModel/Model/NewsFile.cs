using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class NewsFile
    {

        /// <summary>
        /// Новость
        /// </summary>
        public int NewsId { get; set; }

        /// <summary>
        /// Файл
        /// </summary>
        public int FileId { get; set; }

        public virtual News News { get; set; }
    }
}
