using System;
namespace uppgift3_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen för? Du får inte hyra den mer än 1 dag och måste vara i helt antal timmar");
            int hyra = int.Parse(Console.ReadLine());
            int resultat = hyra * 80;
            if (resultat > 950)
                Console.WriteLine("Du kan inte hyra bilen för mer än 12 timmar");
            else
                Console.WriteLine("Du ska betala " + resultat + " .");
        }
    }
}