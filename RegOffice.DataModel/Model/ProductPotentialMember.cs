using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица потенциальных пользователей в продукте
    /// </summary>
    public partial class ProductPotentialMember
    {
        public ProductPotentialMember()
        {
            ProductPotentialMemberProtocols = new HashSet<ProductPotentialMemberProtocol>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ProductPotentialMemberId { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Эл. адрес
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// СНИЛС
        /// </summary>
        public string Snils { get; set; }

        /// <summary>
        /// Признак администратора
        /// </summary>
        public bool? IsAdministrator { get; set; }

        /// <summary>
        /// Время отправки уведомления
        /// </summary>
        public DateTime? NotificationTime { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<ProductPotentialMemberProtocol> ProductPotentialMemberProtocols { get; set; }
    }
}
