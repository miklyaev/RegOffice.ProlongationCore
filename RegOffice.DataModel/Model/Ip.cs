using System;
using System.Collections.Generic;
using System.Net;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица IP серверов
    /// </summary>
    public partial class Ip
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int IpId { get; set; }

        /// <summary>
        /// IP Адрес
        /// </summary>
        public IPAddress IpAddress { get; set; }

        /// <summary>
        /// Сервер
        /// </summary>
        public int ServerId { get; set; }

        public virtual Server Server { get; set; }
    }
}
