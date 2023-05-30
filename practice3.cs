using System;



namespace Shark

{

    internal class Program

    {

        public static void Main(string[] args)

        {

            Console.WriteLine("Введіть речення: ");

            string text = Console.ReadLine();

            char[] charArray = text.ToCharArray();

            Array.Reverse(charArray);

            string reversetext = new string(charArray);

            Console.WriteLine("Речення у зворотному порядку: ");

            Console.WriteLine(reversetext);

            Console.ReadLine();

        }

    }

}