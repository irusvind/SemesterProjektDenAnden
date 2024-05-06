using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Client
    {
        public int ClientId { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

        [Required, DataType(DataType.PhoneNumber)]
        public int Phone {  get; set; }

        [Required,StringLength(50), DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [MaxLength(50)]
        public string ClAddress { get; set; }

        [Required]
        public bool Subscriber {  get; set; }

    }
}
