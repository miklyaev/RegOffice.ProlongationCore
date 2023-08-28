using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица реквизитов лицензий
    /// </summary>
    public partial class LicenseDetail
    {

        /// <summary>
        /// Лицензия
        /// </summary>
        public int LicenseId { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; }

        /// <summary>
        /// ИТС
        /// </summary>
        public int? ItsId { get; set; }

        /// <summary>
        /// Флаг бесплатной лицензии
        /// </summary>
        public bool? IsFree { get; set; }

        /// <summary>
        /// Ид. опции ИТС
        /// </summary>
        public string ItsOptionId { get; set; }

        /// <summary>
        /// Ид. пользователя 1С
        /// </summary>
        public string Uin1c { get; set; }

        public virtual It Its { get; set; }
        public virtual LicensePool License { get; set; }
        public virtual Office Office { get; set; }
    }
}
