using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов запросов на обратный звонок
    /// </summary>
    public partial class CallbackRequestType
    {
        public CallbackRequestType()
        {
            CallbackRequests = new HashSet<CallbackRequest>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int CallbackRequestTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string CallbackRequestTypeName { get; set; }

        public virtual ICollection<CallbackRequest> CallbackRequests { get; set; }
    }
}
