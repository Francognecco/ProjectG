using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Entities
{
    public class Paquete
    {
        public int PaqueteId { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual List<PaqueteItem> PaqueteItems { get; set; }
    }
}
