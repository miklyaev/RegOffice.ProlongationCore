using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AuthorizationCodes
    {
        public int IdAuthorizationCode { get; set; }
        public Guid AuthorizationId { get; set; }
        public int? AuthorizationCount { get; set; }
        public Guid AuthorizationSecretKey { get; set; }
    }
}
