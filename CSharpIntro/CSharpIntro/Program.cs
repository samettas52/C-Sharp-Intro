using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖDEV
            int[] sayilar = new int[3];
            sayilar[0] = 1;
            sayilar[1] = 2;
            sayilar[2] = 3;

            if (sayilar[0] > sayilar[1] && sayilar[0] > sayilar[2])
            {
                Console.WriteLine("en büyük sayı: " + sayilar[0]);
                if (sayilar[1] > sayilar[2])
                {
                    Console.WriteLine("ortanca sayı: " + sayilar[1]);
                    Console.WriteLine(" en küçük sayı: " + sayilar[2]);
                }
                else
                {
                    Console.WriteLine("ortanca sayı: " + sayilar[2]);
                    Console.WriteLine("en küçük sayı: " + sayilar[1]);
                }
            }
            else if (sayilar[1] > sayilar[0] && sayilar[1] > sayilar[2])
            {
                Console.WriteLine("en büyük sayı: " + sayilar[1]);
                if (sayilar[0] > sayilar[2])
                {
                    Console.WriteLine("ortanca sayı: " + sayilar[0]);
                    Console.WriteLine(" en küçük sayı: " + sayilar[2]);
                }
                else
                {
                    Console.WriteLine("ortanca sayı: " + sayilar[2]);
                    Console.WriteLine("en küçük sayı: " + sayilar[0]);
                }
            }
            else
            {
                Console.WriteLine("en büyük sayı: " + sayilar[2]);
                if (sayilar[1] > sayilar[0])
                {
                    Console.WriteLine("ortanca sayı: " + sayilar[1]);
                    Console.WriteLine("en küçük sayı: " + sayilar[0]);
                }
                else
                {
                    Console.WriteLine("ortanca sayı: " + sayilar[0]);
                    Console.WriteLine("en küçük sayı: " + sayilar[1]);
                }
            }
            Console.Read();
        }
    }
}
