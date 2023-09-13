using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class UserPromotionConfirmed
    {
        public int UserId { get; set; }
        public int PromotionTypeId { get; set; }
        public DateTime ConfirmDate { get; set; }

        public virtual PromotionType PromotionType { get; set; }
        public virtual User User { get; set; }
    }
}
