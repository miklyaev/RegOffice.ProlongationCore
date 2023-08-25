using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица сотрудников продукта
    /// </summary>
    public partial class ProductPerson
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ProductPersonId { get; set; }

        /// <summary>
        /// Сотрудник
        /// </summary>
        public int AbonentPersonId { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Ключ
        /// </summary>
        public int? KeyId { get; set; }

        /// <summary>
        /// Квалификация подписи
        /// </summary>
        public int? SignQualificationId { get; set; }

        /// <summary>
        /// Шифровальщик
        /// </summary>
        public bool? Encrypt { get; set; }

        /// <summary>
        /// Онлайн
        /// </summary>
        public bool? IonOnline { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int ProductTypeId { get; set; }

        /// <summary>
        /// Подписант
        /// </summary>
        public bool? Signer { get; set; }

        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        /// <summary>
        /// Тип рег-файла
        /// </summary>
        public int? RegFileTypeId { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Тип хранилища
        /// </summary>
        public int? StorageTypeId { get; set; }

        /// <summary>
        /// Резервный ключ
        /// </summary>
        public int? ReserveKeyId { get; set; }

        /// <summary>
        /// Идентификатор пользователя DSS в БД
        /// </summary>
        public int? DssUserId { get; set; }

        /// <summary>
        /// ГУИД владельца ЭЦП
        /// </summary>
        public Guid ProductPersonGuid { get; set; }

        /// <summary>
        /// Это доверенное лицо
        /// </summary>
        public bool? IsTrusted { get; set; }

        /// <summary>
        /// Сотрудник имеет роль Администратор
        /// </summary>
        public bool? IsAdministrator { get; set; }

        public virtual Key Key { get; set; }
        public virtual Product Product { get; set; }
        public virtual Key ReserveKey { get; set; }
    }
}
