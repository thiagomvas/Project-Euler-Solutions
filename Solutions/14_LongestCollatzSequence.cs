namespace ProjectEuler.Solutions
{
    public class LongestCollatzSequence
    {
        public static void Solution()
        {
            
        var watch = System.Diagnostics.Stopwatch.StartNew();
        long limit = 1000000;
        long longestSequence = 0;
        long startingNumber = 0;
        for(int i = 1; i <= limit; i++)
        {
            long x = i;
            long currentSequence = 1;
            while(x != 1)
            {
                if(x % 2 == 0) x = x/2;
                else x = 3 * x + 1;
                currentSequence++;
            }  
            if(currentSequence > longestSequence)          
            {
                startingNumber = i;
                longestSequence = currentSequence;
            }
        }
        watch.Stop();
        Console.WriteLine($"\nAnswer is {startingNumber} with a sequence of {longestSequence} numbers, ellapsed {watch.ElapsedMilliseconds}ms");

        }
    }
}
