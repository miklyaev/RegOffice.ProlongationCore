using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ProductSkrinInfo
    {
        public int ProductId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual Product Product { get; set; }
    }
}
