using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AkCadeMic.Models
{
    public class ReplyO
    {
        [Key]
        public int IdO { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string TextO { get; set; }

        public int ThreadIdO { get; set; }

        [ForeignKey("ThreadIdO")]
        public virtual ThreadO ThreadO { get; set; }

        public ApplicationUser UserO { get; set; }

        public string EmailH { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
