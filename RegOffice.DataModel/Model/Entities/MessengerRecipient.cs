using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class MessengerRecipient
    {
        public int MessengerId { get; set; }
        public int RecipientId { get; set; }
        public DateTime CreationTime { get; set; }
        public bool Default { get; set; }

        public virtual Messenger Messenger { get; set; }
        public virtual Recipient Recipient { get; set; }
    }
}
