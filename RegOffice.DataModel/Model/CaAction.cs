using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Действие на УЦ
    /// </summary>
    public partial class CaAction
    {
        public CaAction()
        {
            CertificateRevocations = new HashSet<CertificateRevocation>();
            CertificateSteps = new HashSet<CertificateStep>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int ActionId { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string ActionDescription { get; set; }

        public virtual ICollection<CertificateRevocation> CertificateRevocations { get; set; }
        public virtual ICollection<CertificateStep> CertificateSteps { get; set; }
    }
}
