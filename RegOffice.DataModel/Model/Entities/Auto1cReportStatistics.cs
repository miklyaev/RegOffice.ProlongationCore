using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Auto1cReportStatistics
    {
        public int ReportId { get; set; }
        public DateTime ReportDate { get; set; }
        public int? RecievedRegRequests { get; set; }
        public int? UnprocRegRequests { get; set; }
        public int? TwoDaysCount { get; set; }
        public int? FourDaysCount { get; set; }
        public int? SixDaysCount { get; set; }
        public int? MoreDaysCount { get; set; }
        public int? RegisteredAbonents { get; set; }
        public int? Paid { get; set; }
        public int? Exclusive { get; set; }
        public int? RegRequest { get; set; }
        public int? ActiveAbonents { get; set; }
        public int? Partners { get; set; }
        public int? EtpRequests { get; set; }
        public int? EtpActiveAbonents { get; set; }
        public int? EtpPartners { get; set; }
        public int? TotalPaid { get; set; }
        public int? TotalExclusive { get; set; }
        public int? TotalBonus { get; set; }
        public int? UnactivePaid { get; set; }
        public int? UnactiveExclusive { get; set; }
        public int? EtpRecievedRegRequests { get; set; }
        public int? EtpUnprocRegRequests { get; set; }
        public int? EtpTwoDaysCount { get; set; }
        public int? EtpSevenDaysCount { get; set; }
        public int? EtpTwentyEightDaysCount { get; set; }
        public int? EtpMoreDaysCount { get; set; }
        public int? EtpRegRequests { get; set; }
        public int? EtpPaRegRequests { get; set; }
        public int? EtpUnactiveAbonents { get; set; }
        public int? EightDaysCount { get; set; }
        public string SupportStatDataIncidentsEtsJson { get; set; }
        public string SupportStatDataIncidentsJson { get; set; }
        public string SupportStatDataCallsEtsJson { get; set; }
        public string SupportStatDataCallsJson { get; set; }
    }
}
