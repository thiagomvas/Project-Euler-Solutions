using System;
using System.IO;
using System.Linq;
namespace ProjectEuler.Solutions
{
    public class MaximumPathSumI
    {
        public static void Solution()
        {    
            List<int[]> sequences = ConvertToArrays("MaximumPathSum1.txt");

    // Convert the list of sequences to a 2D array
    int[][] triangle = sequences.ToArray();

    // Use dynamic programming to find the maximum path sum
    for (int i = triangle.Length - 2; i >= 0; i--)
    {
        for (int j = 0; j < triangle[i].Length; j++)
        {
            triangle[i][j] += Math.Max(triangle[i+1][j], triangle[i+1][j+1]);
        }
    }

    // The maximum path sum will be the value at the top of the triangle
    int maximumPathSum = triangle[0][0];

    Console.WriteLine($"Answer: {maximumPathSum}");
        }

        public static List<int[]> ConvertToArrays(string filePath)
        {
            var sequences = new List<int[]>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int[] numbers = line.Split(' ').Select(int.Parse).ToArray();
                    sequences.Add(numbers);
                }
            }
            return sequences;
        }        
    }
}