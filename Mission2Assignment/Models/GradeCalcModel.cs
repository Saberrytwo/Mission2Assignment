using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission2Assignment.Models
{
    public class GradeCalcModel
    {
        [Required]
        [Range(0, 100, ErrorMessage = "Please enter a value between 0 & 100 for your Assignment Grade")]
        public double assignment { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Please enter a value between 0 & 100 for your Group Project Grade")]
        public double group { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Please enter a value between 0 & 100 for your Quiz Grade")]
        public double quiz { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Please enter a value between 0 & 100 for your Exam Grade")]
        public double exam { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Please enter a value between 0 & 100 for your Intex Grade")]
        public double intex { get; set; }

    }
}
