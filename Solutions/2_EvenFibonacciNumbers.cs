using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    public class EvenFibonacciNumbers
    {
        public static void Solution()
        {            
            //Calculate fibonacci
            List<int> values = new List<int>();
            values.Add(1); // Starting Value
            values.Add(2); // Second Starting Value
            
            int i = 2;
            int x = 0;
            while(x < 4000000)
            {
                x = values[i - 1] + values[i - 2];
                values.Add(x);
                i++;
            }            

            int result = 0;
            foreach(int value in values) if(value % 2 == 0) result += value;

            Console.WriteLine($"Answer is {result}");
        }

        public void OptimizedSolution()
        {            
            int x = 0, result = 0, a = 1, b = 1;
            while(x < 4000000)
            {
                x = a + b;
                a = b;
                b = x;
                if(x % 2 == 0) result += x;
            }            
            Console.WriteLine($"Answer is {result}");
        }
    }
    
}