using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Socrbase
    {
        public int? Level { get; set; }
        public string Scname { get; set; }
        public string Socrname { get; set; }
        public int? KodTSt { get; set; }
    }
}
