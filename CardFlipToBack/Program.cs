namespace CardFlipToBack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            for(int i = 1; i<=100; i++)
            {
                if (IsFactorEven(i))
                {
                    Console.WriteLine($"{i}, ");
                }
            }
        }
        public static bool IsFactorEven (int number)
        {
            int count = 0;

            for(int i = 1; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    if (i == number / i)
                    {
                        count++;
                    }
                    else
                    {
                        count += 2;
                    }
                    
                }
            }

            //1要略過，所以要-1次。
            count -= 1;

            if(count % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
