using System;

namespace asf_saafsd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hedef text : ");
            string requiredText = Console.ReadLine();
            Console.WriteLine("Istenilen character : ");
            char character = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(isLetterHave(requiredText, character));

            static string isLetterHave(string requiredText, char character);
            {
                for (int i = 0; i < requiredText.Length; i++)
                {
                    if (requiredText[i] == character)
                    {
                        return "he";
                    }

                }
                return "yox";
            }
        }
    }
}
