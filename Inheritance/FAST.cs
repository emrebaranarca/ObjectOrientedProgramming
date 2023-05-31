using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class FAST:IBAN
    {
        public void transaction()
        {
            Console.WriteLine("Your transaction is succesfull");
        }

        public override void register()
        {
            Console.WriteLine("That was registered in your fast transaction");

            //base.register();
        }
    }
}
