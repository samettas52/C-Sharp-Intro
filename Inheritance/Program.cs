using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{   //Kalıtım
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            customerManager.GetBestCustomer();
            //person manager sınıfının add ve update methodlarını çağırabiliriz ve ek olarak customer sınıfının
            //kendine ait olan methodları da kullanabiliriz
            PersonManager personManager = new PersonManager();
            personManager.Add();
            //inheritance olan sınıfta kendi methodlarını kullanabilir


        }
    }
    class PersonManager 
    //bu classta tanımlı olan methodları başka bir classta da kullanmak istiyoruz
    //inheritance burada devreye girer
    { 
     public void Add()
        { Console.WriteLine("Eklendi"); }
     public void Update() 
        { Console.WriteLine("Güncellendi"); }
    }
    class CustomerManager:PersonManager
    //buradaki iki nokta işareti bizim person manager a  ait methodları kullanmamıza olanak sağlar
    {
        public void GetBestCustomer()
        { }
    }
    class EmployeeManager:PersonManager
    {
        public void GetBestEmployee()
        { }
    }

    //başka bir örnek olarak
    class Person
    {
        public int Id { get; set; } //database id
        public int NationalIdentıty { get; set; } //Tc No
        public string Name { get; set; }
        public string LastName { get; set; }
    }

    class Employee:Person
    {
        public string EmployeeNumber { get; set; }
    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; } 
    }
    
}
