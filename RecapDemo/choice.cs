using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo
{
    internal class e_mail : CustomerChoice
    {
        public void choice(int x)
        {
            CustomerChoice choice = new CustomerChoice();
            switch (x)
            {
                case 1:
                    Console.WriteLine("sms"+choice.name);
                    break;
                case 2:
                    Console.WriteLine("e-mail"+choice.name);
                    break;
            }
        }
    }
}
