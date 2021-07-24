using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace AkCadeMic.Models
{
    public class Thread
    {
        [Key]
        public int PostId { get; set; }

        [Required(ErrorMessage ="Required.")]
        [Display(Name ="Subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Body")]
        public string Body { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        public ApplicationUser User { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
