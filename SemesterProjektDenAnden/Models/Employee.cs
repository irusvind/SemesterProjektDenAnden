using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Models
{
    public class Employee
    {

        public int Id { get; set; }

        [Required, StringLength(50), Display(Name = "First Name"), RegularExpression(@"^[a-zA-Z''-'\s]{1,50}$")]
        public string FirstName { get; set; }

        [Required, StringLength(50), Display(Name = "Last Name"), RegularExpression(@"^[a-zA-Z''-'\s]{1,50}$")]
        public string LastName { get; set; }

        [Required, Display(Name = "Phone")]
        public int PhoneNumber { get; set; }

        [Required, StringLength(50), EmailAddress(ErrorMessage = "Invalid email format"), Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        //[Required]
        public string JobTitle { get; set; }
    }
}
