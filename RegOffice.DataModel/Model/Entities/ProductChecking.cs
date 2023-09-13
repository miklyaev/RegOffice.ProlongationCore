using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ProductChecking
    {
        public ProductChecking()
        {
            ProductCheckingSteps = new HashSet<ProductCheckingStep>();
            ProductPassportCheckings = new HashSet<ProductPassportChecking>();
        }

        public int CheckingId { get; set; }
        public int ProductId { get; set; }
        public int CheckingTypeId { get; set; }
        public DateTime CheckingTime { get; set; }
        public string Message { get; set; }
        public int? ProductPersonId { get; set; }
        public Guid? TaskId { get; set; }
        public int StepId { get; set; }
        public int? UserId { get; set; }
        public int? ContentId { get; set; }

        public virtual CheckingType CheckingType { get; set; }
        public virtual File Content { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductPerson ProductPerson { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ProductCheckingStep> ProductCheckingSteps { get; set; }
        public virtual ICollection<ProductPassportChecking> ProductPassportCheckings { get; set; }
    }
}
