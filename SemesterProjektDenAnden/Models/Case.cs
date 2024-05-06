using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Case
    {
       public int CaseId {  get; set; }
       public string CaseTitle {  get; set; }
       public DateOnly StartDate {  get; set; }
       public DateOnly ExEndDate { get; set; }
       public int ExHours { get; set; }
       public bool IsClosed { get; set; }
       public int ServiceId {  get; set; }
       public int EmployeeId { get; set; }
       public int ClientId { get; set; }
    }
}
