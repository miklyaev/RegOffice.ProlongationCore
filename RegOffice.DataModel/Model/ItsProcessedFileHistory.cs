using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class ItsProcessedFileHistory
    {

        /// <summary>
        /// Идентификатор файла
        /// </summary>
        public int ItsProcessedFileHistoryId { get; set; }

        /// <summary>
        /// Имя файла
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Дата обработки файла
        /// </summary>
        public DateTime ProcessedDate { get; set; }
    }
}
