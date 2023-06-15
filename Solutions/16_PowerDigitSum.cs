
namespace ProjectEuler.Solutions
{
    public class PowerDigitSum
    {
        public static void Solution()
        {
            List<int?> digits = new List<int?>();
            int power = 1000;
            digits.Add(1);
     

            for(int i = 0; i < power; i++)
            {

                for(int j = 0; j < digits.Count; j++)
                {
                    if(digits[j] != null) digits[j] *= 2;
                    else break;
                }

                for(int j = digits.Count - 1; j >= 0; j--)
                {
                    if(digits[j] == null) continue;

                    if(digits[j] > 9)
                    {
                        int num = digits[j].Value;
                        int modulus = (num % 10);
                        int carryOver = (int)Math.Floor(((float)(num - modulus))/10);
                        digits[j] -= carryOver * 10;

                        if(j - 1 >= 0 && digits[j - 1] != null) digits[j - 1] += carryOver;
                        else digits.Insert(0, carryOver);
                    }           
                }
            }
            int sum = 0;
            foreach(int? foo in digits) {if(foo != null) sum += foo.Value ; else break;}

            Console.WriteLine(sum);
            
        }
    }
}