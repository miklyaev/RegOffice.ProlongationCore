using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class RegRequestSummaryView
    {
        public string AgentName { get; set; }
        public string OfficeName { get; set; }
        public long? Count { get; set; }
    }
}
