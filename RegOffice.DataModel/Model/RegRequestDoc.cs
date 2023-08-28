using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица документов заявлений
    /// </summary>
    public partial class RegRequestDoc
    {

        /// <summary>
        /// Заявление
        /// </summary>
        public int RegRequestId { get; set; }

        /// <summary>
        /// Документ
        /// </summary>
        public int DocId { get; set; }

        /// <summary>
        /// Источник документа: 1 - заявление, 2 - продукт
        /// </summary>
        public int? SourceId { get; set; }

        /// <summary>
        /// ИД сотрудника
        /// </summary>
        public int? MemberId { get; set; }

        /// <summary>
        /// Подтвердивший пользователь
        /// </summary>
        public int? ConfirmedByUserId { get; set; }

        public virtual User ConfirmedByUser { get; set; }
        public virtual Doc Doc { get; set; }
        public virtual RegRequestMember Member { get; set; }
        public virtual RegRequest RegRequest { get; set; }
    }
}
