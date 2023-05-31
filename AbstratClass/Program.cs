using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace AbstratClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sql sql = new Sql();
            Oracle oracle = new Oracle();
            sql.Add();
            sql.Delete();
            oracle.Add();
            oracle.Delete();

            SqlCustomerDal sqlCustomerDal = new SqlCustomerDal();
            sqlCustomerDal.Add();


            Console.ReadLine();
        }
    }
}
