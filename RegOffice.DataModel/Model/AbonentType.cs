using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов абонентов
    /// </summary>
    public partial class AbonentType
    {
        public AbonentType()
        {
            AbonentImportTasks = new HashSet<AbonentImportTask>();
            Abonents = new HashSet<Abonent>();
            KcrIssues = new HashSet<KcrIssue>();
            PotentialAbonents = new HashSet<PotentialAbonent>();
            Products = new HashSet<Product>();
            RegBankRequests = new HashSet<RegBankRequest>();
            RegRequests = new HashSet<RegRequest>();
            WorkflowDocTypes = new HashSet<WorkflowDocType>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int AbonentTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string AbonentTypeName { get; set; }

        /// <summary>
        /// Тип ИРУЦ
        /// </summary>
        public string IrucTitle { get; set; }

        public virtual ICollection<AbonentImportTask> AbonentImportTasks { get; set; }
        public virtual ICollection<Abonent> Abonents { get; set; }
        public virtual ICollection<KcrIssue> KcrIssues { get; set; }
        public virtual ICollection<PotentialAbonent> PotentialAbonents { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<RegBankRequest> RegBankRequests { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
        public virtual ICollection<WorkflowDocType> WorkflowDocTypes { get; set; }
    }
}
