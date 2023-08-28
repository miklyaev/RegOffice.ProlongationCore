using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица со списком потдтверждённых пользователями акций
    /// </summary>
    public partial class UserPromotionConfirmed
    {

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Идентификатор рекламной акции
        /// </summary>
        public int PromotionTypeId { get; set; }

        /// <summary>
        /// Дата подтверждения
        /// </summary>
        public DateTime ConfirmDate { get; set; }

        public virtual PromotionType PromotionType { get; set; }
        public virtual User User { get; set; }
    }
}
