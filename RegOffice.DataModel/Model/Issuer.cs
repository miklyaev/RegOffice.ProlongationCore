using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Издатели
    /// </summary>
    public partial class Issuer
    {
        public Issuer()
        {
            Cas = new HashSet<Ca>();
            IssuerAccreditations = new HashSet<IssuerAccreditation>();
        }


        /// <summary>
        /// ИД издателя
        /// </summary>
        public int IssuerId { get; set; }

        /// <summary>
        /// Наименование издателя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ИНН издателя
        /// </summary>
        public string Inn { get; set; }

        public virtual ICollection<Ca> Cas { get; set; }
        public virtual ICollection<IssuerAccreditation> IssuerAccreditations { get; set; }
    }
}
