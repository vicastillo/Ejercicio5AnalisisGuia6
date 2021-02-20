using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5AnalisisGuia6
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();

        int num = 0;

        Console.WriteLine("Estos son los números del 1 al 100 exceptuando al 25:");
            
        for (int x = 1; x < 25; x++)
        {
        Console.WriteLine("" + x + "");
        }

        for (int x = 26; x <= 100; x++)
        {
        Console.WriteLine("" + x + "");
        }
        Console.ReadKey();
        }
    } 
}
