using System;

namespace Lab16_Find_Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat;
            int[] primeNums = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };

            Console.WriteLine("Let's Locate Some Primes!\n");
            Console.WriteLine("This application will find you any prime, in order, from first prime on.");
            int[] generatedPrimes;
            int arrayPrime;
            int num = 100;

            bool isPrime = true;
            for (int i = 0; i <= num; i++)
            {
                for (int j = 2; j <= num; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    arrayPrime = i;
                }
                isPrime = true;
            }

            do
            {
                Console.Write("Which prime number are you looking for?");

                int primeSequence = -1;
                bool success = false;
                while (!success)
                {
                    success = int.TryParse(Console.ReadLine(), out primeSequence);

                    if (primeSequence < 1 || primeSequence > 12)
                    {
                        success = false;
                    }
                }

                Console.WriteLine($"The number {primeSequence} is {primeNums[primeSequence - 1]}\n");
                Console.WriteLine("Do you want to find a new prime number?(y/n)\n");
                repeat = GetYesorNo();
            } while (repeat);

        }
        private static bool GetYesorNo()
        {
            bool valid = true;
            bool repeat = true;
            while (valid)
            {
                string answer = Console.ReadLine().ToLower();
                if (answer == "y" || answer == "yes")
                {
                    valid = false;
                    repeat = true;
                }
                else if (answer == "n" || answer == "no")

                {
                    valid = false;
                    repeat = false;
                }
                else
                {
                    Console.Write("Did not enter a valid input. Please enter (y/n): ");
                }
            }

            return repeat;
        }
    }
}
