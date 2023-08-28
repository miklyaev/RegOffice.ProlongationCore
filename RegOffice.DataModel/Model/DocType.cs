using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица видов документов
    /// </summary>
    public partial class DocType
    {
        public DocType()
        {
            AttributeDocumentTypes = new HashSet<AttributeDocumentType>();
            Docs = new HashSet<Doc>();
            OfficeDocTypes = new HashSet<OfficeDocType>();
            WorkflowDocTypes = new HashSet<WorkflowDocType>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int DocTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string DocTypeName { get; set; }

        /// <summary>
        /// Псевдоним
        /// </summary>
        public string DocTypeAlias { get; set; }

        public virtual ICollection<AttributeDocumentType> AttributeDocumentTypes { get; set; }
        public virtual ICollection<Doc> Docs { get; set; }
        public virtual ICollection<OfficeDocType> OfficeDocTypes { get; set; }
        public virtual ICollection<WorkflowDocType> WorkflowDocTypes { get; set; }
    }
}
