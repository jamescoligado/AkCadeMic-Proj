using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AkCadeMic.Models
{
    public class Reply
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string Text { get; set; }

        public int ThreadId { get; set; }

        [ForeignKey("ThreadId")]
        public virtual Thread Thread { get; set; }

        public ApplicationUser User { get; set; }

        public string Email { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
