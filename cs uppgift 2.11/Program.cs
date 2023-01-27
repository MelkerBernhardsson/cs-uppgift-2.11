using System;
namespace Program
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("hur många meter hoppade Alma?");
            float A = float.Parse(Console.ReadLine());
            Console.WriteLine("hur många meter hoppade Elin?");
            float E = float.Parse(Console.ReadLine()); 
            float dif = E - A;
            Console.WriteLine("Elin hoppade " + dif + " meter längre än Alma");
        }
    }
}
