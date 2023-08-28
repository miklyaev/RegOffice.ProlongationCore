using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class DssAuthKey
    {
        public DssAuthKey()
        {
            DssAuthKeySteps = new HashSet<DssAuthKeyStep>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор ключа
        /// </summary>
        public string IdKey { get; set; }

        /// <summary>
        /// Срок действия
        /// </summary>
        public DateTime Expired { get; set; }

        /// <summary>
        /// QR-код
        /// </summary>
        public int QrCodeId { get; set; }

        /// <summary>
        /// Пользователь DSS
        /// </summary>
        public int? DssUserId { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Сотрудник
        /// </summary>
        public int? MemberId { get; set; }

        /// <summary>
        /// DSS
        /// </summary>
        public int DssId { get; set; }

        public virtual Dss Dss { get; set; }
        public virtual DssUser DssUser { get; set; }
        public virtual RegRequestMember Member { get; set; }
        public virtual File QrCode { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<DssAuthKeyStep> DssAuthKeySteps { get; set; }
    }
}
