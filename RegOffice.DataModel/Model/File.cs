using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица файлов
    /// </summary>
    public partial class File
    {
        public File()
        {
            BulkSkziLicenseUploadTaskLicenseListFiles = new HashSet<BulkSkziLicenseUploadTask>();
            BulkSkziLicenseUploadTaskLicensesPdfFiles = new HashSet<BulkSkziLicenseUploadTask>();
            Certificates = new HashSet<Certificate>();
            DssAuthKeys = new HashSet<DssAuthKey>();
            DssAuths = new HashSet<DssAuth>();
            DssUsers = new HashSet<DssUser>();
            Keys = new HashSet<Key>();
            MemberReserveKeys = new HashSet<MemberReserveKey>();
            MercuryMessengerSteps = new HashSet<MercuryMessengerStep>();
            ProductCheckings = new HashSet<ProductChecking>();
            RegRequestCheckings = new HashSet<RegRequestChecking>();
            RegRequests = new HashSet<RegRequest>();
            SkziLicenses = new HashSet<SkziLicense>();
            SmevRequestStages = new HashSet<SmevRequestStage>();
            UserTrusts = new HashSet<UserTrust>();
            RequestComments = new HashSet<AgentBalanceDetailChangeRequestComment>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int FileId { get; set; }

        /// <summary>
        /// Тип файла
        /// </summary>
        public int FileTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Данные
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Гуид
        /// </summary>
        public Guid FileGuid { get; set; }

        /// <summary>
        /// Время удаления
        /// </summary>
        public DateTime? CleaningTime { get; set; }

        public virtual FileType FileType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<BulkSkziLicenseUploadTask> BulkSkziLicenseUploadTaskLicenseListFiles { get; set; }
        public virtual ICollection<BulkSkziLicenseUploadTask> BulkSkziLicenseUploadTaskLicensesPdfFiles { get; set; }
        public virtual ICollection<Certificate> Certificates { get; set; }
        public virtual ICollection<DssAuthKey> DssAuthKeys { get; set; }
        public virtual ICollection<DssAuth> DssAuths { get; set; }
        public virtual ICollection<DssUser> DssUsers { get; set; }
        public virtual ICollection<Key> Keys { get; set; }
        public virtual ICollection<MemberReserveKey> MemberReserveKeys { get; set; }
        public virtual ICollection<MercuryMessengerStep> MercuryMessengerSteps { get; set; }
        public virtual ICollection<ProductChecking> ProductCheckings { get; set; }
        public virtual ICollection<RegRequestChecking> RegRequestCheckings { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
        public virtual ICollection<SkziLicense> SkziLicenses { get; set; }
        public virtual ICollection<SmevRequestStage> SmevRequestStages { get; set; }
        public virtual ICollection<UserTrust> UserTrusts { get; set; }
        public virtual ICollection<AgentBalanceDetailChangeRequestComment> RequestComments { get; set; }
    }
}
