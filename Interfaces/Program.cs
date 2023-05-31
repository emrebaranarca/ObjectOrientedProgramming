using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    

    internal class Program 
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer 
            //{
            //    name="ENES",
            //    id=5
            //};
            //Student student = new Student
            //{
            //    name="SELMAN",
            //    id=3
            //};

            //Add(student);
            //Add(customer);

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
            customerManager.Remove(new SqlCustomerDal());



            IPersonManagerDal[] personManagerDal=new IPersonManagerDal[2] 
            {
                new OracleCustomerDal(),
                new SqlCustomerDal()
            };

            foreach(var person in personManagerDal)
            {
                person.Add();
            }

            
            

           Console.ReadLine();
        }
        static void Add(Interface1 interface1)
        {
            Console.WriteLine(interface1.name + "--> " + interface1.id);
        }

    }

}
