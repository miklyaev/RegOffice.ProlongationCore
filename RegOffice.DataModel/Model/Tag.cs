using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица тегов
    /// </summary>
    public partial class Tag
    {
        public Tag()
        {
            News = new HashSet<News>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TagId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string TagName { get; set; }

        /// <summary>
        /// Группа
        /// </summary>
        public int? TagGroupId { get; set; }

        public virtual TagGroup TagGroup { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
}
