using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class ProductContractTariff
    {
        public int? ProductId { get; set; }
        public Guid? ProductGuid { get; set; }
        public int? AbonentId { get; set; }
        public int? OfficeId { get; set; }
        public int? CategoryId { get; set; }
        public int? ProductTypeId { get; set; }
        public int? PStepId { get; set; }
        public string ProgramVersion { get; set; }
        public DateTime? CreationTime { get; set; }
        public string Mobile { get; set; }
        public string AbonentEmail { get; set; }
        public int? ContractTariffId { get; set; }
        public int? ContractId { get; set; }
        public int? TariffId { get; set; }
        public int? StepId { get; set; }
        public DateOnly? InitialDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public decimal? Price { get; set; }
        public decimal? PercentDiscount { get; set; }
        public decimal? DiscountSum { get; set; }
        public decimal? Sum { get; set; }
        public int? UserId { get; set; }
        public int? WaitingDays { get; set; }
        public string RegistrationNumber { get; set; }
        public bool? IsPrimary { get; set; }
        public int? Number { get; set; }
        public int? SectionId { get; set; }
        public decimal? Cost { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string UserUin { get; set; }
    }
}
