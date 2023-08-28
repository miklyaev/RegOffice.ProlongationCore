using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class NewsBrowsing
    {

        /// <summary>
        /// Пользователь
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Новость
        /// </summary>
        public int NewsId { get; set; }

        /// <summary>
        /// Время просмотра
        /// </summary>
        public DateTime BrowseTime { get; set; }

        /// <summary>
        /// Время установки флага like
        /// </summary>
        public DateTime? LikeTime { get; set; }

        public virtual News News { get; set; }
        public virtual User User { get; set; }
    }
}
