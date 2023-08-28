using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица сотрудников продукта
    /// </summary>
    public partial class ProductPerson
    {
        public ProductPerson()
        {
            ContactPeople = new HashSet<ContactPerson>();
            DssAuths = new HashSet<DssAuth>();
            ProductCheckings = new HashSet<ProductChecking>();
            ProductDocs = new HashSet<ProductDoc>();
            ProductPersonAvailableProtocols = new HashSet<ProductPersonAvailableProtocol>();
            ProductPersonHistories = new HashSet<ProductPersonHistory>();
            ProductPersonKeys = new HashSet<ProductPersonKey>();
            ProductPersonSteps = new HashSet<ProductPersonStep>();
            RegRequestMembers = new HashSet<RegRequestMember>();
            Services = new HashSet<Service>();
            Ekus = new HashSet<Eku>();
        }


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

        public virtual AbonentPerson AbonentPerson { get; set; }
        public virtual DssUser DssUser { get; set; }
        public virtual Key Key { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual RegFileType RegFileType { get; set; }
        public virtual Key ReserveKey { get; set; }
        public virtual SignQualification SignQualification { get; set; }
        public virtual Step Step { get; set; }
        public virtual StorageType StorageType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ContactPerson> ContactPeople { get; set; }
        public virtual ICollection<DssAuth> DssAuths { get; set; }
        public virtual ICollection<ProductChecking> ProductCheckings { get; set; }
        public virtual ICollection<ProductDoc> ProductDocs { get; set; }
        public virtual ICollection<ProductPersonAvailableProtocol> ProductPersonAvailableProtocols { get; set; }
        public virtual ICollection<ProductPersonHistory> ProductPersonHistories { get; set; }
        public virtual ICollection<ProductPersonKey> ProductPersonKeys { get; set; }
        public virtual ICollection<ProductPersonStep> ProductPersonSteps { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<Eku> Ekus { get; set; }
    }
}
