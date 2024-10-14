using System;
using System.Collections.Generic;


namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu yöntemle dizilere başka bir eleman eklememiz olanaksız oluyor .

            //string[] cities = new string[] { "Ankara", "İstanbul", "İzmir" };
            //Console.WriteLine(cities.Length);

            //cities = new string[4];
            //cities[3] = "Bursa";
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //Bu yüden liste yöntemini kullanırız
            //Bu sistemde liste içine sonradan eleman eklemek veya çıkarmak mümkündür

            List<string> Cities = new List<string>() { "Ankara" , "İstanbul" , "İzmir"};
            Console.WriteLine(Cities.Count);

            Cities.Add("Bursa");

            foreach (string City in Cities) 
            {
                Console.WriteLine(City);
            }
            Console.WriteLine();

            Cities.Remove("İstanbul");
            foreach (string City in Cities)
            { Console.WriteLine(City); }

            Console.WriteLine();

            // contains dizi içindeki bir elemanın var ya da yok olduğunu true false halinde bize verir
            bool result = Cities.Contains("İzmir");
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
