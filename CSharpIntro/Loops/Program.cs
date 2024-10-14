using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            //bir dizi oluştururuz
            string[] krediler = new string[7];
            krediler[0] = "Hızlı kredi";
            krediler[1] = "kredi 2";
            krediler[2] = "kredi 3";
            krediler[3] = "kredi 4";
            krediler[4] = "kredi 5";
            krediler[5] = "kredi 6";
            krediler[6] = "kredi 7";
            //başlangıç değeri belirlenir, koşul verilir,
            //koşul sağlancığı müddetce başlangıç değerindeki değişim verilir
            //buradaki var değişkeninde tanımlanan i değeri
            //verilen sayısal değerden ötürü int olarak sayılır.
            for (var i = 0; i < krediler.Length; i++)
            {
              Console.WriteLine("kredi" + (i + 1) + ": " + krediler[i]);
            }

            Console.WriteLine("for dögüsü Bitti! ");

            Console.WriteLine();
            Console.WriteLine();


            //başlangıç ve bitişe gerek yok direkt diziyi seçeriz.
            //foreach genelde dizilerde kullanılır.
            //kredi string değerini aldı
            //buradaki kredi değeri dizi içindeki kredileri(krediler[]) temsil eder.
            foreach (var kredi in krediler) 
            {
              Console.WriteLine(kredi);
            }

            Console.WriteLine("foreach döngüsü bitti! ");
            Console.WriteLine();
            Console.WriteLine();

            //while dögüsünde ise döngüye girmeden bir değişken belirlenir
            //koşul parantez içine yazılır ve süslü içine de artışı yazılır
            int sayac = 0;
            while (sayac < krediler.Length)
            {
              Console.WriteLine(krediler[sayac]);
              sayac++;
            }
            Console.WriteLine("while döngüsü bitti");
            
            Console.WriteLine();
            Console.WriteLine();

            //do while döngüsü ile while döngüsü arasındaki tek fark 
            //do while da şart salanmasa bile en az bir kere döngü çalılşır.
            var sayac2=0;
            do
            {
              Console.WriteLine(krediler[sayac2]);
              sayac2++;
            } 
            while (sayac2< krediler.Length);

            Console.WriteLine("do while döngüsü bitti");

            Console.WriteLine();
            Console.WriteLine();

            Console.Read();
        }
    }
}
