using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //string kredi1 = "HIZLI KREDİ";
            //string kredi2 = "MAAŞINI HALKBANKTAN ALANLARA ÖZEL KREDİ";

            //Console.WriteLine(kredi1);
            //Console.WriteLine(kredi2);

            //bunu diziye dönüştürücel olursak
            string[] krediler = new string[7];
            krediler[0] = "Hızlı kredi";
            krediler[1] = "kredi 2";
            krediler[2] = "kredi 3";
            krediler[3] = "kredi 4";
            krediler[4] = "kredi 5";
            krediler[5] = "kredi 6";
            krediler[6] = "kredi 7";

            Console.WriteLine(krediler[3]);
            Console.Read();
        }
    }
}
