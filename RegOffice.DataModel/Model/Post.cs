using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица должностей
    /// </summary>
    public partial class Post
    {
        public Post()
        {
            AbonentPeople = new HashSet<AbonentPerson>();
            RegRequestMembers = new HashSet<RegRequestMember>();
            Users = new HashSet<User>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PostId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string PostName { get; set; }

        /// <summary>
        /// Флаг отображения
        /// </summary>
        public bool Display { get; set; }

        /// <summary>
        /// Наименование в родительном падеже
        /// </summary>
        public string GenitiveName { get; set; }

        public virtual ICollection<AbonentPerson> AbonentPeople { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
