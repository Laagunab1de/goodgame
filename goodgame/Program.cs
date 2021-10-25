using System;

namespace goodgame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 20);
            int b = -1;
            
            Console.WriteLine("я загадал число, угадай его ");
            while(a != b)
            {
                b = Convert.ToInt32(Console.ReadLine());
                if (a < b) 
                {
                    Console.WriteLine("много");
                }
                if (a > b)
                {
                    Console.WriteLine("мало");
                }
                if (a == b)
                {
                    Console.WriteLine($"Молодец, угадал это было число {a}");
                    
                }
                
            }
            
            Console.ReadKey();
        }
    }
}
