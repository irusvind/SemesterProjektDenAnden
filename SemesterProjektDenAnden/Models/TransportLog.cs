using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TransportLog
    {
        public int TransportLogId { get; set; }
        public int KmDriven { get; set; }
        public string LogDescription { get; set; }
        public int CaseId { get; set; }
        public int ServiceId { get; set; }
    }
}
