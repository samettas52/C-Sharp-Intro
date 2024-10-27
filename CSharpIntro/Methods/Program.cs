using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // methodu çağırdık ve sonra altta bize ne yapacağını söyledik
            Matematik matematik = new Matematik();
            int sonuc1 = matematik.Topla(2, 3,5);
            int sonuc2 = matematik.Cikar(2);
            int sonuc3 = matematik.Topla();
            // değer verme sırasını değiştirebiliriz
            int sonuc4 = matematik.Topla(sayi2:32,sayi1:21);
            int sonuc5 = matematik.Topla(sayi2:89);
            Console.WriteLine(sonuc1 +" "+ sonuc2 +" "+ sonuc3 +" "+ sonuc4 +" "+ sonuc5);
            //istediğimiz kadar veri girişi sağlayabiliriz
            int sonuc6 = matematik.ToplaParams(new int[] { 2, 3, 7, 4, 1, 7 });
            //array formatı gerekli değildir
            int sonuc7 = matematik.ToplaParams(9,8,4,2,0);
            Console.WriteLine(sonuc6+" "+sonuc7);
            
            Console.Read();

        }
    }
    //overloaing = birden fazla aynı isimde method oluşturabiliriz
    //parametrelerin birbirinden farklı olma şartı var
    class Matematik
    {   //methodu void yerine int vermemizin sebebi int bir işlem yapacağını main kısmında belirtmemiz
        //() içine değerleri atama sebebimiz ise 2 değeri main kısmında çağıracak olmamız
        public int Topla(int sayi1 = 0 ,int sayi2 = 0) //default değer belirledik eğer değer girilmezse diye
        {
            //return bize sayi1+ sayi2 yi getir demek
            return sayi1 + sayi2;
        }
        //bir class birden çok method bulundurabilir
        public int Cikar(int sayi1=0,int sayi2=0)
        {
            return sayi1 - sayi2;
        }
        public int Topla(int sayi1 , int sayi2 , int sayi3 = 0) 
        {
           
            return sayi1 + sayi2 + sayi3;
        }
        //eğer elle girilemicek kadar fazla değerle işlem yapmak istiyorsak
        public  int ToplaParams(params int[] sayilar)
        {
            //yapacağı işlemi bir döngü ile tanımlarız
            int sonuc = 0;
            foreach (int sayi in sayilar) 
            {
                sonuc += sayi;
            }
            return sonuc;
            //return sayilar.sum(); bize dizinin toplamını verir . Döngüye gerek kalmaz 
         }
    }

}
