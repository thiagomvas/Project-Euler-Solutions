namespace ProjectEuler.Solutions
{
    public class SummationOfPrimes
    {
        public static void Solution(){
        const int limit = 2000000;
        long sum = 0;

        // Create a boolean array to represent the prime numbers up to the limit.
        bool[] primes = new bool[limit + 1];
        for (int i = 2; i <= limit; i++)
        {
            primes[i] = true;
        }

        // Use the Sieve of Eratosthenes algorithm to mark all non-prime numbers.
        for (int i = 2; i * i <= limit; i++)
        {
            if (primes[i])
            {
                for (int j = i * i; j <= limit; j += i)
                {
                    primes[j] = false;
                }
            }
        }

        // Sum up all the prime numbers.
        for (int i = 2; i <= limit; i++)
        {
            if (primes[i])
            {
                sum += i;
            }
        }

        Console.WriteLine($"The sum of all primes below {limit} is {sum}.");
    }
    }
}