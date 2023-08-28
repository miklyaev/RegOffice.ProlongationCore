using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица объектов
    /// </summary>
    public partial class Object
    {
        public Object()
        {
            Transitions = new HashSet<Transition>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ObjectId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string ObjectName { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int ObjectTypeId { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        public string ObjectValue { get; set; }

        /// <summary>
        /// Тип значения
        /// </summary>
        public int ValueTypeId { get; set; }

        public virtual ObjectType ObjectType { get; set; }
        public virtual ValueType ValueType { get; set; }
        public virtual ICollection<Transition> Transitions { get; set; }
    }
}
