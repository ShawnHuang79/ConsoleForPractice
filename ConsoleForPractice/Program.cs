namespace ConsoleForPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            int answer = GetValidNumber();
            while (true)
            {
                if(IsPalindrome(answer, 10)&& IsPalindrome(answer, 8)&& IsPalindrome(answer, 2))
                {
                    Console.WriteLine(answer);
                    break;
                }
                answer++;
            }
        }
        public static int GetValidNumber()
        {
            int answer;
            Console.WriteLine("Please enter a number, the answer will bigger than it:");
            while (true)
            {
                string? input = Console.ReadLine();
                if (!int.TryParse(input, out int mustBiggerThan))
                {
                    Console.WriteLine("Invalid number format. Please enter a number:");
                    continue;
                }
                answer = mustBiggerThan + 1;
                break;
            }
            return answer;
        }

        public static bool IsPalindrome(int answer, int numeralSystem)
        {
            string representation = Convert.ToString(answer, numeralSystem);
            int lastIndex = representation.Length - 1;
            for (int i = 0; i < representation.Length / 2; i++)
            {
                if (representation[i] != representation[lastIndex - i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
