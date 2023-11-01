using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadService.Classes
{
    public class ResourceTimeTableItem
    {
        public int ResourceId { get; set; }
        [ForeignKey(nameof(ResourceId))]
        public Resource Resource { get; set; }

        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }

        public ResourceTimeTableItem(Resource resource, DateTime timeStart, DateTime timeEnd) 
        {
            ResourceId = resource.Id;
            Resource = resource;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
        }
    }
}
