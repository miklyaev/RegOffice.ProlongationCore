using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOffice.DataModel.Model
{
    [NotMapped]
    public class ProductProlongationData
    {
        public int AbonentId { get; set; }
        public int ContractId { get; set; }
        public int ProductId { get; set; }

        public DateTime? TariffInitialDate { get; set; }
        public DateTime? TariffEndDate { get; set; }

        public string RegistrationNumber { get; set; }
        public decimal TotalSum { get; set; }

        public DateTime? CertificateInitialDate { get; set; }
        public DateTime? CertificateEndDate { get; set; }
    }
}
