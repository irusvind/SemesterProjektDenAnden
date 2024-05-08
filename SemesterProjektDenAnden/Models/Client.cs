using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Client
    {
        public int ClientId { get; set; }

        [Required, StringLength(50), Display(Name = "First Name"), RegularExpression(@"^[a-zA-Z''-'\s]{1,50}$")]
        public string FirstName { get; set; }

        [Required, StringLength(50), RegularExpression(@"^[a-zA-Z''-'\s]{1,50}$")]
        public string LastName { get; set; }

        [Required, Display(Name = "Phone")]
        public int Phone {  get; set; }

        [Required,StringLength(50), EmailAddress(ErrorMessage = "Invalid email format"),Display(Name = "Email")]
        public string Mail { get; set; }

        [MaxLength(50), RegularExpression(@"^[a-zA-Z''-'\s]{1,50}$")]
        public string ClAddress { get; set; }

        [Required]
        public bool Subscriber {  get; set; }

    }
}
