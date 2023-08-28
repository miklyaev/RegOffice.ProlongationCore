using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class RegRequestStepProductView
    {
        public int? RegRequestId { get; set; }
        public int? OfficeId { get; set; }
        public int? UserId { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string RegistrationNumber { get; set; }
        public int? RegRequestTypeId { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? StepId { get; set; }
        public string StepName { get; set; }
        public int? ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public int? ProductStepId { get; set; }
        public bool? IsIts { get; set; }
        public int? PostalAddressId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Guid? ProductGuid { get; set; }
        public string Mobile { get; set; }
        public long? IsSpecialCondition { get; set; }
        public long? IsBonus { get; set; }
        public string SpecialConditionNumber { get; set; }
        public string CompanyGroupName { get; set; }
        public string CompanyGroupInn { get; set; }
        public string CompanyGroupKpp { get; set; }
        public int? CrStepType { get; set; }
        public int? IrucStepType { get; set; }
        public int? ClStepType { get; set; }
        public string FirstTeamPerson { get; set; }
        public string SecondTeamPerson { get; set; }
        public string RegRequestTypeName { get; set; }
        public Guid? AbonentGuid { get; set; }
        public string FormatVersion { get; set; }
        public string ProgramVersion { get; set; }
        public int? CategoryId { get; set; }
        public int? WorkflowTypeId { get; set; }
    }
}
