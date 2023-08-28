using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class ActionNumbersView
    {
        public int? AbonentId { get; set; }
        public int? AgentId { get; set; }
        public long? ActionNumber { get; set; }
        public DateTime? RegistrationDate { get; set; }
    }
}
