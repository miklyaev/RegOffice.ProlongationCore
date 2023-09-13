using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ServerMemberView
    {
        public string Id { get; set; }
        public Guid? Guid { get; set; }
        public string Mobile { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string Post { get; set; }
        public string Snils { get; set; }
        public byte[] Certificate { get; set; }
        public string Skid { get; set; }
        public int? Type { get; set; }
    }
}
