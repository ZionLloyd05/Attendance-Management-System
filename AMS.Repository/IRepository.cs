using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMS.DAL;

namespace AMS.Repository
{
    public interface IRepository
    {
        int Create(IEntity entity);
        int Update(IEntity entity);
        int Delete(IEntity entity);
        IEntity GetOne(IEntity entity);
        IEnumerable<IEntity> GetAll(IEntity entity);
    }
}
