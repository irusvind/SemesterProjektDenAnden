using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Service
    {
        public int ServiceId { get; set; }

        [Required, StringLength(50)]
        public string ServiceName { get; set; }

        [Required, DataType(DataType.Currency)]
        public float Price {  get; set; }

        [Required]
        public bool PriceHourly { get; set; }
    }
}
