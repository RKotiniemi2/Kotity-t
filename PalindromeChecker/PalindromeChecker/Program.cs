namespace PalindromeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä Sana: ");
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Empty.");
                return;
            }
            string str = input;
            bool isPalindrome = true;
            int length = str.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine($"{str} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{str} is not a palindrome.");
            }
        }
    }
}
