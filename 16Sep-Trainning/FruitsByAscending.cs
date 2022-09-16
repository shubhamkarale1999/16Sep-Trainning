using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _16Sep_Trainning
{
    internal class FruitsByAscending
    {
        public static void Execute()
        {
           Console.WriteLine("Enetr Number of fruits");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Details");
           // Console.WriteLine("brand Name");
            List<string> fruits = new List<string>();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Details");
                fruits.Add(Console.ReadLine());
                

            }
           // string s = Console.ReadLine();
            var result = (from b in fruits
                  orderby b ascending
                  select b).ToList();
            Console.WriteLine("Below is List Of Fruits in Assscending Order");
            foreach (var brand in result)
            {
                Console.WriteLine(brand);
            }
            Console.ReadLine();

        }
    }
}
