using System;

class Program
{
    public static void Main(string[] args)
    {
        string userInput = "no";
        do
        {

            Console.Write("Please enter a measurement type: ");
            string input = Console.ReadLine();

            if (input == "foot")
            {

                Console.Write("Please input amount: ");
                decimal num = decimal.Parse(Console.ReadLine());

                decimal num1 = num * 5;
                if (num1 <= 1)
                {
                    Console.WriteLine("Converts to " + num1 + " meme");
                }
                else if (num1 > 1)
                {
                    Console.WriteLine("Converts to " + num1 + " memes");
                }
            }
            else if (input == "feet")
            {

                Console.Write("Please input amount: ");
                decimal num = decimal.Parse(Console.ReadLine());

                decimal num1 = num * 5;
                if (num1 <= 1)
                {
                    Console.WriteLine("Converts to " + num1 + " meme");
                }
                else if (num1 > 1)
                {
                    Console.WriteLine("Converts to " + num1 + " memes");
                }
            }
            else if (input == "memes")
            {

                Console.Write("Please input amount: ");
                decimal num = decimal.Parse(Console.ReadLine());

                decimal num2 = num / 5;
                if (num2 <= 1)
                {
                    Console.WriteLine("Converts to " + num2 + " foot");
                }
                else if (num2 > 1)
                {
                    Console.WriteLine("Converts to " + num2 + " feet");
                }
            }
            else if (input == "meme")
            {

                Console.Write("Please input amount: ");
                decimal num = decimal.Parse(Console.ReadLine());

                decimal num2 = num / 5;
                if (num2 <= 1)
                {
                    Console.WriteLine("Converts to " + num2 + " foot");
                }
                else if (num2 > 1)
                {
                    Console.WriteLine("Converts to " + num2 + " feet");
                }
            }
            else if (input == "inch")
            {

                Console.Write("Please input amount: ");
                decimal num = decimal.Parse(Console.ReadLine());

                decimal num3 = num * 3.5m;
                if (num3 <= 1)
                {
                    Console.WriteLine("Converts to " + num3 + " fidget spinner");
                }
                else if (num3 > 1)
                {
                    Console.WriteLine("Converts to " + num3 + " fidget spinners");
                }
            }
            else if (input == "inches")
            {

                Console.Write("Please input amount: ");
                decimal num = decimal.Parse(Console.ReadLine());

                decimal num3 = num * 3.5m;
                if (num3 <= 1)
                {
                    Console.WriteLine("Converts to " + num3 + " fidget spinner");
                }
                else if (num3 > 1)
                {
                    Console.WriteLine("Converts to " + num3 + " fidget spinners");
                }
            }
            else if (input == "fidget spinner")
            {

                Console.Write("Please input amount: ");
                decimal num = decimal.Parse(Console.ReadLine());

                decimal num4 = num / 3.5m;
                if (num4 <= 1)
                {
                    Console.WriteLine("Converts to " + num4 + " inch");
                }
                else if (num4 > 1)
                {
                    Console.WriteLine("Converts to " + num4 + " inches");
                }
            }
            else if (input == "fidget spinners")
            {

                Console.Write("Please input amount: ");
                decimal num = decimal.Parse(Console.ReadLine());

                decimal num4 = num / 3.5m;
                if (num4 <= 1)
                {
                    Console.WriteLine("Converts to " + num4 + " inch");
                }
                else if (num4 > 1)
                {
                    Console.WriteLine("Converts to " + num4 + " inches");
                }
            }
            Console.WriteLine("Would you like to run the program again? (yes/no)");
            userInput = Console.ReadLine().ToLower();
        } while (userInput == "yes");
    }
}
