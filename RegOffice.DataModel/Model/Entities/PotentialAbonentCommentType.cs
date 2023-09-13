using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonentCommentType
    {
        public PotentialAbonentCommentType()
        {
            PotentialAbonentComments = new HashSet<PotentialAbonentComment>();
        }

        public int CommentTypeId { get; set; }
        public string CommentName { get; set; }

        public virtual ICollection<PotentialAbonentComment> PotentialAbonentComments { get; set; }
    }
}
