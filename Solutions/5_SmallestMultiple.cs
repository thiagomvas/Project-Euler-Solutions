// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

namespace ProjectEuler.Solutions
{
    public class SmallestMultiple
    {
        public static void Solution()
        {
            int maxNumber = 20;
            List<int> values = new List<int>();
            for(int i = 1; i <= maxNumber; i++)
            {
                if(IsPrime(i)) values.Add(i);
            }

            int result = 1;
            foreach(int value in values)
            {
                int x = 1;
                while(x * value < maxNumber) x *= value;
                result *= x;
            }

            Console.WriteLine(result);
        }      
        
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));
                
            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;
            
            return true;    
        }
    }
}