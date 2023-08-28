using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class LicenseType
    {
        public LicenseType()
        {
            LicensePools = new HashSet<LicensePool>();
            Licenses = new HashSet<License>();
        }

        public int LicenseTypeId { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string LicenseTypeName { get; set; }

        /// <summary>
        /// Дата время создания
        /// </summary>
        public DateTime? CreationTime { get; set; }

        public virtual ICollection<LicensePool> LicensePools { get; set; }
        public virtual ICollection<License> Licenses { get; set; }
    }
}
