using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица серверов
    /// </summary>
    public partial class Server
    {
        public Server()
        {
            Ips = new HashSet<Ip>();
            MessengerUpdaters = new HashSet<MessengerUpdater>();
            Messengers = new HashSet<Messenger>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ServerId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// Входящий домен
        /// </summary>
        public string DomainIn { get; set; }

        /// <summary>
        /// Исходящий домен
        /// </summary>
        public string DomainOut { get; set; }

        /// <summary>
        /// Публичный
        /// </summary>
        public bool PublicServer { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual ICollection<Ip> Ips { get; set; }
        public virtual ICollection<MessengerUpdater> MessengerUpdaters { get; set; }
        public virtual ICollection<Messenger> Messengers { get; set; }
    }
}
