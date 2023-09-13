using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RefreshToken
    {
        public int RefreshTokenId { get; set; }
        public int UserId { get; set; }
        public string RefreshToken1 { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime ExpiresIn { get; set; }
        public DateTime? OffTime { get; set; }

        public virtual User User { get; set; }
    }
}
