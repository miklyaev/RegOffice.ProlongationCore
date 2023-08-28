using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class OfdPin
    {
        public OfdPin()
        {
            OfdPinSettings = new HashSet<OfdPinSetting>();
            OfdPinTemplates = new HashSet<OfdPinTemplate>();
        }


        /// <summary>
        /// Ид.
        /// </summary>
        public int PinId { get; set; }

        /// <summary>
        /// Префикс
        /// </summary>
        public int PrefixId { get; set; }

        /// <summary>
        /// Пин
        /// </summary>
        public string Pin { get; set; }

        /// <summary>
        /// Время создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Счёт
        /// </summary>
        public int? BillId { get; set; }

        /// <summary>
        /// Время активации
        /// </summary>
        public DateTime? ActivationTime { get; set; }
        public int? ContractTariffId { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public int? CommentId { get; set; }

        /// <summary>
        /// Срок действия тарифа
        /// </summary>
        public int? Validity { get; set; }

        /// <summary>
        /// Единица измерения срока действия тарифа
        /// </summary>
        public int? ValidityUnitId { get; set; }

        /// <summary>
        /// Ид. скидки
        /// </summary>
        public int? OfdDiscountId { get; set; }

        /// <summary>
        /// Настройки
        /// </summary>
        public string ConfigJson { get; set; }

        /// <summary>
        /// Полное значение пин-кода
        /// </summary>
        public string PinFull { get; set; }

        /// <summary>
        /// Партнёр
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// ЦП
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Дни ожидания
        /// </summary>
        public int? WaitingDays { get; set; }

        /// <summary>
        /// Цена для партнёра
        /// </summary>
        public decimal? AgentPrice { get; set; }

        /// <summary>
        /// Цена для ЦП
        /// </summary>
        public decimal? ScPrice { get; set; }

        /// <summary>
        /// Номенклатура
        /// </summary>
        public string Article { get; set; }

        /// <summary>
        /// Ид шаблона
        /// </summary>
        public Guid? PinTemplateId { get; set; }

        /// <summary>
        /// Доступность кода активации
        /// </summary>
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn { get; set; }
        public int? OfdDeviceId { get; set; }

        /// <summary>
        /// Тип пин кода
        /// </summary>
        public int OfdPinTypeId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual SendedBill Bill { get; set; }
        public virtual Comment Comment { get; set; }
        public virtual ContractTariff ContractTariff { get; set; }
        public virtual OfdDevice OfdDevice { get; set; }
        public virtual OfdDiscount OfdDiscount { get; set; }
        public virtual OfdPinType OfdPinType { get; set; }
        public virtual Agent Parent { get; set; }
        public virtual OfdPinTemplate PinTemplate { get; set; }
        public virtual OfdPrefix Prefix { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
        public virtual Unit ValidityUnit { get; set; }
        public virtual ICollection<OfdPinSetting> OfdPinSettings { get; set; }
        public virtual ICollection<OfdPinTemplate> OfdPinTemplates { get; set; }
    }
}
