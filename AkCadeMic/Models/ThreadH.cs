using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace AkCadeMic.Models
{
    public class ThreadH
    {
        [Key]
        public int PostIdH { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Subject")]
        public string SubjectH { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Body")]
        public string BodyH { get; set; }

        [Display(Name = "Email")]
        public string EmailH { get; set; }
        public ApplicationUser UserH { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
