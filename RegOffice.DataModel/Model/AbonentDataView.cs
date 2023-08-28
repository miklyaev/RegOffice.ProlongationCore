using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class AbonentDataView
    {
        public int? AbonentId { get; set; }
        public string AbonentName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string RnsPfr { get; set; }
        public DateTime? CreationTime { get; set; }
        public string StepName { get; set; }
        public int? StepId { get; set; }
        public int? CrStepType { get; set; }
        public int? IrucStepType { get; set; }
        public int? ClStepType { get; set; }
        public long? CompanyGroupCount { get; set; }
        public string CompanyGroupName { get; set; }
        public string CompanyGroupNameList { get; set; }
    }
}
