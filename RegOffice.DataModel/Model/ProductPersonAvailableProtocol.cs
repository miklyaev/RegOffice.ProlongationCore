using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class ProductPersonAvailableProtocol
    {
        public int ProductPersonId { get; set; }
        public int ProtocolId { get; set; }
        public bool? IsEncryptor { get; set; }
        public int ProductPersonAvailableProtocolId { get; set; }

        public virtual ProductPerson ProductPerson { get; set; }
        public virtual Protocol Protocol { get; set; }
    }
}
