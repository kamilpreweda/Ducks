using System.Collections.Generic;

namespace Ducks
{
    public class Program
    {
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine($"{duck.Kind}, {duck.Size} cm");
            }

        }
        static void Main(string[] args)
        {
            
        }
    } 
}

