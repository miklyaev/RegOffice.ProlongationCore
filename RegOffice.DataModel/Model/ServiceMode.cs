using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица с режимами услуг
    /// </summary>
    public partial class ServiceMode
    {
        public ServiceMode()
        {
            ServiceTypes = new HashSet<ServiceType>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int ServiceModeId { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание режима
        /// </summary>
        public string Description { get; set; }

        public virtual ICollection<ServiceType> ServiceTypes { get; set; }
    }
}
