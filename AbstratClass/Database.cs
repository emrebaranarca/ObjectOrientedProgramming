using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratClass
{
    public abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public abstract void Delete();  //içeriği değişken olan soyut metod
    }
}
