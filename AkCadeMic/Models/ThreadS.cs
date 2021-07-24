using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace AkCadeMic.Models
{
    public class ThreadS
    {
        [Key]
        public int PostIdS { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Subject")]
        public string SubjectS { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Body")]
        public string BodyS { get; set; }

        [Display(Name = "Email")]
        public string EmailS { get; set; }
        public ApplicationUser UserS { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
