using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Kladr
    {
        public string Name { get; set; }
        public string Socr { get; set; }
        public string Code { get; set; }
        public string Index { get; set; }
        public string Gninmb { get; set; }
        public string Uno { get; set; }
        public string Ocatd { get; set; }
        public int? Status { get; set; }
    }
}
