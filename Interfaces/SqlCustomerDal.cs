using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class SqlCustomerDal : IPersonManagerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }
        public void Remove()
        {
            Console.WriteLine("Sql Removed");
        }
        public void Update()
        {
            Console.WriteLine("Sql Uptated");
        }
    }
}
