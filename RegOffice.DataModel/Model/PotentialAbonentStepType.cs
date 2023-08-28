using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний для модуля &quot;Потенциальные абоненты&quot;
    /// </summary>
    public partial class PotentialAbonentStepType
    {
        public PotentialAbonentStepType()
        {
            PotentialAbonents = new HashSet<PotentialAbonent>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string StepName { get; set; }

        /// <summary>
        /// Тип продукта
        /// </summary>
        public int? ProductTypeId { get; set; }

        public virtual PotentialAbonentProductType ProductType { get; set; }
        public virtual ICollection<PotentialAbonent> PotentialAbonents { get; set; }
    }
}
