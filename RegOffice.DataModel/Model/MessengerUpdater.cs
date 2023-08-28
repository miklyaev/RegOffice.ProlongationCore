using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица обновления курьеров
    /// </summary>
    public partial class MessengerUpdater
    {
        public MessengerUpdater()
        {
            Messengers = new HashSet<Messenger>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int MessengerUpdaterId { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        public string MessengerCode { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string MessengerName { get; set; }

        /// <summary>
        /// Сервер
        /// </summary>
        public int ServerId { get; set; }

        /// <summary>
        /// Протокол
        /// </summary>
        public int ProtocolId { get; set; }

        /// <summary>
        /// Домен СОЭД
        /// </summary>
        public string DomainSoed { get; set; }

        /// <summary>
        /// СОС
        /// </summary>
        public int? SosId { get; set; }

        /// <summary>
        /// Входящий порт
        /// </summary>
        public int PortIn { get; set; }

        /// <summary>
        /// Исходящий порт
        /// </summary>
        public int PortOut { get; set; }

        /// <summary>
        /// СУ
        /// </summary>
        public string Suid { get; set; }

        /// <summary>
        /// Регистрация в ПФР
        /// </summary>
        public bool RegPfr { get; set; }

        /// <summary>
        /// Провайдер ПФР
        /// </summary>
        public int? PfrProviderId { get; set; }

        /// <summary>
        /// Курьер
        /// </summary>
        public int MessengerId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Дата подтверждения
        /// </summary>
        public DateTime? ConfirmDate { get; set; }

        /// <summary>
        /// Дата применения
        /// </summary>
        public DateTime? ApplyDate { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Ожидать ответ
        /// </summary>
        public bool WaitReply { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertId { get; set; }

        public virtual Messenger Messenger { get; set; }
        public virtual Office Office { get; set; }
        public virtual PfrProvider PfrProvider { get; set; }
        public virtual Protocol Protocol { get; set; }
        public virtual Server Server { get; set; }
        public virtual So Sos { get; set; }
        public virtual VipnetNode Su { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Messenger> Messengers { get; set; }
    }
}
