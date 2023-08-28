using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица групп пользователей DSS
    /// </summary>
    public partial class DssUserGroup
    {
        public DssUserGroup()
        {
            DssUsers = new HashSet<DssUser>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// DSS
        /// </summary>
        public int DssId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Период действия лицензии
        /// </summary>
        public int LicenseValidity { get; set; }

        /// <summary>
        /// Единицы времени лицензии
        /// </summary>
        public int ValidityUnitId { get; set; }

        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        /// <summary>
        /// Группа по умолчанию
        /// </summary>
        public bool? IsDefault { get; set; }

        public virtual Dss Dss { get; set; }
        public virtual Unit ValidityUnit { get; set; }
        public virtual ICollection<DssUser> DssUsers { get; set; }
    }
}
