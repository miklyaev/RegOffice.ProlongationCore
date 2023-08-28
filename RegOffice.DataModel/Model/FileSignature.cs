using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица подписей файла
    /// </summary>
    public partial class FileSignature
    {

        /// <summary>
        /// Файл
        /// </summary>
        public int FileId { get; set; }

        /// <summary>
        /// Подпись
        /// </summary>
        public int SignatureId { get; set; }
    }
}
