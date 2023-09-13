using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CaMessenger
    {
        public int CaId { get; set; }
        public int MessengerId { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual Messenger Messenger { get; set; }
    }
}
