using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица сотрудников
    /// </summary>
    public partial class AbonentPerson
    {
        public AbonentPerson()
        {
            ProductPeople = new HashSet<ProductPerson>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AbonentPersonId { get; set; }

        /// <summary>
        /// Абонент
        /// </summary>
        public int AbonentId { get; set; }

        /// <summary>
        /// Личность
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public int? PostId { get; set; }

        /// <summary>
        /// Подразделение
        /// </summary>
        public int? OrgUnitId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime UpdateTime { get; set; }
        public string PostName { get; set; }

        /// <summary>
        /// Документ
        /// </summary>
        public string Document { get; set; }

        /// <summary>
        /// Номер документа
        /// </summary>
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Дата документа
        /// </summary>
        public DateOnly? DocumentDate { get; set; }

        /// <summary>
        /// Мобильный телефон
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Электронный адрес
        /// </summary>
        public string Email { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual OrgUnit OrgUnit { get; set; }
        public virtual Person Person { get; set; }
        public virtual Post Post { get; set; }
        public virtual ICollection<ProductPerson> ProductPeople { get; set; }
    }
}
