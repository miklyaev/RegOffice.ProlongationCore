using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class ExtremumLicenseView
    {
        public int? MinLicenseId { get; set; }
        public int? MaxLicenseId { get; set; }
        public int? ProductId { get; set; }
    }
}
