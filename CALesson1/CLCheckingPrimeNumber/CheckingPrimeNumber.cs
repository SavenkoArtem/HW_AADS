using System;

namespace CLCheckingPrimeNumber
{
    public class CheckingPrimeNumber
    {
        public string CheckPrimeNumber(int number)
        {
            int d = 0;
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }
                i++;
            }

            if (d == 0)
            {
                return "This is a prime number";
            }
            return "It's not a prime number";
        }
    }
}
