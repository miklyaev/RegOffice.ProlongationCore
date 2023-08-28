using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Данные по аппаратуре ОФД
    /// </summary>
    public partial class OfdDevice
    {
        public OfdDevice()
        {
            OfdPins = new HashSet<OfdPin>();
        }


        /// <summary>
        /// Идентификатор аппаратуры ОФД
        /// </summary>
        public int OfdDeviceId { get; set; }

        /// <summary>
        /// Заводской номер
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Тип аппаратуры
        /// </summary>
        public int OfdDeviceTypeId { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Идентификатор партнера
        /// </summary>
        public int? AgentId { get; set; }

        /// <summary>
        /// Идентификатор центра продаж
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// Идентификатор Астрал-ККТ
        /// </summary>
        public int? AstralKktId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime? AstralKktDate { get; set; }

        /// <summary>
        /// Дата получения центром продаж
        /// </summary>
        public DateTime? ParentDate { get; set; }

        /// <summary>
        /// Дата получения партнером
        /// </summary>
        public DateTime? AgentDate { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public int UserId { get; set; }
        public DateTime LastChangeDate { get; set; }

        /// <summary>
        /// Продолжительность периода действия кода активации
        /// </summary>
        public int? ValidityLength { get; set; }

        /// <summary>
        /// Единица измерения периода действия кода активации
        /// </summary>
        public int? ValidityUnitId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Agent AstralKkt { get; set; }
        public virtual OfdDeviceType OfdDeviceType { get; set; }
        public virtual Agent Parent { get; set; }
        public virtual User User { get; set; }
        public virtual Unit ValidityUnit { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
    }
}
