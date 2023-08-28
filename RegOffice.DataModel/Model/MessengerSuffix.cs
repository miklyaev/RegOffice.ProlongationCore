using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Суффиксы курьеров
    /// </summary>
    public partial class MessengerSuffix
    {

        /// <summary>
        /// Курьер
        /// </summary>
        public int MessengerId { get; set; }

        /// <summary>
        /// Суффикс
        /// </summary>
        public string Suffix { get; set; }

        public virtual Messenger Messenger { get; set; }
    }
}
