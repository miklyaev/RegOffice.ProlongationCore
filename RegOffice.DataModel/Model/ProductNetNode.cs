using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица сетевых узло продуктов
    /// </summary>
    public partial class ProductNetNode
    {
        public ProductNetNode()
        {
            ProductNetNodeSteps = new HashSet<ProductNetNodeStep>();
        }


        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Сетевой узел
        /// </summary>
        public string NetNodeName { get; set; }

        /// <summary>
        /// Шлюз Астрал Онлайн
        /// </summary>
        public Guid GateGuid { get; set; }
        public int StepId { get; set; }

        public virtual Gate Gate { get; set; }
        public virtual Product Product { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<ProductNetNodeStep> ProductNetNodeSteps { get; set; }
    }
}
