using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasesses
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CustomerManager customerManager = new CustomerManager();
           customerManager.information();

           Students students = new Students();
            students[1] = 5;
            Console.Write(students[1]);
            students[2] = 6;
            Console.Write(students[2]);



            Console.ReadLine();

        }
    }
    class Students
    {
        private int[] series=new int[3];
        public int this [int id]
        { 
                get { return series[id]; }
                set { }
        
        }
    }
}
