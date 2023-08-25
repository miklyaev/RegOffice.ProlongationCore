using RegOffice.General.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOffice.General.Models
{
    public enum StepTypeInfo
    {
        [EnumNameAttribute("Отсутствует")]
        None = 0,
        [EnumNameAttribute("Принято")]
        Received = 1,
        [EnumNameAttribute("Заблокировано")]
        Locked = 4,
        [EnumNameAttribute("Создание запроса в ИРУЦ")]
        CreateIrucRequest = 9,
        [EnumNameAttribute("Отправка запроса в ИРУЦ")]
        SendIrucRequest = 10,
        [EnumNameAttribute("Запрос ответа из ИРУЦ")]
        ReceiveIrucReply = 11,
        [EnumNameAttribute("Регистрация сертификата")]
        InstallCertificate = 22,
        [EnumNameAttribute("Создание запроса на сертификат")]
        CreateCertificateRequest = 17,
        [EnumNameAttribute("Отправка запроса на сертификат")]
        SendCertificateRequest = 24,
        [EnumNameAttribute("Генерация ключевого контейнера")]
        CreateContainer = 21,
        [EnumNameAttribute("Ошибка")]
        Error = 20,
        [EnumNameAttribute("Зарегистрировано")]
        Registered = 5,
        [EnumNameAttribute("В работе")]
        Processing = 2,
        [EnumNameAttribute("Регистрация в ИС")]
        RegistrationInfoSys = 8,
        [EnumNameAttribute("Создание рег-файла")]
        CreateRegFile = 18,
        [EnumNameAttribute("Отклонено")]
        Rejected = 3,
        [EnumNameAttribute("Создание лицензии")]
        CreateLicense = 7,
        [EnumNameAttribute("Создание рег-пакета")]
        CreateRegPacket = 25,
        [EnumNameAttribute("Обновление хранилища")]
        UpdateStorage = 26,
        [EnumNameAttribute("Создание рег-информации для ПФР")]
        PfrXmlCreation = 12,
        [EnumNameAttribute("Создание рег-пакета для ПФР")]
        PfrZipCreation = 13,
        [EnumNameAttribute("Отправка рег-информации в ПФР")]
        PfrSending = 14,
        [EnumNameAttribute("Получение квитанции из ПФР")]
        PfrRegistering = 23,
        [EnumNameAttribute("В ожидании")]
        Pending = 16,
        [EnumNameAttribute("Регистрация на СОС")]
        SosRegistration = 27,
        [EnumNameAttribute("Завершено")]
        Completed = 28,
        [EnumNameAttribute("Обратная связь")]
        Feedback = 29,
        [EnumNameAttribute("Установка сертификата в контейнер")]
        SetCertToContainer = 34,
        [EnumNameAttribute("Требуется перевыпуск сертификата")]
        RecreatedCertificate = 35,
        [EnumNameAttribute("Требуется перерегистрация в ИС")]
        RecreatedRequestIS = 36,
        [EnumNameAttribute("Требуется перевыпуск рег.файла")]
        RecreatedRegFile = 37,
        [EnumNameAttribute("Активация")]
        Activation = 38,
        [EnumNameAttribute("Обновление")]
        Update = 39,
        [EnumNameAttribute("Отправка запроса в ИОН")]
        CreateIonRequest = 44,
        [EnumNameAttribute("Запрос отключения курьера")]
        CreateBlockRequest = 40,
        [EnumNameAttribute("Проверка отключения курьера")]
        ReceiveBlockReply = 41,
        [EnumNameAttribute("Отключено")]
        Blocked = 42,
        [EnumNameAttribute("Частично зарегистрирован")]
        PartialRegistered = 43,
        [EnumNameAttribute("Отозвано")]
        Revoked = 55,
        [EnumNameAttribute("Создание запроса ЭДО")]
        CreateEdoRequest = 53,
        [EnumNameAttribute("Ожидание ответа ЭДО")]
        ReceiveEdoReply = 54,
        [EnumNameAttribute("Замещено")]
        Replaced = 56,
        [EnumNameAttribute("Регистрация почтового ящика")]
        MailRegistration = 59,
        [EnumNameAttribute("Отправка пакета на блокировку")]
        SendBlockedPacket = 60,
        [EnumNameAttribute("Получено")]
        Attached = 61,
        [EnumNameAttribute("Ответ загружен")]
        ReplyLoaded = 62,
        [EnumNameAttribute("Подтверждено")]
        Confirmed = 63,
        [EnumNameAttribute("Приостановлено")]
        Suspended = 64,
        [EnumNameAttribute("Регистрация на сервере")]
        Reflect = 65,
        [EnumNameAttribute("Регистрация в ЕСИА")]
        Esia = 66,
        [EnumNameAttribute("Регистрация в сверке НДС")]
        BalanceRegistration = 69,
        [EnumNameAttribute("Разрегистрация в информационных системах")]
        UnregisterInfoSys = 70,
        [EnumNameAttribute("Разрегистрация рег-пакета")]
        UnregisterRegPacket = 71,
        [EnumNameAttribute("Разрегистрация на сервере")]
        UnregisterReflect = 72,
        [EnumNameAttribute("Регистрация в сервисе госзакупок")]
        TenderConsultingRegistration = 77,
        [EnumNameAttribute("Ожидание подтверждения")]
        WaitingConfirmation = 78,
        [EnumNameAttribute("Регистрация в БД 1С:Хаб")]
        Hub1SRegistration = 79,
        [EnumNameAttribute("Запрос на регистрацию пользователя в ЦС отправлен")]
        UserRequestSent = 81,
        [EnumNameAttribute("Пользователь в ЦС создан")]
        UserCreated = 82,
        [EnumNameAttribute("Запрос на сертификат в ЦС отправлен ")]
        CertRequestSent = 83,
        [EnumNameAttribute("Сертификат в ЦС создан")]
        CertCreated = 84,
        [EnumNameAttribute("Сертификат в ЦС подтвержден")]
        CertConfirmed = 85,
        [EnumNameAttribute("Регистрация в БД ОФД")]
        OfdRegistration = 86,
        [EnumNameAttribute("Требуется уведомление")]
        NotificationRequired = 87,
        [EnumNameAttribute("Проверка")]
        Checking = 90,
        [EnumNameAttribute("Автоматическая обработка")]
        AutoProcessing = 91,
        [EnumNameAttribute("Проверка пройдена")]
        CheckingPassed = 92,
        [EnumNameAttribute("Проверка не пройдена")]
        CheckingNotPassed = 93,
        [EnumNameAttribute("Отложенная проверка")]
        LazyChecking = 94,
        [EnumNameAttribute("Ожидание результатов проверки")]
        WaitCheckingResult = 95,
        [EnumNameAttribute("Проверка не требуется")]
        CheckingNotRequired = 96,
        [EnumNameAttribute("Запрос на отзыв сертификата")]
        CreateRevokeRequest = 97,
        [EnumNameAttribute("Ручная проверка")]
        ManualChecking = 98,
        [EnumNameAttribute("Обновление после разрегистрации")]
        UnregisterUpdate = 99,
        [EnumNameAttribute("Создание рег-информации для РОССТАТ")]
        StatXmlCreation = 110,
        [EnumNameAttribute("Отправка рег-пакета в РОССТАТ")]
        StatSending = 112,
        [EnumNameAttribute("Получение квитанции из РОССТАТ")]
        StatRegistering = 113,
        [EnumNameAttribute("Ожидание документов")]
        WaitingDocuments = 114,
        [EnumNameAttribute("Проверка документов")]
        CheckingDocuments = 115,
        [EnumNameAttribute("Идентификация")]
        Identification = 116,
        [EnumNameAttribute("Идентификация пройдена")]
        IdentificationPassed = 117,
        [EnumNameAttribute("Идентификация не пройдена")]
        IdentificationNotPassed = 118,
        [EnumName("Требуется обновление рег. файла")]
        NeedRegFileUpdate = 119,
        [EnumNameAttribute("Предварительная запись в базу отражений")]
        PreliminaryReflect = 120,
        [EnumNameAttribute("Удалено")]
        Deleted = 121,
        [EnumNameAttribute("Закреплено")]
        Fixed = 122,
        [EnumNameAttribute("Назначено")]
        Assigned = 123,
        [EnumName("Проверка результатов в СМЭВ3")]
        CheckSmev3Results = 125,
        [EnumName("Пропущено")]
        Skipped = 127,
        [EnumName("Разрегистрация в DSS")]
        UnregisterDss = 128,
        [EnumName("Отключено в DSS")]
        DssMobileUnregistered = 129,
        [EnumName("Включена аутентификация по паролю")]
        DssPasswordAuthEnabled = 130,
        [EnumName("Миграция")]
        Migration = 131,
        [EnumName("Включено")]
        Enabled = 133,
        [EnumNameAttribute("Проверка в УЦ ФНС")]
        FnsCaChecking = 134,
        [EnumNameAttribute("Идентификация в УЦ ФНС")]
        FnsCaIdentification = 135,
        [EnumName("Регистрация в торговой площадке")]
        TradingPlatformRegistration = 136,
        [EnumName("Ожидание регистрации в торговой площадке")]
        TradingPlatformRegistrationProcessing = 137,
        [EnumName("Инициализация пользователя DSS")]
        DssUserInitializing = 138,
        [EnumName("Инициализация МП DSS")]
        DssMobileAppInitializing = 139,
        [EnumName("Инициализация DSS завершена")]
        DssInitialized = 140,
        [EnumNameAttribute("Завершение разрегистрации")]
        UnregisterСompletion = 141,
    }
}
