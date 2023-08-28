using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов сообщений
    /// </summary>
    public partial class PotentialAbonentCommentType
    {
        public PotentialAbonentCommentType()
        {
            PotentialAbonentComments = new HashSet<PotentialAbonentComment>();
        }


        /// <summary>
        /// Идентификатор типа сообщения
        /// </summary>
        public int CommentTypeId { get; set; }

        /// <summary>
        /// Наименование типа сообщения
        /// </summary>
        public string CommentName { get; set; }

        public virtual ICollection<PotentialAbonentComment> PotentialAbonentComments { get; set; }
    }
}
