using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public float Price {  get; set; }
        public bool PriceHourly { get; set; }
    }
}
