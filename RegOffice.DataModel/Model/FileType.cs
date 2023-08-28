using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов файлов
    /// </summary>
    public partial class FileType
    {
        public FileType()
        {
            Files = new HashSet<File>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int FileTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string FileTypeName { get; set; }

        /// <summary>
        /// Расширение
        /// </summary>
        public string FileExtension { get; set; }

        public virtual ICollection<File> Files { get; set; }
    }
}
