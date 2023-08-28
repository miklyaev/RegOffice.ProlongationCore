using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class RegRequestConfirmedStep
    {

        /// <summary>
        /// Заявка
        /// </summary>
        public int RegRequestId { get; set; }

        /// <summary>
        /// Время подтверждения
        /// </summary>
        public DateTime ConfirmationTime { get; set; }

        public virtual RegRequest RegRequest { get; set; }
    }
}
