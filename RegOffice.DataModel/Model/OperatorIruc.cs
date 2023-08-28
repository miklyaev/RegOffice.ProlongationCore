using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица операторов ИРУЦ
    /// </summary>
    public partial class OperatorIruc
    {
        public OperatorIruc()
        {
            MercuryMessengers = new HashSet<MercuryMessenger>();
            Offices = new HashSet<Office>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int OperatorIrucId { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }

        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string OperatorIrucName { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        public string IrucLogin { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string IrucPassword { get; set; }

        /// <summary>
        /// СОС
        /// </summary>
        public int? SosId { get; set; }

        /// <summary>
        /// ДУЦ
        /// </summary>
        public int? DucId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual Ca Duc { get; set; }
        public virtual So Sos { get; set; }
        public virtual ICollection<MercuryMessenger> MercuryMessengers { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
    }
}
