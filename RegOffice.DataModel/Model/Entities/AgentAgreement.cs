using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentAgreement
    {
        public int AgreementId { get; set; }
        public bool? AgreementIs { get; set; }
        public string AgreementDescription { get; set; }
        public int AgentId { get; set; }

        public virtual Agent Agent { get; set; }
    }
}
