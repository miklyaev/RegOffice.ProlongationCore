using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Report
    {
        public int ReportId { get; set; }
        public DateTime CreationTime { get; set; }
        public int StepId { get; set; }
        public int AgentId { get; set; }
        public int ProductTypeId { get; set; }
        public int? ActiveCount { get; set; }
        public int? YearLostCount { get; set; }
        public int? IncCount { get; set; }
        public int? PrevMonthIncCount { get; set; }
        public int? ToProlInPeriodCount { get; set; }
        public int? LostInPeriodCount { get; set; }
        public int? LastYearToProlInPeriodCount { get; set; }
        public int? LastYearLostInPeriod { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? YearToProlCount { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int? PrevQuarterActiveCount { get; set; }
        public int? LastYearLostCount { get; set; }
        public int? LastYearToProlCount { get; set; }
        public int? PrevQuarterIncCount { get; set; }
        public int? PrevQuarterToProl { get; set; }
        public int? PrevQuarterLost { get; set; }
        public int? PrevMonthToProl { get; set; }
        public int? PrevMonthLost { get; set; }
        public int? QuarterToProl { get; set; }
        public int? QuarterLost { get; set; }
        public int? PrevYearActiveCount { get; set; }
        public int? QuarterIncCount { get; set; }
        public int? PrevYearEndActiveCount { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Step Step { get; set; }
    }
}
