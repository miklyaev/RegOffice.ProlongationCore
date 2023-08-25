using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlongationService.Containers
{
    public class SummaryDifferenceData
    {
        public int OfficeId { get; set; }
        public int ProlongationId { get; set; }

        public DateTime? TransferDate { get; set; }
        public DateTime? TariffEndDate { get; set; }

        public DateTime? CertificateInitialDate { get; set; }
        public DateTime? CertificateEndDate { get; set; }

        public bool NoDispatch { get; set; }
        public bool IgnoreDispatch { get; set; }
    }
}
