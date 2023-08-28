using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Причина отзыва
    /// </summary>
    public partial class RevocationReason
    {
        public RevocationReason()
        {
            CertificateRevocations = new HashSet<CertificateRevocation>();
            CertificateSteps = new HashSet<CertificateStep>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int ReasonId { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string ReasonDescription { get; set; }

        public virtual ICollection<CertificateRevocation> CertificateRevocations { get; set; }
        public virtual ICollection<CertificateStep> CertificateSteps { get; set; }
    }
}
