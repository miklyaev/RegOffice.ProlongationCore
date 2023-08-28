using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOffice.General.Enums
{
    public enum ServiceTypeInfo
    {
        Bonus1S = 1,
        Test = 2,
        Special = 3,
        NeedItsRegistration = 5,
        AutoDistrubution = 6,
        DelayedItsRegistration = 7,
        AdditionAccount1SWithoutTariff = 8,
        Confirmation1SStorage = 9,
        Discount = 10,
        Proxy = 11,
        SmsIdentification = 14,
        ProductUnactive = 15,
        Gate = 19,
        PaperlessExtension = 16,
        PaperlessExtensionWithRequest = 17,
        RegRequestType = 18,
        EdoPrefix = 20,
        PaymentNotAllowed = 21,
        CertificateChangeExtensionRequired = 22,
        ContractNumber = 24,
        ContractDate = 25,
        AbonentOfdConfirmationRequired = 26,
        AutomaticProcessing = 27,
        AnotherCa = 28,
        ManualChecking = 29,
        Physical = 30,
        Receipt = 31,
        ReasonCode = 32,
        Okpo = 33,
        CountOfCertificates = 34,
        ElectronicReportingMember = 35,
        UserId1C = 36,
        PriorityProcessing = 37,
        CryptoProLicense = 38,
        CompanyGroupIndividual = 39,
        WorkingWithTwoKeys = 42,
        AdvancedScheme = 43,
        OrganizationType = 44,
        CertificateDocuments = 45,
        BackdatingCheck = 46,
        Allowed1cCa = 47,
        AllowedAoCa = 48,
        PlatformVersion1C = 49,
        ProgramName1C = 51,
        ProgramVersionNumber1C = 52,
        ItsRegNumber = 53,
        AbonentElementConfirmationRequired = 54,
        JuridicalWithPhysicalCertificate = 55,
        AbonentScrinConfirmationRequired = 56,
        /// <summary>
        /// Одобрение подписанной расписки
        /// </summary>
        CertReceiptApproved = 62,
        DelayActivationCode = 63,
        TestDssUser = 64,
        ChangePassword = 65,
        MigrationAo5 = 67,
        EsiaCertRegistration = 68,
        ForceProlongation = 70,
        IssuedNewCertificate = 71,
        DssCallbackAddress = 72,
        SolidCAScheme = 73,
        MigrationIotchetToPlatform = 74,
        /// <summary>
        /// Замена префикса спецоператора
        /// </summary>
        ChangeSos = 75,
        DssPasswordAuthEnabled = 77,
        /// <summary>
        /// Отправлять пароль DSS в файле автонастройки
        /// </summary>
        SendDssPassword = 78,
        /// <summary>
        /// Отправлять QR-код в файле автонастройки
        /// </summary>
        SendDssQrCode = 79,
        /// <summary>
        /// Получить код активации повторно
        /// </summary>
        GetActivationCode = 80,
        /// <summary>
        /// Небходимо загрузить расписку о получении сертификата
        /// </summary>
        SendReceipt = 81,
        /// <summary>
        /// Смена ключа DSS
        /// </summary>
        ChangeDssKeyOnly = 82,
        /// <summary>
        /// Псевдоним DSS
        /// </summary>
        DssKeyword = 83,
        /// <summary>
        /// Электронная подпись для сотрудника доверенного партнера
        /// </summary>
        UserAgentTrust = 84,

        /// <summary>
        /// Ид. подписчика портала 1С
        /// </summary>
        SubscriberId = 85,
        /// <summary>
        /// Загрузка расписки в РОСЭЛТОРГ
        /// </summary>
        UploadRosEltorgReceipt = 86,

        /// <summary>
        /// Проверять неприкреплённые к ключу документы
        /// </summary>
        CheckNotAttachedDocs = 87,

        /// <summary>
        /// Подключение в рамках акции "Бывших нет"
        /// </summary>
        NoExAction = 89,

        /// <summary>
        /// Подключение в рамках акции "Супер ход!"
        /// </summary>
        SuperMoveAction = 90,

        /// <summary>
        /// тип идентификации в запросе на сертификат, не соответсвующий косвенным признакам заявления 
        /// </summary>
        NotExpectedIdentificationKind = 91,

        /// <summary>
        /// Дополнительные данные для продукта
        /// </summary>
        AdditionalData = 92,
        /// <summary>
        /// Создание DSS пользователя
        /// </summary>
        DssUserCreation = 93,
        /// <summary>
        /// Ответ сервиса B2B
        /// </summary>
        B2bResponse = 94,

        /// <summary>
        /// ФИО из заявки на подключение КЦР 
        /// </summary>
        IdentityCenterRequestFio = 95,

        /// <summary>
        /// Признак бюджетной организации
        /// </summary>
        BudgetOrganization = 96,
        /// <summary>
        /// Признак финансовой организации
        /// </summary>
        FinancialOrganization = 97,
        /// <summary>
        /// Наличие владельца сертификата в выписке
        /// </summary>
        CertificateOwnerInOrder = 98,
        /// <summary>
        /// Проверки проведены клиентским ПО
        /// </summary>
        RegRequestCheckedByClient = 99,
        /// <summary>
        /// Хук 'Проверки по заявлению пройдены'
        /// </summary>
        HookCheckingPassed = 100,
        /// <summary>
        /// Хук 'Сертификат готов'
        /// </summary>
        HookCertificateReady = 101,
        /// <summary>
        /// Хук 'Регистрация в ИС завершена'
        /// </summary>
        HookIsRegistered = 102,
        /// <summary>
        /// Хук 'Сертификат заблокирован'
        /// </summary>
        HookBlocked = 103,
        /// <summary>
        /// Хук 'Документооборот завершен'
        /// </summary>
        HookCompleted = 104,
        /// <summary>
        /// Режим выпуска лицензии
        /// </summary>
        IssueLicenseMode = 105,

        /// <summary>
        /// Идентификатор УЦ для проверки
        /// </summary>
        CaIdForChecking = 106,

        /// <summary>
        /// Запрет автоматической обработки
        /// </summary>
        AutomaticProcessingDisabled = 107,

        /// <summary>
        /// ID авторизованного центра, указанный до отправки заявки в обработку
        /// </summary>
        AccrRepresentId = 111,
        /// <summary>
        /// Онлайн оплата услуг
        /// </summary>
        OnlinePaymentOfServices = 112,
        /// <summary>
        /// Отслеживание блокировки сертификата
        /// </summary>
        BlockCertificateTracking = 115,
        /// <summary>
        /// Повторное использование сертификата в рамках партнера
        /// </summary>
        SimpleCertificateReuse = 116,
        /// <summary>
        /// Поддерживается многопользовательский режим
        /// </summary>
        HasMultimodeSupport = 117,
        /// <summary>
        /// Это многопользовательский режим
        /// </summary>
        IsMultimode = 118,

        /// <summary>
        /// GUID выпуска КЦР
        /// </summary>
        KcrIssueGuid = 119,

        /// <summary>
        /// Sla на обработку заявки
        /// </summary>
        Sla = 120,
        /// <summary>
        /// Хранение ключей в мобильном приложении
        /// </summary>
        DssAuthId = 121,
        /// <summary>
        /// Хук 'Пользователь DSS инициализирован'
        /// </summary>
        HookDssUserCreated = 122,
        /// <summary>
        /// Хук 'Мобильное приложение DSS инициализировано'
        /// </summary>
        HookDssAppInitialized = 123,
        /// <summary>
        /// Хук 'Запрос на сертификат подписан'
        /// </summary>
        HookDssRequestSigned = 124,
        /*
         * Схема с идентификацией на госуслугах
         */
        SmevIdentification = 127,
        /// <summary>
        /// Использовать списки пользователей по направлениям
        /// </summary>
        UseAvailableRecipients = 128,
        /// <summary>
        /// Признак согласия пользователя на информирование через СМС о статусах отправленных отчетов и о входящих документах
        /// </summary>
        IsNotificationRequired = 129,

        /// <summary>
        /// Идентификатор для отслеживания всех шагов выпуска ЭП
        /// </summary>
        TraceGuid = 130,
        /// <summary>
        /// Флаг отсутствия ИНН
        /// </summary>
        IsMissingInn = 131,
        /// <summary>
        /// Причина разрегистрации
        /// </summary>
        UnregisteredReason = 132,
        /// <summary>
        /// Использовать списки пользователей по направлениям
        /// </summary>
        AllRecipientsAreAvailable = 133
    }

    public static class ServicesGroup
    {
        public static int[] AcfSafeUpdateServices
        {
            get
            {
                return new int[] { (int)ServiceTypeInfo.SendDssPassword, (int)ServiceTypeInfo.GetActivationCode };
            }
        }
    }
}
