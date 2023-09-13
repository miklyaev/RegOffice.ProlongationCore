using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Abonent1cView
    {
        public string Id { get; set; }
        public string Guid { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Mobile { get; set; }
        public string Pfr { get; set; }
        public int? Protocol { get; set; }
        public string Host { get; set; }
        public DateTime? EndTime { get; set; }
        public byte[] Certificate { get; set; }
        public bool? SmsNotice { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ShortName { get; set; }
        public int? CategoryId { get; set; }
    }
}
