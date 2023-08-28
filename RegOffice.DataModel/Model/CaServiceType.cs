using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class CaServiceType
    {
        public CaServiceType()
        {
            CaServices = new HashSet<CaService>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CaServiceTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string CaServiceTypeName { get; set; }

        public virtual ICollection<CaService> CaServices { get; set; }
    }
}
