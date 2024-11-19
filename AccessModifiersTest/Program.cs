using AccessModifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//public bir class başka bir namespacete ise buradan onu dahil ederiz


namespace AccessModifiersTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Home home = new Home();
            home.Id = 1;
            //artık Home classına erişimimiz var
            //Home yazıp çıkan ampulden referans olarak ekle seçeneğini seçmeliyiz

        }
    }
}
