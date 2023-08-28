using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class CertificateRevokeHistory
    {

        /// <summary>
        /// Заявление на отзыв сертификата
        /// </summary>
        public int CertificateRevokeId { get; set; }

        /// <summary>
        /// Имя файла
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Статус заявки
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Пользователь, изменивший заявление
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Дата изменения
        /// </summary>
        public DateTime ChangeTime { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CertificateRevokeHistoryId { get; set; }

        public virtual CertificateRevokeRequest CertificateRevoke { get; set; }
        public virtual User User { get; set; }
    }
}
