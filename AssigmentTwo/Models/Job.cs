using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Job
    {
        [Required, MinLength(2)]
        public string JobTitle { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {0} and smaller than {int.MaxValue}")]
        public int Salary { get; set; }
    }
}