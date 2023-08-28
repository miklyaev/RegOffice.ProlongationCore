using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов объектов
    /// </summary>
    public partial class ObjectType
    {
        public ObjectType()
        {
            Objects = new HashSet<Object>();
            Transitions = new HashSet<Transition>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int ObjectTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string ObjectTypeName { get; set; }

        public virtual ICollection<Object> Objects { get; set; }
        public virtual ICollection<Transition> Transitions { get; set; }
    }
}
