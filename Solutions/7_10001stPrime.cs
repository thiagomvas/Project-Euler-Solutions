namespace ProjectEuler.Solutions
{
    public class stPrime
    {
        public static void Solution()
        {
            int primePosition = 10001;
            int currentPosition = 0;
            int n = 1;
            while(currentPosition < primePosition)
            {
                n++;
                if(IsPrime(n)) currentPosition++;
            }
            Console.WriteLine($"The {primePosition}th prime is {n}");
        }
        static bool IsPrime(int n)
        {
            if (n == 2 || n == 3)
                return true;

            if (n <= 1 || n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }
    }
}