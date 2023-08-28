using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица ключей сотрудников продукта
    /// </summary>
    public partial class ProductPersonKey
    {
        public ProductPersonKey()
        {
            KeyPermissions = new HashSet<KeyPermission>();
            ProductPersonKeySteps = new HashSet<ProductPersonKeyStep>();
        }


        /// <summary>
        /// Сотрудник
        /// </summary>
        public int ProductPersonId { get; set; }

        /// <summary>
        /// Ключ
        /// </summary>
        public int KeyId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Флаг резервного ключа
        /// </summary>
        public bool Reserve { get; set; }

        /// <summary>
        /// Пользователь DSS
        /// </summary>
        public int? DssUserId { get; set; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PersonKeyId { get; set; }

        /// <summary>
        /// Тип хранилища
        /// </summary>
        public int? StorageTypeId { get; set; }

        /// <summary>
        /// Шаг ключа
        /// </summary>
        public int? StepId { get; set; }

        public virtual DssUser DssUser { get; set; }
        public virtual Key Key { get; set; }
        public virtual ProductPerson ProductPerson { get; set; }
        public virtual Step Step { get; set; }
        public virtual StorageType StorageType { get; set; }
        public virtual ICollection<KeyPermission> KeyPermissions { get; set; }
        public virtual ICollection<ProductPersonKeyStep> ProductPersonKeySteps { get; set; }
    }
}
