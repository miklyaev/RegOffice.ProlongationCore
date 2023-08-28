using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица шлюзов
    /// </summary>
    public partial class Gate
    {
        public Gate()
        {
            GateProductTypes = new HashSet<GateProductType>();
            GateProtocols = new HashSet<GateProtocol>();
            GateSettings = new HashSet<GateSetting>();
            GateUpdaters = new HashSet<GateUpdater>();
            ProductNetNodes = new HashSet<ProductNetNode>();
            RegRequestGates = new HashSet<RegRequestGate>();
            WorkflowServices = new HashSet<WorkflowService>();
            Tokens = new HashSet<Token>();
        }


        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid GateId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string GateName { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertificateId { get; set; }
        public int? SystemId { get; set; }
        public bool IsVirtual { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual UpdateSystem System { get; set; }
        public virtual ICollection<GateProductType> GateProductTypes { get; set; }
        public virtual ICollection<GateProtocol> GateProtocols { get; set; }
        public virtual ICollection<GateSetting> GateSettings { get; set; }
        public virtual ICollection<GateUpdater> GateUpdaters { get; set; }
        public virtual ICollection<ProductNetNode> ProductNetNodes { get; set; }
        public virtual ICollection<RegRequestGate> RegRequestGates { get; set; }
        public virtual ICollection<WorkflowService> WorkflowServices { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
    }
}
