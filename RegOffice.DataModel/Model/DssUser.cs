using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица пользователей DSS
    /// </summary>
    public partial class DssUser
    {
        public DssUser()
        {
            DssAuthKeys = new HashSet<DssAuthKey>();
            DssAuths = new HashSet<DssAuth>();
            DssUserAuthSteps = new HashSet<DssUserAuthStep>();
            ProductPeople = new HashSet<ProductPerson>();
            ProductPersonKeys = new HashSet<ProductPersonKey>();
            RegRequestMembers = new HashSet<RegRequestMember>();
            Apps = new HashSet<DssApp>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Продукт пользователя
        /// </summary>
        public int? ProductId { get; set; }

        /// <summary>
        /// Номер мобильного телефона
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// Электронная почта
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Режим аутентификации
        /// </summary>
        public int AuthModeId { get; set; }

        /// <summary>
        /// Тип контакта для аутентификации
        /// </summary>
        public int? AuthContactTypeId { get; set; }

        /// <summary>
        /// QR-код
        /// </summary>
        public int? QrcodeFileId { get; set; }

        /// <summary>
        /// Дата окончания действия кода
        /// </summary>
        public DateTime? QrcodeEndDate { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// DSS
        /// </summary>
        public int DssId { get; set; }

        /// <summary>
        /// Идентификатор пользователя в ЦИ
        /// </summary>
        public Guid? StsUserId { get; set; }

        /// <summary>
        /// Группа пользователей DSS
        /// </summary>
        public int? GroupId { get; set; }

        /// <summary>
        /// Состояние аутентификации
        /// </summary>
        public int? AuthStepId { get; set; }

        /// <summary>
        /// Дата последней инициализации мобильной аутентификации
        /// </summary>
        public DateTime? LastInitialTime { get; set; }

        /// <summary>
        /// Дата следующей проверки на отключение мобильной аутентификации
        /// </summary>
        public DateTime? NextCheckTime { get; set; }

        /// <summary>
        /// Время активации ключа в myDSS
        /// </summary>
        public DateTime? InstallDate { get; set; }

        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        public virtual ContactType AuthContactType { get; set; }
        public virtual DssAuthMode AuthMode { get; set; }
        public virtual Step AuthStep { get; set; }
        public virtual Dss Dss { get; set; }
        public virtual DssUserGroup Group { get; set; }
        public virtual File QrcodeFile { get; set; }
        public virtual ICollection<DssAuthKey> DssAuthKeys { get; set; }
        public virtual ICollection<DssAuth> DssAuths { get; set; }
        public virtual ICollection<DssUserAuthStep> DssUserAuthSteps { get; set; }
        public virtual ICollection<ProductPerson> ProductPeople { get; set; }
        public virtual ICollection<ProductPersonKey> ProductPersonKeys { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
        public virtual ICollection<DssApp> Apps { get; set; }
    }
}
