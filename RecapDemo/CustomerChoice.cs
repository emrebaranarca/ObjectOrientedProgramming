using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo
{
    internal class CustomerChoice
    {
        public string name { get; set; }
        public int choice { get; set; }
        public void information()
        {
            Console.WriteLine("Enter your name :");
            name=Console.ReadLine();
            Console.WriteLine("sms(1) email(2) ");
            choice=Convert.ToInt16(Console.ReadLine());


        }
    }
}
