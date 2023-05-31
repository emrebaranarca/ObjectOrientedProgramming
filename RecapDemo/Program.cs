using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //müşteri ismini al tercihini sor daha sonra ekrana ismini ve tercihlerini yaz.
            CustomerChoice customerChoice = new CustomerChoice();
            customerChoice.information();
            e_mail mail=new e_mail();
            mail.choice(customerChoice.choice);




            Console.ReadLine();
        }
    }
}
