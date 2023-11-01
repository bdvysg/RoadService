using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadService.Repository.IRepository
{
    public interface IUnitOfWork
    {
        void Save();
    }
}
