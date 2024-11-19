using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inetface şu şekilde çağırılır
            //IPersonManager customerManager2 = new CustomerManager2();
            //IPersonManager customerManager3 = new CustomerManager3();
            // yani bu şablona göre bana şu class ı çağır dedik
            //customerManager2.Add2();
            //customerManager3.Add2();

            //tek tek implementleri çağırmak yerine hepsini projectManager adı altında çağırabiliriz
            
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add2(new CustomerManager2());
            projectManager.Add2(new CustomerManager3());
            Console.Read();
        }
    }

    class PersonManager
    {
        //implemented operation
        //içi doldurulmuş operasyon
        public void Add()
        {
            Console.WriteLine("Eklendi");
        }

    }

    class CustomerManager : PersonManager
    {

    }

    interface IPersonManager
    {
        //default değeri public tir
        //inheritance ile farkı aynı methodu farklı içerikler ile çağırabiliyor olmamız
        //içndeki methodların hepsi implemente edildiği tğm classlarda tanımlanmalıdır
        void Add2();
    }
    class CustomerManager2 : IPersonManager
    {
        // üste implemente edilmemiş kodu burada doldururuz
        public void Add2()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Hello World!!");
        }
    }

    class CustomerManager3 : IPersonManager
    {
        public void Add2()
        { Console.WriteLine("Ben Samet"); }
    }
    // bunun sayesinde interfacelerin implementlerini tek tek main e çağırmamız gerekmez
    class ProjectManager
    {
        public void Add2(IPersonManager projectManger) 
        {
         projectManger.Add2();
        }
    }
}
