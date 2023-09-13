using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class MercuryMessenger
    {
        public MercuryMessenger()
        {
            MercuryMessengerSteps = new HashSet<MercuryMessengerStep>();
            MercuryRecipients = new HashSet<MercuryRecipient>();
        }

        public int MercuryId { get; set; }
        public int MessengerId { get; set; }
        public string AccountIn { get; set; }
        public string AccountOut { get; set; }
        public string PasswordIn { get; set; }
        public string PasswordOut { get; set; }
        public string PackId { get; set; }
        public int StepId { get; set; }
        public string IrucAccount { get; set; }
        public string IrucPassword { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime? OffTime { get; set; }
        public int? OperatorIrucId { get; set; }

        public virtual Product Mercury { get; set; }
        public virtual Messenger Messenger { get; set; }
        public virtual OperatorIruc OperatorIruc { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<MercuryMessengerStep> MercuryMessengerSteps { get; set; }
        public virtual ICollection<MercuryRecipient> MercuryRecipients { get; set; }
    }
}
