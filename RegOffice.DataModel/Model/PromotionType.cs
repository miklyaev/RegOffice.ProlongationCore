using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица с типами рекламных акций
    /// </summary>
    public partial class PromotionType
    {
        public PromotionType()
        {
            UserPromotionConfirmeds = new HashSet<UserPromotionConfirmed>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PromotionTypeId { get; set; }

        /// <summary>
        /// Имя акции
        /// </summary>
        public string PromotionTypeName { get; set; }

        public virtual ICollection<UserPromotionConfirmed> UserPromotionConfirmeds { get; set; }
    }
}
