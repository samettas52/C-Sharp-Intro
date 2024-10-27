using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Yapıcı Elaman
            //bir classı new lediğimiz zaman çalışan elamanıdır,
            //class oluştrulduktan sonra bir kez çalışır ve birdaha çalışmaz
            Customer customer1 = new Customer (2,"sad","sad","sad");
            Customer customer2 = new Customer {Id=1,FirstName="asf",LastName="fkm",City="sdf" };
            Console.WriteLine(customer1.FirstName);
            Console.Read();

        }
    }
    class Customer
    {
        //default constructer
        //main kısımında new lenen kısım burasıdır

        //overload yaprak iki türlü methodu çağırabiliriz
        public Customer(int id ,string firstName,string lastName,string city)
        {   //burada neyin neye ait olduğunu göstermemiz gerekir
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            //customer1 bir için bu constructer çalışır
        }
        public Customer()
        {
            //customer2 için bu constructer çalışırz
            Console.WriteLine("Yapıcı Blok Çalıştı");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }    
}
