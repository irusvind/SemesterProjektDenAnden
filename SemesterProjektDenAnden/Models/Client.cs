using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone {  get; set; }
        public string Mail { get; set; }
        public string ClAddress { get; set; }
        public bool Subscriber {  get; set; }

    }
}
