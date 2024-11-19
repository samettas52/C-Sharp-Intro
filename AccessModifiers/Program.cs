using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{   //erişim belirleyiciler
    internal class Program
    {
        static void Main(string[] args)
        {
            Home home = new Home();
            //eğer name ya da id public olmasaydı buradan erişmemiz mümkün olmazdı
            home.Name = "Test";
            home.Id = 1;
        }
    }

    class Customer
    {

    }
}
