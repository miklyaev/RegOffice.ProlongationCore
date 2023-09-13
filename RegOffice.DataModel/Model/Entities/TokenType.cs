using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TokenType
    {
        public TokenType()
        {
            Tokens = new HashSet<Token>();
        }

        public int TokenTypeId { get; set; }
        public string TokenTypeName { get; set; }
        public int LifeTime { get; set; }

        public virtual ICollection<Token> Tokens { get; set; }
    }
}
