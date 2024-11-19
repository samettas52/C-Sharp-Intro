using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1; // burada değer atama işleminde set komutundan yararlanırız
            Console.WriteLine(product.Id);// burada ise id yi okuma işleminde get özelliğini kullanıyoruz
            product.UnitPrice = 500;
            //biz 500 değerini değilde 500+kdv olarak bize değer döndürsün istiyoruz
            Console.WriteLine(product.UnitPrice);
            Console.Read();
        }
    }

    class Product
    {
        // get ve set özelliği ne işe yarar ?
        public int Id { get; set; }
        public string ProductName { get; set; }
        //normal şartlarda get set e dokunulmaz ama örnek için
        //field
        decimal _unitPrice;//bir değiken atanır
        public decimal UnitPrice
        {
            get { return _unitPrice + _unitPrice * 20 / 100; } // atanan değeri bu şekilde döndür dedik
            set { _unitPrice = value; }//main kısmında verilen değeri değişkene ata dedik
        }
        // %99 olarak bunlarda get ve set lerin içinde birşey bulunmaz ama işimize yarayabilir
        //propfull yazıp shift tuşuna basarak ta bu kodu oluşturabiliriz.
        /*
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        */
    }
}
