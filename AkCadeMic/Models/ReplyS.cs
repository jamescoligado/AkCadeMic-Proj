using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AkCadeMic.Models
{
    public class ReplyS
    {
        [Key]
        public int IdS { get; set; }

        [Required]
        public string TextS { get; set; }

        public int ThreadIdS { get; set; }

        [ForeignKey("ThreadIdS")]
        public virtual ThreadS ThreadS { get; set; }

        public ApplicationUser UserS { get; set; }
    }
}
