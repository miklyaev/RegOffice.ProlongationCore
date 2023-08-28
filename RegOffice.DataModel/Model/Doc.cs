using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица документов
    /// </summary>
    public partial class Doc
    {
        public Doc()
        {
            PersonDocs = new HashSet<PersonDoc>();
            ProductDocs = new HashSet<ProductDoc>();
            RegRequestDocs = new HashSet<RegRequestDoc>();
            RegBankRequests = new HashSet<RegBankRequest>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int DocId { get; set; }

        /// <summary>
        /// Абонент
        /// </summary>
        public int? AbonentId { get; set; }

        /// <summary>
        /// Вид документа
        /// </summary>
        public int DocTypeId { get; set; }

        /// <summary>
        /// Тип документа удостоверяющего личность
        /// </summary>
        public int? PassportTypeId { get; set; }

        /// <summary>
        /// Серия документа
        /// </summary>
        public string Series { get; set; }

        /// <summary>
        /// Номер документа
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Дата выдачи
        /// </summary>
        public DateOnly? IssueDate { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Дополнение
        /// </summary>
        public string Addon { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Файл
        /// </summary>
        public int? FileId { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual DocType DocType { get; set; }
        public virtual PassportType PassportType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<PersonDoc> PersonDocs { get; set; }
        public virtual ICollection<ProductDoc> ProductDocs { get; set; }
        public virtual ICollection<RegRequestDoc> RegRequestDocs { get; set; }
        public virtual ICollection<RegBankRequest> RegBankRequests { get; set; }
    }
}
