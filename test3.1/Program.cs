using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int i = 0;
            while (i <= 1000)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i + " Det är delbart med 3.");
                }
                if (i % 7 == 0)
                {
                    Console.WriteLine(i + " Det är delbart med 7.");
                }
                i++;
            }*/

            
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i + " Det är delbart med 3.");
                }
                if (i % 7 == 0)
                {
                    Console.WriteLine(i + " Det är delbart med 7.");
                }
                else
                {
                    Console.WriteLine(i + " Är inte delbart med varken 3 eller 7.");
                }
                i++;
                
                
            }

            Console.ReadKey();

        }
    }
}
