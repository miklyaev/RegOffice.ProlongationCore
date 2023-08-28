using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class CertificateInProduct
    {
        public int? CertificateId { get; set; }
        public DateTime? InitialTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? ProductId { get; set; }
        public int? ProductTypeId { get; set; }
    }
}
