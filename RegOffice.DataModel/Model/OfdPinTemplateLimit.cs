using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица ограничений использования шаблона
    /// </summary>
    public partial class OfdPinTemplateLimit
    {

        /// <summary>
        /// Ид. шаблона
        /// </summary>
        public Guid OfdPinTemplateId { get; set; }

        /// <summary>
        /// Ограничение
        /// </summary>
        public int LimitId { get; set; }

        /// <summary>
        /// Целочисленное значение
        /// </summary>
        public int? LimitValueInt { get; set; }

        public virtual Limit Limit { get; set; }
        public virtual OfdPinTemplate OfdPinTemplate { get; set; }
    }
}
