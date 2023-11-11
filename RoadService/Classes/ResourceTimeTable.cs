using RoadService.Repository;
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
        private UnitOfWork _unitOfWork;

        public ResourceTimeTable(UnitOfWork unitOfWork)
        {
            _items = unitOfWork.ResourceTimeTableItem.GetAll().ToList();
            _unitOfWork = unitOfWork;
        }

        public List<Resource> GetResources(DateTime timeStart, DateTime timeEnd)
        {
            List<Resource> resources = _items.Where(u=> u.TimeStart >= timeStart && u.TimeEnd < timeEnd)
                                             .Select(u => u.Resource).ToList();
            return resources;
        }

        public void ReserveResource(Resource resource, DateTime timeStart, DateTime timeEnd)
        {
            var res = new ResourceTimeTableItem();
            res.Resource = resource;
            res.TimeStart = timeStart;
            res.TimeEnd = timeEnd;
            _unitOfWork.ResourceTimeTableItem.Add(res);
            _unitOfWork.Save();
            
        }
        public void UnReserveResource(Resource resource, DateTime timeStart, DateTime timeEnd)
        {
            var res = new ResourceTimeTableItem();
            res.Resource = resource;
            res.TimeStart = timeStart;
            res.TimeEnd = timeEnd;
            _unitOfWork.ResourceTimeTableItem.Remove(res);
            _unitOfWork.Save();
        }
    }
}
