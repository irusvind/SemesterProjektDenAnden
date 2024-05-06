using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TransportLog
    {
        public int TransportLogId { get; set; }

        [Required]
        public int KmDriven { get; set; }

        [StringLength(200), AllowNull]
        public string LogDescription { get; set; }

        [Required]
        public int CaseId { get; set; }

        [Required]
        public int ServiceId { get; set; }
    }
}
