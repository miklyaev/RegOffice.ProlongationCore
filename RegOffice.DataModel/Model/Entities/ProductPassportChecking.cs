using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ProductPassportChecking
    {
        public int PassportCheckingId { get; set; }
        public int ProductCheckingId { get; set; }
        public int PassportDataTypeId { get; set; }
        public string PassportDataFromScan { get; set; }
        public string PassportDataFromProduct { get; set; }
        public bool IsEquals { get; set; }

        public virtual PassportDataType PassportDataType { get; set; }
        public virtual ProductChecking ProductChecking { get; set; }
    }
}
