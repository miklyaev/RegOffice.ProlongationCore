using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Тип применения
    /// </summary>
    public partial class UseType
    {
        public UseType()
        {
            ContactPersonUses = new HashSet<ContactPersonUse>();
            ContactUses = new HashSet<ContactUse>();
            ReflexUseTypes = new HashSet<ReflexUseType>();
            RegRequestContactUses = new HashSet<RegRequestContactUse>();
            RegRequestMemberContactUses = new HashSet<RegRequestMemberContactUse>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int UseTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string UseTypeName { get; set; }

        public virtual ICollection<ContactPersonUse> ContactPersonUses { get; set; }
        public virtual ICollection<ContactUse> ContactUses { get; set; }
        public virtual ICollection<ReflexUseType> ReflexUseTypes { get; set; }
        public virtual ICollection<RegRequestContactUse> RegRequestContactUses { get; set; }
        public virtual ICollection<RegRequestMemberContactUse> RegRequestMemberContactUses { get; set; }
    }
}
