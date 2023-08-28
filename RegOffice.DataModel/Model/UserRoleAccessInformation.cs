using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
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
