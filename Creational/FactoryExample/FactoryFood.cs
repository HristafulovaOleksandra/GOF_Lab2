﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lab2.Creational.FactoryExample
{
    public class FactoryFood
    {
        public IFood getFood(string type)
        {
            if ("burger".Equals(type))
                return new FactorySalty();
            else return new FactorySweet();
        }
    }
}
