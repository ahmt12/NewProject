﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        
        public void Add(Product product) 
        {
            int x = 600 - product.UnıtPrice;
            Console.WriteLine(product.ProductName +" eklendi.");   

        }
        public void Update(Product product) 
        {

            Console.WriteLine(product.ProductName+" güncellendi.");


        }
    }
}
