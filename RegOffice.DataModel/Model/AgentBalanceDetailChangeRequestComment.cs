using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Комментарии по заявке на изменение позиции в сверке
    /// </summary>
    public partial class AgentBalanceDetailChangeRequestComment
    {
        public AgentBalanceDetailChangeRequestComment()
        {
            Files = new HashSet<File>();
        }


        /// <summary>
        /// Идентификатор комментария
        /// </summary>
        public int RequestCommentId { get; set; }

        /// <summary>
        /// Заявка на изменение позиции в сверке
        /// </summary>
        public int BalanceDetailChangeRequestId { get; set; }

        /// <summary>
        /// Текст комментария
        /// </summary>
        public string CommentText { get; set; }

        /// <summary>
        /// Время добавления комментария
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Пользователь, добавивший комментарий
        /// </summary>
        public int UserId { get; set; }

        public virtual AgentBalanceDetailChangeRequest BalanceDetailChangeRequest { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<File> Files { get; set; }
    }
}
