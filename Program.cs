using PasswordUtility.PasswordGenerator;
using System.Threading;
using System;

namespace PasswordGenerator
{
    public class Program
    {
        static void Main()
        {
            int Length = 0; bool upper_Case = false; bool use_Digits = false; bool user_Special_Characters = false;

            Console.Clear(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Password Generator\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("State Password Length\n");
            Console.ForegroundColor = ConsoleColor.White;
            int.TryParse(Console.ReadLine(), out Length);

            Thread.Sleep(1000); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("\nState if upper Case Letters should be used\n 1. Yes\n 2. No\n");
            Console.ForegroundColor = ConsoleColor.White;
            var answer_1 = Console.ReadLine();
            switch (answer_1)
            {
                case "1":
                    upper_Case = true; break;
                case "2":
                    use_Digits = false; break;
            }
            Thread.Sleep(1000); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("\nState if it should use Digits\n 1. Yes\n 2. No\n");
            Console.ForegroundColor = ConsoleColor.White;
            var answer_2 = Console.ReadLine();
            switch (answer_2)
            {
                case "1":
                    use_Digits = true; break;
                case "2":
                    use_Digits = false; break;
            }
            Thread.Sleep(1000); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("\nState if it should use Special Characters\n 1. Yes\n 2. No\n");
            Console.ForegroundColor = ConsoleColor.White;
            var answer_3 = Console.ReadLine();
            switch (answer_3)
            {
                case "1":
                    user_Special_Characters = true; break;
                case "2":
                    user_Special_Characters = false; break;
            }
            Thread.Sleep(1000); Console.Clear();
            string result = Password(Length, upper_Case, use_Digits, user_Special_Characters);
            Thread.Sleep(1000); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"Youre Generated Password is:\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{result}");
            Console.ReadLine(); Main();
        }




        static string Password(int Length, bool upperCase, bool useDigits, bool useSpecialCharacters)
        {
            var Password = PwGenerator.Generate(Length, upperCase, useDigits, useSpecialCharacters).ReadString();
            if (Password != null) return Password.ToString(); else return "Error";
        }
    }
}
