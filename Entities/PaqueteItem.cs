using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class PaqueteItem
    {
        public int PaqueteItemId { get; set; }

        public int PaqueteId { get; set; }

        public virtual Paquete Paquete { get; set; }

        public int ItemId { get; set; }

        public virtual Item Item { get; set; }
    }
}
