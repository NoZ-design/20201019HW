using System;

namespace _20201019
{
    class Program
    {
        static void Main(string[] args)
        {
            int keyin;
            int number1;
            int number2;
            int answer;

            

            do
            {
                Random rm = new Random();
                number1 = rm.Next(0, 10);
                number2 = rm.Next(0, 10);
                do
                {
                    Console.Write("How much is {0} times {1}？", number1, number2);
                    keyin = int.Parse(Console.ReadLine());
                    answer = number1 * number2;

                    if (keyin == answer)
                    {
                        Console.WriteLine("Very good.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("No.Please try again.");
                    }
                }
                while (true);
            }
            while (true);

            Console.Read();
        }
    }
}
