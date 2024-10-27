using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes2
{
    //Methods
    //reusability = bir şeyi tekrar tekrar yazmak yerine bir kaynağı bir çok yerde kullanabilmek.   
     class ProductManager
    {
        //parantez içinde add methoduna product classından veri ekleyeceğimi belirtiyoruz
        public void Add(Product product) 
        {   //artık product klasına erişimimiz var
            //parantez içine product classından product name i yazdır deriz
            Console.WriteLine("Ürün eklendi:"+product.ProductName);
        }


    }
}
