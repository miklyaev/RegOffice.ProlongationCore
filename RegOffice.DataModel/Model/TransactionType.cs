using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов транзакций документооборота
    /// </summary>
    public partial class TransactionType
    {
        public TransactionType()
        {
            Transactions = new HashSet<Transaction>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TransactionTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string TransactionTypeName { get; set; }

        /// <summary>
        /// Тип документооборота
        /// </summary>
        public int WorkflowTypeId { get; set; }

        public virtual WorkflowType WorkflowType { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
