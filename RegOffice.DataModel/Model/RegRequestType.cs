using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов запросов на регистрацию
    /// </summary>
    public partial class RegRequestType
    {
        public RegRequestType()
        {
            RegRequests = new HashSet<RegRequest>();
            RejectedRegRequests = new HashSet<RejectedRegRequest>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int RegRequestTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string RegRequestTypeName { get; set; }

        public virtual ICollection<RegRequest> RegRequests { get; set; }
        public virtual ICollection<RejectedRegRequest> RejectedRegRequests { get; set; }
    }
}
