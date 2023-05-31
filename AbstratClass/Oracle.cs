using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratClass
{
    internal class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted in Oracle");
        }
    }
}
