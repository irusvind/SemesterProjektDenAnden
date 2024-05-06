using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Models
{
    public class Employee
    {

        public int Id { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

        [Required, DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

        [Required, StringLength(50), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(50), AllowNull]
        public string Address { get; set; }

        [Required, StringLength(25)]
        public string JobTitle { get; set; }
    }
}
