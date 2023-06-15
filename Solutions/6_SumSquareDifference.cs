// The sum of the squares of the first ten natural numbers is,
// 1² + 2² + ... + 10² = 385
// The square of the sum of the first ten natural numbers is,
// (1 + 2 + ... + 10)² = 55² = 3025
// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 
// 3025 - 385 = 2640
// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

namespace ProjectEuler.Solutions
{
    public class SumSquareDifference
    {
        public static void Solution()
        {
            int firstXNumbers = 100;

            //Calculate the sum of the squares
            long sumOfSquares = 0;
            for(int i = 1; i <= firstXNumbers; i++) sumOfSquares += i * i;

            //Calculate the square of the sums
            int sum = 0;
            for(int i = 0; i <= firstXNumbers; i++) sum += i;
            long sumSquared = sum * sum;

            long difference = sumSquared - sumOfSquares;
            Console.WriteLine($"Answer is {difference}");
        }
    }
}