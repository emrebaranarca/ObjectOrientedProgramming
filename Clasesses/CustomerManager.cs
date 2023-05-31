using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasesses
{
    internal class CustomerManager
    {
        private string name="ARCA";
        public string Name
        {
            get { return "Mr."+name; }
            set { name = value; }
        }
        public void information()
        {
            Console.WriteLine(Name);
        }

    }
}
