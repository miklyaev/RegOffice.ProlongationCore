using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица документов продуктов
    /// </summary>
    public partial class ProductDoc
    {

        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Абонент
        /// </summary>
        public int AbonentId { get; set; }

        /// <summary>
        /// Документ
        /// </summary>
        public int DocId { get; set; }

        /// <summary>
        /// Владелец ключа
        /// </summary>
        public int? ProductPersonId { get; set; }

        /// <summary>
        /// Ключ
        /// </summary>
        public int? KeyId { get; set; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ProductDocId { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual Key Key { get; set; }
        public virtual ProductPerson ProductPerson { get; set; }
        public virtual Doc Doc { get; set; }
    }
}
