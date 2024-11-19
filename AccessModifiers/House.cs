using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    // internal default değerdir ve sadece aynı namespacelerde çalışır

    internal class House
    {
        //bu class a mainden ya da customer classından ulaşabilirim ama
        //sadece accessmodifiers içinde erişimim olabilir
    }
    public class Home
    {
        //burada ise default olarak private değeri kullanılır ve dışarıdan erişimi engeller

        int LastName { get; set; }
        //buradaki publicler de bize class dışında erişim özelliği sağlar
        //public olmazsa dışarıdan erişim sağlayamayız aynı namespace olsa bile
        public int Id { get; set; }
        //intenal yaparsak burada sadece aynı namespacete kullanma izni verir
        //ve testte erişimimiz engellenir
        internal string Name { get; set; }

        //peki public olursa ne olur ve nasıl ulaşırım
        //cevabı testte

        //protected classının privatedan tek farkı kalıtımda buna erişimimizin olması
        protected int Age { get; set; }
    }
    public class Home2 : Home
    {
        public Home2()
        {
            Age = 22;
            //LastName e ulaşamazsın
        }
    }
}
