using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class RegRequestEgrulRequest
    {

        /// <summary>
        /// Идентификатор заявки
        /// </summary>
        public int RegRequestId { get; set; }

        /// <summary>
        /// Идентификатор запроса на выписку ЕГРЮЛ
        /// </summary>
        public string EgrulRequestId { get; set; }

        /// <summary>
        /// Дата получения документа
        /// </summary>
        public DateTime? OffTime { get; set; }
    }
}
