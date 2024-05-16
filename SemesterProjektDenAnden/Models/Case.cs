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
        public DateTime StartDate { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime ExEndDate { get; set; }


        [Required, DataType(DataType.Time)]
        public int EstHours { get; set; }

        [Required]
        public int UsedHours { get; set; }

        [Required]
        public bool Done { get; set; }


        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public int ClientId { get; set; }
    }
}
