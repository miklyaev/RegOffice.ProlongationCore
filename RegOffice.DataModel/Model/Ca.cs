using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица центров сертификации
    /// </summary>
    public partial class Ca
    {
        public Ca()
        {
            CaAccreditations = new HashSet<CaAccreditation>();
            CaCertificates = new HashSet<CaCertificate>();
            CaMessengers = new HashSet<CaMessenger>();
            CaProductTypes = new HashSet<CaProductType>();
            CaSettings = new HashSet<CaSetting>();
            CaTemplates = new HashSet<CaTemplate>();
            Keys = new HashSet<Key>();
            MemberReserveKeys = new HashSet<MemberReserveKey>();
            Offices = new HashSet<Office>();
            OperatorIrucs = new HashSet<OperatorIruc>();
            Ras = new HashSet<Ra>();
            RegCertRequests = new HashSet<RegCertRequest>();
            RegRequestMembers = new HashSet<RegRequestMember>();
            TariffAttributeCas = new HashSet<TariffAttributeCa>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CaId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string CaName { get; set; }

        /// <summary>
        /// Cертификат
        /// </summary>
        public int CertificateId { get; set; }

        /// <summary>
        /// Префикс ДУЦ
        /// </summary>
        public string PrefixDuc { get; set; }

        /// <summary>
        /// Номер сети ViPNet
        /// </summary>
        public string NetNumber { get; set; }

        /// <summary>
        /// СМ по умолчанию
        /// </summary>
        public string DefaultCuid { get; set; }

        /// <summary>
        /// Объектный идентификатор политики
        /// </summary>
        public string PolicyOid { get; set; }

        /// <summary>
        /// Адрес документа политики
        /// </summary>
        public string PolicyUrl { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        /// <summary>
        /// Системное имя ДУЦ
        /// </summary>
        public string SystemNameDuc { get; set; }

        /// <summary>
        /// Внешнее имя
        /// </summary>
        public string CaShortName { get; set; }

        /// <summary>
        /// Квалифицированный
        /// </summary>
        public bool IsQualified { get; set; }

        /// <summary>
        /// Крипто ПРО
        /// </summary>
        public bool IsCryptopro { get; set; }

        /// <summary>
        /// Признак СУЦ(Солидный УЦ)
        /// </summary>
        public bool IsSolid { get; set; }

        /// <summary>
        /// Мнемоника
        /// </summary>
        public string Mnemonic { get; set; }

        /// <summary>
        /// ИНН УЦ
        /// </summary>
        public string Inn { get; set; }

        /// <summary>
        /// Издатель
        /// </summary>
        public int? IssuerId { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual VipnetNode DefaultCu { get; set; }
        public virtual Issuer Issuer { get; set; }
        public virtual CaRequestApi CaRequestApi { get; set; }
        public virtual ICollection<CaAccreditation> CaAccreditations { get; set; }
        public virtual ICollection<CaCertificate> CaCertificates { get; set; }
        public virtual ICollection<CaMessenger> CaMessengers { get; set; }
        public virtual ICollection<CaProductType> CaProductTypes { get; set; }
        public virtual ICollection<CaSetting> CaSettings { get; set; }
        public virtual ICollection<CaTemplate> CaTemplates { get; set; }
        public virtual ICollection<Key> Keys { get; set; }
        public virtual ICollection<MemberReserveKey> MemberReserveKeys { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
        public virtual ICollection<OperatorIruc> OperatorIrucs { get; set; }
        public virtual ICollection<Ra> Ras { get; set; }
        public virtual ICollection<RegCertRequest> RegCertRequests { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
        public virtual ICollection<TariffAttributeCa> TariffAttributeCas { get; set; }
    }
}
