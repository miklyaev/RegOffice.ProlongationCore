using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class LoginFailAttempts
    {
        public int FailAttemptId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime AttemptDate { get; set; }
    }
}
