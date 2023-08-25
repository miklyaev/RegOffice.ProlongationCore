using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица абонентов
    /// </summary>
    public partial class Abonent
    {
        public Abonent()
        {
            InverseCompanyGroup = new HashSet<Abonent>();
            Agents = new HashSet<Agent>();
            ProductAbonents = new HashSet<Product>();
            ProductAccrRepresentNavigations = new HashSet<Product>();
            ProlongationShortData = new HashSet<ProlongationShortDatum>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int AbonentId { get; set; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AbonentTypeId { get; set; }

        /// <summary>
        /// Краткое наименование
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Полное наименование
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; }

        /// <summary>
        /// ОГРН
        /// </summary>
        public string Ogrn { get; set; }

        /// <summary>
        /// Рег. номер ПФР
        /// </summary>
        public string RnsPfr { get; set; }

        /// <summary>
        /// Рег. номер ФСС
        /// </summary>
        public string RnsFss { get; set; }

        /// <summary>
        /// Код подразделения ФСС
        /// </summary>
        public string KpFss { get; set; }

        /// <summary>
        /// Юридический адрес
        /// </summary>
        public int? PostalAddressId { get; set; }

        /// <summary>
        /// Фактический адрес
        /// </summary>
        public int? LocationAddressId { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Факс
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// Мобильный телефон
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Эл. почта
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// ОКОПФ
        /// </summary>
        public int? OkopfId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Рег. номер ПФР работодателя
        /// </summary>
        public string StRnsPfr { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        public string AbonentLogin { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string AbonentPassword { get; set; }

        /// <summary>
        /// Контакты
        /// </summary>
        public string ContactPeople { get; set; }

        /// <summary>
        /// Головной абонент
        /// </summary>
        public int? CompanyGroupId { get; set; }

        /// <summary>
        /// Необработанные данные почтового адреса
        /// </summary>
        public string RawPostalAddress { get; set; }

        /// <summary>
        /// Необработанные данные фактического адреса
        /// </summary>
        public string RawLocationAddress { get; set; }

        /// <summary>
        /// Необработанные данные контактов
        /// </summary>
        public string RawContacts { get; set; }

        /// <summary>
        /// Расчетный счет
        /// </summary>
        public string PaymentAccount { get; set; }

        /// <summary>
        /// Наименование банка
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// БИК
        /// </summary>
        public string Bic { get; set; }

        /// <summary>
        /// Корреспондентский счёт
        /// </summary>
        public string CorrespondentAccount { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Лицевой счет
        /// </summary>
        public string PersonalAccount { get; set; }

        /// <summary>
        /// Ид. региона
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// Ид. гуид
        /// </summary>
        public Guid AbonentGuid { get; set; }

        /// <summary>
        /// Код подчиненности ФСС
        /// </summary>
        public string EmplParentNo { get; set; }

        /// <summary>
        /// Рег. номер ФСС обособленного подразделения
        /// </summary>
        public string RnsFssSub { get; set; }

        public virtual Abonent CompanyGroup { get; set; }
        public virtual Office Office { get; set; }
        public virtual ICollection<Abonent> InverseCompanyGroup { get; set; }
        public virtual ICollection<Agent> Agents { get; set; }
        public virtual ICollection<Product> ProductAbonents { get; set; }
        public virtual ICollection<Product> ProductAccrRepresentNavigations { get; set; }
        public virtual ICollection<ProlongationShortDatum> ProlongationShortData { get; set; }
    }
}
