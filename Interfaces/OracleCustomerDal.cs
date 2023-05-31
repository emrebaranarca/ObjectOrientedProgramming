﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class OracleCustomerDal:IPersonManagerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }
        public void Remove()
        {
            Console.WriteLine("Oracle Removed");
        }
        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }
}
