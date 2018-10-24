using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.DAL
{
    public class Entity:IEntity
    {
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
