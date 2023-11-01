using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadService.Classes
{
    public class ResourceTimeTable
    {
        private readonly List<ResourceTimeTableItem> _items;

        public ResourceTimeTable()
        {
            // обращение к бд
        }

        public List<Resource> GetResources(DateTime timeStart, DateTime timeEnd)
        {
            List<Resource> resources = _items.Where(u=> u.TimeStart >= timeStart && u.TimeEnd < timeEnd)
                                             .Select(u => u.Resource).ToList();
            return resources;
        }

        public void ReserveResource(Resource resource, DateTime timeStart, DateTime timeEnd)
        {
            // добавление ResourceTimeTableItem в бд
        }
        public void UnReserveResource(Resource resource, DateTime timeStart, DateTime timeEnd)
        {
            // удаление ResourceTimeTableItem в бд
        }
    }
}
