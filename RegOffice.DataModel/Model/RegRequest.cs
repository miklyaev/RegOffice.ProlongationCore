using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица запросов на регистрацию
    /// </summary>
    public partial class RegRequest
    {
        public RegRequest()
        {
            AstralWorkflowClients = new HashSet<AstralWorkflowClient>();
            KcrIssues = new HashSet<KcrIssue>();
            ProductPersonHistories = new HashSet<ProductPersonHistory>();
            RegRequestAccounts = new HashSet<RegRequestAccount>();
            RegRequestCheckings = new HashSet<RegRequestChecking>();
            RegRequestComments = new HashSet<RegRequestComment>();
            RegRequestContacts = new HashSet<RegRequestContact>();
            RegRequestDocs = new HashSet<RegRequestDoc>();
            RegRequestFeedbacks = new HashSet<RegRequestFeedback>();
            RegRequestGates = new HashSet<RegRequestGate>();
            RegRequestMembers = new HashSet<RegRequestMember>();
            RegRequestPlugins = new HashSet<RegRequestPlugin>();
            RegRequestPotentialMembers = new HashSet<RegRequestPotentialMember>();
            RegRequestRecipients = new HashSet<RegRequestRecipient>();
            RegRequestServices = new HashSet<RegRequestService>();
            RegRequestSteps = new HashSet<RegRequestStep>();
            RegRequestTariffs = new HashSet<RegRequestTariff>();
            RegRequestTransferLogs = new HashSet<RegRequestTransferLog>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RegRequestId { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int RegRequestTypeId { get; set; }

        /// <summary>
        /// Тип абонента
        /// </summary>
        public int? AbonentTypeId { get; set; }

        /// <summary>
        /// ГУИД абонента
        /// </summary>
        public Guid? AbonentGuid { get; set; }

        /// <summary>
        /// Категория
        /// </summary>
        public int? CategoryId { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; }

        /// <summary>
        /// Полное наименование
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Мобильный
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Почтовый адрес
        /// </summary>
        public int? PostalAddressId { get; set; }

        /// <summary>
        /// Фактический адрес
        /// </summary>
        public int? LocationAddressId { get; set; }

        /// <summary>
        /// Эл. адрес
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Краткое наименование
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Рег. номер ПФР
        /// </summary>
        public string RnsPfr { get; set; }

        /// <summary>
        /// ИП работодатель
        /// </summary>
        public bool StPfr { get; set; }

        /// <summary>
        /// Рег. номер ФСС
        /// </summary>
        public string RnsFss { get; set; }

        /// <summary>
        /// Код подразделения ФСС
        /// </summary>
        public string KpFss { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Тип продукта
        /// </summary>
        public int ProductTypeId { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        public int? ProductId { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int? OfficeId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Документооборот
        /// </summary>
        public int WorkflowId { get; set; }

        /// <summary>
        /// Центр компетенции
        /// </summary>
        public int CenterId { get; set; }

        /// <summary>
        /// Главный абонент
        /// </summary>
        public int? CompanyGroupId { get; set; }

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
        /// ОГРН
        /// </summary>
        public string Ogrn { get; set; }

        /// <summary>
        /// Точка выдачи
        /// </summary>
        public int? TransferPointId { get; set; }

        /// <summary>
        /// СМС подтверждение
        /// </summary>
        public bool SmsConfirmation { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Версия формата
        /// </summary>
        public string FormatVersion { get; set; }

        /// <summary>
        /// Группа компаний
        /// </summary>
        public int? CompanyGroup2Id { get; set; }

        /// <summary>
        /// УП
        /// </summary>
        public int? ProxyAgentId { get; set; }

        /// <summary>
        /// Заявление
        /// </summary>
        public int? RequestId { get; set; }

        /// <summary>
        /// ОКПО
        /// </summary>
        public string Okpo { get; set; }

        /// <summary>
        /// Точка идентификации
        /// </summary>
        public int? IdentPointId { get; set; }

        /// <summary>
        /// ОКОПФ
        /// </summary>
        public int? OkopfId { get; set; }

        /// <summary>
        /// Рег номер продукта до перехода на опции
        /// </summary>
        public string RegistrationNumberOld { get; set; }

        /// <summary>
        /// Код подчиненности ФСС
        /// </summary>
        public string EmplParentNo { get; set; }

        /// <summary>
        /// Рег. номер ФСС обособленного подразделения
        /// </summary>
        public string RnsFssSub { get; set; }

        /// <summary>
        /// Признак отправки запроса в модуль счетов ЛКП с целью создания заказа и автоматического формирования счета
        /// </summary>
        public bool LkpBill { get; set; }

        public virtual AbonentType AbonentType { get; set; }
        public virtual Category Category { get; set; }
        public virtual Agent Center { get; set; }
        public virtual Abonent CompanyGroup { get; set; }
        public virtual CompanyGroup CompanyGroup2 { get; set; }
        public virtual Point IdentPoint { get; set; }
        public virtual Addr LocationAddress { get; set; }
        public virtual Office Office { get; set; }
        public virtual Okopf Okopf { get; set; }
        public virtual Addr PostalAddress { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ProxyAgent ProxyAgent { get; set; }
        public virtual RegRequestType RegRequestType { get; set; }
        public virtual File Request { get; set; }
        public virtual Step Step { get; set; }
        public virtual StorageType StorageType { get; set; }
        public virtual Point TransferPoint { get; set; }
        public virtual User User { get; set; }
        public virtual Workflow Workflow { get; set; }
        public virtual RegRequestTeam RegRequestTeam { get; set; }
        public virtual ICollection<AstralWorkflowClient> AstralWorkflowClients { get; set; }
        public virtual ICollection<KcrIssue> KcrIssues { get; set; }
        public virtual ICollection<ProductPersonHistory> ProductPersonHistories { get; set; }
        public virtual ICollection<RegRequestAccount> RegRequestAccounts { get; set; }
        public virtual ICollection<RegRequestChecking> RegRequestCheckings { get; set; }
        public virtual ICollection<RegRequestComment> RegRequestComments { get; set; }
        public virtual ICollection<RegRequestContact> RegRequestContacts { get; set; }
        public virtual ICollection<RegRequestDoc> RegRequestDocs { get; set; }
        public virtual ICollection<RegRequestFeedback> RegRequestFeedbacks { get; set; }
        public virtual ICollection<RegRequestGate> RegRequestGates { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
        public virtual ICollection<RegRequestPlugin> RegRequestPlugins { get; set; }
        public virtual ICollection<RegRequestPotentialMember> RegRequestPotentialMembers { get; set; }
        public virtual ICollection<RegRequestRecipient> RegRequestRecipients { get; set; }
        public virtual ICollection<RegRequestService> RegRequestServices { get; set; }
        public virtual ICollection<RegRequestStep> RegRequestSteps { get; set; }
        public virtual ICollection<RegRequestTariff> RegRequestTariffs { get; set; }
        public virtual ICollection<RegRequestTransferLog> RegRequestTransferLogs { get; set; }
    }
}
