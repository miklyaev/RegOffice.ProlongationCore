using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class BulkSkziLicenseUploadTask
    {
        public int BulkSkziLicenseUploadTaskId { get; set; }
        public int? LicenseListFileId { get; set; }
        public int? LicensesPdfFileId { get; set; }
        public DateTime CreationTime { get; set; }
        public int StepId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }
        public int MerchandiseId { get; set; }

        public virtual File LicenseListFile { get; set; }
        public virtual File LicensesPdfFile { get; set; }
        public virtual Merchandise Merchandise { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
