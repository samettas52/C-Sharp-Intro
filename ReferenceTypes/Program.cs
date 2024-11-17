using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,enum,boolean ---> value types
            //Örnek 1:
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("sayı1 :" + sayi1);
            //bunların bellekteki çalışma şekli
            /*        Stack ---> bulundukları alan
             * sayi1=10   sayi2=20
             * sayi1=20   sayi2=100
             bu mantıkta sayi1 çağırıldığında 20 değerini bize verir
             */


            //array,class,interface,... ---> reference types
            //Örnek 2:
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 100;
            Console.WriteLine("sayilar1[0] :" + sayilar1[0]);
            //bunların bellekteki çalışma şekli
            /*
             *     Stack          Heap ---> bulundukları alan
             * sayilar1 - 101    {1,2,3} - 101 ---> sayilar1 i new lediğimiz zaman oluşan adres ve new de verdiğimiz değerler
             * sayilar2 - 102    {10,20,30} - 102
             * sayilar1 - 102     artık 101 adresini tutan array olamadığı için 101 artık silinir
             sayilar1 = sayilar2 yaptığımızda aslında ona değer değil adresi atamış oluyoruz
             bu sebeple sonradan sayilar2 de yapılacak bir değişiklik artık sayilar1 de de değişir 
             */
            //örnek 3 :
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Samet";
            person1 = person2;
            person2.FirstName = "Eren";
            Console.WriteLine("person1 FirstName : "+ person1.FirstName);
            //sonuç olarak bize Eren ismini verir

            //örnek 4:
            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "12312451";
            Person person3 = customer;
            customer.FirstName = "Ahmet";
            Console.WriteLine("customer FistName: " + person3.FirstName);
            //person3=customer ataması yapmamıza rağmen customer ın creditcard methoduna person3 ten ulaşamıyoruz
            //çünkü ana şablon olarak person ı kullanıyoruz bunun için ;
            Console.WriteLine("customer CreditCartNumber: "+((Customer)person3).CreditCardNumber);

            //örnek 5:
            //aynı kodu farklı nesneler için çağırmamıza yarar
            PersonManager personmanager = new PersonManager();
            personmanager.Add(customer);
            personmanager.Add(person1);
            personmanager.Add(person3);

            Console.Read();
        }
    }
    //Örnek 3,4,5 in class ı:
    class Person
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    { public string CreditCardNumber { get; set; } }

    class PersonManager
    { //burada person classını içermesini söylüyoruz
    public void Add(Person person)
        { Console.WriteLine(person.FirstName); }
    }
    
}
