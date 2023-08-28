using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица стадий запроса к СМЭВ
    /// </summary>
    public partial class SmevRequestStage
    {

        /// <summary>
        /// Идентификатор стадии
        /// </summary>
        public int RequestStageId { get; set; }

        /// <summary>
        /// Идентификатор первоначального запроса в СМЭВ
        /// </summary>
        public Guid OriginalRequestId { get; set; }

        /// <summary>
        /// Время запроса/ответ в СМЭВ
        /// </summary>
        public DateTime? StageTime { get; set; }
        public int StageTypeId { get; set; }

        /// <summary>
        /// XML запроса/ответ в СМЭВ
        /// </summary>
        public int FileId { get; set; }

        public virtual File File { get; set; }
        public virtual SmevStageType StageType { get; set; }
    }
}
