using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class UserRoleAccessInformation
    {
        public int? UserId { get; set; }
        public int? ModuleId { get; set; }
        public string ModuleName { get; set; }
        public int? LevelPriority { get; set; }
        public int? AccessLevelId { get; set; }
        public string AccessLevelName { get; set; }
    }
}
