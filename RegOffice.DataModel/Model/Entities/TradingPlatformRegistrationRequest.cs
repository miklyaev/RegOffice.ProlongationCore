using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TradingPlatformRegistrationRequest
    {
        public int RequestId { get; set; }
        public string ExternalRequestId { get; set; }
        public int TradingPlatformTariffAttributeId { get; set; }
        public int ProductId { get; set; }
        public int KeyId { get; set; }
        public int StepId { get; set; }
        public string Error { get; set; }

        public virtual Key Key { get; set; }
        public virtual Product Product { get; set; }
        public virtual Step Step { get; set; }
        public virtual TradingPlatformTariffAttribute TradingPlatformTariffAttribute { get; set; }
    }
}
