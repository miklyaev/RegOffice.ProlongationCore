using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица связи УЦ и курьеров
    /// </summary>
    public partial class CaMessenger
    {

        /// <summary>
        /// УЦ
        /// </summary>
        public int CaId { get; set; }

        /// <summary>
        /// Курьер
        /// </summary>
        public int MessengerId { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual Messenger Messenger { get; set; }
    }
}
