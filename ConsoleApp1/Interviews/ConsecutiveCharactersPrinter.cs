namespace ConsoleApp1.Interviews
{
    using System;

    public class ConsecutiveCharactersPrinter
    {
        public static void MainA()
        {
            string input = "aaabbbcccd";
            PrintConsecutiveCharacters(input);
        }

        public static void PrintConsecutiveCharacters(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input string is empty.");
                return;
            }

            char currentChar = input[0];
            int count = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == currentChar)
                {
                    count++;
                }
                else
                {
                    Console.Write($"{currentChar}{count}");
                    currentChar = input[i];
                    count = 1;
                }
            }

            Console.Write($"{currentChar}{count}");
        }
    }
}
