using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица ссылок (URI) на списки анулированных сертификатов
    /// </summary>
    public partial class CrlLink
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CrlLinkId { get; set; }

        /// <summary>
        /// Список
        /// </summary>
        public int CrlId { get; set; }

        /// <summary>
        /// Ссылка
        /// </summary>
        public string Link { get; set; }

        public virtual Crl Crl { get; set; }
    }
}
