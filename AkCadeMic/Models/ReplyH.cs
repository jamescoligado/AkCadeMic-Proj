using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AkCadeMic.Models
{
    public class ReplyH
    {
        [Key]
        public int IdH { get; set; }

        [Required]
        public string TextH { get; set; }

        public int ThreadIdH { get; set; }

        [ForeignKey("ThreadIdH")]
        public virtual ThreadH ThreadH { get; set; }

        public ApplicationUser UserH { get; set; }
    }
}
