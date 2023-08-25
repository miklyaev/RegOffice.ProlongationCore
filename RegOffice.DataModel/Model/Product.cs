using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица продуктов
    /// </summary>
    public partial class Product
    {
        public Product()
        {
            ProductPeople = new HashSet<ProductPerson>();
            ProlongationShortData = new HashSet<ProlongationShortDatum>();
            ContractTariffs = new HashSet<ContractTariff>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public Guid ProductGuid { get; set; }

        /// <summary>
        /// Абонент
        /// </summary>
        public int AbonentId { get; set; }

        /// <summary>
        /// Договор
        /// </summary>
        public int? ContractId { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateOnly? DateFixed { get; set; }

        /// <summary>
        /// Крупнейший
        /// </summary>
        public bool? FirstRate { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Привязка к СОС
        /// </summary>
        public bool? HardCodeSos { get; set; }

        /// <summary>
        /// Категория
        /// </summary>
        public int? CategoryId { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int ProductTypeId { get; set; }

        /// <summary>
        /// Зависимый
        /// </summary>
        public bool? AccrRepresent { get; set; }

        /// <summary>
        /// УП
        /// </summary>
        public int? AccrRepresentId { get; set; }

        /// <summary>
        /// Тип РНС ПФР
        /// </summary>
        public bool? StPfr { get; set; }

        /// <summary>
        /// Псевдоним
        /// </summary>
        public string Pseudonym { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Почтовый логин
        /// </summary>
        public string MailLogin { get; set; }

        /// <summary>
        /// Почтовый пароль
        /// </summary>
        public string MailPassword { get; set; }

        /// <summary>
        /// Дата обновления рег-пакета
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// Рег. номер продукта
        /// </summary>
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Версия программы (конфигурации)
        /// </summary>
        public string ProgramVersion { get; set; }

        /// <summary>
        /// Тип хранилища
        /// </summary>
        public int? StorageTypeId { get; set; }

        /// <summary>
        /// Флаг ИТС
        /// </summary>
        public bool? IsIts { get; set; }

        /// <summary>
        /// Краткое наименование
        /// </summary>
        public string AbonentShortName { get; set; }

        /// <summary>
        /// Полное наименование
        /// </summary>
        public string AbonentFullName { get; set; }

        /// <summary>
        /// Рег. номер ПФР
        /// </summary>
        public string AbonentRnsPfr { get; set; }

        /// <summary>
        /// Рег. номер ФСС
        /// </summary>
        public string AbonentRnsFss { get; set; }

        /// <summary>
        /// Код подразделения ФСС
        /// </summary>
        public string AbonentKpFss { get; set; }

        /// <summary>
        /// Юридический адрес
        /// </summary>
        public int? AbonentPostalAddressId { get; set; }

        /// <summary>
        /// Фактический адрес
        /// </summary>
        public int? AbonentLocationAddressId { get; set; }

        /// <summary>
        /// Эл. почта
        /// </summary>
        public string AbonentEmail { get; set; }

        /// <summary>
        /// Частичный рег-файл
        /// </summary>
        public bool IsPartial { get; set; }

        /// <summary>
        /// Точка выдачи
        /// </summary>
        public int? TransferPointId { get; set; }

        /// <summary>
        /// СМС подтверждение
        /// </summary>
        public bool SmsConfirmation { get; set; }

        /// <summary>
        /// Мобильный телефон
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Рег-файл
        /// </summary>
        public int? RegFileId { get; set; }

        /// <summary>
        /// Пакет обновления
        /// </summary>
        public int? PacketId { get; set; }

        /// <summary>
        /// Файл лицензии
        /// </summary>
        public int? LicFileId { get; set; }

        /// <summary>
        /// Отложенное обновление
        /// </summary>
        public bool LazyUpdate { get; set; }

        /// <summary>
        /// УП
        /// </summary>
        public int? ProxyAgentId { get; set; }

        /// <summary>
        /// Конфиденциальные данные
        /// </summary>
        public int? SafeId { get; set; }

        /// <summary>
        /// Идентификатор системы налогообложения
        /// </summary>
        public int? TaxSystemId { get; set; }

        /// <summary>
        /// Идентификатор типа абонента этого продукта
        /// </summary>
        public int? AbonentTypeId { get; set; }

        /// <summary>
        /// ОКПО
        /// </summary>
        public string Okpo { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual Abonent AccrRepresentNavigation { get; set; }
        public virtual Office Office { get; set; }
        public virtual ICollection<ProductPerson> ProductPeople { get; set; }
        public virtual ICollection<ProlongationShortDatum> ProlongationShortData { get; set; }
        public virtual ICollection<ContractTariff> ContractTariffs { get; set; }
    }
}
