using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {           
            CLCheckingPrimeNumber.CheckingPrimeNumber cpn = new CLCheckingPrimeNumber.CheckingPrimeNumber();            
            while (true)
            {
                Console.Write("Whether the number is Prime. Input number for checking: ");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    if(result>1) /* 
                                  * проверка на отрицательные числа. Если ввести любые отрицательные числа, 
                                  * то выводит сообщение, что это не простое число. Вводил -2, -6, -8, -5, -7 и даже 0 и 1
                                  * немного расширил проверку простых чисел. Т.к. 1 не входит в простые числа, если верить Википедии
                                  */
                    {
                        Console.WriteLine(cpn.CheckPrimeNumber(result));
                    }
                    else
                    {
                        Console.WriteLine("It's not a prime number");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Please. Integer only!");
                }

                Console.Write("To stop scanning (input 'exit'): ");
                if(Console.ReadLine() == "exit")
                {
                    return;
                }
            }          
        }
    }
}
