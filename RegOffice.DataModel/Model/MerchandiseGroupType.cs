using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class MerchandiseGroupType
    {
        public MerchandiseGroupType()
        {
            MerchandiseGroups = new HashSet<MerchandiseGroup>();
        }


        /// <summary>
        /// Ид
        /// </summary>
        public int MerchandiseGroupTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string MerchandiseGroupTypeName { get; set; }

        public virtual ICollection<MerchandiseGroup> MerchandiseGroups { get; set; }
    }
}
