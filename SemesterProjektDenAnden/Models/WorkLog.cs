using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class WorkLog
    {
        public int WorkLogId { get; set; }

        [Required, DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [Required, DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        [Required, StringLength(200), AllowNull]
        public string WorkDescription { get; set; }

        [Required]
        public int CaseId { get; set; }

        [Required]
        public int ServiceId { get; set; }
    }
}
