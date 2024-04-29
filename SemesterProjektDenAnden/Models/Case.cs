using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Case
    {
       public int caseId {  get; set; }
       public string caseTitle {  get; set; }
       public DateTime startDate {  get; set; }
       public DateTime exEndDate { get; set; }
       public int exHours { get; set; }
       public int hoursUsed { get; set; }
       public int transExpense {  get; set; }
       public int serviceId {  get; set; }
       public int employeeId { get; set; }
       public int clientId { get; set; }
    }
}
