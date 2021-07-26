using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace AkCadeMic.Models
{
    public class ThreadO
    {
        [Key]
        public int PostIdO { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Subject")]
        public string SubjectO { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Body")]
        public string BodyO { get; set; }

        [Display(Name = "Email")]
        public string EmailO { get; set; }

        public ApplicationUser UserO { get; set; }

        public DateTime DateAdded { get; set; }

        public ICollection<ReplyO> RepliesO { get; set; }
    }
}
