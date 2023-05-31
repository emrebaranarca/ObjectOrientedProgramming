using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class CustomerManager
    {
       public void Add(IPersonManagerDal personManagerDal)
        {
            personManagerDal.Add();
        }
        public void Remove(IPersonManagerDal personManagerDal)
        {
            personManagerDal.Remove();
        }
        public void Update(IPersonManagerDal personManagerDal)
        {
            personManagerDal.Update();
        }
    }
}
