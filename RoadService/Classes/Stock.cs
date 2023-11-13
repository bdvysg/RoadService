using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadService.Classes
{
    public class Stock
    {
        public int ResourceId { get; set; }
        [ForeignKey(nameof(ResourceId))]
        public Resource Resource { get; set; }

        public int Count { get; set; }
    }
}
