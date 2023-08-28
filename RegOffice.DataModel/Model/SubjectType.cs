using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов субъектов документооборота
    /// </summary>
    public partial class SubjectType
    {
        public SubjectType()
        {
            TransactionRecipientTypes = new HashSet<Transaction>();
            TransactionSenderTypes = new HashSet<Transaction>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int SubjectTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string SubjectTypeName { get; set; }

        /// <summary>
        /// Тип документооборота
        /// </summary>
        public int WorkflowTypeId { get; set; }

        public virtual WorkflowType WorkflowType { get; set; }
        public virtual ICollection<Transaction> TransactionRecipientTypes { get; set; }
        public virtual ICollection<Transaction> TransactionSenderTypes { get; set; }
    }
}
