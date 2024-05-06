using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Case
    {


        public int CaseId { get; set; }

        [Required, StringLength(50)]
        public string CaseTitle { get; set; }

        [Required, DataType(DataType.Date)]
        public DateOnly StartDate { get; set; }

        [Required, DataType(DataType.Date)]
        public DateOnly ExEndDate { get; set; }

        [Required, DataType(DataType.Time)]
        public int ExHours { get; set; }

        [Required]
        public bool IsClosed { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public int ClientId { get; set; }
    }
}
