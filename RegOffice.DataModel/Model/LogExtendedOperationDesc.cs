using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Описание операций логирования
    /// </summary>
    public partial class LogExtendedOperationDesc
    {
        public LogExtendedOperationDesc()
        {
            LogExtendeds = new HashSet<LogExtended>();
        }

        public int OperationId { get; set; }
        public string OperationDescription { get; set; }

        public virtual ICollection<LogExtended> LogExtendeds { get; set; }
    }
}
