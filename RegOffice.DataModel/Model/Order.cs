using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class Order
    {

        /// <summary>
        /// Ид
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Счёт
        /// </summary>
        public int BillId { get; set; }

        /// <summary>
        /// Адрес доставки
        /// </summary>
        public int? AddrId { get; set; }

        /// <summary>
        /// ФИО
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Вознаграждение
        /// </summary>
        public decimal SumReward { get; set; }

        /// <summary>
        /// Дата отгрузки
        /// </summary>
        public DateTime? DispatchTime { get; set; }

        /// <summary>
        /// Отгрузивший заказ
        /// </summary>
        public int? DispatchUser { get; set; }
        public string Email { get; set; }

        public virtual Addr Addr { get; set; }
        public virtual SendedBill Bill { get; set; }
        public virtual User DispatchUserNavigation { get; set; }
        public virtual Step Step { get; set; }
    }
}
