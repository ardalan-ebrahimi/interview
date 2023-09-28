
namespace BadCode
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine("Even number: " + numbers[i]);
                    sum += numbers[i];
                }
                else
                {
                    Console.WriteLine("Odd number: " + numbers[i]);
                    sum += numbers[i];
                }
            }

            Console.WriteLine("Sum of all numbers: " + sum);

            int factorial = CalculateFactorial(5);
            Console.WriteLine("Factorial of 5: " + factorial);

            string reversed = ReverseString("Hello, World!");
            Console.WriteLine("Reversed string: " + reversed);

            double[] temperatures = new double[] { 32.0, 25.5, 40.2, 28.8 };
            double average = 0.0;

            for (int i = 0; i < temperatures.Length; i++)
            {
                average += temperatures[i];
            }

            average /= temperatures.Length;
            Console.WriteLine("Average temperature: " + average);

            bool isPrime = IsPrime(7);
            Console.WriteLine("Is 7 prime? " + isPrime);
        }

        // Calculate the factorial of a number
        static int CalculateFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }

        // Reverse a string
        static string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        // Check if a number is prime
        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
