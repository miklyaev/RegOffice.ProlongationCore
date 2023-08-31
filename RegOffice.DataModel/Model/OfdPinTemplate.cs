using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class OfdPinTemplate
    {
        public OfdPinTemplate()
        {
            OfdPinTemplateLimits = new HashSet<OfdPinTemplateLimit>();
            OfdPins = new HashSet<OfdPin>();
        }


        /// <summary>
        /// Ид
        /// </summary>
        public Guid OfdPinTemplateId { get; set; }

        /// <summary>
        /// Срок действия
        /// </summary>
        public int? Validity { get; set; }

        /// <summary>
        /// Единица измерения срока действия
        /// </summary>
        public int? ValidityUnitId { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Цена для партнёра
        /// </summary>
        public decimal AgentPrice { get; set; }

        /// <summary>
        /// Цена для ЦП
        /// </summary>
        public decimal ScPrice { get; set; }

        /// <summary>
        /// Время начала действия
        /// </summary>
        public DateTime? InitialTime { get; set; }

        /// <summary>
        /// Время окончания действия
        /// </summary>
        public DateTime? OffTime { get; set; }

        /// <summary>
        /// Номенклатура
        /// </summary>
        public string Article { get; set; }

        /// <summary>
        /// Ид. ЦП
        /// </summary>
        public int? SaleCenterId { get; set; }

        /// <summary>
        /// Читаемый код
        /// </summary>
        public string SecretId { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string TemplateName { get; set; }

        /// <summary>
        /// Цена для 1С
        /// </summary>
        public decimal? Cost1c { get; set; }

        /// <summary>
        /// Тип пин кода
        /// </summary>
        public int OfdPinTypeId { get; set; }

        public virtual OfdPinType OfdPinType { get; set; }
        public virtual Agent SaleCenter { get; set; }
        public virtual Unit ValidityUnit { get; set; }
        public virtual ICollection<OfdPinTemplateLimit> OfdPinTemplateLimits { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
    }
}
