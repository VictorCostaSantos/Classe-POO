using System;
using Autocarro.Src;

namespace Autocarro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tipos astra = new Tipos("Astra", 0, 42590);
            Tipos mode = new Tipos("Gol", 1, 50000);
            Tipos oi = new Tipos("Up", 2, 39087);


            Console.WriteLine(astra.ToString());
            Console.WriteLine("<3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3");
            Console.WriteLine(mode.ToString());
            Console.WriteLine("<3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 <3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3");
            Console.WriteLine(oi.ToString());
            Console.WriteLine("<3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3 < 3");
        }
    }
}
