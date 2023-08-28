using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов стадий взаимодействия со СМЭВ
    /// </summary>
    public partial class SmevStageType
    {
        public SmevStageType()
        {
            SmevRequestStages = new HashSet<SmevRequestStage>();
        }


        /// <summary>
        /// Идентификатор типа
        /// </summary>
        public int StageTypeId { get; set; }

        /// <summary>
        /// Название стадии
        /// </summary>
        public string StageName { get; set; }

        public virtual ICollection<SmevRequestStage> SmevRequestStages { get; set; }
    }
}
