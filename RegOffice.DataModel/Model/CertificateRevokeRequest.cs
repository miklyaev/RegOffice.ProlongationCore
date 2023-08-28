using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class CertificateRevokeRequest
    {
        public CertificateRevokeRequest()
        {
            CertificateRevokeHistories = new HashSet<CertificateRevokeHistory>();
        }


        /// <summary>
        /// Ид заявки на отзыв сертификата
        /// </summary>
        public int CertificateRevokeRequestId { get; set; }

        /// <summary>
        /// Отозванный сертификат
        /// </summary>
        public int CertificateId { get; set; }

        /// <summary>
        /// Статус заявки
        /// </summary>
        public int? StepId { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Дата создания заявки
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Прикрепленный файл
        /// </summary>
        public int FileId { get; set; }

        /// <summary>
        /// Время блокировки
        /// </summary>
        public DateTime? BlockedTime { get; set; }

        /// <summary>
        /// Статус до блокировки
        /// </summary>
        public int? StepBeforeBlock { get; set; }

        /// <summary>
        /// Заявка от партнера 1С-ЭТП
        /// </summary>
        public bool Is1cEtpPartner { get; set; }

        /// <summary>
        /// Сотрудник УЦ подтвердивший/отклонивший заявку
        /// </summary>
        public int? Executor { get; set; }

        /// <summary>
        /// Видимость заявки сотруднику УЦ
        /// </summary>
        public bool? IsShowEmploeeUc { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<CertificateRevokeHistory> CertificateRevokeHistories { get; set; }
    }
}
