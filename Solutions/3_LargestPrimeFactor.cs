//The prime factors of 13195 are 5, 7, 13 and 29.
//What is the largest prime factor of the number 600851475143 ?


namespace ProjectEuler.Solutions
{
    public class LargestPrimeFactor
    {
        //1- write function to know if number is prime
        //2- divide that number to find it lmfao
        public static void Solution()
        { 
            var watch = System.Diagnostics.Stopwatch.StartNew();
            long valueToCheck = 600851475143  ;
            long k = 2;
            long n = 600851475143;
            while (k * k <= n)
            {
                if (n % k == 0)
                {
                    n /= k;
                }
                else
                {
                    ++k;
                }
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"Value to check: {valueToCheck}\nAnswer is {n} \nElapsed: {elapsedMs.ToString()}ms");
        }

        public void OptimizedSolution()
        {            

        }
    }
    
}