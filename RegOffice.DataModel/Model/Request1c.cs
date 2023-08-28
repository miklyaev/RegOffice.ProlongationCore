using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class Request1c
    {
        public Guid ProductGuid { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string AbonentName { get; set; }
        public int? StepId { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string FileName { get; set; }

        public virtual Step Step { get; set; }
    }
}
