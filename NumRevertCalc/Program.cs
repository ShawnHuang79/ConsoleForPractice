namespace NumRevertCalc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for(int i = 1000; i < 10000; i++)
            {
                if (CanReverseByMultiplication(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static bool CanReverseByMultiplication(int number)
        {
            string numStr = number.ToString();
            int reversedNumber = int.Parse(new String(numStr.Reverse().ToArray()));
            int thousands = number / 1000;
            int hundreds = (number / 100) % 10;
            int tens = (number / 10) % 10;
            int ones = number % 10;

            int mult1X3 = thousands * (number % 1000);
            int mult2X2 = (number / 100) * (number % 100);
            int mult3X1 = (number / 10) * ones;
            int mult1X1X2 = thousands * hundreds * (number % 100);
            int mult1X2X1 = thousands * tens * ones;
            int mult2X1X1 = (number / 100) * tens * ones;
            int mult1X1X1X1 = thousands * hundreds * tens * ones;
            
            return reversedNumber == mult1X3
                || reversedNumber == mult2X2
                || reversedNumber == mult3X1
                || reversedNumber == mult1X1X2
                || reversedNumber == mult1X2X1
                || reversedNumber == mult2X1X1
                || reversedNumber == mult1X1X1X1;
        }
    }
}
