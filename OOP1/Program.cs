﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoriId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            //diğer yazım şekli:

            Product product2 = new Product { Id = 2, CategoriId = 5,UnitInStock=5,ProductName="Kalem" ,UnitPrice=35};


            //PascalCase   //camelCase     
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            

            



           
        }
    }
}
