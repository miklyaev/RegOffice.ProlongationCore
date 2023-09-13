using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegRequestComment
    {
        public int CommentId { get; set; }
        public int RegRequestId { get; set; }
        public string CommentText { get; set; }
        public int UserId { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual RegRequest RegRequest { get; set; }
        public virtual User User { get; set; }
    }
}
