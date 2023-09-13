using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class DisqualifiedPerson
    {
        public int RecordId { get; set; }
        public int? Number { get; set; }
        public string RdlNumber { get; set; }
        public string FullName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string OrgName { get; set; }
        public string OrgInn { get; set; }
        public string Post { get; set; }
        public string CodexClause { get; set; }
        public string ProtocolAgency { get; set; }
        public string JudgeFullName { get; set; }
        public string JudgePost { get; set; }
        public string DisqualificationTerm { get; set; }
        public DateTime? DisqualificationStart { get; set; }
        public DateTime? DisqualificationEnd { get; set; }
    }
}
