using System;

namespace LexiconFirstProgram
{
    class Program
    {
        public static void BuyTicket()
        {
            Console.WriteLine("Enter your age in digits");

            int digitAge;
            do
            {
                var age = Console.ReadLine();
                if (!int.TryParse(age, out digitAge))
                {
                    Console.WriteLine("Your input is not an integer. Please enter your age in digits only. Try again.");
                } else
                {
                    break;
                }
            } while (true);

            if (digitAge < 20)
            {
                if (digitAge <= 5)
                    Console.WriteLine("Your cinema ticket is free");
                else
                    Console.WriteLine("Your have to pay 80 kr for your cinema ticket.");
            }
            else if (digitAge > 64)
            {
                if (digitAge >= 100)
                    Console.WriteLine("Your cinema ticket is free");
                else
                    Console.WriteLine("Your have to pay 90 kr for your cinema ticket.");
            }
            else
                Console.WriteLine("Your have to pay the standard price of 120 kr for your cinema ticket.");
        }

        public static void Loop10Times()
        {
            Console.WriteLine("Enter your text to be printed 10 times here");
            var text = Console.ReadLine();
            var str = "";
            for (int i = 1; i <= 10; i++)
            {
                str = str + i + ". " + text + ", ";
            }
            int strcounter = str.Length;
            Console.WriteLine(str.Substring(0, strcounter - 2));
        }

        public static void PrintThirdWord()
        {
            Console.WriteLine("Enter a string with three or more words.");

            String[] words;
            do {
                var str = Console.ReadLine();

                words = str.Split(' ');
                if (words.Length < 3)
                {
                    Console.WriteLine("Your string is short. Enter a string with three or more words, not less.");
                } else
                {
                    break;
                }
            } while (true);

            Console.WriteLine("The third word in your string: " + words[2]);
        }

        static void Main(string[] args)
        {
            bool state = true;
            Console.WriteLine("You're in the main menu.\n");

            while (state)
            {
                int menu;

                do
                {
                    Console.WriteLine("Enter 1 to buy cinema tickets \nEnter 2 to run a loop 10 times \nEnter 3 to get the third word from a sentence \nEnter 0 to exit the program");

                    var choice = Console.ReadLine();
                    if (!int.TryParse(choice, out menu))
                    {
                        Console.WriteLine("Your input is not an integer. Please enter digits only between 0-3. Try again.");
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                switch (menu)
                {
                    case 0:
                        state = false;
                        break;
                    case 1:
                        BuyTicket();
                        break;
                    case 2:
                        Loop10Times();
                        break;
                    case 3:
                        PrintThirdWord();
                        break;
                    default:
                        Console.WriteLine("Please enter digits only between 0-3. Try again.");
                        break;
                }

            }

        }
    }
}