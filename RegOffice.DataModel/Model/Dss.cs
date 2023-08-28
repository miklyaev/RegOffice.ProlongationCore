using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// DSS
    /// </summary>
    public partial class Dss
    {
        public Dss()
        {
            DssAuthKeys = new HashSet<DssAuthKey>();
            DssAuthSystems = new HashSet<DssAuthSystem>();
            DssUserGroups = new HashSet<DssUserGroup>();
            DssUsers = new HashSet<DssUser>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int DssId { get; set; }

        /// <summary>
        /// Наименование УЦ
        /// </summary>
        public string CaName { get; set; }

        /// <summary>
        /// ИД клиента
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string DssHost { get; set; }

        /// <summary>
        /// Криптопровайдер
        /// </summary>
        public int ProviderId { get; set; }

        /// <summary>
        /// OID шаблона
        /// </summary>
        public string TemplateOid { get; set; }

        /// <summary>
        /// Адрес СЭП
        /// </summary>
        public string SignAddress { get; set; }

        /// <summary>
        /// Идентификатор ЦИ
        /// </summary>
        public string StsId { get; set; }

        /// <summary>
        /// Идентификатор СЭП
        /// </summary>
        public string SignId { get; set; }

        /// <summary>
        /// Внутренний идентификатор
        /// </summary>
        public string InnerId { get; set; }

        /// <summary>
        /// Шаблон подтверждения
        /// </summary>
        public string ConfirmTemplate { get; set; }

        /// <summary>
        /// Способ аутентификации
        /// </summary>
        public int? AuthMethod { get; set; }

        /// <summary>
        /// Способ подтверждения
        /// </summary>
        public int? ConfirmMethod { get; set; }

        /// <summary>
        /// Адрес ЛК
        /// </summary>
        public string AccountAddress { get; set; }

        /// <summary>
        /// Используется
        /// </summary>
        public bool? Used { get; set; }

        /// <summary>
        /// Таймаут
        /// </summary>
        public int? Timeout { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Версия АПИ
        /// </summary>
        public string ApiVer { get; set; }

        /// <summary>
        /// Адрес ЦИ
        /// </summary>
        public string StsAddress { get; set; }

        /// <summary>
        /// Адрес SVS
        /// </summary>
        public string SvsAddress { get; set; }

        /// <summary>
        /// Открытый пользователь
        /// </summary>
        public string EncryptUser { get; set; }

        /// <summary>
        /// Адрес криптосервиса
        /// </summary>
        public string CsAddress { get; set; }

        /// <summary>
        /// Пароль открытого пользователя
        /// </summary>
        public string EncryptUserPassword { get; set; }

        /// <summary>
        /// Сертификат оператора
        /// </summary>
        public int CertificateId { get; set; }

        /// <summary>
        /// Представление
        /// </summary>
        public string DssName { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual DssTariff DssTariff { get; set; }
        public virtual ICollection<DssAuthKey> DssAuthKeys { get; set; }
        public virtual ICollection<DssAuthSystem> DssAuthSystems { get; set; }
        public virtual ICollection<DssUserGroup> DssUserGroups { get; set; }
        public virtual ICollection<DssUser> DssUsers { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
