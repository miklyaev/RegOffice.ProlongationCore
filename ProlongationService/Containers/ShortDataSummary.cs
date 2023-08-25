using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlongationService.Containers
{
    public class ShortDataSummary
    {
        public int OfficeId { get; set; }
        public int ExpiredInThisMonth { get; set; }
        public int ExpiredInNextMonth { get; set; }
        public int Expired { get; set; }
        public int ProlongateImmediate { get; set; }
        public int RiskGroup { get; set; }
        public int DisabledDispatchCount { get; set; }
    }
}
