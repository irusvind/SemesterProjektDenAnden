using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class WorkLog
    {
        public int WorkLogId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string WorkDescription { get; set; }
        public int CaseId { get; set; }
        public int ServiceId { get; set; }
    }
}
