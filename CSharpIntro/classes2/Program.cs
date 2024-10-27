using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes2
{
    internal class Program
    {
        //instance = örnek
        static void Main(string[] args)
        {   Console.ForegroundColor = ConsoleColor.Green;
            //ürün classını çağıralım 
            //bu şekilde de değer ataması yapabiliriz
            Product products = new Product() { ProductName = "Laptop", UnitPrice = 5000, UnitsInStock = 5 };
            //class ı çağırdık
            ProductManager productManager = new ProductManager();
            //methodunu çalıştırdık
            productManager.Add(products);

            
            
            




            Console.Read();
        }
    }
}
