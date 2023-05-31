using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class IBAN
    {
        public void write()
        {
            Console.WriteLine("Your IBAN :45454545454");
        }
        public virtual void register()
        {
            Console.WriteLine("IBAN registered");
        }
    }
}
