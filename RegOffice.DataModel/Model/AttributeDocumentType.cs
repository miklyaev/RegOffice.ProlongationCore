using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица документов требуемых для атрибута
    /// </summary>
    public partial class AttributeDocumentType
    {

        /// <summary>
        /// ИД атрибута
        /// </summary>
        public int AttributeId { get; set; }

        /// <summary>
        /// ИД типа документа
        /// </summary>
        public int DocTypeId { get; set; }

        /// <summary>
        /// Документ требуется только к доверенности
        /// </summary>
        public bool OnlyForProxy { get; set; }

        public virtual Attribute Attribute { get; set; }
        public virtual DocType DocType { get; set; }
    }
}
