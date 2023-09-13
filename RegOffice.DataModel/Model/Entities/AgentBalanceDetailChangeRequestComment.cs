using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentBalanceDetailChangeRequestComment
    {
        public AgentBalanceDetailChangeRequestComment()
        {
            AgentBalanceDetailChangeRequestFiles = new HashSet<AgentBalanceDetailChangeRequestFile>();
        }

        public int RequestCommentId { get; set; }
        public int BalanceDetailChangeRequestId { get; set; }
        public string CommentText { get; set; }
        public DateTime CreationTime { get; set; }
        public int UserId { get; set; }

        public virtual AgentBalanceDetailChangeRequest BalanceDetailChangeRequest { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<AgentBalanceDetailChangeRequestFile> AgentBalanceDetailChangeRequestFiles { get; set; }
    }
}
