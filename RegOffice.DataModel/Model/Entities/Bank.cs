using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Bank
    {
        public string Bic { get; set; }
        public string BankName { get; set; }
        public string CorrespondentAccount { get; set; }
        public string City { get; set; }
        public DateTime? OffDate { get; set; }
    }
}
