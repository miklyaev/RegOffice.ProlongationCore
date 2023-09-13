using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonentComment
    {
        public int CommentId { get; set; }
        public int PotentialAbonentId { get; set; }
        public string CommentText { get; set; }
        public int UserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int CommentTypeId { get; set; }

        public virtual PotentialAbonentCommentType CommentType { get; set; }
        public virtual User User { get; set; }
    }
}
