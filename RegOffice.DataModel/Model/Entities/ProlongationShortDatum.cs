using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ProlongationShortDatum
    {
        public int ProlongationId { get; set; }
        public int AbonentId { get; set; }
        public int ContractId { get; set; }
        public DateTime? TariffEndDate { get; set; }
        public DateTime? CertificateEndDate { get; set; }
        public decimal TotalSum { get; set; }
        public bool NoDispatch { get; set; }
        public DateTime? TransferDate { get; set; }
        public int? ReasonId { get; set; }
        public string Comment { get; set; }
        public DateTime? TariffInitialDate { get; set; }
        public DateTime? CertificateInitialDate { get; set; }
        public int ProductId { get; set; }
        public bool IgnoreDispatch { get; set; }
        public string RegistrationNumber { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual Contract Contract { get; set; }
        public virtual Product Product { get; set; }
    }
}
