using System;

namespace PrintEvenNumbers
{
    public class Answer { 
            static void PrintEvenNumbers(int number)
        {
            for (int i = 2; i <= number; i++)
            {
                bool isEven;
                isEven = (i % 2 == 0) ? true : false;
                if(isEven)
                {
                    Console.Write(" " + i);
                }
            }
                        
        }
    
        static public void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int number;

            if(args.Length >= 1)
            {
                number = int.Parse(args[0]);
            }
            else
            {
                number = 11;
            }
            PrintEvenNumbers(number);
        }
    }
}
