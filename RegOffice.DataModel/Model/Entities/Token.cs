using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Token
    {
        public Token()
        {
            TokenGates = new HashSet<TokenGate>();
        }

        public int? ApplicationId { get; set; }
        public int TokenTypeId { get; set; }
        public string Value { get; set; }
        public DateTime InitialTime { get; set; }
        public int? UserId { get; set; }
        public Guid TokenId { get; set; }
        public int LifeTime { get; set; }
        public int? ProductId { get; set; }

        public virtual Application Application { get; set; }
        public virtual Product Product { get; set; }
        public virtual TokenType TokenType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<TokenGate> TokenGates { get; set; }
    }
}
