using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AkCadeMic.Models
{
    public class ThreadJ
    {
        [Key]
        public int PostIdJ { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Subject")]
        public string SubjectJ { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Body")]
        public string BodyJ { get; set; }

        [Display(Name = "Email")]
        public string EmailJ { get; set; }
    }
}
