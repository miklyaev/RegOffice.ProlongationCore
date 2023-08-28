using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица операций
    /// </summary>
    public partial class Operation
    {
        public Operation()
        {
            OperationLogs = new HashSet<OperationLog>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int OperationId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string OperationName { get; set; }

        public virtual ICollection<OperationLog> OperationLogs { get; set; }
    }
}
