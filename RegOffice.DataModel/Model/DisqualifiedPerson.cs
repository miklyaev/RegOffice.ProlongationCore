using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица с выгрузкой дисквалифицированных лиц
    /// </summary>
    public partial class DisqualifiedPerson
    {
        public int RecordId { get; set; }

        /// <summary>
        /// № п/п
        /// </summary>
        public int? Number { get; set; }

        /// <summary>
        /// Номер записи РДЛ
        /// </summary>
        public string RdlNumber { get; set; }

        /// <summary>
        /// ФИО дисквалифицированного лица
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Дата рождения дисквалифицированного лица
        /// </summary>
        public DateOnly? BirthDate { get; set; }

        /// <summary>
        /// Место рождения дисквалифицированного лица
        /// </summary>
        public string BirthPlace { get; set; }

        /// <summary>
        /// Наименование организации
        /// </summary>
        public string OrgName { get; set; }

        /// <summary>
        /// ИНН организации
        /// </summary>
        public string OrgInn { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string Post { get; set; }

        /// <summary>
        /// Статья КоАП РФ
        /// </summary>
        public string CodexClause { get; set; }

        /// <summary>
        /// Наименование органа, составившего протокол об административном правонарушении
        /// </summary>
        public string ProtocolAgency { get; set; }

        /// <summary>
        /// ФИО судьи
        /// </summary>
        public string JudgeFullName { get; set; }

        /// <summary>
        /// Должность судьи
        /// </summary>
        public string JudgePost { get; set; }

        /// <summary>
        /// Срок дисквалификации
        /// </summary>
        public string DisqualificationTerm { get; set; }

        /// <summary>
        /// Дата начала дисквалификации
        /// </summary>
        public DateOnly? DisqualificationStart { get; set; }

        /// <summary>
        /// Дата истечения срока дисквалификации
        /// </summary>
        public DateOnly? DisqualificationEnd { get; set; }
    }
}
