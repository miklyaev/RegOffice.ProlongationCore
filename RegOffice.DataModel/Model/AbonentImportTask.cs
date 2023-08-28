using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица задач по импорту абонентов
    /// </summary>
    public partial class AbonentImportTask
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TaskId { get; set; }

        /// <summary>
        /// Наименование файла
        /// </summary>
        public string TaskFileName { get; set; }

        /// <summary>
        /// Данные входного файла
        /// </summary>
        public byte[] InputFileData { get; set; }

        /// <summary>
        /// Данные выходного файла
        /// </summary>
        public byte[] OutputFileData { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Тип импортируемых абонентов
        /// </summary>
        public int AbonentTypeId { get; set; }

        /// <summary>
        /// Пользователь, осуществивший импорт
        /// </summary>
        public int UserId { get; set; }

        public virtual AbonentType AbonentType { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
